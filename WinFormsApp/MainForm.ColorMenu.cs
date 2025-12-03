using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private void ColorMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem clicked)
            {
                var wasChecked = clicked.Checked;

                // Uncheck all sibling items
                if (clicked.Owner is ToolStripDropDownMenu owner)
                {
                    foreach (ToolStripItem item in owner.Items)
                    {
                        if (item is ToolStripMenuItem menuItem)
                        {
                            menuItem.Checked = false;
                        }
                    }
                }

                // If it was previously checked, toggle off and reset to default
                if (wasChecked)
                {
                    this.BackColor = System.Drawing.SystemColors.Control;
                    return;
                }

                // Otherwise set the clicked item as checked and apply its color
                clicked.Checked = true;
                if (clicked.Tag is System.Drawing.Color color)
                {
                    this.BackColor = color;
                }
            }
        }
    }
}
