namespace Inspectra.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            assetsToolStripMenuItem = new ToolStripMenuItem();
            inspectionToolStripMenuItem = new ToolStripMenuItem();
            corrosionToolStripMenuItem = new ToolStripMenuItem();
            rBIToolStripMenuItem = new ToolStripMenuItem();
            fFSToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, assetsToolStripMenuItem, inspectionToolStripMenuItem, corrosionToolStripMenuItem, rBIToolStripMenuItem, fFSToolStripMenuItem, reportsToolStripMenuItem, toolsToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // assetsToolStripMenuItem
            // 
            assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            assetsToolStripMenuItem.Size = new Size(64, 24);
            assetsToolStripMenuItem.Text = "Assets";
            // 
            // inspectionToolStripMenuItem
            // 
            inspectionToolStripMenuItem.Name = "inspectionToolStripMenuItem";
            inspectionToolStripMenuItem.Size = new Size(91, 24);
            inspectionToolStripMenuItem.Text = "Inspection";
            // 
            // corrosionToolStripMenuItem
            // 
            corrosionToolStripMenuItem.Name = "corrosionToolStripMenuItem";
            corrosionToolStripMenuItem.Size = new Size(87, 24);
            corrosionToolStripMenuItem.Text = "Corrosion";
            // 
            // rBIToolStripMenuItem
            // 
            rBIToolStripMenuItem.Name = "rBIToolStripMenuItem";
            rBIToolStripMenuItem.Size = new Size(45, 24);
            rBIToolStripMenuItem.Text = "RBI";
            // 
            // fFSToolStripMenuItem
            // 
            fFSToolStripMenuItem.Name = "fFSToolStripMenuItem";
            fFSToolStripMenuItem.Size = new Size(45, 24);
            fFSToolStripMenuItem.Text = "FFS";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(78, 24);
            windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 629);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inspectra";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem assetsToolStripMenuItem;
        private ToolStripMenuItem inspectionToolStripMenuItem;
        private ToolStripMenuItem corrosionToolStripMenuItem;
        private ToolStripMenuItem rBIToolStripMenuItem;
        private ToolStripMenuItem fFSToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
    }
}
