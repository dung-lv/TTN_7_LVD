namespace QuanLyThuVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyHeThongTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyTaiKhoanTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhapTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatSachTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatDocGiaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatLinhVucTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatThongTinMuonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyHeThongTSMI,
            this.CapNhatTSMI,
            this.TimKiemTSMI,
            this.TroGiupTSMI,
            this.ThoatTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyHeThongTSMI
            // 
            this.QuanLyHeThongTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyTaiKhoanTSMI,
            this.DoiMatKhauTSMI,
            this.DangNhapTSMI});
            this.QuanLyHeThongTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyHeThongTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_01;
            this.QuanLyHeThongTSMI.Name = "QuanLyHeThongTSMI";
            this.QuanLyHeThongTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.QuanLyHeThongTSMI.Size = new System.Drawing.Size(109, 24);
            this.QuanLyHeThongTSMI.Text = "Hệ Thống";
            // 
            // QuanLyTaiKhoanTSMI
            // 
            this.QuanLyTaiKhoanTSMI.Enabled = false;
            this.QuanLyTaiKhoanTSMI.Name = "QuanLyTaiKhoanTSMI";
            this.QuanLyTaiKhoanTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.QuanLyTaiKhoanTSMI.Size = new System.Drawing.Size(270, 26);
            this.QuanLyTaiKhoanTSMI.Text = "Quản Lý Tài Khoản";
            this.QuanLyTaiKhoanTSMI.Click += new System.EventHandler(this.TaoTaiKhoanTSMI_Click);
            // 
            // DoiMatKhauTSMI
            // 
            this.DoiMatKhauTSMI.Name = "DoiMatKhauTSMI";
            this.DoiMatKhauTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.DoiMatKhauTSMI.Size = new System.Drawing.Size(270, 26);
            this.DoiMatKhauTSMI.Text = "Đổi Mật Khẩu";
            this.DoiMatKhauTSMI.Click += new System.EventHandler(this.DoiMatKhauTSMI_Click);
            // 
            // DangNhapTSMI
            // 
            this.DangNhapTSMI.Name = "DangNhapTSMI";
            this.DangNhapTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DangNhapTSMI.Size = new System.Drawing.Size(270, 26);
            this.DangNhapTSMI.Text = "Đăng Nhập";
            this.DangNhapTSMI.Click += new System.EventHandler(this.DangNhapTSMI_Click);
            // 
            // CapNhatTSMI
            // 
            this.CapNhatTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapNhatSachTSMI,
            this.CapNhatDocGiaTSMI,
            this.CapNhatLinhVucTSMI,
            this.CapNhatThongTinMuonTSMI});
            this.CapNhatTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhatTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_20;
            this.CapNhatTSMI.Name = "CapNhatTSMI";
            this.CapNhatTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.CapNhatTSMI.Size = new System.Drawing.Size(98, 24);
            this.CapNhatTSMI.Text = "Quản Lý";
            // 
            // CapNhatSachTSMI
            // 
            this.CapNhatSachTSMI.Name = "CapNhatSachTSMI";
            this.CapNhatSachTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.CapNhatSachTSMI.Size = new System.Drawing.Size(251, 26);
            this.CapNhatSachTSMI.Text = "Sách";
            this.CapNhatSachTSMI.Click += new System.EventHandler(this.CapNhatSachTSMI_Click);
            // 
            // CapNhatDocGiaTSMI
            // 
            this.CapNhatDocGiaTSMI.Name = "CapNhatDocGiaTSMI";
            this.CapNhatDocGiaTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.CapNhatDocGiaTSMI.Size = new System.Drawing.Size(251, 26);
            this.CapNhatDocGiaTSMI.Text = "Độc Giả";
            this.CapNhatDocGiaTSMI.Click += new System.EventHandler(this.CapNhatDocGiaTSMI_Click);
            // 
            // CapNhatLinhVucTSMI
            // 
            this.CapNhatLinhVucTSMI.Name = "CapNhatLinhVucTSMI";
            this.CapNhatLinhVucTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.CapNhatLinhVucTSMI.Size = new System.Drawing.Size(251, 26);
            this.CapNhatLinhVucTSMI.Text = "Lĩnh Vực";
            this.CapNhatLinhVucTSMI.Click += new System.EventHandler(this.CapNhatLinhVucTSMI_Click);
            // 
            // CapNhatThongTinMuonTSMI
            // 
            this.CapNhatThongTinMuonTSMI.Name = "CapNhatThongTinMuonTSMI";
            this.CapNhatThongTinMuonTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.CapNhatThongTinMuonTSMI.Size = new System.Drawing.Size(251, 26);
            this.CapNhatThongTinMuonTSMI.Text = "Thông Tin Mượn";
            this.CapNhatThongTinMuonTSMI.Click += new System.EventHandler(this.CapNhatThongTinMuonTSMI_Click);
            // 
            // TimKiemTSMI
            // 
            this.TimKiemTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiemTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_02;
            this.TimKiemTSMI.Name = "TimKiemTSMI";
            this.TimKiemTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TimKiemTSMI.Size = new System.Drawing.Size(186, 24);
            this.TimKiemTSMI.Text = "Phiếu mượn quá hạn";
            this.TimKiemTSMI.Click += new System.EventHandler(this.TimKiemTSMI_Click);
            // 
            // TroGiupTSMI
            // 
            this.TroGiupTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroGiupTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_50;
            this.TroGiupTSMI.Name = "TroGiupTSMI";
            this.TroGiupTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.TroGiupTSMI.Size = new System.Drawing.Size(101, 24);
            this.TroGiupTSMI.Text = "Trợ Giúp";
            this.TroGiupTSMI.Click += new System.EventHandler(this.TroGiupTSMI_Click);
            // 
            // ThoatTSMI
            // 
            this.ThoatTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_35;
            this.ThoatTSMI.Name = "ThoatTSMI";
            this.ThoatTSMI.Size = new System.Drawing.Size(82, 24);
            this.ThoatTSMI.Text = "Thoát";
            this.ThoatTSMI.Click += new System.EventHandler(this.ThoatTSMI_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.DarkGreen;
            this.label0.Location = new System.Drawing.Point(369, 21);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(328, 46);
            this.label0.TabIndex = 4;
            this.label0.Text = " Quản Lý Thư Viện";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label0);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1074, 85);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.logo_main;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 505);
            this.panel1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1098, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyHeThongTSMI;
        private System.Windows.Forms.ToolStripMenuItem QuanLyTaiKhoanTSMI;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauTSMI;
        private System.Windows.Forms.ToolStripMenuItem CapNhatTSMI;
        private System.Windows.Forms.ToolStripMenuItem CapNhatSachTSMI;
        private System.Windows.Forms.ToolStripMenuItem CapNhatDocGiaTSMI;
        private System.Windows.Forms.ToolStripMenuItem TimKiemTSMI;
        private System.Windows.Forms.ToolStripMenuItem TroGiupTSMI;
        private System.Windows.Forms.ToolStripMenuItem ThoatTSMI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.ToolStripMenuItem CapNhatLinhVucTSMI;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.ToolStripMenuItem DangNhapTSMI;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem CapNhatThongTinMuonTSMI;
        private System.Windows.Forms.Panel panel1;
    }
}

