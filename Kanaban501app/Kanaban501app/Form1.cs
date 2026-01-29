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
    public partial class Kanban501 : Form
    {
        public Kanban501()
        {
            InitializeComponent();
            this.Size = new Size(1000, 700);
            CenterKanbanBoard();
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
    }

}
