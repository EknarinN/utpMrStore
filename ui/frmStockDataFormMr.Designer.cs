
namespace utpStore.ui
{
    partial class frmStockDataFormMr
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
            this.gBoxTitleReceive = new System.Windows.Forms.GroupBox();
            this.lblTitleReceive = new System.Windows.Forms.Label();
            this.gBoxCurrentDateTime = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dataGridReceive = new System.Windows.Forms.DataGridView();
            this.gBoxReceiveDocumentDetail = new System.Windows.Forms.GroupBox();
            this.txtReceiveNo = new System.Windows.Forms.TextBox();
            this.lblReceiveNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_SearchDataByDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDataByDate = new System.Windows.Forms.Label();
            this.gBoxSearchData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearchFirstName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.gBoxTitleReceive.SuspendLayout();
            this.gBoxCurrentDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceive)).BeginInit();
            this.gBoxReceiveDocumentDetail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxSearchData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTitleReceive
            // 
            this.gBoxTitleReceive.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxTitleReceive.Controls.Add(this.lblTitleReceive);
            this.gBoxTitleReceive.Location = new System.Drawing.Point(12, 12);
            this.gBoxTitleReceive.Name = "gBoxTitleReceive";
            this.gBoxTitleReceive.Size = new System.Drawing.Size(874, 44);
            this.gBoxTitleReceive.TabIndex = 54;
            this.gBoxTitleReceive.TabStop = false;
            // 
            // lblTitleReceive
            // 
            this.lblTitleReceive.AutoSize = true;
            this.lblTitleReceive.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleReceive.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleReceive.Location = new System.Drawing.Point(500, 4);
            this.lblTitleReceive.Name = "lblTitleReceive";
            this.lblTitleReceive.Size = new System.Drawing.Size(108, 32);
            this.lblTitleReceive.TabIndex = 1;
            this.lblTitleReceive.Text = "ข้อมูลคลัง";
            this.lblTitleReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxCurrentDateTime
            // 
            this.gBoxCurrentDateTime.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxCurrentDateTime.Controls.Add(this.lblDate);
            this.gBoxCurrentDateTime.Controls.Add(this.lblCurrentDate);
            this.gBoxCurrentDateTime.Controls.Add(this.lblTime);
            this.gBoxCurrentDateTime.Controls.Add(this.lblCurrentTime);
            this.gBoxCurrentDateTime.Location = new System.Drawing.Point(892, 12);
            this.gBoxCurrentDateTime.Name = "gBoxCurrentDateTime";
            this.gBoxCurrentDateTime.Size = new System.Drawing.Size(380, 44);
            this.gBoxCurrentDateTime.TabIndex = 55;
            this.gBoxCurrentDateTime.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(8, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "วันที่";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentDate.Location = new System.Drawing.Point(53, 10);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(112, 24);
            this.lblCurrentDate.TabIndex = 4;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(214, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 24);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "เวลา";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentTime.Location = new System.Drawing.Point(261, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(113, 24);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // dataGridReceive
            // 
            this.dataGridReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceive.Location = new System.Drawing.Point(12, 210);
            this.dataGridReceive.Name = "dataGridReceive";
            this.dataGridReceive.Size = new System.Drawing.Size(1260, 486);
            this.dataGridReceive.TabIndex = 58;
            // 
            // gBoxReceiveDocumentDetail
            // 
            this.gBoxReceiveDocumentDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtReceiveNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblReceiveNo);
            this.gBoxReceiveDocumentDetail.Location = new System.Drawing.Point(603, 62);
            this.gBoxReceiveDocumentDetail.Name = "gBoxReceiveDocumentDetail";
            this.gBoxReceiveDocumentDetail.Size = new System.Drawing.Size(669, 89);
            this.gBoxReceiveDocumentDetail.TabIndex = 56;
            this.gBoxReceiveDocumentDetail.TabStop = false;
            // 
            // txtReceiveNo
            // 
            this.txtReceiveNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtReceiveNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReceiveNo.Location = new System.Drawing.Point(7, 43);
            this.txtReceiveNo.Name = "txtReceiveNo";
            this.txtReceiveNo.Size = new System.Drawing.Size(656, 32);
            this.txtReceiveNo.TabIndex = 9;
            this.txtReceiveNo.Text = "Search All Character In Table";
            this.txtReceiveNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReceiveNo
            // 
            this.lblReceiveNo.AutoSize = true;
            this.lblReceiveNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblReceiveNo.ForeColor = System.Drawing.Color.Teal;
            this.lblReceiveNo.Location = new System.Drawing.Point(3, 16);
            this.lblReceiveNo.Name = "lblReceiveNo";
            this.lblReceiveNo.Size = new System.Drawing.Size(134, 24);
            this.lblReceiveNo.TabIndex = 8;
            this.lblReceiveNo.Text = "ค้นหาข้อมูลตามคำ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1260, 47);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(948, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 32);
            this.button3.TabIndex = 50;
            this.button3.Text = "EXPORT PDF";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1104, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "EXPORT EXCEL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_SearchDataByDate
            // 
            this.dateTimePicker_SearchDataByDate.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.Location = new System.Drawing.Point(10, 43);
            this.dateTimePicker_SearchDataByDate.Name = "dateTimePicker_SearchDataByDate";
            this.dateTimePicker_SearchDataByDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker_SearchDataByDate.TabIndex = 45;
            // 
            // lblSearchDataByDate
            // 
            this.lblSearchDataByDate.AutoSize = true;
            this.lblSearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchDataByDate.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchDataByDate.Location = new System.Drawing.Point(6, 16);
            this.lblSearchDataByDate.Name = "lblSearchDataByDate";
            this.lblSearchDataByDate.Size = new System.Drawing.Size(174, 24);
            this.lblSearchDataByDate.TabIndex = 44;
            this.lblSearchDataByDate.Text = "ค้นหาข้อมูลตามช่วงวันที่";
            // 
            // gBoxSearchData
            // 
            this.gBoxSearchData.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxSearchData.Controls.Add(this.label1);
            this.gBoxSearchData.Controls.Add(this.dateTimePicker1);
            this.gBoxSearchData.Controls.Add(this.btnSearchFirstName);
            this.gBoxSearchData.Controls.Add(this.lblSearchDataByDate);
            this.gBoxSearchData.Controls.Add(this.dateTimePicker_SearchDataByDate);
            this.gBoxSearchData.Location = new System.Drawing.Point(12, 62);
            this.gBoxSearchData.Name = "gBoxSearchData";
            this.gBoxSearchData.Size = new System.Drawing.Size(585, 89);
            this.gBoxSearchData.TabIndex = 42;
            this.gBoxSearchData.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(200, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "ถึง";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // btnSearchFirstName
            // 
            this.btnSearchFirstName.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFirstName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFirstName.ForeColor = System.Drawing.Color.White;
            this.btnSearchFirstName.Location = new System.Drawing.Point(426, 43);
            this.btnSearchFirstName.Name = "btnSearchFirstName";
            this.btnSearchFirstName.Size = new System.Drawing.Size(150, 32);
            this.btnSearchFirstName.TabIndex = 46;
            this.btnSearchFirstName.Text = "แสดงข้อมูล";
            this.btnSearchFirstName.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(12, 702);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 47);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1104, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // frmStockDataFormMr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridReceive);
            this.Controls.Add(this.gBoxReceiveDocumentDetail);
            this.Controls.Add(this.gBoxTitleReceive);
            this.Controls.Add(this.gBoxCurrentDateTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxSearchData);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmStockDataFormMr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลคลัง";
            this.gBoxTitleReceive.ResumeLayout(false);
            this.gBoxTitleReceive.PerformLayout();
            this.gBoxCurrentDateTime.ResumeLayout(false);
            this.gBoxCurrentDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceive)).EndInit();
            this.gBoxReceiveDocumentDetail.ResumeLayout(false);
            this.gBoxReceiveDocumentDetail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gBoxSearchData.ResumeLayout(false);
            this.gBoxSearchData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxTitleReceive;
        private System.Windows.Forms.Label lblTitleReceive;
        private System.Windows.Forms.GroupBox gBoxCurrentDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.DataGridView dataGridReceive;
        private System.Windows.Forms.GroupBox gBoxReceiveDocumentDetail;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.Label lblReceiveNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchDataByDate;
        private System.Windows.Forms.Label lblSearchDataByDate;
        private System.Windows.Forms.GroupBox gBoxSearchData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerCurrentTime;
    }
}