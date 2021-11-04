
namespace utpStore.ui
{
    partial class frmDisplaySearchUser
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
            this.components = new System.ComponentModel.Container();
            this.gBoxSearchUser = new System.Windows.Forms.GroupBox();
            this.maskTxtBoxSearchCardId = new System.Windows.Forms.MaskedTextBox();
            this.lblSearchCardId = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblTitleSearchUser = new System.Windows.Forms.Label();
            this.gBoxDateTime = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dataGridUserData = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.timerCurentTime = new System.Windows.Forms.Timer(this.components);
            this.gBoxSearchUser.SuspendLayout();
            this.gBoxDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxSearchUser
            // 
            this.gBoxSearchUser.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxSearchUser.Controls.Add(this.btnExit);
            this.gBoxSearchUser.Controls.Add(this.maskTxtBoxSearchCardId);
            this.gBoxSearchUser.Controls.Add(this.btnSelect);
            this.gBoxSearchUser.Controls.Add(this.lblSearchCardId);
            this.gBoxSearchUser.Controls.Add(this.lblSearchName);
            this.gBoxSearchUser.Controls.Add(this.txtSearchName);
            this.gBoxSearchUser.Location = new System.Drawing.Point(12, 55);
            this.gBoxSearchUser.Name = "gBoxSearchUser";
            this.gBoxSearchUser.Size = new System.Drawing.Size(1260, 101);
            this.gBoxSearchUser.TabIndex = 0;
            this.gBoxSearchUser.TabStop = false;
            // 
            // maskTxtBoxSearchCardId
            // 
            this.maskTxtBoxSearchCardId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.maskTxtBoxSearchCardId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.maskTxtBoxSearchCardId.Location = new System.Drawing.Point(471, 55);
            this.maskTxtBoxSearchCardId.Mask = "0-0000-00000-00-0";
            this.maskTxtBoxSearchCardId.Name = "maskTxtBoxSearchCardId";
            this.maskTxtBoxSearchCardId.Size = new System.Drawing.Size(449, 32);
            this.maskTxtBoxSearchCardId.TabIndex = 7;
            this.maskTxtBoxSearchCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearchCardId
            // 
            this.lblSearchCardId.AutoSize = true;
            this.lblSearchCardId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchCardId.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchCardId.Location = new System.Drawing.Point(467, 28);
            this.lblSearchCardId.Name = "lblSearchCardId";
            this.lblSearchCardId.Size = new System.Drawing.Size(195, 24);
            this.lblSearchCardId.TabIndex = 6;
            this.lblSearchCardId.Text = "ค้นหาด้วยเลขบัตรประชาชน";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchName.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchName.Location = new System.Drawing.Point(12, 28);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(134, 24);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "ค้นหาด้วยชื่อ-สกุล";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearchName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearchName.Location = new System.Drawing.Point(16, 55);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(449, 32);
            this.txtSearchName.TabIndex = 3;
            this.txtSearchName.Text = "Fliter";
            this.txtSearchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitleSearchUser
            // 
            this.lblTitleSearchUser.AutoSize = true;
            this.lblTitleSearchUser.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleSearchUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleSearchUser.Location = new System.Drawing.Point(12, 9);
            this.lblTitleSearchUser.Name = "lblTitleSearchUser";
            this.lblTitleSearchUser.Size = new System.Drawing.Size(134, 32);
            this.lblTitleSearchUser.TabIndex = 10;
            this.lblTitleSearchUser.Text = "ค้นหาผู้ใช้งาน";
            // 
            // gBoxDateTime
            // 
            this.gBoxDateTime.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxDateTime.Controls.Add(this.lblDate);
            this.gBoxDateTime.Controls.Add(this.lblCurrentDate);
            this.gBoxDateTime.Controls.Add(this.lblTime);
            this.gBoxDateTime.Controls.Add(this.lblCurrentTime);
            this.gBoxDateTime.Location = new System.Drawing.Point(152, 5);
            this.gBoxDateTime.Name = "gBoxDateTime";
            this.gBoxDateTime.Size = new System.Drawing.Size(1120, 44);
            this.gBoxDateTime.TabIndex = 11;
            this.gBoxDateTime.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(327, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "วันที่ :";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentDate.Location = new System.Drawing.Point(381, 10);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(112, 24);
            this.lblCurrentDate.TabIndex = 3;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(524, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 24);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "เวลา :";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentTime.Location = new System.Drawing.Point(580, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(113, 24);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // dataGridUserData
            // 
            this.dataGridUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserData.Location = new System.Drawing.Point(12, 162);
            this.dataGridUserData.Name = "dataGridUserData";
            this.dataGridUserData.Size = new System.Drawing.Size(1260, 300);
            this.dataGridUserData.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1106, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSelect.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(944, 55);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 32);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "เลือก";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // timerCurentTime
            // 
            this.timerCurentTime.Tick += new System.EventHandler(this.timerCurentTime_Tick);
            // 
            // frmDisplaySearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 481);
            this.Controls.Add(this.dataGridUserData);
            this.Controls.Add(this.lblTitleSearchUser);
            this.Controls.Add(this.gBoxDateTime);
            this.Controls.Add(this.gBoxSearchUser);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDisplaySearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEARCH : USER";
            this.gBoxSearchUser.ResumeLayout(false);
            this.gBoxSearchUser.PerformLayout();
            this.gBoxDateTime.ResumeLayout(false);
            this.gBoxDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSearchUser;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchCardId;
        private System.Windows.Forms.MaskedTextBox maskTxtBoxSearchCardId;
        private System.Windows.Forms.Label lblTitleSearchUser;
        private System.Windows.Forms.GroupBox gBoxDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.DataGridView dataGridUserData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Timer timerCurentTime;
    }
}