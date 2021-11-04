
namespace utpStore.ui
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuReceive = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStockData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReceive,
            this.menuStockData,
            this.menuRequest,
            this.menuOrderApprove,
            this.menuReport,
            this.menuCloseProgram});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1284, 32);
            this.menuMain.TabIndex = 0;
            // 
            // menuReceive
            // 
            this.menuReceive.BackColor = System.Drawing.SystemColors.Control;
            this.menuReceive.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReceive.ForeColor = System.Drawing.Color.Teal;
            this.menuReceive.Name = "menuReceive";
            this.menuReceive.Size = new System.Drawing.Size(94, 28);
            this.menuReceive.Text = "รับเข้าคลัง";
            this.menuReceive.Click += new System.EventHandler(this.menuReceive_Click);
            // 
            // menuStockData
            // 
            this.menuStockData.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStockData.ForeColor = System.Drawing.Color.Teal;
            this.menuStockData.Name = "menuStockData";
            this.menuStockData.Size = new System.Drawing.Size(93, 28);
            this.menuStockData.Text = "ข้อมูลคลัง";
            this.menuStockData.Click += new System.EventHandler(this.menuStockData_Click);
            // 
            // menuRequest
            // 
            this.menuRequest.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRequest.ForeColor = System.Drawing.Color.Teal;
            this.menuRequest.Name = "menuRequest";
            this.menuRequest.Size = new System.Drawing.Size(68, 28);
            this.menuRequest.Text = "ขอเบิก";
            this.menuRequest.Click += new System.EventHandler(this.menuRequest_Click);
            // 
            // menuOrderApprove
            // 
            this.menuOrderApprove.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOrderApprove.ForeColor = System.Drawing.Color.Teal;
            this.menuOrderApprove.Name = "menuOrderApprove";
            this.menuOrderApprove.Size = new System.Drawing.Size(89, 28);
            this.menuOrderApprove.Text = "อนุมัติเบิก";
            this.menuOrderApprove.Click += new System.EventHandler(this.menuOrderApprove_Click);
            // 
            // menuReport
            // 
            this.menuReport.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReport.ForeColor = System.Drawing.Color.Teal;
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(74, 28);
            this.menuReport.Text = "รายงาน";
            // 
            // menuCloseProgram
            // 
            this.menuCloseProgram.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCloseProgram.ForeColor = System.Drawing.Color.Red;
            this.menuCloseProgram.Name = "menuCloseProgram";
            this.menuCloseProgram.Size = new System.Drawing.Size(141, 28);
            this.menuCloseProgram.Text = "ออกจากโปรแกรม";
            this.menuCloseProgram.Click += new System.EventHandler(this.menuCloseProgram_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1284, 759);
            this.panelMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 791);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบบริหารคลังพัสดุแบบฟอร์มเวชระเบียน (DEMO)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuReceive;
        private System.Windows.Forms.ToolStripMenuItem menuRequest;
        private System.Windows.Forms.ToolStripMenuItem menuOrderApprove;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.ToolStripMenuItem menuCloseProgram;
        private System.Windows.Forms.ToolStripMenuItem menuStockData;
    }
}