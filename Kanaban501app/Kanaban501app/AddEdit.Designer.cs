namespace Kanaban501app
{
    partial class AddEdit
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
            this.ActivityText = new System.Windows.Forms.Label();
            this.ResourcesText = new System.Windows.Forms.Label();
            this.CompleteByText = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.ActivityTextBox = new System.Windows.Forms.TextBox();
            this.ResourcesTextBox = new System.Windows.Forms.TextBox();
            this.CompleteBy = new System.Windows.Forms.DateTimePicker();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActivityText
            // 
            this.ActivityText.AutoSize = true;
            this.ActivityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityText.Location = new System.Drawing.Point(138, 109);
            this.ActivityText.Name = "ActivityText";
            this.ActivityText.Size = new System.Drawing.Size(144, 42);
            this.ActivityText.TabIndex = 0;
            this.ActivityText.Text = "Activity";
            // 
            // ResourcesText
            // 
            this.ResourcesText.AutoSize = true;
            this.ResourcesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourcesText.Location = new System.Drawing.Point(75, 260);
            this.ResourcesText.Name = "ResourcesText";
            this.ResourcesText.Size = new System.Drawing.Size(207, 42);
            this.ResourcesText.TabIndex = 1;
            this.ResourcesText.Text = "Resources";
            // 
            // CompleteByText
            // 
            this.CompleteByText.AutoSize = true;
            this.CompleteByText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteByText.Location = new System.Drawing.Point(40, 611);
            this.CompleteByText.Name = "CompleteByText";
            this.CompleteByText.Size = new System.Drawing.Size(242, 42);
            this.CompleteByText.TabIndex = 2;
            this.CompleteByText.Text = "Complete By";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(829, 50);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(130, 42);
            this.StatusText.TabIndex = 3;
            this.StatusText.Text = "Status";
            // 
            // ActivityTextBox
            // 
            this.ActivityTextBox.Location = new System.Drawing.Point(321, 121);
            this.ActivityTextBox.Name = "ActivityTextBox";
            this.ActivityTextBox.Size = new System.Drawing.Size(375, 31);
            this.ActivityTextBox.TabIndex = 4;
            // 
            // ResourcesTextBox
            // 
            this.ResourcesTextBox.Location = new System.Drawing.Point(321, 272);
            this.ResourcesTextBox.Multiline = true;
            this.ResourcesTextBox.Name = "ResourcesTextBox";
            this.ResourcesTextBox.Size = new System.Drawing.Size(375, 283);
            this.ResourcesTextBox.TabIndex = 5;
            // 
            // CompleteBy
            // 
            this.CompleteBy.CustomFormat = "\"MM/dd/yyyy\"";
            this.CompleteBy.Location = new System.Drawing.Point(321, 622);
            this.CompleteBy.Name = "CompleteBy";
            this.CompleteBy.Size = new System.Drawing.Size(375, 31);
            this.CompleteBy.TabIndex = 6;
            this.CompleteBy.Value = new System.DateTime(2026, 1, 28, 20, 6, 50, 0);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "To Do",
            "Working On",
            "Done"});
            this.StatusBox.Location = new System.Drawing.Point(785, 121);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(219, 33);
            this.StatusBox.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(47, 719);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 43);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(874, 719);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(197, 43);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.CompleteBy);
            this.Controls.Add(this.ResourcesTextBox);
            this.Controls.Add(this.ActivityTextBox);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.CompleteByText);
            this.Controls.Add(this.ResourcesText);
            this.Controls.Add(this.ActivityText);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActivityText;
        private System.Windows.Forms.Label ResourcesText;
        private System.Windows.Forms.Label CompleteByText;
        private System.Windows.Forms.Label StatusText;
        public System.Windows.Forms.TextBox ActivityTextBox;
        public System.Windows.Forms.TextBox ResourcesTextBox;
        public System.Windows.Forms.DateTimePicker CompleteBy;
        public System.Windows.Forms.ComboBox StatusBox;
        public new System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button OkButton;
    }
}