namespace Rayco_Planner.Forms
{
    partial class ProjectToevoegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NaamBox = new System.Windows.Forms.TextBox();
            this.OpdrachtgeverBox = new System.Windows.Forms.TextBox();
            this.SoortenBox = new System.Windows.Forms.ListBox();
            this.ProjectLedenBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project naam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opdrachtgever";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project soort";
            // 
            // NaamBox
            // 
            this.NaamBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NaamBox.Location = new System.Drawing.Point(211, 18);
            this.NaamBox.Name = "NaamBox";
            this.NaamBox.Size = new System.Drawing.Size(199, 32);
            this.NaamBox.TabIndex = 3;
            // 
            // OpdrachtgeverBox
            // 
            this.OpdrachtgeverBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpdrachtgeverBox.Location = new System.Drawing.Point(211, 58);
            this.OpdrachtgeverBox.Name = "OpdrachtgeverBox";
            this.OpdrachtgeverBox.Size = new System.Drawing.Size(199, 32);
            this.OpdrachtgeverBox.TabIndex = 4;
            // 
            // SoortenBox
            // 
            this.SoortenBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoortenBox.FormattingEnabled = true;
            this.SoortenBox.ItemHeight = 25;
            this.SoortenBox.Location = new System.Drawing.Point(211, 103);
            this.SoortenBox.Name = "SoortenBox";
            this.SoortenBox.Size = new System.Drawing.Size(199, 79);
            this.SoortenBox.TabIndex = 5;
            // 
            // ProjectLedenBox
            // 
            this.ProjectLedenBox.FormattingEnabled = true;
            this.ProjectLedenBox.Location = new System.Drawing.Point(121, 248);
            this.ProjectLedenBox.Name = "ProjectLedenBox";
            this.ProjectLedenBox.Size = new System.Drawing.Size(199, 202);
            this.ProjectLedenBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(121, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Projectleden koppelen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(159, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjectLedenBox);
            this.Controls.Add(this.SoortenBox);
            this.Controls.Add(this.OpdrachtgeverBox);
            this.Controls.Add(this.NaamBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectToevoegen";
            this.Text = "ProjectToevoegen";
            this.Load += new System.EventHandler(this.ProjectToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NaamBox;
        private TextBox OpdrachtgeverBox;
        public ListBox SoortenBox;
        private CheckedListBox ProjectLedenBox;
        private Label label4;
        private Button button1;
    }
}