﻿namespace QuanLyThuVien
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
            this.gbDangNhap = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyHeThongTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TaoTaiKhoanTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhapTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatSachTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatDocGiaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatLinhVucTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatThongTinMuonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemSachTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemDocGiaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTTMuonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbDangNhap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDangNhap
            // 
            this.gbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.gbDangNhap.Controls.Add(this.label6);
            this.gbDangNhap.Controls.Add(this.label5);
            this.gbDangNhap.Controls.Add(this.txtMatKhau);
            this.gbDangNhap.Controls.Add(this.txtTenTaiKhoan);
            this.gbDangNhap.Controls.Add(this.btnLogin);
            this.gbDangNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDangNhap.Location = new System.Drawing.Point(373, 103);
            this.gbDangNhap.Name = "gbDangNhap";
            this.gbDangNhap.Size = new System.Drawing.Size(266, 456);
            this.gbDangNhap.TabIndex = 1;
            this.gbDangNhap.TabStop = false;
            this.gbDangNhap.Text = "Đăng nhập vào hệ thống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mật khẩu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên đăng nhập :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(115, 140);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(131, 26);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(115, 91);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(131, 26);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(158, 185);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 27);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnDangNhap_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyHeThongTSMI
            // 
            this.QuanLyHeThongTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoTaiKhoanTSMI,
            this.DoiMatKhauTSMI,
            this.DangNhapTSMI});
            this.QuanLyHeThongTSMI.Enabled = false;
            this.QuanLyHeThongTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_01;
            this.QuanLyHeThongTSMI.Name = "QuanLyHeThongTSMI";
            this.QuanLyHeThongTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.QuanLyHeThongTSMI.Size = new System.Drawing.Size(162, 24);
            this.QuanLyHeThongTSMI.Text = "&Quản Lý Hệ Thống";
            // 
            // TaoTaiKhoanTSMI
            // 
            this.TaoTaiKhoanTSMI.Name = "TaoTaiKhoanTSMI";
            this.TaoTaiKhoanTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TaoTaiKhoanTSMI.Size = new System.Drawing.Size(229, 26);
            this.TaoTaiKhoanTSMI.Text = "Tạo Tài Khoản";
            this.TaoTaiKhoanTSMI.Click += new System.EventHandler(this.TaoTaiKhoanTSMI_Click);
            // 
            // DoiMatKhauTSMI
            // 
            this.DoiMatKhauTSMI.Name = "DoiMatKhauTSMI";
            this.DoiMatKhauTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.DoiMatKhauTSMI.Size = new System.Drawing.Size(229, 26);
            this.DoiMatKhauTSMI.Text = "Đổi Mật Khẩu";
            this.DoiMatKhauTSMI.Click += new System.EventHandler(this.DoiMatKhauTSMI_Click);
            // 
            // DangNhapTSMI
            // 
            this.DangNhapTSMI.Name = "DangNhapTSMI";
            this.DangNhapTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DangNhapTSMI.Size = new System.Drawing.Size(229, 26);
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
            this.CapNhatTSMI.Enabled = false;
            this.CapNhatTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_20;
            this.CapNhatTSMI.Name = "CapNhatTSMI";
            this.CapNhatTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.CapNhatTSMI.Size = new System.Drawing.Size(103, 24);
            this.CapNhatTSMI.Text = "Cập Nhật";
            // 
            // CapNhatSachTSMI
            // 
            this.CapNhatSachTSMI.Name = "CapNhatSachTSMI";
            this.CapNhatSachTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.CapNhatSachTSMI.Size = new System.Drawing.Size(239, 26);
            this.CapNhatSachTSMI.Text = "Sách";
            this.CapNhatSachTSMI.Click += new System.EventHandler(this.CapNhatSachTSMI_Click);
            // 
            // CapNhatDocGiaTSMI
            // 
            this.CapNhatDocGiaTSMI.Name = "CapNhatDocGiaTSMI";
            this.CapNhatDocGiaTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.CapNhatDocGiaTSMI.Size = new System.Drawing.Size(239, 26);
            this.CapNhatDocGiaTSMI.Text = "Độc Giả";
            this.CapNhatDocGiaTSMI.Click += new System.EventHandler(this.CapNhatDocGiaTSMI_Click);
            // 
            // CapNhatLinhVucTSMI
            // 
            this.CapNhatLinhVucTSMI.Name = "CapNhatLinhVucTSMI";
            this.CapNhatLinhVucTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.CapNhatLinhVucTSMI.Size = new System.Drawing.Size(239, 26);
            this.CapNhatLinhVucTSMI.Text = "Lĩnh Vực";
            this.CapNhatLinhVucTSMI.Click += new System.EventHandler(this.CapNhatLinhVucTSMI_Click);
            // 
            // CapNhatThongTinMuonTSMI
            // 
            this.CapNhatThongTinMuonTSMI.Name = "CapNhatThongTinMuonTSMI";
            this.CapNhatThongTinMuonTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.CapNhatThongTinMuonTSMI.Size = new System.Drawing.Size(239, 26);
            this.CapNhatThongTinMuonTSMI.Text = "Thông Tin Mượn";
            this.CapNhatThongTinMuonTSMI.Click += new System.EventHandler(this.CapNhatThongTinMuonTSMI_Click);
            // 
            // TimKiemTSMI
            // 
            this.TimKiemTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimKiemSachTSMI,
            this.TimKiemDocGiaTSMI,
            this.TimKiemTTMuonTSMI});
            this.TimKiemTSMI.Enabled = false;
            this.TimKiemTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_02;
            this.TimKiemTSMI.Name = "TimKiemTSMI";
            this.TimKiemTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TimKiemTSMI.Size = new System.Drawing.Size(104, 24);
            this.TimKiemTSMI.Text = "Tìm Kiếm";
            // 
            // TimKiemSachTSMI
            // 
            this.TimKiemSachTSMI.Name = "TimKiemSachTSMI";
            this.TimKiemSachTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TimKiemSachTSMI.Size = new System.Drawing.Size(243, 26);
            this.TimKiemSachTSMI.Text = "Sách";
            this.TimKiemSachTSMI.Click += new System.EventHandler(this.TimKiemSachTSMI_Click);
            // 
            // TimKiemDocGiaTSMI
            // 
            this.TimKiemDocGiaTSMI.Name = "TimKiemDocGiaTSMI";
            this.TimKiemDocGiaTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TimKiemDocGiaTSMI.Size = new System.Drawing.Size(243, 26);
            this.TimKiemDocGiaTSMI.Text = "Độc Giả";
            this.TimKiemDocGiaTSMI.Click += new System.EventHandler(this.TimKiemDocGiaTSMI_Click);
            // 
            // TimKiemTTMuonTSMI
            // 
            this.TimKiemTTMuonTSMI.Name = "TimKiemTTMuonTSMI";
            this.TimKiemTTMuonTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TimKiemTTMuonTSMI.Size = new System.Drawing.Size(243, 26);
            this.TimKiemTTMuonTSMI.Text = "Thông tin mượn";
            this.TimKiemTTMuonTSMI.Click += new System.EventHandler(this.TimKiemTTMuonTSMI_Click);
            // 
            // TroGiupTSMI
            // 
            this.TroGiupTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_50;
            this.TroGiupTSMI.Name = "TroGiupTSMI";
            this.TroGiupTSMI.Size = new System.Drawing.Size(97, 24);
            this.TroGiupTSMI.Text = "Trợ Giúp";
            this.TroGiupTSMI.Click += new System.EventHandler(this.TroGiupTSMI_Click);
            // 
            // ThoatTSMI
            // 
            this.ThoatTSMI.Image = global::QuanLyThuVien.Properties.Resources.onebit_35;
            this.ThoatTSMI.Name = "ThoatTSMI";
            this.ThoatTSMI.Size = new System.Drawing.Size(79, 24);
            this.ThoatTSMI.Text = "Thoát";
            this.ThoatTSMI.Click += new System.EventHandler(this.ThoatTSMI_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 456);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lê Văn Dũng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sinh viên thực hiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên hướng dẫn: ";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label0.Location = new System.Drawing.Point(318, 18);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(328, 46);
            this.label0.TabIndex = 4;
            this.label0.Text = " Quản Lý Thư Viện";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(645, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 456);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.vrtableserat;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 456);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label0);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDangNhap);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbDangNhap.ResumeLayout(false);
            this.gbDangNhap.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyHeThongTSMI;
        private System.Windows.Forms.ToolStripMenuItem TaoTaiKhoanTSMI;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem CapNhatLinhVucTSMI;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.ToolStripMenuItem DangNhapTSMI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem TimKiemDocGiaTSMI;
        private System.Windows.Forms.ToolStripMenuItem CapNhatThongTinMuonTSMI;
        private System.Windows.Forms.ToolStripMenuItem TimKiemSachTSMI;
        private System.Windows.Forms.ToolStripMenuItem TimKiemTTMuonTSMI;
    }
}

