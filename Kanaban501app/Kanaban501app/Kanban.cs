using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public partial class Kanban501 : Form
    {
        private string GoalActivityFile = "GoalActivity.txt";

        public Kanban501()
        {
            InitializeComponent();
            this.Size = new Size(1000, 700);
            LoadGoalActivities();
            CenterKanbanBoard();

            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            WorkingOnList.SelectedIndexChanged += WorkingOnList_SelectedIndexChanged;
            DoneList.SelectedIndexChanged += DoneList_SelectedIndexChanged;
        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToDoList.SelectedIndex != -1)
            {
                WorkingOnList.ClearSelected();
                DoneList.ClearSelected();
            }
        }

        private void WorkingOnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkingOnList.SelectedIndex != -1)
            {
                ToDoList.ClearSelected();
                DoneList.ClearSelected();
            }
        }

        private void DoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoneList.SelectedIndex != -1)
            {
                ToDoList.ClearSelected();
                WorkingOnList.ClearSelected();
            }
        }

        private void LoadGoalActivities()
        {
            try
            {
                // If the file does not exist, create it and early return
                if(!File.Exists(GoalActivityFile))
                {
                    File.WriteAllText(GoalActivityFile, "[ToDo]\n\n[WorkingOn]\n\n[Done]\n");
                    return;
                }
                string[] lines = File.ReadAllLines(GoalActivityFile);
                string currentSection = "";

                ToDoList.Items.Clear();
                WorkingOnList.Items.Clear();
                DoneList.Items.Clear();

                foreach (string line in lines)
                {
                    if(line == "[ToDo]")
                    {
                        currentSection = "ToDo";
                    }
                    else if(line == "[WorkingOn]")
                    {
                        currentSection = "WorkingOn";
                    }
                    else if(line == "[Done]")
                    {
                        currentSection = "Done";
                    }
                    else if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Parse the line: Activity|Resources|CompleteBy|Status
                        string[] parts = line.Split('|');
                        if (parts.Length >= 4)
                        {
                            string activity = parts[0];
                            string resources = parts[1];
                            DateTime completeBy = DateTime.Parse(parts[2]);
                            string status = parts[3];

                            KanbanItem item = new KanbanItem(activity, resources, completeBy, status);

                            switch (currentSection)
                            {
                                case "ToDo":
                                    ToDoList.Items.Add(item);
                                    break;
                                case "WorkingOn":
                                    WorkingOnList.Items.Add(item);
                                    break;
                                case "Done":
                                    DoneList.Items.Add(item);
                                    break;
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading goal activities: " + ex.Message);
            }
        }

        private void SaveGoalActivities()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(GoalActivityFile))
                {
                    writer.WriteLine("[ToDo]");
                    foreach (KanbanItem item in ToDoList.Items)
                    {
                        // Save as: Activity|Resources|CompleteBy|Status --- so when we save we can have the preloaded data 
                        writer.WriteLine($"{item.Activity}|{item.Resources}|{item.CompleteBy:yyyy-MM-dd}|{item.Status}");
                    }
                    writer.WriteLine();

                    writer.WriteLine("[WorkingOn]");
                    foreach (KanbanItem item in WorkingOnList.Items)
                    {
                        writer.WriteLine($"{item.Activity}|{item.Resources}|{item.CompleteBy:yyyy-MM-dd}|{item.Status}");
                    }
                    writer.WriteLine();

                    writer.WriteLine("[Done]");
                    foreach (KanbanItem item in DoneList.Items)
                    {
                        writer.WriteLine($"{item.Activity}|{item.Resources}|{item.CompleteBy:yyyy-MM-dd}|{item.Status}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving goal activities: " + ex.Message);
            }
        }

        private void CenterKanbanBoard()
        {
            // Find bounds
            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;

            foreach (Control control in this.Controls)
            {
                minX = Math.Min(minX, control.Left);
                minY = Math.Min(minY, control.Top);
                maxX = Math.Max(maxX, control.Right);
                maxY = Math.Max(maxY, control.Bottom);
            }

            int contentWidth = maxX - minX;
            int contentHeight = maxY - minY;

            // Center calculation
            int offsetX = (this.ClientSize.Width - contentWidth) / 2 - minX;
            int offsetY = (this.ClientSize.Height - contentHeight) / 2 - minY;

            // Move all controls to the center so it can look nice
            foreach (Control control in this.Controls)
            {
                control.Left += offsetX;
                control.Top += offsetY;
            }
        }

        private void Kanban501_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGoalActivities();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
    
            if(addEdit.ShowDialog() == DialogResult.OK)
            {
                if (addEdit.StatusBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a status.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(addEdit.ActivityTextBox.Text))
                {
                    MessageBox.Show("Please enter an activity.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string activity = addEdit.ActivityTextBox.Text;
                string status = addEdit.StatusBox.SelectedItem.ToString();
                string source = addEdit.ResourcesTextBox.Text;
                DateTime completeBy = addEdit.CompleteBy.Value;

                KanbanItem item = new KanbanItem(activity, source, completeBy, status);
                ListBox targetList = null;

                switch (status)
                {
                    case "To Do":
                        targetList = ToDoList;
                        break;
                    case "Working On":
                        targetList = WorkingOnList;
                        break;
                    case "Done":
                        targetList = DoneList;
                        break;
                }

                // Check 15-item limit for To Do and 3-item for Working On lists
                if (targetList != null)
                {
                    if (status == "Working On" && targetList.Items.Count >= 3)
                    {
                        MessageBox.Show("The Working On list is full! Maximum 3 entries allowed.",
                            "List Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (targetList.Items.Count >= 15)
                    {
                        MessageBox.Show($"The {status} list is full! Maximum 15 entries allowed.",
                            "List Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        targetList.Items.Add(item);
                        SaveGoalActivities();
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ListBox selectedListBox = null;
            KanbanItem item = null;

            if (ToDoList.SelectedIndex != -1)
            {
                selectedListBox = ToDoList;
                item = (KanbanItem)ToDoList.SelectedItem;
            }
            else if (WorkingOnList.SelectedIndex != -1)
            {
                selectedListBox = WorkingOnList;
                item = (KanbanItem)WorkingOnList.SelectedItem;
            }
            else if (DoneList.SelectedIndex != -1)
            {
                selectedListBox = DoneList;
                item = (KanbanItem)DoneList.SelectedItem;
            }

            // If nothing is selected, show a message that there was nothing selected
            if (selectedListBox == null || item == null)
            {
                MessageBox.Show("Please select an item to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Store the old status to check if it changed
            string oldStatus = item.Status;
            int selectedIndex = selectedListBox.SelectedIndex;

            AddEdit addEdit = new AddEdit(item);

            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                if (addEdit.StatusBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a status.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(addEdit.ActivityTextBox.Text))
                {
                    MessageBox.Show("Please enter an activity.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Update item properties
                item.Activity = addEdit.ActivityTextBox.Text;
                item.Resources = addEdit.ResourcesTextBox.Text;
                item.CompleteBy = addEdit.CompleteBy.Value;
                item.Status = addEdit.StatusBox.SelectedItem.ToString();
                string newStatus = addEdit.StatusBox.SelectedItem.ToString();

                // Check if status changed
                if (oldStatus != newStatus)
                {
                    selectedListBox.Items.RemoveAt(selectedIndex);

                    // Determine new list
                    ListBox targetList = null;

                    switch (newStatus)
                    {
                        case "To Do":
                            targetList = ToDoList;
                            break;
                        case "Working On":
                            targetList = WorkingOnList;
                            break;
                        case "Done":
                            targetList = DoneList;
                            break;
                    }

                    // Check limits before moving
                    if (targetList != null)
                    {
                        if (newStatus == "Working On" && targetList.Items.Count >= 3)
                        {
                            MessageBox.Show("The Working On list is full! Maximum 3 entries allowed.",
                                "List Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            // Add back to original list
                            selectedListBox.Items.Insert(selectedIndex, item);
                            item.Status = oldStatus; // Revert status
                            return;
                        }
                        else if (targetList.Items.Count >= 15)
                        {
                            MessageBox.Show($"The {newStatus} list is full! Maximum 15 entries allowed.",
                                "List Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            // Add back to original list
                            selectedListBox.Items.Insert(selectedIndex, item);
                            item.Status = oldStatus; // Revert status
                            return;
                        }

                        // Add to new list
                        targetList.Items.Add(item);
                    }
                }
                else
                {
                    // Status didn't change, just refresh the display
                    selectedListBox.Items[selectedIndex] = item;
                }
                SaveGoalActivities();

                ToDoList.ClearSelected();
                WorkingOnList.ClearSelected();
                DoneList.ClearSelected();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ListBox selectedListBox = null;
            KanbanItem item = null;

            if (ToDoList.SelectedIndex != -1)
            {
                selectedListBox = ToDoList;
                item = (KanbanItem)ToDoList.SelectedItem;
            }
            else if (WorkingOnList.SelectedIndex != -1)
            {
                selectedListBox = WorkingOnList;
                item = (KanbanItem)WorkingOnList.SelectedItem;
            }
            else if (DoneList.SelectedIndex != -1)
            {
                selectedListBox = DoneList;
                item = (KanbanItem)DoneList.SelectedItem;
            }

            // If nothing is selected, show a message that there was nothing selected
            if (selectedListBox == null || item == null)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion
            var result = MessageBox.Show($"Are you sure you want to delete the activity: {item.Activity}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                selectedListBox.Items.Remove(item);
                SaveGoalActivities();
            }
            else
            {
                // Do nothing if user selects No
                return;
            }
        }
    }
}
