
namespace utpStore.ui
{
    partial class frmAddUser
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
            this.gBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.btnSearchCardId = new System.Windows.Forms.Button();
            this.btnSearchFirstName = new System.Windows.Forms.Button();
            this.maskTxtBoxCardId = new System.Windows.Forms.MaskedTextBox();
            this.lblCardId = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtWorkLevel = new System.Windows.Forms.TextBox();
            this.lblWorkLevel = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.photoUser = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.gBoxUserLogin = new System.Windows.Forms.GroupBox();
            this.btnCheckLoginDuplicate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUserPermission = new System.Windows.Forms.Label();
            this.gBoxButton = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.gBoxDateTime = new System.Windows.Forms.GroupBox();
            this.gBoxSearchUserData = new System.Windows.Forms.GroupBox();
            this.txtSearchUserData = new System.Windows.Forms.TextBox();
            this.lblSearchUserData = new System.Windows.Forms.Label();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.lblTitleAddUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblRecorder = new System.Windows.Forms.Label();
            this.txtRecorder = new System.Windows.Forms.TextBox();
            this.gBoxUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUser)).BeginInit();
            this.gBoxUserLogin.SuspendLayout();
            this.gBoxButton.SuspendLayout();
            this.gBoxDateTime.SuspendLayout();
            this.gBoxSearchUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxUserInfo
            // 
            this.gBoxUserInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxUserInfo.Controls.Add(this.btnSearchLastName);
            this.gBoxUserInfo.Controls.Add(this.btnSearchCardId);
            this.gBoxUserInfo.Controls.Add(this.btnSearchFirstName);
            this.gBoxUserInfo.Controls.Add(this.maskTxtBoxCardId);
            this.gBoxUserInfo.Controls.Add(this.lblCardId);
            this.gBoxUserInfo.Controls.Add(this.txtOrganization);
            this.gBoxUserInfo.Controls.Add(this.lblOrganization);
            this.gBoxUserInfo.Controls.Add(this.txtDepartment);
            this.gBoxUserInfo.Controls.Add(this.lblDepartment);
            this.gBoxUserInfo.Controls.Add(this.txtWorkLevel);
            this.gBoxUserInfo.Controls.Add(this.lblWorkLevel);
            this.gBoxUserInfo.Controls.Add(this.lblRole);
            this.gBoxUserInfo.Controls.Add(this.txtRole);
            this.gBoxUserInfo.Controls.Add(this.lblLastName);
            this.gBoxUserInfo.Controls.Add(this.lblFirstName);
            this.gBoxUserInfo.Controls.Add(this.lblTitle);
            this.gBoxUserInfo.Controls.Add(this.txtLastName);
            this.gBoxUserInfo.Controls.Add(this.txtFirstName);
            this.gBoxUserInfo.Controls.Add(this.txtTitle);
            this.gBoxUserInfo.Location = new System.Drawing.Point(12, 62);
            this.gBoxUserInfo.Name = "gBoxUserInfo";
            this.gBoxUserInfo.Size = new System.Drawing.Size(758, 274);
            this.gBoxUserInfo.TabIndex = 6;
            this.gBoxUserInfo.TabStop = false;
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchLastName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLastName.ForeColor = System.Drawing.Color.White;
            this.btnSearchLastName.Location = new System.Drawing.Point(216, 167);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(67, 32);
            this.btnSearchLastName.TabIndex = 14;
            this.btnSearchLastName.Text = "ค้นหา";
            this.btnSearchLastName.UseVisualStyleBackColor = false;
            // 
            // btnSearchCardId
            // 
            this.btnSearchCardId.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchCardId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCardId.ForeColor = System.Drawing.Color.White;
            this.btnSearchCardId.Location = new System.Drawing.Point(216, 229);
            this.btnSearchCardId.Name = "btnSearchCardId";
            this.btnSearchCardId.Size = new System.Drawing.Size(67, 32);
            this.btnSearchCardId.TabIndex = 17;
            this.btnSearchCardId.Text = "ค้นหา";
            this.btnSearchCardId.UseVisualStyleBackColor = false;
            // 
            // btnSearchFirstName
            // 
            this.btnSearchFirstName.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFirstName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFirstName.ForeColor = System.Drawing.Color.White;
            this.btnSearchFirstName.Location = new System.Drawing.Point(216, 105);
            this.btnSearchFirstName.Name = "btnSearchFirstName";
            this.btnSearchFirstName.Size = new System.Drawing.Size(67, 32);
            this.btnSearchFirstName.TabIndex = 11;
            this.btnSearchFirstName.Text = "ค้นหา";
            this.btnSearchFirstName.UseVisualStyleBackColor = false;
            // 
            // maskTxtBoxCardId
            // 
            this.maskTxtBoxCardId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.maskTxtBoxCardId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.maskTxtBoxCardId.Location = new System.Drawing.Point(10, 229);
            this.maskTxtBoxCardId.Mask = "0-0000-00000-00-0";
            this.maskTxtBoxCardId.Name = "maskTxtBoxCardId";
            this.maskTxtBoxCardId.Size = new System.Drawing.Size(200, 32);
            this.maskTxtBoxCardId.TabIndex = 16;
            this.maskTxtBoxCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCardId
            // 
            this.lblCardId.AutoSize = true;
            this.lblCardId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCardId.ForeColor = System.Drawing.Color.Teal;
            this.lblCardId.Location = new System.Drawing.Point(6, 202);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(164, 24);
            this.lblCardId.TabIndex = 15;
            this.lblCardId.Text = "หมายเลขบัตรประชาชน";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtOrganization.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtOrganization.Location = new System.Drawing.Point(289, 229);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(450, 32);
            this.txtOrganization.TabIndex = 25;
            this.txtOrganization.Text = "Auto Complete Filter";
            this.txtOrganization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblOrganization.ForeColor = System.Drawing.Color.Teal;
            this.lblOrganization.Location = new System.Drawing.Point(285, 202);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(51, 24);
            this.lblOrganization.TabIndex = 24;
            this.lblOrganization.Text = "สังกัด";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDepartment.Location = new System.Drawing.Point(289, 167);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(450, 32);
            this.txtDepartment.TabIndex = 23;
            this.txtDepartment.Text = "Auto Complete Filter";
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Teal;
            this.lblDepartment.Location = new System.Drawing.Point(285, 140);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(135, 24);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "หน่วยงาน / แผนก";
            // 
            // txtWorkLevel
            // 
            this.txtWorkLevel.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWorkLevel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtWorkLevel.Location = new System.Drawing.Point(289, 105);
            this.txtWorkLevel.Name = "txtWorkLevel";
            this.txtWorkLevel.Size = new System.Drawing.Size(450, 32);
            this.txtWorkLevel.TabIndex = 21;
            this.txtWorkLevel.Text = "Auto Complete Filter";
            this.txtWorkLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWorkLevel
            // 
            this.lblWorkLevel.AutoSize = true;
            this.lblWorkLevel.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblWorkLevel.ForeColor = System.Drawing.Color.Teal;
            this.lblWorkLevel.Location = new System.Drawing.Point(285, 78);
            this.lblWorkLevel.Name = "lblWorkLevel";
            this.lblWorkLevel.Size = new System.Drawing.Size(142, 24);
            this.lblWorkLevel.TabIndex = 20;
            this.lblWorkLevel.Text = "ระดับการปฏิบัติงาน";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRole.ForeColor = System.Drawing.Color.Teal;
            this.lblRole.Location = new System.Drawing.Point(285, 16);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(68, 24);
            this.lblRole.TabIndex = 18;
            this.lblRole.Text = "ตำแหน่ง";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRole.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRole.Location = new System.Drawing.Point(289, 43);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(450, 32);
            this.txtRole.TabIndex = 19;
            this.txtRole.Text = "Auto Complete Filter";
            this.txtRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLastName.ForeColor = System.Drawing.Color.Teal;
            this.lblLastName.Location = new System.Drawing.Point(6, 140);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(40, 24);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "สกุล";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Teal;
            this.lblFirstName.Location = new System.Drawing.Point(6, 78);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(30, 24);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "ชื่อ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "คำนำหน้าชื่อ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLastName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtLastName.Location = new System.Drawing.Point(10, 167);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 32);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFirstName.Location = new System.Drawing.Point(10, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 32);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTitle.Location = new System.Drawing.Point(10, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 32);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "Auto Complete Filter";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSelectPhoto.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSelectPhoto.Location = new System.Drawing.Point(19, 228);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(156, 32);
            this.btnSelectPhoto.TabIndex = 26;
            this.btnSelectPhoto.Text = "เลือกรูปประจำตัว";
            this.btnSelectPhoto.UseVisualStyleBackColor = false;
            // 
            // photoUser
            // 
            this.photoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoUser.Location = new System.Drawing.Point(19, 16);
            this.photoUser.Name = "photoUser";
            this.photoUser.Size = new System.Drawing.Size(156, 180);
            this.photoUser.TabIndex = 21;
            this.photoUser.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtId.Location = new System.Drawing.Point(10, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 32);
            this.txtId.TabIndex = 29;
            this.txtId.Text = "Run Auto";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLoginName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtLoginName.Location = new System.Drawing.Point(11, 107);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(200, 32);
            this.txtLoginName.TabIndex = 31;
            this.txtLoginName.Text = "กด Check ตรวจสอบชื่อซ้ำ";
            this.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.Location = new System.Drawing.Point(11, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 32);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblId.ForeColor = System.Drawing.Color.Teal;
            this.lblId.Location = new System.Drawing.Point(6, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLoginName.ForeColor = System.Drawing.Color.Teal;
            this.lblLoginName.Location = new System.Drawing.Point(7, 80);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(107, 24);
            this.lblLoginName.TabIndex = 30;
            this.lblLoginName.Text = "LOGIN NAME";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(7, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 24);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblConfirmPassword.Location = new System.Drawing.Point(7, 202);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(172, 24);
            this.lblConfirmPassword.TabIndex = 35;
            this.lblConfirmPassword.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(11, 229);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 32);
            this.txtConfirmPassword.TabIndex = 36;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBoxUserLogin
            // 
            this.gBoxUserLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxUserLogin.Controls.Add(this.btnCheckLoginDuplicate);
            this.gBoxUserLogin.Controls.Add(this.txtId);
            this.gBoxUserLogin.Controls.Add(this.lblConfirmPassword);
            this.gBoxUserLogin.Controls.Add(this.lblPassword);
            this.gBoxUserLogin.Controls.Add(this.lblLoginName);
            this.gBoxUserLogin.Controls.Add(this.txtConfirmPassword);
            this.gBoxUserLogin.Controls.Add(this.txtPassword);
            this.gBoxUserLogin.Controls.Add(this.lblId);
            this.gBoxUserLogin.Controls.Add(this.txtLoginName);
            this.gBoxUserLogin.Location = new System.Drawing.Point(776, 62);
            this.gBoxUserLogin.Name = "gBoxUserLogin";
            this.gBoxUserLogin.Size = new System.Drawing.Size(297, 274);
            this.gBoxUserLogin.TabIndex = 27;
            this.gBoxUserLogin.TabStop = false;
            // 
            // btnCheckLoginDuplicate
            // 
            this.btnCheckLoginDuplicate.BackColor = System.Drawing.Color.Chocolate;
            this.btnCheckLoginDuplicate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLoginDuplicate.ForeColor = System.Drawing.Color.White;
            this.btnCheckLoginDuplicate.Location = new System.Drawing.Point(217, 107);
            this.btnCheckLoginDuplicate.Name = "btnCheckLoginDuplicate";
            this.btnCheckLoginDuplicate.Size = new System.Drawing.Size(67, 32);
            this.btnCheckLoginDuplicate.TabIndex = 32;
            this.btnCheckLoginDuplicate.Text = "CHECK";
            this.btnCheckLoginDuplicate.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 35);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "Auto Complete";
            // 
            // lblUserPermission
            // 
            this.lblUserPermission.AutoSize = true;
            this.lblUserPermission.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUserPermission.ForeColor = System.Drawing.Color.Teal;
            this.lblUserPermission.Location = new System.Drawing.Point(7, 8);
            this.lblUserPermission.Name = "lblUserPermission";
            this.lblUserPermission.Size = new System.Drawing.Size(106, 24);
            this.lblUserPermission.TabIndex = 37;
            this.lblUserPermission.Text = "สิทธิ์การใช้งาน";
            // 
            // gBoxButton
            // 
            this.gBoxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxButton.Controls.Add(this.btnDelete);
            this.gBoxButton.Controls.Add(this.btnExit);
            this.gBoxButton.Controls.Add(this.btnSave);
            this.gBoxButton.Controls.Add(this.btnEdit);
            this.gBoxButton.Location = new System.Drawing.Point(1079, 424);
            this.gBoxButton.Name = "gBoxButton";
            this.gBoxButton.Size = new System.Drawing.Size(193, 325);
            this.gBoxButton.TabIndex = 45;
            this.gBoxButton.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(19, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 32);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "ลบข้อมูล";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(19, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 32);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "ปิดหน้านี้";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(19, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 32);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(19, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 32);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "แก้ไขข้อมูล";
            this.btnEdit.UseVisualStyleBackColor = false;
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
            this.lblCurrentDate.TabIndex = 3;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(8, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "วันที่";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(214, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 24);
            this.lblTime.TabIndex = 4;
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
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // gBoxDateTime
            // 
            this.gBoxDateTime.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxDateTime.Controls.Add(this.lblDate);
            this.gBoxDateTime.Controls.Add(this.lblCurrentDate);
            this.gBoxDateTime.Controls.Add(this.lblTime);
            this.gBoxDateTime.Controls.Add(this.lblCurrentTime);
            this.gBoxDateTime.Location = new System.Drawing.Point(892, 12);
            this.gBoxDateTime.Name = "gBoxDateTime";
            this.gBoxDateTime.Size = new System.Drawing.Size(380, 44);
            this.gBoxDateTime.TabIndex = 1;
            this.gBoxDateTime.TabStop = false;
            // 
            // gBoxSearchUserData
            // 
            this.gBoxSearchUserData.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxSearchUserData.Controls.Add(this.txtSearchUserData);
            this.gBoxSearchUserData.Controls.Add(this.lblSearchUserData);
            this.gBoxSearchUserData.Location = new System.Drawing.Point(12, 342);
            this.gBoxSearchUserData.Name = "gBoxSearchUserData";
            this.gBoxSearchUserData.Size = new System.Drawing.Size(758, 76);
            this.gBoxSearchUserData.TabIndex = 41;
            this.gBoxSearchUserData.TabStop = false;
            // 
            // txtSearchUserData
            // 
            this.txtSearchUserData.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearchUserData.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearchUserData.Location = new System.Drawing.Point(10, 35);
            this.txtSearchUserData.Name = "txtSearchUserData";
            this.txtSearchUserData.Size = new System.Drawing.Size(729, 32);
            this.txtSearchUserData.TabIndex = 43;
            this.txtSearchUserData.Text = "Search All Character In Table";
            this.txtSearchUserData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearchUserData
            // 
            this.lblSearchUserData.AutoSize = true;
            this.lblSearchUserData.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearchUserData.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchUserData.Location = new System.Drawing.Point(6, 8);
            this.lblSearchUserData.Name = "lblSearchUserData";
            this.lblSearchUserData.Size = new System.Drawing.Size(88, 24);
            this.lblSearchUserData.TabIndex = 42;
            this.lblSearchUserData.Text = "ค้นหาข้อมูล";
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(12, 424);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(1061, 269);
            this.dataGridUser.TabIndex = 44;
            // 
            // lblTitleAddUser
            // 
            this.lblTitleAddUser.AutoSize = true;
            this.lblTitleAddUser.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitleAddUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleAddUser.Location = new System.Drawing.Point(500, 4);
            this.lblTitleAddUser.Name = "lblTitleAddUser";
            this.lblTitleAddUser.Size = new System.Drawing.Size(131, 32);
            this.lblTitleAddUser.TabIndex = 1;
            this.lblTitleAddUser.Text = "ผู้ใช้งานระบบ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.lblTitleAddUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.photoUser);
            this.groupBox2.Controls.Add(this.btnSelectPhoto);
            this.groupBox2.Location = new System.Drawing.Point(1079, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.lblUserPermission);
            this.groupBox3.Location = new System.Drawing.Point(776, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(1079, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 76);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 35);
            this.comboBox2.MaxDropDownItems = 2;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 32);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.Text = "Auto Complete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "สถานะ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.lblRecorder);
            this.groupBox5.Controls.Add(this.txtRecorder);
            this.groupBox5.Location = new System.Drawing.Point(12, 699);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1061, 50);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            // 
            // lblRecorder
            // 
            this.lblRecorder.AutoSize = true;
            this.lblRecorder.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRecorder.ForeColor = System.Drawing.Color.Teal;
            this.lblRecorder.Location = new System.Drawing.Point(641, 14);
            this.lblRecorder.Name = "lblRecorder";
            this.lblRecorder.Size = new System.Drawing.Size(102, 24);
            this.lblRecorder.TabIndex = 39;
            this.lblRecorder.Text = "ผู้บันทึกข้อมูล";
            // 
            // txtRecorder
            // 
            this.txtRecorder.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRecorder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRecorder.Location = new System.Drawing.Point(749, 10);
            this.txtRecorder.Name = "txtRecorder";
            this.txtRecorder.Size = new System.Drawing.Size(306, 32);
            this.txtRecorder.TabIndex = 40;
            this.txtRecorder.Text = "ดึงชื่อจาก Login";
            this.txtRecorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridUser);
            this.Controls.Add(this.gBoxSearchUserData);
            this.Controls.Add(this.gBoxDateTime);
            this.Controls.Add(this.gBoxButton);
            this.Controls.Add(this.gBoxUserLogin);
            this.Controls.Add(this.gBoxUserInfo);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD : USER";
            this.gBoxUserInfo.ResumeLayout(false);
            this.gBoxUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUser)).EndInit();
            this.gBoxUserLogin.ResumeLayout(false);
            this.gBoxUserLogin.PerformLayout();
            this.gBoxButton.ResumeLayout(false);
            this.gBoxDateTime.ResumeLayout(false);
            this.gBoxDateTime.PerformLayout();
            this.gBoxSearchUserData.ResumeLayout(false);
            this.gBoxSearchUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxUserInfo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtWorkLevel;
        private System.Windows.Forms.Label lblWorkLevel;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox photoUser;
        private System.Windows.Forms.GroupBox gBoxUserLogin;
        private System.Windows.Forms.Label lblCardId;
        private System.Windows.Forms.GroupBox gBoxButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.MaskedTextBox maskTxtBoxCardId;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.Button btnSearchCardId;
        private System.Windows.Forms.Button btnSearchFirstName;
        private System.Windows.Forms.Button btnCheckLoginDuplicate;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gBoxDateTime;
        private System.Windows.Forms.GroupBox gBoxSearchUserData;
        private System.Windows.Forms.TextBox txtSearchUserData;
        private System.Windows.Forms.Label lblSearchUserData;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.Label lblTitleAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUserPermission;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblRecorder;
        private System.Windows.Forms.TextBox txtRecorder;
    }
}