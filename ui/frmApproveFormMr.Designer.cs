
namespace utpStore.ui
{
    partial class frmApproveFormMr
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
            this.lblTitleApprove = new System.Windows.Forms.Label();
            this.gBoxCurrentDateTime = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timerCurrentDateTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridRequest = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridRequestDetail = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxReceiveFromMrDetail = new System.Windows.Forms.GroupBox();
            this.btnPrintApprove = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.txtFormMrName = new System.Windows.Forms.TextBox();
            this.lblFormMrName = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gBoxTitleReceive.SuspendLayout();
            this.gBoxCurrentDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequestDetail)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gBoxReceiveFromMrDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTitleReceive
            // 
            this.gBoxTitleReceive.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxTitleReceive.Controls.Add(this.lblTitleApprove);
            this.gBoxTitleReceive.Location = new System.Drawing.Point(12, 12);
            this.gBoxTitleReceive.Name = "gBoxTitleReceive";
            this.gBoxTitleReceive.Size = new System.Drawing.Size(874, 44);
            this.gBoxTitleReceive.TabIndex = 56;
            this.gBoxTitleReceive.TabStop = false;
            // 
            // lblTitleApprove
            // 
            this.lblTitleApprove.AutoSize = true;
            this.lblTitleApprove.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleApprove.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleApprove.Location = new System.Drawing.Point(500, 4);
            this.lblTitleApprove.Name = "lblTitleApprove";
            this.lblTitleApprove.Size = new System.Drawing.Size(104, 32);
            this.lblTitleApprove.TabIndex = 1;
            this.lblTitleApprove.Text = "อนุมัติเบิก";
            this.lblTitleApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gBoxCurrentDateTime.TabIndex = 57;
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
            // timerCurrentDateTime
            // 
            this.timerCurrentDateTime.Tick += new System.EventHandler(this.timerCurrentDateTime_Tick);
            // 
            // dataGridRequest
            // 
            this.dataGridRequest.AllowUserToAddRows = false;
            this.dataGridRequest.AllowUserToDeleteRows = false;
            this.dataGridRequest.AllowUserToResizeColumns = false;
            this.dataGridRequest.AllowUserToResizeRows = false;
            this.dataGridRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequest.Location = new System.Drawing.Point(6, 9);
            this.dataGridRequest.MultiSelect = false;
            this.dataGridRequest.Name = "dataGridRequest";
            this.dataGridRequest.ReadOnly = true;
            this.dataGridRequest.RowHeadersVisible = false;
            this.dataGridRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRequest.Size = new System.Drawing.Size(424, 389);
            this.dataGridRequest.TabIndex = 58;
            this.dataGridRequest.Click += new System.EventHandler(this.dataGridRequest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dataGridRequest);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 407);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dataGridRequestDetail);
            this.groupBox2.Location = new System.Drawing.Point(456, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 407);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // dataGridRequestDetail
            // 
            this.dataGridRequestDetail.AllowUserToAddRows = false;
            this.dataGridRequestDetail.AllowUserToDeleteRows = false;
            this.dataGridRequestDetail.AllowUserToResizeColumns = false;
            this.dataGridRequestDetail.AllowUserToResizeRows = false;
            this.dataGridRequestDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequestDetail.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridRequestDetail.Location = new System.Drawing.Point(6, 9);
            this.dataGridRequestDetail.MultiSelect = false;
            this.dataGridRequestDetail.Name = "dataGridRequestDetail";
            this.dataGridRequestDetail.ReadOnly = true;
            this.dataGridRequestDetail.RowHeadersVisible = false;
            this.dataGridRequestDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRequestDetail.Size = new System.Drawing.Size(804, 389);
            this.dataGridRequestDetail.TabIndex = 58;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(99, 22);
            this.menuEdit.Text = "แก้ไข";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // gBoxReceiveFromMrDetail
            // 
            this.gBoxReceiveFromMrDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnPrintApprove);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnApprove);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnExit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnCancelEdit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.cboxUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnSaveEdit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtRemaining);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblRemaining);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtQty);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblQty);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtTotalPrice);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblTotalPrice);
            this.gBoxReceiveFromMrDetail.Location = new System.Drawing.Point(12, 475);
            this.gBoxReceiveFromMrDetail.Name = "gBoxReceiveFromMrDetail";
            this.gBoxReceiveFromMrDetail.Size = new System.Drawing.Size(1260, 274);
            this.gBoxReceiveFromMrDetail.TabIndex = 61;
            this.gBoxReceiveFromMrDetail.TabStop = false;
            // 
            // btnPrintApprove
            // 
            this.btnPrintApprove.BackColor = System.Drawing.Color.Olive;
            this.btnPrintApprove.Enabled = false;
            this.btnPrintApprove.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintApprove.ForeColor = System.Drawing.Color.White;
            this.btnPrintApprove.Location = new System.Drawing.Point(1104, 129);
            this.btnPrintApprove.Name = "btnPrintApprove";
            this.btnPrintApprove.Size = new System.Drawing.Size(150, 32);
            this.btnPrintApprove.TabIndex = 69;
            this.btnPrintApprove.Text = "พิมพ์ใบเบิก";
            this.btnPrintApprove.UseVisualStyleBackColor = false;
            this.btnPrintApprove.Click += new System.EventHandler(this.btnPrintApprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApprove.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(1104, 91);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 32);
            this.btnApprove.TabIndex = 68;
            this.btnApprove.Text = "อนุมัติเบิก";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1104, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelEdit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(792, 91);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(150, 32);
            this.btnCancelEdit.TabIndex = 66;
            this.btnCancelEdit.Text = "ยกเลิกแก้ไข";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // cboxUnit
            // 
            this.cboxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Items.AddRange(new object[] {
            "ใบ",
            "แผ่น",
            "ซอง",
            "เล่ม",
            "ม้วน",
            "กล่อง"});
            this.cboxUnit.Location = new System.Drawing.Point(796, 36);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(91, 32);
            this.cboxUnit.TabIndex = 65;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblPricePerUnit.Location = new System.Drawing.Point(992, 11);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(103, 24);
            this.lblPricePerUnit.TabIndex = 64;
            this.lblPricePerUnit.Text = "ราคาต่อหน่วย";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPricePerUnit.Location = new System.Drawing.Point(988, 36);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(130, 32);
            this.txtPricePerUnit.TabIndex = 62;
            this.txtPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.Teal;
            this.btnSaveEdit.Enabled = false;
            this.btnSaveEdit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(948, 91);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(150, 32);
            this.btnSaveEdit.TabIndex = 52;
            this.btnSaveEdit.Text = "บันทึกแก้ไข";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // txtFormMrName
            // 
            this.txtFormMrName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFormMrName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFormMrName.Location = new System.Drawing.Point(10, 36);
            this.txtFormMrName.Name = "txtFormMrName";
            this.txtFormMrName.Size = new System.Drawing.Size(685, 32);
            this.txtFormMrName.TabIndex = 28;
            this.txtFormMrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormMrName
            // 
            this.lblFormMrName.AutoSize = true;
            this.lblFormMrName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFormMrName.ForeColor = System.Drawing.Color.Teal;
            this.lblFormMrName.Location = new System.Drawing.Point(6, 9);
            this.lblFormMrName.Name = "lblFormMrName";
            this.lblFormMrName.Size = new System.Drawing.Size(82, 24);
            this.lblFormMrName.TabIndex = 27;
            this.lblFormMrName.Text = "แบบฟอร์ม";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemaining.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRemaining.Location = new System.Drawing.Point(701, 36);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(89, 32);
            this.txtRemaining.TabIndex = 32;
            this.txtRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRemaining.ForeColor = System.Drawing.Color.Teal;
            this.lblRemaining.Location = new System.Drawing.Point(697, 9);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(66, 24);
            this.lblRemaining.TabIndex = 31;
            this.lblRemaining.Text = "คงเหลือ";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblUnit.Location = new System.Drawing.Point(792, 9);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(70, 24);
            this.lblUnit.TabIndex = 33;
            this.lblUnit.Text = "หน่วยนับ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtQty.Location = new System.Drawing.Point(893, 36);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(89, 32);
            this.txtQty.TabIndex = 32;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblQty.ForeColor = System.Drawing.Color.Teal;
            this.lblQty.Location = new System.Drawing.Point(889, 9);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(81, 24);
            this.lblQty.TabIndex = 35;
            this.lblQty.Text = "จำนวนเบิก";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalPrice.Location = new System.Drawing.Point(1124, 36);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 32);
            this.txtTotalPrice.TabIndex = 38;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalPrice.Location = new System.Drawing.Point(1124, 11);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 24);
            this.lblTotalPrice.TabIndex = 37;
            this.lblTotalPrice.Text = "ราคาเบิกรวม";
            // 
            // frmApproveFormMr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.gBoxReceiveFromMrDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxTitleReceive);
            this.Controls.Add(this.gBoxCurrentDateTime);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmApproveFormMr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "อนุมัติเบิก";
            this.Load += new System.EventHandler(this.frmApproveFormMr_Load);
            this.gBoxTitleReceive.ResumeLayout(false);
            this.gBoxTitleReceive.PerformLayout();
            this.gBoxCurrentDateTime.ResumeLayout(false);
            this.gBoxCurrentDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequestDetail)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTitleReceive;
        private System.Windows.Forms.Label lblTitleApprove;
        private System.Windows.Forms.GroupBox gBoxCurrentDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timerCurrentDateTime;
        private System.Windows.Forms.DataGridView dataGridRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridRequestDetail;
        private System.Windows.Forms.GroupBox gBoxReceiveFromMrDetail;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox txtFormMrName;
        private System.Windows.Forms.Label lblFormMrName;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnPrintApprove;
    }
}