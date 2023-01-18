namespace Rayco_Planner.Forms
{
    partial class DashboardGebruiker
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
            this.HoofdMenuStrip = new System.Windows.Forms.MenuStrip();
            this.startschermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSoortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoofdMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoofdMenuStrip
            // 
            this.HoofdMenuStrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoofdMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startschermToolStripMenuItem,
            this.projectenToolStripMenuItem,
            this.projectledenToolStripMenuItem});
            this.HoofdMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HoofdMenuStrip.Name = "HoofdMenuStrip";
            this.HoofdMenuStrip.Size = new System.Drawing.Size(800, 33);
            this.HoofdMenuStrip.TabIndex = 1;
            this.HoofdMenuStrip.Text = "menuStrip1";
            // 
            // startschermToolStripMenuItem
            // 
            this.startschermToolStripMenuItem.Name = "startschermToolStripMenuItem";
            this.startschermToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.startschermToolStripMenuItem.Text = "Startscherm";
            // 
            // projectenToolStripMenuItem
            // 
            this.projectenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectOverviewToolStripMenuItem,
            this.takenToolStripMenuItem,
            this.projectSoortenToolStripMenuItem});
            this.projectenToolStripMenuItem.Name = "projectenToolStripMenuItem";
            this.projectenToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.projectenToolStripMenuItem.Text = "Projecten";
            // 
            // projectOverviewToolStripMenuItem
            // 
            this.projectOverviewToolStripMenuItem.Name = "projectOverviewToolStripMenuItem";
            this.projectOverviewToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.projectOverviewToolStripMenuItem.Text = "Project overview";
            // 
            // takenToolStripMenuItem
            // 
            this.takenToolStripMenuItem.Name = "takenToolStripMenuItem";
            this.takenToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.takenToolStripMenuItem.Text = "Project soorten";
            // 
            // projectSoortenToolStripMenuItem
            // 
            this.projectSoortenToolStripMenuItem.Name = "projectSoortenToolStripMenuItem";
            this.projectSoortenToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.projectSoortenToolStripMenuItem.Text = "Project taken";
            // 
            // projectledenToolStripMenuItem
            // 
            this.projectledenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectledenOverviewToolStripMenuItem});
            this.projectledenToolStripMenuItem.Name = "projectledenToolStripMenuItem";
            this.projectledenToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.projectledenToolStripMenuItem.Text = "Projectleden";
            // 
            // projectledenOverviewToolStripMenuItem
            // 
            this.projectledenOverviewToolStripMenuItem.Name = "projectledenOverviewToolStripMenuItem";
            this.projectledenOverviewToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.projectledenOverviewToolStripMenuItem.Text = "Projectleden overview";
            // 
            // DashboardGebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HoofdMenuStrip);
            this.Name = "DashboardGebruiker";
            this.Text = "DashboardGebruiker";
            this.Load += new System.EventHandler(this.DashboardGebruiker_Load);
            this.HoofdMenuStrip.ResumeLayout(false);
            this.HoofdMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip HoofdMenuStrip;
        private ToolStripMenuItem startschermToolStripMenuItem;
        private ToolStripMenuItem projectenToolStripMenuItem;
        private ToolStripMenuItem projectOverviewToolStripMenuItem;
        private ToolStripMenuItem takenToolStripMenuItem;
        private ToolStripMenuItem projectSoortenToolStripMenuItem;
        private ToolStripMenuItem projectledenToolStripMenuItem;
        private ToolStripMenuItem projectledenOverviewToolStripMenuItem;
    }
}