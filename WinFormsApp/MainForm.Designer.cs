namespace WinFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLightBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLightGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLightYellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLightGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLightCoralToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLightGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLightYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLightGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLightCoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorLightBlueToolStripMenuItem,
            this.colorLightGreenToolStripMenuItem,
            this.colorLightYellowToolStripMenuItem,
            this.colorLightGrayToolStripMenuItem,
            this.colorLightCoralToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // colorLightBlueToolStripMenuItem
            // 
            this.colorLightBlueToolStripMenuItem.Name = "colorLightBlueToolStripMenuItem";
            this.colorLightBlueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLightBlueToolStripMenuItem.Text = "Light Blue";
            this.colorLightBlueToolStripMenuItem.Tag = System.Drawing.Color.LightBlue;
            this.colorLightBlueToolStripMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // colorLightGreenToolStripMenuItem
            // 
            this.colorLightGreenToolStripMenuItem.Name = "colorLightGreenToolStripMenuItem";
            this.colorLightGreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLightGreenToolStripMenuItem.Text = "Light Green";
            this.colorLightGreenToolStripMenuItem.Tag = System.Drawing.Color.LightGreen;
            this.colorLightGreenToolStripMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // colorLightYellowToolStripMenuItem
            // 
            this.colorLightYellowToolStripMenuItem.Name = "colorLightYellowToolStripMenuItem";
            this.colorLightYellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLightYellowToolStripMenuItem.Text = "Light Yellow";
            this.colorLightYellowToolStripMenuItem.Tag = System.Drawing.Color.LightYellow;
            this.colorLightYellowToolStripMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // colorLightGrayToolStripMenuItem
            // 
            this.colorLightGrayToolStripMenuItem.Name = "colorLightGrayToolStripMenuItem";
            this.colorLightGrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLightGrayToolStripMenuItem.Text = "Light Gray";
            this.colorLightGrayToolStripMenuItem.Tag = System.Drawing.Color.LightGray;
            this.colorLightGrayToolStripMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // colorLightCoralToolStripMenuItem
            // 
            this.colorLightCoralToolStripMenuItem.Name = "colorLightCoralToolStripMenuItem";
            this.colorLightCoralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLightCoralToolStripMenuItem.Text = "Light Coral";
            this.colorLightCoralToolStripMenuItem.Tag = System.Drawing.Color.LightCoral;
            this.colorLightCoralToolStripMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 39);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(62, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(710, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
