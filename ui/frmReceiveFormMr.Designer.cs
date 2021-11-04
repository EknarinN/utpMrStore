
namespace utpStore.ui
{
    partial class frmReceiveFormMr
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
            this.lblTitleReceive = new System.Windows.Forms.Label();
            this.gBoxCurrentDateTime = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dateTimePicker_ReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.gBoxReceiveDocumentDetail = new System.Windows.Forms.GroupBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtReceiveNo = new System.Windows.Forms.TextBox();
            this.lblReceiveNo = new System.Windows.Forms.Label();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblFormMrName = new System.Windows.Forms.Label();
            this.txtFormMrName = new System.Windows.Forms.TextBox();
            this.timerCurentDateTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridReceive = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxSearchData = new System.Windows.Forms.GroupBox();
            this.lblSearchDataByDate = new System.Windows.Forms.Label();
            this.dateTimePicker_SearchDataByDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchDataByChar = new System.Windows.Forms.TextBox();
            this.lblSearchDataByChar = new System.Windows.Forms.Label();
            this.gBoxButton = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.gBoxReceiveFromMrDetail = new System.Windows.Forms.GroupBox();
            this.lblLotNo = new System.Windows.Forms.Label();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtGrandTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotlaPrice = new System.Windows.Forms.Label();
            this.gBoxTitleReceive = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRecorder = new System.Windows.Forms.Label();
            this.txtRecorder = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxCurrentDateTime.SuspendLayout();
            this.gBoxReceiveDocumentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceive)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gBoxSearchData.SuspendLayout();
            this.gBoxButton.SuspendLayout();
            this.gBoxReceiveFromMrDetail.SuspendLayout();
            this.gBoxTitleReceive.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleReceive
            // 
            this.lblTitleReceive.AutoSize = true;
            this.lblTitleReceive.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleReceive.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleReceive.Location = new System.Drawing.Point(500, 4);
            this.lblTitleReceive.Name = "lblTitleReceive";
            this.lblTitleReceive.Size = new System.Drawing.Size(110, 32);
            this.lblTitleReceive.TabIndex = 1;
            this.lblTitleReceive.Text = "รับเข้าคลัง";
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
            this.gBoxCurrentDateTime.TabIndex = 2;
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
            // dateTimePicker_ReceiveDate
            // 
            this.dateTimePicker_ReceiveDate.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_ReceiveDate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_ReceiveDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_ReceiveDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_ReceiveDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_ReceiveDate.Location = new System.Drawing.Point(200, 43);
            this.dateTimePicker_ReceiveDate.Name = "dateTimePicker_ReceiveDate";
            this.dateTimePicker_ReceiveDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker_ReceiveDate.TabIndex = 11;
            // 
            // gBoxReceiveDocumentDetail
            // 
            this.gBoxReceiveDocumentDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblInvoiceNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblCompany);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtInvoiceNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtVendor);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.txtReceiveNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblReceiveNo);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.lblReceiveDate);
            this.gBoxReceiveDocumentDetail.Controls.Add(this.dateTimePicker_ReceiveDate);
            this.gBoxReceiveDocumentDetail.Location = new System.Drawing.Point(12, 62);
            this.gBoxReceiveDocumentDetail.Name = "gBoxReceiveDocumentDetail";
            this.gBoxReceiveDocumentDetail.Size = new System.Drawing.Size(1260, 150);
            this.gBoxReceiveDocumentDetail.TabIndex = 7;
            this.gBoxReceiveDocumentDetail.TabStop = false;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Teal;
            this.lblInvoiceNo.Location = new System.Drawing.Point(386, 16);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(111, 24);
            this.lblInvoiceNo.TabIndex = 12;
            this.lblInvoiceNo.Text = "เลขที่ใบส่งของ";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCompany.ForeColor = System.Drawing.Color.Teal;
            this.lblCompany.Location = new System.Drawing.Point(6, 78);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(120, 24);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "บริษัท / ห้างร้าน";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtInvoiceNo.Location = new System.Drawing.Point(390, 43);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(184, 32);
            this.txtInvoiceNo.TabIndex = 13;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVendor
            // 
            this.txtVendor.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVendor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtVendor.Location = new System.Drawing.Point(10, 105);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(564, 32);
            this.txtVendor.TabIndex = 15;
            this.txtVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendor.TextChanged += new System.EventHandler(this.txtVendor_TextChanged);
            // 
            // txtReceiveNo
            // 
            this.txtReceiveNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtReceiveNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReceiveNo.Location = new System.Drawing.Point(10, 43);
            this.txtReceiveNo.Name = "txtReceiveNo";
            this.txtReceiveNo.Size = new System.Drawing.Size(184, 32);
            this.txtReceiveNo.TabIndex = 9;
            this.txtReceiveNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceiveNo.TextChanged += new System.EventHandler(this.txtReceiveNo_TextChanged);
            // 
            // lblReceiveNo
            // 
            this.lblReceiveNo.AutoSize = true;
            this.lblReceiveNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblReceiveNo.ForeColor = System.Drawing.Color.Teal;
            this.lblReceiveNo.Location = new System.Drawing.Point(6, 16);
            this.lblReceiveNo.Name = "lblReceiveNo";
            this.lblReceiveNo.Size = new System.Drawing.Size(64, 24);
            this.lblReceiveNo.TabIndex = 8;
            this.lblReceiveNo.Text = "เลขที่รับ";
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblReceiveDate.ForeColor = System.Drawing.Color.Teal;
            this.lblReceiveDate.Location = new System.Drawing.Point(196, 16);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(58, 24);
            this.lblReceiveDate.TabIndex = 10;
            this.lblReceiveDate.Text = "วันที่รับ";
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.AutoSize = true;
            this.lblPriceTotal.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPriceTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblPriceTotal.Location = new System.Drawing.Point(995, 16);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(70, 24);
            this.lblPriceTotal.TabIndex = 27;
            this.lblPriceTotal.Text = "ราคารวม";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalPrice.Location = new System.Drawing.Point(986, 43);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 32);
            this.txtTotalPrice.TabIndex = 28;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPricePerUnit.Location = new System.Drawing.Point(850, 43);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(130, 32);
            this.txtPricePerUnit.TabIndex = 26;
            this.txtPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPricePerUnit.TextChanged += new System.EventHandler(this.txtPricePerUnit_TextChanged);
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblPricePerUnit.Location = new System.Drawing.Point(856, 16);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(103, 24);
            this.lblPricePerUnit.TabIndex = 25;
            this.lblPricePerUnit.Text = "ราคาต่อหน่วย";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUnit.ForeColor = System.Drawing.Color.Teal;
            this.lblUnit.Location = new System.Drawing.Point(758, 16);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(70, 24);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "หน่วยนับ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Teal;
            this.lblQuantity.Location = new System.Drawing.Point(656, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(96, 24);
            this.lblQuantity.TabIndex = 21;
            this.lblQuantity.Text = "จำนวนรับเข้า";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtQuantity.Location = new System.Drawing.Point(660, 43);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(89, 32);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblFormMrName
            // 
            this.lblFormMrName.AutoSize = true;
            this.lblFormMrName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFormMrName.ForeColor = System.Drawing.Color.Teal;
            this.lblFormMrName.Location = new System.Drawing.Point(6, 16);
            this.lblFormMrName.Name = "lblFormMrName";
            this.lblFormMrName.Size = new System.Drawing.Size(82, 24);
            this.lblFormMrName.TabIndex = 17;
            this.lblFormMrName.Text = "แบบฟอร์ม";
            // 
            // txtFormMrName
            // 
            this.txtFormMrName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFormMrName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFormMrName.Location = new System.Drawing.Point(10, 43);
            this.txtFormMrName.Name = "txtFormMrName";
            this.txtFormMrName.Size = new System.Drawing.Size(564, 32);
            this.txtFormMrName.TabIndex = 18;
            this.txtFormMrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerCurentDateTime
            // 
            this.timerCurentDateTime.Enabled = true;
            this.timerCurentDateTime.Tick += new System.EventHandler(this.timerCurentDateTime_Tick);
            // 
            // dataGridReceive
            // 
            this.dataGridReceive.AllowUserToAddRows = false;
            this.dataGridReceive.AllowUserToDeleteRows = false;
            this.dataGridReceive.AllowUserToResizeColumns = false;
            this.dataGridReceive.AllowUserToResizeRows = false;
            this.dataGridReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceive.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridReceive.Location = new System.Drawing.Point(12, 459);
            this.dataGridReceive.MultiSelect = false;
            this.dataGridReceive.Name = "dataGridReceive";
            this.dataGridReceive.ReadOnly = true;
            this.dataGridReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReceive.Size = new System.Drawing.Size(1084, 234);
            this.dataGridReceive.TabIndex = 37;
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
            // gBoxSearchData
            // 
            this.gBoxSearchData.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxSearchData.Controls.Add(this.lblSearchDataByDate);
            this.gBoxSearchData.Controls.Add(this.dateTimePicker_SearchDataByDate);
            this.gBoxSearchData.Controls.Add(this.txtSearchDataByChar);
            this.gBoxSearchData.Controls.Add(this.lblSearchDataByChar);
            this.gBoxSearchData.Location = new System.Drawing.Point(12, 370);
            this.gBoxSearchData.Name = "gBoxSearchData";
            this.gBoxSearchData.Size = new System.Drawing.Size(796, 83);
            this.gBoxSearchData.TabIndex = 30;
            this.gBoxSearchData.TabStop = false;
            // 
            // lblSearchDataByDate
            // 
            this.lblSearchDataByDate.AutoSize = true;
            this.lblSearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchDataByDate.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchDataByDate.Location = new System.Drawing.Point(6, 6);
            this.lblSearchDataByDate.Name = "lblSearchDataByDate";
            this.lblSearchDataByDate.Size = new System.Drawing.Size(145, 24);
            this.lblSearchDataByDate.TabIndex = 31;
            this.lblSearchDataByDate.Text = "ค้นหาข้อมูลตามวันที่";
            // 
            // dateTimePicker_SearchDataByDate
            // 
            this.dateTimePicker_SearchDataByDate.CalendarFont = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dateTimePicker_SearchDataByDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_SearchDataByDate.Location = new System.Drawing.Point(11, 34);
            this.dateTimePicker_SearchDataByDate.Name = "dateTimePicker_SearchDataByDate";
            this.dateTimePicker_SearchDataByDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePicker_SearchDataByDate.TabIndex = 32;
            // 
            // txtSearchDataByChar
            // 
            this.txtSearchDataByChar.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearchDataByChar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearchDataByChar.Location = new System.Drawing.Point(201, 33);
            this.txtSearchDataByChar.Name = "txtSearchDataByChar";
            this.txtSearchDataByChar.Size = new System.Drawing.Size(374, 32);
            this.txtSearchDataByChar.TabIndex = 34;
            this.txtSearchDataByChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearchDataByChar
            // 
            this.lblSearchDataByChar.AutoSize = true;
            this.lblSearchDataByChar.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchDataByChar.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchDataByChar.Location = new System.Drawing.Point(196, 6);
            this.lblSearchDataByChar.Name = "lblSearchDataByChar";
            this.lblSearchDataByChar.Size = new System.Drawing.Size(134, 24);
            this.lblSearchDataByChar.TabIndex = 33;
            this.lblSearchDataByChar.Text = "ค้นหาข้อมูลตามคำ";
            // 
            // gBoxButton
            // 
            this.gBoxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxButton.Controls.Add(this.btnCancelEdit);
            this.gBoxButton.Controls.Add(this.btnExit);
            this.gBoxButton.Controls.Add(this.btnSave);
            this.gBoxButton.Controls.Add(this.btnEditUpdate);
            this.gBoxButton.Location = new System.Drawing.Point(1102, 459);
            this.gBoxButton.Name = "gBoxButton";
            this.gBoxButton.Size = new System.Drawing.Size(170, 290);
            this.gBoxButton.TabIndex = 41;
            this.gBoxButton.TabStop = false;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelEdit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(10, 47);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(150, 32);
            this.btnCancelEdit.TabIndex = 43;
            this.btnCancelEdit.Text = "ยกเลิกแก้ไข";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 32);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnEditUpdate.TabIndex = 42;
            this.btnEditUpdate.Text = "บันทึกแก้ไขข้อมูล";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // gBoxReceiveFromMrDetail
            // 
            this.gBoxReceiveFromMrDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblLotNo);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtLotNo);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.cboxUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.btnAddToList);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblFormMrName);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtQuantity);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblQuantity);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtPricePerUnit);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.txtTotalPrice);
            this.gBoxReceiveFromMrDetail.Controls.Add(this.lblPriceTotal);
            this.gBoxReceiveFromMrDetail.Location = new System.Drawing.Point(12, 218);
            this.gBoxReceiveFromMrDetail.Name = "gBoxReceiveFromMrDetail";
            this.gBoxReceiveFromMrDetail.Size = new System.Drawing.Size(1260, 146);
            this.gBoxReceiveFromMrDetail.TabIndex = 16;
            this.gBoxReceiveFromMrDetail.TabStop = false;
            // 
            // lblLotNo
            // 
            this.lblLotNo.AutoSize = true;
            this.lblLotNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLotNo.ForeColor = System.Drawing.Color.Teal;
            this.lblLotNo.Location = new System.Drawing.Point(7, 78);
            this.lblLotNo.Name = "lblLotNo";
            this.lblLotNo.Size = new System.Drawing.Size(70, 24);
            this.lblLotNo.TabIndex = 19;
            this.lblLotNo.Text = "LOT NO.";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLotNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtLotNo.Location = new System.Drawing.Point(10, 108);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(130, 32);
            this.txtLotNo.TabIndex = 20;
            this.txtLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxUnit
            // 
            this.cboxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.ItemHeight = 24;
            this.cboxUnit.Items.AddRange(new object[] {
            "ใบ",
            "แผ่น",
            "ซอง",
            "เล่ม",
            "ม้วน",
            "กล่อง"});
            this.cboxUnit.Location = new System.Drawing.Point(755, 43);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(91, 32);
            this.cboxUnit.TabIndex = 24;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.Teal;
            this.btnAddToList.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.Location = new System.Drawing.Point(1142, 42);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(82, 32);
            this.btnAddToList.TabIndex = 29;
            this.btnAddToList.Text = "รับเข้า";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtGrandTotalPrice
            // 
            this.txtGrandTotalPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtGrandTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtGrandTotalPrice.Location = new System.Drawing.Point(16, 36);
            this.txtGrandTotalPrice.Name = "txtGrandTotalPrice";
            this.txtGrandTotalPrice.Size = new System.Drawing.Size(266, 32);
            this.txtGrandTotalPrice.TabIndex = 36;
            this.txtGrandTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotlaPrice
            // 
            this.lblTotlaPrice.AutoSize = true;
            this.lblTotlaPrice.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotlaPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblTotlaPrice.Location = new System.Drawing.Point(12, 9);
            this.lblTotlaPrice.Name = "lblTotlaPrice";
            this.lblTotlaPrice.Size = new System.Drawing.Size(113, 24);
            this.lblTotlaPrice.TabIndex = 39;
            this.lblTotlaPrice.Text = "ราคารับทั้งหมด";
            // 
            // gBoxTitleReceive
            // 
            this.gBoxTitleReceive.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxTitleReceive.Controls.Add(this.lblTitleReceive);
            this.gBoxTitleReceive.Location = new System.Drawing.Point(12, 12);
            this.gBoxTitleReceive.Name = "gBoxTitleReceive";
            this.gBoxTitleReceive.Size = new System.Drawing.Size(874, 44);
            this.gBoxTitleReceive.TabIndex = 0;
            this.gBoxTitleReceive.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.lblTotlaPrice);
            this.groupBox2.Controls.Add(this.txtGrandTotalPrice);
            this.groupBox2.Location = new System.Drawing.Point(814, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 83);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.lblRecorder);
            this.groupBox3.Controls.Add(this.txtRecorder);
            this.groupBox3.Location = new System.Drawing.Point(12, 699);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 50);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // lblRecorder
            // 
            this.lblRecorder.AutoSize = true;
            this.lblRecorder.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRecorder.ForeColor = System.Drawing.Color.Teal;
            this.lblRecorder.Location = new System.Drawing.Point(664, 20);
            this.lblRecorder.Name = "lblRecorder";
            this.lblRecorder.Size = new System.Drawing.Size(102, 24);
            this.lblRecorder.TabIndex = 39;
            this.lblRecorder.Text = "ผู้บันทึกข้อมูล";
            // 
            // txtRecorder
            // 
            this.txtRecorder.Enabled = false;
            this.txtRecorder.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRecorder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRecorder.Location = new System.Drawing.Point(772, 12);
            this.txtRecorder.Name = "txtRecorder";
            this.txtRecorder.Size = new System.Drawing.Size(306, 32);
            this.txtRecorder.TabIndex = 40;
            this.txtRecorder.Text = "ดึงชื่อจาก Login";
            this.txtRecorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmReceiveFormMr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxTitleReceive);
            this.Controls.Add(this.gBoxReceiveDocumentDetail);
            this.Controls.Add(this.gBoxReceiveFromMrDetail);
            this.Controls.Add(this.gBoxButton);
            this.Controls.Add(this.gBoxSearchData);
            this.Controls.Add(this.dataGridReceive);
            this.Controls.Add(this.gBoxCurrentDateTime);
            this.Name = "frmReceiveFormMr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รับเข้าคลัง";
            this.Load += new System.EventHandler(this.frmReceiveFormMr_Load);
            this.gBoxCurrentDateTime.ResumeLayout(false);
            this.gBoxCurrentDateTime.PerformLayout();
            this.gBoxReceiveDocumentDetail.ResumeLayout(false);
            this.gBoxReceiveDocumentDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceive)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gBoxSearchData.ResumeLayout(false);
            this.gBoxSearchData.PerformLayout();
            this.gBoxButton.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.ResumeLayout(false);
            this.gBoxReceiveFromMrDetail.PerformLayout();
            this.gBoxTitleReceive.ResumeLayout(false);
            this.gBoxTitleReceive.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleReceive;
        private System.Windows.Forms.GroupBox gBoxCurrentDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReceiveDate;
        private System.Windows.Forms.GroupBox gBoxReceiveDocumentDetail;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.Timer timerCurentDateTime;
        private System.Windows.Forms.Label lblReceiveNo;
        private System.Windows.Forms.Label lblFormMrName;
        private System.Windows.Forms.TextBox txtFormMrName;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dataGridReceive;
        private System.Windows.Forms.GroupBox gBoxSearchData;
        private System.Windows.Forms.TextBox txtSearchDataByChar;
        private System.Windows.Forms.Label lblSearchDataByChar;
        private System.Windows.Forms.GroupBox gBoxButton;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.GroupBox gBoxReceiveFromMrDetail;
        private System.Windows.Forms.TextBox txtGrandTotalPrice;
        private System.Windows.Forms.Label lblTotlaPrice;
        private System.Windows.Forms.GroupBox gBoxTitleReceive;
        private System.Windows.Forms.Label lblSearchDataByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchDataByDate;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRecorder;
        private System.Windows.Forms.TextBox txtRecorder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.Label lblLotNo;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}