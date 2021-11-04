
namespace utpStore.ui
{
    partial class frmRequestFormMr
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
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBoxTitleReceive = new System.Windows.Forms.GroupBox();
            this.lblTitleOrder = new System.Windows.Forms.Label();
            this.gBoxReceiveDocumentDetail = new System.Windows.Forms.GroupBox();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSellNo = new System.Windows.Forms.TextBox();
            this.lblReceiveNo = new System.Windows.Forms.Label();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.dateTimePicker_SellDate = new System.Windows.Forms.DateTimePicker();
            this.txtFormMrName = new System.Windows.Forms.TextBox();
            this.lblFormMrName = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.gBoxCurrentDateTime = new System.Windows.Forms.GroupBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.gBoxButton = new System.Windows.Forms.GroupBox();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.lblSearchDataByChar = new System.Windows.Forms.Label();
            this.timerCurentDateTime = new System.Windows.Forms.Timer(this.components);
            this.gBoxReceiveFromMrDetail = new System.Windows.Forms.GroupBox();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.gBoxSearchData = new System.Windows.Forms.GroupBox();
            this.lblSearchDataByDate = new System.Windows.Forms.Label();
            this.dateTimePicker_SearchDataByDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchDataByChar = new System.Windows.Forms.TextBox();
            this.dataGridSell = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGrandTotalPrice = new System.Windows.Forms.Label();
            this.txtGrandTotalPrice = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxTitleReceive.SuspendLayout();
            this.gBoxReceiveDocumentDetail.SuspendLayout();
            this.gBoxCurrentDateTime.SuspendLayout();
            this.gBoxButton.SuspendLayout();
            this.gBoxReceiveFromMrDetail.SuspendLayout();
            this.gBoxSearchData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSell)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(10, 47);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(150, 32);
            this.btnCancelEdit.TabIndex = 50;
            this.btnCancelEdit.Text = "ยกเลิกการแก้ไข";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditUpdate.Enabled = false;
            this.btnEditUpdate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEditUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEditUpdate.Location = new System.Drawing.Point(10, 9);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(150, 32);
            this.btnEditUpdate.TabIndex = 49;
            this.btnEditUpdate.Text = "บันทึกแก้ไขข้อมูล";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.Teal;
            this.btnAddToList.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.Location = new System.Drawing.Point(1168, 36);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(82, 32);
            this.btnAddToList.TabIndex = 52;
            this.btnAddToList.Text = "เบิก";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(12, 699);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 50);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(1102, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 72);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // gBoxTitleReceive
            // 
            this.gBoxTitleReceive.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxTitleReceive.Controls.Add(this.lblTitleOrder);
            this.gBoxTitleReceive.Location = new System.Drawing.Point(12, 12);
            this.gBoxTitleReceive.Name = "gBoxTitleReceive";
            this.gBoxTitleReceive.Size = new System.Drawing.Size(874, 44);
            this.gBoxTitleReceive.TabIndex = 54;
            this.gBoxTitleReceive.TabStop = false;
            // 
            // lblTitleOrder
            // 
            this.lblTitleOrder.AutoSize = true;
            this.lblTitleOrder.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleOrder.Location = new System.Drawing.Point(500, 4);
            this.lblTitleOrder.Name = "lblTitleOrder";
            this.lblTitleOrder.Size = new System.Drawing.Size(50, 32);
            this.lblTitleOrder.TabIndex = 1;
            this.lblTitleOrder.Text = "เบิก";
            this.lblTitleOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxReceiveDocumentDetail
            // 
            this.gBoxReceiveDocumentDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblUserFullName);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtUserRequest);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblDepartment);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtDepartment);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtSellNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblReceiveNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblReceiveDate);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.dateTimePicker_SellDate);
            this.gBoxReceiveDocumentDetail.Location = new System.Drawing.Point(12, 62);
            this.gBoxReceiveDocumentDetail.Name = "gBoxReceiveDocumentDetail";
            this.gBoxReceiveDocumentDetail.Size = new System.Drawing.Size(1260, 82);
            this.gBoxReceiveDocumentDetail.TabIndex = 56;
            this.gBoxReceiveDocumentDetail.TabStop = false;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.Teal;
            this.lblUserFullName.Location = new System.Drawing.Point(940, 10);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(47, 24);
            this.lblUserFullName.TabIndex = 42;
            this.lblUserFullName.Text = "ผู้เบิก";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.Enabled = false;
            this.txtUserRequest.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUserRequest.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUserRequest.Location = new System.Drawing.Point(944, 37);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.Size = new System.Drawing.Size(306, 32);
            this.txtUserRequest.TabIndex = 41;
            this.txtUserRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Teal;
            this.lblDepartment.Location = new System.Drawing.Point(386, 10);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(112, 24);
            this.lblDepartment.TabIndex = 24;
            this.lblDepartment.Text = "หน่วยงานที่เบิก";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDepartment.Location = new System.Drawing.Point(390, 37);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(548, 32);
            this.txtDepartment.TabIndex = 25;
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSellNo
            // 
            this.txtSellNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSellNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSellNo.Location = new System.Drawing.Point(10, 37);
            this.txtSellNo.Name = "txtSellNo";
            this.txtSellNo.ReadOnly = true;
            this.txtSellNo.Size = new System.Drawing.Size(184, 32);
            this.txtSellNo.TabIndex = 9;
            this.txtSellNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReceiveNo
            // 
            this.lblReceiveNo.AutoSize = true;
            this.lblReceiveNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblReceiveNo.ForeColor = System.Drawing.Color.Teal;
            this.lblReceiveNo.Location = new System.Drawing.Point(6, 10);
            this.lblReceiveNo.Name = "lblReceiveNo";
            this.lblReceiveNo.Size = new System.Drawing.Size(71, 24);
            this.lblReceiveNo.TabIndex = 8;
            this.lblReceiveNo.Text = "เลขที่เบิก";
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblReceiveDate.ForeColor = System.Drawing.Color.Teal;
            this.lblReceiveDate.Location = new System.Drawing.Point(196, 10);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(65, 24);
            this.lblReceiveDate.TabIndex = 10;
            this.lblReceiveDate.Text = "วันที่เบิก";
            // 
            // dateTimePicker_SellDate
            // 
            this.dateTimePicker_SellDate.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SellDate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SellDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SellDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SellDate.Location = new System.Drawing.Point(200, 37);
            this.dateTimePicker_SellDate.Name = "dateTimePicker_SellDate";
            this.dateTimePicker_SellDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker_SellDate.TabIndex = 11;
            // 
            // txtFormMrName
            // 
            this.txtFormMrName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFormMrName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFormMrName.Location = new System.Drawing.Point(10, 36);
            this.txtFormMrName.Name = "txtFormMrName";
            this.txtFormMrName.Size = new System.Drawing.Size(564, 32);
            this.txtFormMrName.TabIndex = 28;
            this.txtFormMrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFormMrName.TextChanged += new System.EventHandler(this.txtFormMrName_TextChanged);
            this.txtFormMrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormMrName_KeyDown);
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
            this.txtRemaining.Location = new System.Drawing.Point(580, 36);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(89, 32);
            this.txtRemaining.TabIndex = 32;
            this.txtRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Teal;
            this.lblQuantity.Location = new System.Drawing.Point(781, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 24);
            this.lblQuantity.TabIndex = 31;
            this.lblQuantity.Text = "จำนวนเบิก";
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
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblUnit.Location = new System.Drawing.Point(671, 8);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(70, 24);
            this.lblUnit.TabIndex = 33;
            this.lblUnit.Text = "หน่วยนับ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtQty.Location = new System.Drawing.Point(785, 35);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(89, 32);
            this.txtQty.TabIndex = 32;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblPricePerUnit.Location = new System.Drawing.Point(876, 8);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(103, 24);
            this.lblPricePerUnit.TabIndex = 35;
            this.lblPricePerUnit.Text = "ราคาต่อหน่วย";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalPrice.Location = new System.Drawing.Point(1016, 35);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 32);
            this.txtTotalPrice.TabIndex = 38;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // gBoxButton
            // 
            this.gBoxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxButton.Controls.Add(this.btnExit);
            this.gBoxButton.Controls.Add(this.btnCancelEdit);
            this.gBoxButton.Controls.Add(this.btnEditUpdate);
            this.gBoxButton.Location = new System.Drawing.Point(1102, 381);
            this.gBoxButton.Name = "gBoxButton";
            this.gBoxButton.Size = new System.Drawing.Size(170, 368);
            this.gBoxButton.TabIndex = 61;
            this.gBoxButton.TabStop = false;
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.AutoSize = true;
            this.lblPriceTotal.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPriceTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblPriceTotal.Location = new System.Drawing.Point(1016, 10);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(96, 24);
            this.lblPriceTotal.TabIndex = 37;
            this.lblPriceTotal.Text = "ราคาเบิกรวม";
            // 
            // lblSearchDataByChar
            // 
            this.lblSearchDataByChar.AutoSize = true;
            this.lblSearchDataByChar.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchDataByChar.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchDataByChar.Location = new System.Drawing.Point(196, 4);
            this.lblSearchDataByChar.Name = "lblSearchDataByChar";
            this.lblSearchDataByChar.Size = new System.Drawing.Size(134, 24);
            this.lblSearchDataByChar.TabIndex = 42;
            this.lblSearchDataByChar.Text = "ค้นหาข้อมูลตามคำ";
            // 
            // timerCurentDateTime
            // 
            this.timerCurentDateTime.Enabled = true;
            this.timerCurentDateTime.Tick += new System.EventHandler(this.timerCurentDateTime_Tick);
            // 
            // gBoxReceiveFromMrDetail
            // 
            this.gBoxReceiveFromMrDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveFromMrDetail.Controls.Add(this.cboxUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblRemaining);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnAddToList);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtRemaining);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblQuantity);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtQty);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtTotalPrice);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblPriceTotal);
            this.gBoxReceiveFromMrDetail.Location = new System.Drawing.Point(12, 150);
            this.gBoxReceiveFromMrDetail.Name = "gBoxReceiveFromMrDetail";
            this.gBoxReceiveFromMrDetail.Size = new System.Drawing.Size(1260, 146);
            this.gBoxReceiveFromMrDetail.TabIndex = 58;
            this.gBoxReceiveFromMrDetail.TabStop = false;
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
            this.cboxUnit.Location = new System.Drawing.Point(675, 35);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(91, 32);
            this.cboxUnit.TabIndex = 65;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRemaining.ForeColor = System.Drawing.Color.Teal;
            this.lblRemaining.Location = new System.Drawing.Point(580, 10);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(66, 24);
            this.lblRemaining.TabIndex = 64;
            this.lblRemaining.Text = "คงเหลือ";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPricePerUnit.Location = new System.Drawing.Point(880, 35);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(130, 32);
            this.txtPricePerUnit.TabIndex = 62;
            this.txtPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBoxSearchData
            // 
            this.gBoxSearchData.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxSearchData.Controls.Add(this.lblSearchDataByDate);
            this.gBoxSearchData.Controls.Add(this.dateTimePicker_SearchDataByDate);
            this.gBoxSearchData.Controls.Add(this.txtSearchDataByChar);
            this.gBoxSearchData.Controls.Add(this.lblSearchDataByChar);
            this.gBoxSearchData.Location = new System.Drawing.Point(12, 302);
            this.gBoxSearchData.Name = "gBoxSearchData";
            this.gBoxSearchData.Size = new System.Drawing.Size(766, 73);
            this.gBoxSearchData.TabIndex = 59;
            this.gBoxSearchData.TabStop = false;
            // 
            // lblSearchDataByDate
            // 
            this.lblSearchDataByDate.AutoSize = true;
            this.lblSearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchDataByDate.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchDataByDate.Location = new System.Drawing.Point(6, 4);
            this.lblSearchDataByDate.Name = "lblSearchDataByDate";
            this.lblSearchDataByDate.Size = new System.Drawing.Size(145, 24);
            this.lblSearchDataByDate.TabIndex = 44;
            this.lblSearchDataByDate.Text = "ค้นหาข้อมูลตามวันที่";
            // 
            // dateTimePicker_SearchDataByDate
            // 
            this.dateTimePicker_SearchDataByDate.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.Enabled = false;
            this.dateTimePicker_SearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.Location = new System.Drawing.Point(10, 31);
            this.dateTimePicker_SearchDataByDate.Name = "dateTimePicker_SearchDataByDate";
            this.dateTimePicker_SearchDataByDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker_SearchDataByDate.TabIndex = 45;
            // 
            // txtSearchDataByChar
            // 
            this.txtSearchDataByChar.Enabled = false;
            this.txtSearchDataByChar.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearchDataByChar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearchDataByChar.Location = new System.Drawing.Point(200, 31);
            this.txtSearchDataByChar.Name = "txtSearchDataByChar";
            this.txtSearchDataByChar.Size = new System.Drawing.Size(469, 32);
            this.txtSearchDataByChar.TabIndex = 43;
            this.txtSearchDataByChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridSell
            // 
            this.dataGridSell.AllowUserToAddRows = false;
            this.dataGridSell.AllowUserToDeleteRows = false;
            this.dataGridSell.AllowUserToResizeColumns = false;
            this.dataGridSell.AllowUserToResizeRows = false;
            this.dataGridSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSell.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridSell.Location = new System.Drawing.Point(12, 381);
            this.dataGridSell.MultiSelect = false;
            this.dataGridSell.Name = "dataGridSell";
            this.dataGridSell.ReadOnly = true;
            this.dataGridSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSell.Size = new System.Drawing.Size(1084, 312);
            this.dataGridSell.TabIndex = 60;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdit,
            this.menuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(99, 22);
            this.menuEdit.Text = "แก้ไข";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(99, 22);
            this.menuDelete.Text = "ลบ";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.lblGrandTotalPrice);
            this.groupBox1.Controls.Add(this.txtGrandTotalPrice);
            this.groupBox1.Location = new System.Drawing.Point(784, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 72);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // lblGrandTotalPrice
            // 
            this.lblGrandTotalPrice.AutoSize = true;
            this.lblGrandTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGrandTotalPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblGrandTotalPrice.Location = new System.Drawing.Point(9, 4);
            this.lblGrandTotalPrice.Name = "lblGrandTotalPrice";
            this.lblGrandTotalPrice.Size = new System.Drawing.Size(120, 24);
            this.lblGrandTotalPrice.TabIndex = 39;
            this.lblGrandTotalPrice.Text = "ราคาเบิกทั้งหมด";
            // 
            // txtGrandTotalPrice
            // 
            this.txtGrandTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtGrandTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtGrandTotalPrice.Location = new System.Drawing.Point(13, 31);
            this.txtGrandTotalPrice.Name = "txtGrandTotalPrice";
            this.txtGrandTotalPrice.Size = new System.Drawing.Size(225, 32);
            this.txtGrandTotalPrice.TabIndex = 40;
            this.txtGrandTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRequestFormMr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxTitleReceive);
            this.Controls.Add(this.gBoxReceiveDocumentDetail);
            this.Controls.Add(this.gBoxCurrentDateTime);
            this.Controls.Add(this.gBoxButton);
            this.Controls.Add(this.gBoxReceiveFromMrDetail);
            this.Controls.Add(this.gBoxSearchData);
            this.Controls.Add(this.dataGridSell);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmRequestFormMr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขอเบิก";
            this.Load += new System.EventHandler(this.frmRequestFormMr_Load);
            this.gBoxTitleReceive.ResumeLayout(false);
            this.gBoxTitleReceive.PerformLayout();
            this.gBoxReceiveDocumentDetail.ResumeLayout(false);
            this.gBoxReceiveDocumentDetail.PerformLayout();
            this.gBoxCurrentDateTime.ResumeLayout(false);
            this.gBoxCurrentDateTime.PerformLayout();
            this.gBoxButton.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.PerformLayout();
            this.gBoxSearchData.ResumeLayout(false);
            this.gBoxSearchData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSell)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gBoxTitleReceive;
        private System.Windows.Forms.Label lblTitleOrder;
        private System.Windows.Forms.GroupBox gBoxReceiveDocumentDetail;
        private System.Windows.Forms.TextBox txtSellNo;
        private System.Windows.Forms.Label lblReceiveNo;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SellDate;
        private System.Windows.Forms.TextBox txtFormMrName;
        private System.Windows.Forms.Label lblFormMrName;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gBoxCurrentDateTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.GroupBox gBoxButton;
        private System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.Label lblSearchDataByChar;
        private System.Windows.Forms.Timer timerCurentDateTime;
        private System.Windows.Forms.GroupBox gBoxReceiveFromMrDetail;
        private System.Windows.Forms.GroupBox gBoxSearchData;
        private System.Windows.Forms.Label lblSearchDataByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchDataByDate;
        private System.Windows.Forms.TextBox txtSearchDataByChar;
        private System.Windows.Forms.DataGridView dataGridSell;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.TextBox txtUserRequest;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrandTotalPrice;
        private System.Windows.Forms.TextBox txtGrandTotalPrice;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}