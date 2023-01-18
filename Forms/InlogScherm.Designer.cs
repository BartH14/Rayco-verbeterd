namespace Rayco_Planner.Forms
{
    partial class InlogScherm
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
            this.WachtwoordVeld = new System.Windows.Forms.TextBox();
            this.GebruikersnaamVeld = new System.Windows.Forms.TextBox();
            this.GebruikersnaamText = new System.Windows.Forms.Label();
            this.WachtwoordText = new System.Windows.Forms.Label();
            this.LoginKnop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WachtwoordVeld
            // 
            this.WachtwoordVeld.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WachtwoordVeld.Location = new System.Drawing.Point(397, 218);
            this.WachtwoordVeld.Name = "WachtwoordVeld";
            this.WachtwoordVeld.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.WachtwoordVeld.Size = new System.Drawing.Size(146, 32);
            this.WachtwoordVeld.TabIndex = 1;
            this.WachtwoordVeld.UseSystemPasswordChar = true;
            // 
            // GebruikersnaamVeld
            // 
            this.GebruikersnaamVeld.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GebruikersnaamVeld.Location = new System.Drawing.Point(397, 170);
            this.GebruikersnaamVeld.Name = "GebruikersnaamVeld";
            this.GebruikersnaamVeld.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GebruikersnaamVeld.Size = new System.Drawing.Size(146, 32);
            this.GebruikersnaamVeld.TabIndex = 2;
            // 
            // GebruikersnaamText
            // 
            this.GebruikersnaamText.AutoSize = true;
            this.GebruikersnaamText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GebruikersnaamText.Location = new System.Drawing.Point(219, 173);
            this.GebruikersnaamText.Name = "GebruikersnaamText";
            this.GebruikersnaamText.Size = new System.Drawing.Size(150, 25);
            this.GebruikersnaamText.TabIndex = 3;
            this.GebruikersnaamText.Text = "Gebruikersnaam";
            // 
            // WachtwoordText
            // 
            this.WachtwoordText.AutoSize = true;
            this.WachtwoordText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WachtwoordText.Location = new System.Drawing.Point(219, 225);
            this.WachtwoordText.Name = "WachtwoordText";
            this.WachtwoordText.Size = new System.Drawing.Size(119, 25);
            this.WachtwoordText.TabIndex = 4;
            this.WachtwoordText.Text = "Wachtwoord";
            // 
            // LoginKnop
            // 
            this.LoginKnop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginKnop.Location = new System.Drawing.Point(397, 318);
            this.LoginKnop.Name = "LoginKnop";
            this.LoginKnop.Size = new System.Drawing.Size(91, 34);
            this.LoginKnop.TabIndex = 5;
            this.LoginKnop.Text = "Login";
            this.LoginKnop.UseVisualStyleBackColor = true;
            this.LoginKnop.Click += new System.EventHandler(this.LoginKnop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connection string";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(397, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Leeg laten voor default";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(211, 32);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InlogScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginKnop);
            this.Controls.Add(this.WachtwoordText);
            this.Controls.Add(this.GebruikersnaamText);
            this.Controls.Add(this.GebruikersnaamVeld);
            this.Controls.Add(this.WachtwoordVeld);
            this.Name = "InlogScherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InlogScherm";
            this.Load += new System.EventHandler(this.InlogScherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox WachtwoordVeld;
        private TextBox GebruikersnaamVeld;
        private Label GebruikersnaamText;
        private Label WachtwoordText;
        private Button LoginKnop;
        private Label label1;
        private TextBox textBox1;
    }
}