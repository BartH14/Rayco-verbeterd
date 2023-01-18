namespace Rayco_Planner.Forms
{
    partial class DashboardAdmin
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
            this.projectToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.HoofdMenuStrip.TabIndex = 0;
            this.HoofdMenuStrip.Text = "menuStrip1";
            this.HoofdMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HoofdMenuStrip_ItemClicked);
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
            this.projectSoortenToolStripMenuItem,
            this.projectToevoegenToolStripMenuItem});
            this.projectenToolStripMenuItem.Name = "projectenToolStripMenuItem";
            this.projectenToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.projectenToolStripMenuItem.Text = "Projecten";
            // 
            // projectOverviewToolStripMenuItem
            // 
            this.projectOverviewToolStripMenuItem.Name = "projectOverviewToolStripMenuItem";
            this.projectOverviewToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.projectOverviewToolStripMenuItem.Text = "Project overview";
            // 
            // takenToolStripMenuItem
            // 
            this.takenToolStripMenuItem.Name = "takenToolStripMenuItem";
            this.takenToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.takenToolStripMenuItem.Text = "Project soorten";
            // 
            // projectSoortenToolStripMenuItem
            // 
            this.projectSoortenToolStripMenuItem.Name = "projectSoortenToolStripMenuItem";
            this.projectSoortenToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.projectSoortenToolStripMenuItem.Text = "Project taken";
            // 
            // projectToevoegenToolStripMenuItem
            // 
            this.projectToevoegenToolStripMenuItem.Name = "projectToevoegenToolStripMenuItem";
            this.projectToevoegenToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.projectToevoegenToolStripMenuItem.Text = "Project toevoegen";
            this.projectToevoegenToolStripMenuItem.Click += new System.EventHandler(this.projectToevoegenToolStripMenuItem_Click);
            // 
            // projectledenToolStripMenuItem
            // 
            this.projectledenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectledenOverviewToolStripMenuItem,
            this.projectledenToevoegenToolStripMenuItem});
            this.projectledenToolStripMenuItem.Name = "projectledenToolStripMenuItem";
            this.projectledenToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.projectledenToolStripMenuItem.Text = "Projectleden";
            // 
            // projectledenOverviewToolStripMenuItem
            // 
            this.projectledenOverviewToolStripMenuItem.Name = "projectledenOverviewToolStripMenuItem";
            this.projectledenOverviewToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.projectledenOverviewToolStripMenuItem.Text = "Projectleden overview";
            // 
            // projectledenToevoegenToolStripMenuItem
            // 
            this.projectledenToevoegenToolStripMenuItem.Name = "projectledenToevoegenToolStripMenuItem";
            this.projectledenToevoegenToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.projectledenToevoegenToolStripMenuItem.Text = "Projectleden toevoegen";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 355);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HoofdMenuStrip);
            this.MainMenuStrip = this.HoofdMenuStrip;
            this.Name = "DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardAdmin";
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
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
        private ToolStripMenuItem projectToevoegenToolStripMenuItem;
        private ToolStripMenuItem projectledenToolStripMenuItem;
        private ToolStripMenuItem projectledenOverviewToolStripMenuItem;
        private ToolStripMenuItem projectledenToevoegenToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
    }
}