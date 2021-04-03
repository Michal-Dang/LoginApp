namespace LoginApp
{
    partial class Login
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.buttonWyjdz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(37, 134);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(174, 22);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonZaloguj);
            this.panel1.Controls.Add(this.txtHaslo);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(305, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 329);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasło";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(37, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ZAREJESTRUJ SIĘ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZaloguj.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZaloguj.Location = new System.Drawing.Point(37, 234);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(174, 23);
            this.buttonZaloguj.TabIndex = 2;
            this.buttonZaloguj.Text = "ZALOGUJ SIĘ";
            this.buttonZaloguj.UseVisualStyleBackColor = false;
            this.buttonZaloguj.Click += new System.EventHandler(this.ButtonZaloguj_Click);
            // 
            // txtHaslo
            // 
            this.txtHaslo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHaslo.Location = new System.Drawing.Point(37, 189);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(174, 22);
            this.txtHaslo.TabIndex = 1;
            this.txtHaslo.UseSystemPasswordChar = true;
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.BackColor = System.Drawing.Color.Crimson;
            this.buttonWyjdz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWyjdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyjdz.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyjdz.Location = new System.Drawing.Point(823, 476);
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonWyjdz.TabIndex = 3;
            this.buttonWyjdz.Text = "ZAMKNIJ";
            this.buttonWyjdz.UseVisualStyleBackColor = false;
            this.buttonWyjdz.Click += new System.EventHandler(this.ButtonWyjdz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginApp.Properties.Resources.głos;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 521);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Logowanie";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 511);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonWyjdz;
        private System.Windows.Forms.Label label3;
    }
}