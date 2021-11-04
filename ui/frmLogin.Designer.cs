
namespace utpStore
{
    partial class frmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMrSystem = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.gBoxTopicLogin = new System.Windows.Forms.GroupBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.gBoxLogin.SuspendLayout();
            this.gBoxTopicLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUsername.Location = new System.Drawing.Point(9, 19);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasswd
            // 
            this.txtPasswd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPasswd.Location = new System.Drawing.Point(9, 55);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(216, 32);
            this.txtPasswd.TabIndex = 2;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswd_KeyPress);
            // 
            // gBoxLogin
            // 
            this.gBoxLogin.Controls.Add(this.btnExit);
            this.gBoxLogin.Controls.Add(this.txtPasswd);
            this.gBoxLogin.Controls.Add(this.btnLogin);
            this.gBoxLogin.Controls.Add(this.txtUsername);
            this.gBoxLogin.Location = new System.Drawing.Point(138, 13);
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.Size = new System.Drawing.Size(235, 132);
            this.gBoxLogin.TabIndex = 0;
            this.gBoxLogin.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(120, 92);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(9, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMrSystem
            // 
            this.lblMrSystem.AutoSize = true;
            this.lblMrSystem.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMrSystem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMrSystem.Location = new System.Drawing.Point(31, 22);
            this.lblMrSystem.Name = "lblMrSystem";
            this.lblMrSystem.Size = new System.Drawing.Size(301, 24);
            this.lblMrSystem.TabIndex = 6;
            this.lblMrSystem.Text = "ระบบบริหารคลังพัสดุแบบฟอร์มเวชระเบียน";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHospital.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHospital.Location = new System.Drawing.Point(91, 46);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(176, 24);
            this.lblHospital.TabIndex = 7;
            this.lblHospital.Text = "โรงพยาบาลอุทุมพรพิสัย";
            // 
            // gBoxTopicLogin
            // 
            this.gBoxTopicLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxTopicLogin.Controls.Add(this.lblMrSystem);
            this.gBoxTopicLogin.Controls.Add(this.lblHospital);
            this.gBoxTopicLogin.Location = new System.Drawing.Point(12, 151);
            this.gBoxTopicLogin.Name = "gBoxTopicLogin";
            this.gBoxTopicLogin.Size = new System.Drawing.Size(361, 79);
            this.gBoxTopicLogin.TabIndex = 5;
            this.gBoxTopicLogin.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::utpStore.Properties.Resources.utp_logo_main_bgwhite_01;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 25);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(120, 120);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 5;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.DoubleClick += new System.EventHandler(this.picBoxLogo_DoubleClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.gBoxTopicLogin);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.gBoxLogin);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            this.gBoxTopicLogin.ResumeLayout(false);
            this.gBoxTopicLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMrSystem;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.GroupBox gBoxTopicLogin;
    }
}

