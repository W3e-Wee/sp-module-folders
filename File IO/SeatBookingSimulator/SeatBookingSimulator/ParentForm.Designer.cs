namespace SeatBookingSimulator
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.safeDistanceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeDistanceAndSmartModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulationModeToolStripMenuItem
            // 
            this.simulationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalModeMenuItem1,
            this.safeDistanceModeToolStripMenuItem,
            this.safeDistanceAndSmartModeToolStripMenuItem});
            this.simulationModeToolStripMenuItem.Name = "simulationModeToolStripMenuItem";
            this.simulationModeToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.simulationModeToolStripMenuItem.Text = "Simulation mode";
            // 
            // normalModeMenuItem1
            // 
            this.normalModeMenuItem1.Name = "normalModeMenuItem1";
            this.normalModeMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.normalModeMenuItem1.Text = "Normal mode";
            // 
            // safeDistanceModeToolStripMenuItem
            // 
            this.safeDistanceModeToolStripMenuItem.Name = "safeDistanceModeToolStripMenuItem";
            this.safeDistanceModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.safeDistanceModeToolStripMenuItem.Text = "Safe Distance mode";
            // 
            // safeDistanceAndSmartModeToolStripMenuItem
            // 
            this.safeDistanceAndSmartModeToolStripMenuItem.Name = "safeDistanceAndSmartModeToolStripMenuItem";
            this.safeDistanceAndSmartModeToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.safeDistanceAndSmartModeToolStripMenuItem.Text = "Safe Distance And Smart mode";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalModeMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem safeDistanceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeDistanceAndSmartModeToolStripMenuItem;
    }
}