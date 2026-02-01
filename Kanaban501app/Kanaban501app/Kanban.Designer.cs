namespace Kanaban501app
{
    partial class Kanban501
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kanban501Label = new System.Windows.Forms.Label();
            this.WorkingOnLabel = new System.Windows.Forms.Label();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.DoneLabel = new System.Windows.Forms.Label();
            this.ToDoList = new System.Windows.Forms.ListBox();
            this.WorkingOnList = new System.Windows.Forms.ListBox();
            this.DoneList = new System.Windows.Forms.ListBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kanban501Label
            // 
            this.Kanban501Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kanban501Label.AutoSize = true;
            this.Kanban501Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kanban501Label.Location = new System.Drawing.Point(294, 36);
            this.Kanban501Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kanban501Label.Name = "Kanban501Label";
            this.Kanban501Label.Size = new System.Drawing.Size(372, 73);
            this.Kanban501Label.TabIndex = 0;
            this.Kanban501Label.Text = "Kanban501";
            this.Kanban501Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkingOnLabel
            // 
            this.WorkingOnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WorkingOnLabel.AutoSize = true;
            this.WorkingOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingOnLabel.Location = new System.Drawing.Point(320, 111);
            this.WorkingOnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorkingOnLabel.Name = "WorkingOnLabel";
            this.WorkingOnLabel.Size = new System.Drawing.Size(225, 42);
            this.WorkingOnLabel.TabIndex = 1;
            this.WorkingOnLabel.Text = "Working On";
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoLabel.Location = new System.Drawing.Point(102, 111);
            this.ToDoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(125, 42);
            this.ToDoLabel.TabIndex = 2;
            this.ToDoLabel.Text = "To Do";
            // 
            // DoneLabel
            // 
            this.DoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoneLabel.AutoSize = true;
            this.DoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneLabel.Location = new System.Drawing.Point(577, 111);
            this.DoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoneLabel.Name = "DoneLabel";
            this.DoneLabel.Size = new System.Drawing.Size(112, 42);
            this.DoneLabel.TabIndex = 3;
            this.DoneLabel.Text = "Done";
            // 
            // ToDoList
            // 
            this.ToDoList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToDoList.FormattingEnabled = true;
            this.ToDoList.Location = new System.Drawing.Point(38, 157);
            this.ToDoList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(194, 290);
            this.ToDoList.TabIndex = 4;
            // 
            // WorkingOnList
            // 
            this.WorkingOnList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WorkingOnList.FormattingEnabled = true;
            this.WorkingOnList.Location = new System.Drawing.Point(278, 157);
            this.WorkingOnList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkingOnList.Name = "WorkingOnList";
            this.WorkingOnList.Size = new System.Drawing.Size(194, 290);
            this.WorkingOnList.TabIndex = 5;
            // 
            // DoneList
            // 
            this.DoneList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoneList.FormattingEnabled = true;
            this.DoneList.Location = new System.Drawing.Point(512, 157);
            this.DoneList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoneList.Name = "DoneList";
            this.DoneList.Size = new System.Drawing.Size(194, 290);
            this.DoneList.TabIndex = 6;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewButton.Location = new System.Drawing.Point(38, 484);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(90, 32);
            this.NewButton.TabIndex = 7;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditButton.Location = new System.Drawing.Point(140, 484);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(90, 32);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteButton.Location = new System.Drawing.Point(612, 484);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 32);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Kanban501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 535);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.DoneList);
            this.Controls.Add(this.WorkingOnList);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.DoneLabel);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.WorkingOnLabel);
            this.Controls.Add(this.Kanban501Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Kanban501";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban501";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kanban501_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kanban501Label;
        private System.Windows.Forms.Label WorkingOnLabel;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.Label DoneLabel;
        private System.Windows.Forms.ListBox ToDoList;
        private System.Windows.Forms.ListBox WorkingOnList;
        private System.Windows.Forms.ListBox DoneList;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

