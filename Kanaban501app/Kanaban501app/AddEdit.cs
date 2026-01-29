using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public partial class AddEdit : Form
    {
        public AddEdit()
        {
            InitializeComponent();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK button clicked!");
            if (string.IsNullOrWhiteSpace(ActivityTextBox.Text))
            {
                MessageBox.Show("Please enter an activity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActivityTextBox.Focus();
                return; // Dont close the form
            }

            // Validate status is selected
            if (StatusBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StatusBox.Focus();
                return; // Dont close the form
            }

            // All validations passed
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
