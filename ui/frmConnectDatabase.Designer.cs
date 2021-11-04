
namespace utpStore.ui
{
    partial class frmConnectDatabase
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
            this.gBoxSettingDatabase = new System.Windows.Forms.GroupBox();
            this.lblMysqlPort = new System.Windows.Forms.Label();
            this.lblMysqlPassword = new System.Windows.Forms.Label();
            this.lblMysqlUsername = new System.Windows.Forms.Label();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.txtMysqlPort = new System.Windows.Forms.TextBox();
            this.txtMysqlPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMysqlUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.gBoxSettingDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSettingDatabase
            // 
            this.gBoxSettingDatabase.Controls.Add(this.lblMysqlPort);
            this.gBoxSettingDatabase.Controls.Add(this.lblMysqlPassword);
            this.gBoxSettingDatabase.Controls.Add(this.lblMysqlUsername);
            this.gBoxSettingDatabase.Controls.Add(this.lblServerIp);
            this.gBoxSettingDatabase.Controls.Add(this.txtMysqlPort);
            this.gBoxSettingDatabase.Controls.Add(this.txtMysqlPassword);
            this.gBoxSettingDatabase.Controls.Add(this.btnExit);
            this.gBoxSettingDatabase.Controls.Add(this.txtMysqlUsername);
            this.gBoxSettingDatabase.Controls.Add(this.btnSave);
            this.gBoxSettingDatabase.Controls.Add(this.txtServerIp);
            this.gBoxSettingDatabase.Location = new System.Drawing.Point(12, 12);
            this.gBoxSettingDatabase.Name = "gBoxSettingDatabase";
            this.gBoxSettingDatabase.Size = new System.Drawing.Size(241, 306);
            this.gBoxSettingDatabase.TabIndex = 0;
            this.gBoxSettingDatabase.TabStop = false;
            // 
            // lblMysqlPort
            // 
            this.lblMysqlPort.AutoSize = true;
            this.lblMysqlPort.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMysqlPort.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMysqlPort.Location = new System.Drawing.Point(7, 198);
            this.lblMysqlPort.Name = "lblMysqlPort";
            this.lblMysqlPort.Size = new System.Drawing.Size(137, 24);
            this.lblMysqlPort.TabIndex = 7;
            this.lblMysqlPort.Text = "DATABASE PORT";
            // 
            // lblMysqlPassword
            // 
            this.lblMysqlPassword.AutoSize = true;
            this.lblMysqlPassword.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMysqlPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMysqlPassword.Location = new System.Drawing.Point(6, 138);
            this.lblMysqlPassword.Name = "lblMysqlPassword";
            this.lblMysqlPassword.Size = new System.Drawing.Size(182, 24);
            this.lblMysqlPassword.TabIndex = 5;
            this.lblMysqlPassword.Text = "DATABASE PASSWORD";
            // 
            // lblMysqlUsername
            // 
            this.lblMysqlUsername.AutoSize = true;
            this.lblMysqlUsername.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMysqlUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMysqlUsername.Location = new System.Drawing.Point(6, 78);
            this.lblMysqlUsername.Name = "lblMysqlUsername";
            this.lblMysqlUsername.Size = new System.Drawing.Size(181, 24);
            this.lblMysqlUsername.TabIndex = 3;
            this.lblMysqlUsername.Text = "DATABASE USERNAME";
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblServerIp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblServerIp.Location = new System.Drawing.Point(6, 18);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(165, 24);
            this.lblServerIp.TabIndex = 1;
            this.lblServerIp.Text = "SERVER IP ADDRESS";
            // 
            // txtMysqlPort
            // 
            this.txtMysqlPort.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMysqlPort.Location = new System.Drawing.Point(11, 224);
            this.txtMysqlPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtMysqlPort.Name = "txtMysqlPort";
            this.txtMysqlPort.Size = new System.Drawing.Size(216, 32);
            this.txtMysqlPort.TabIndex = 8;
            this.txtMysqlPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMysqlPassword
            // 
            this.txtMysqlPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMysqlPassword.Location = new System.Drawing.Point(11, 164);
            this.txtMysqlPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtMysqlPassword.Name = "txtMysqlPassword";
            this.txtMysqlPassword.PasswordChar = '*';
            this.txtMysqlPassword.Size = new System.Drawing.Size(216, 32);
            this.txtMysqlPassword.TabIndex = 6;
            this.txtMysqlPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(122, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 32);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMysqlUsername
            // 
            this.txtMysqlUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMysqlUsername.Location = new System.Drawing.Point(11, 104);
            this.txtMysqlUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtMysqlUsername.Name = "txtMysqlUsername";
            this.txtMysqlUsername.Size = new System.Drawing.Size(216, 32);
            this.txtMysqlUsername.TabIndex = 4;
            this.txtMysqlUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(11, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtServerIp
            // 
            this.txtServerIp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtServerIp.Location = new System.Drawing.Point(10, 44);
            this.txtServerIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(216, 32);
            this.txtServerIp.TabIndex = 2;
            this.txtServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmConnectDatabase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(264, 331);
            this.Controls.Add(this.gBoxSettingDatabase);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmConnectDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เชื่อมต่อฐานข้อมูล";
            this.gBoxSettingDatabase.ResumeLayout(false);
            this.gBoxSettingDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSettingDatabase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMysqlUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.TextBox txtMysqlPort;
        private System.Windows.Forms.TextBox txtMysqlPassword;
        private System.Windows.Forms.Label lblMysqlPort;
        private System.Windows.Forms.Label lblMysqlPassword;
        private System.Windows.Forms.Label lblMysqlUsername;
        private System.Windows.Forms.Label lblServerIp;
    }
}