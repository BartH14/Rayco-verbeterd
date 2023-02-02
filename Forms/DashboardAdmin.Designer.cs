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
            this.ProjectenLijst = new System.Windows.Forms.ComboBox();
            this.DoorlooptijdKnop = new System.Windows.Forms.Button();
            this.KritiekePadKnop = new System.Windows.Forms.Button();
            this.TakenKnop = new System.Windows.Forms.Button();
            this.HoofdMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoofdMenuStrip
            // 
            this.HoofdMenuStrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoofdMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.richTextBox1.Location = new System.Drawing.Point(233, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 336);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ProjectenLijst
            // 
            this.ProjectenLijst.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectenLijst.FormattingEnabled = true;
            this.ProjectenLijst.Items.AddRange(new object[] {
            "Selecteer het project"});
            this.ProjectenLijst.Location = new System.Drawing.Point(12, 36);
            this.ProjectenLijst.Name = "ProjectenLijst";
            this.ProjectenLijst.Size = new System.Drawing.Size(213, 33);
            this.ProjectenLijst.TabIndex = 3;
            this.ProjectenLijst.Text = "Selecteer een project";
            this.ProjectenLijst.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DoorlooptijdKnop
            // 
            this.DoorlooptijdKnop.Location = new System.Drawing.Point(18, 85);
            this.DoorlooptijdKnop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoorlooptijdKnop.Name = "DoorlooptijdKnop";
            this.DoorlooptijdKnop.Size = new System.Drawing.Size(190, 37);
            this.DoorlooptijdKnop.TabIndex = 4;
            this.DoorlooptijdKnop.Text = "Doorlooptijd";
            this.DoorlooptijdKnop.UseVisualStyleBackColor = true;
            this.DoorlooptijdKnop.Click += new System.EventHandler(this.DoorlooptijdKnop_Click);
            // 
            // KritiekePadKnop
            // 
            this.KritiekePadKnop.Location = new System.Drawing.Point(18, 126);
            this.KritiekePadKnop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KritiekePadKnop.Name = "KritiekePadKnop";
            this.KritiekePadKnop.Size = new System.Drawing.Size(190, 37);
            this.KritiekePadKnop.TabIndex = 5;
            this.KritiekePadKnop.Text = "Kritieke pad";
            this.KritiekePadKnop.UseVisualStyleBackColor = true;
            this.KritiekePadKnop.Click += new System.EventHandler(this.KritiekePadKnop_Click);
            // 
            // TakenKnop
            // 
            this.TakenKnop.Location = new System.Drawing.Point(18, 167);
            this.TakenKnop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TakenKnop.Name = "TakenKnop";
            this.TakenKnop.Size = new System.Drawing.Size(190, 37);
            this.TakenKnop.TabIndex = 6;
            this.TakenKnop.Text = "Toegewezen taken";
            this.TakenKnop.UseVisualStyleBackColor = true;
            this.TakenKnop.Click += new System.EventHandler(this.TakenKnop_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TakenKnop);
            this.Controls.Add(this.KritiekePadKnop);
            this.Controls.Add(this.DoorlooptijdKnop);
            this.Controls.Add(this.ProjectenLijst);
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
        private ComboBox ProjectenLijst;
        private Button DoorlooptijdKnop;
        private Button KritiekePadKnop;
        private Button TakenKnop;
    }
}