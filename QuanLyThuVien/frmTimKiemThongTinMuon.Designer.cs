namespace QuanLyThuVien
{
    partial class frmTimKiemThongTinMuon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoatCoBan = new System.Windows.Forms.Button();
            this.btnTimCoBan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMuonSachCoBan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLuaChon = new System.Windows.Forms.ComboBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMuonSachNangCao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbNgayTra = new System.Windows.Forms.MaskedTextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.mtbNgayMuon = new System.Windows.Forms.MaskedTextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.btnThoatNangCao = new System.Windows.Forms.Button();
            this.btnTimNangCao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSachCoBan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSachNangCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 639);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1044, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm Kiếm Cơ bản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThoatCoBan);
            this.groupBox5.Controls.Add(this.btnTimCoBan);
            this.groupBox5.Location = new System.Drawing.Point(832, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(191, 126);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btnThoatCoBan
            // 
            this.btnThoatCoBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCoBan.Location = new System.Drawing.Point(37, 73);
            this.btnThoatCoBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatCoBan.Name = "btnThoatCoBan";
            this.btnThoatCoBan.Size = new System.Drawing.Size(100, 28);
            this.btnThoatCoBan.TabIndex = 5;
            this.btnThoatCoBan.Text = "Thoát";
            this.btnThoatCoBan.UseVisualStyleBackColor = true;
            this.btnThoatCoBan.Click += new System.EventHandler(this.btnThoatCoBan_Click);
            // 
            // btnTimCoBan
            // 
            this.btnTimCoBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCoBan.Location = new System.Drawing.Point(37, 20);
            this.btnTimCoBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimCoBan.Name = "btnTimCoBan";
            this.btnTimCoBan.Size = new System.Drawing.Size(100, 28);
            this.btnTimCoBan.TabIndex = 4;
            this.btnTimCoBan.Text = "Tìm";
            this.btnTimCoBan.UseVisualStyleBackColor = true;
            this.btnTimCoBan.Click += new System.EventHandler(this.btnTimCoBan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dgvMuonSachCoBan);
            this.groupBox4.Location = new System.Drawing.Point(8, 161);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1033, 503);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(328, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thông Tin Mượn Sách";
            // 
            // dgvMuonSachCoBan
            // 
            this.dgvMuonSachCoBan.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMuonSachCoBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonSachCoBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMuonSachCoBan.Location = new System.Drawing.Point(4, 106);
            this.dgvMuonSachCoBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMuonSachCoBan.Name = "dgvMuonSachCoBan";
            this.dgvMuonSachCoBan.Size = new System.Drawing.Size(1025, 393);
            this.dgvMuonSachCoBan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbLuaChon);
            this.groupBox3.Controls.Add(this.txtTuKhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(779, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // cbLuaChon
            // 
            this.cbLuaChon.FormattingEnabled = true;
            this.cbLuaChon.Items.AddRange(new object[] {
            "MADG",
            "HOTEN",
            "NGAYSINH",
            "GIOITINH",
            "LOP",
            "DIACHI"});
            this.cbLuaChon.Location = new System.Drawing.Point(220, 30);
            this.cbLuaChon.Margin = new System.Windows.Forms.Padding(4);
            this.cbLuaChon.Name = "cbLuaChon";
            this.cbLuaChon.Size = new System.Drawing.Size(380, 24);
            this.cbLuaChon.TabIndex = 1;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(220, 78);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(380, 22);
            this.txtTuKhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1044, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm Nâng Cao";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dgvMuonSachNangCao);
            this.groupBox2.Location = new System.Drawing.Point(4, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1031, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(357, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 35);
            this.label10.TabIndex = 1;
            this.label10.Text = "Thông Tin Mượn Sách";
            // 
            // dgvMuonSachNangCao
            // 
            this.dgvMuonSachNangCao.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMuonSachNangCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonSachNangCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMuonSachNangCao.Location = new System.Drawing.Point(4, 83);
            this.dgvMuonSachNangCao.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMuonSachNangCao.Name = "dgvMuonSachNangCao";
            this.dgvMuonSachNangCao.Size = new System.Drawing.Size(1023, 331);
            this.dgvMuonSachNangCao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbNgayTra);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.mtbNgayMuon);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.btnThoatNangCao);
            this.groupBox1.Controls.Add(this.btnTimNangCao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mtbNgayTra
            // 
            this.mtbNgayTra.Location = new System.Drawing.Point(549, 66);
            this.mtbNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgayTra.Mask = "00/00/0000";
            this.mtbNgayTra.Name = "mtbNgayTra";
            this.mtbNgayTra.Size = new System.Drawing.Size(261, 22);
            this.mtbNgayTra.TabIndex = 6;
            this.mtbNgayTra.ValidatingType = typeof(System.DateTime);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(120, 69);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(261, 22);
            this.txtMaSach.TabIndex = 4;
            // 
            // mtbNgayMuon
            // 
            this.mtbNgayMuon.Location = new System.Drawing.Point(549, 23);
            this.mtbNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgayMuon.Mask = "00/00/0000";
            this.mtbNgayMuon.Name = "mtbNgayMuon";
            this.mtbNgayMuon.Size = new System.Drawing.Size(261, 22);
            this.mtbNgayMuon.TabIndex = 5;
            this.mtbNgayMuon.ValidatingType = typeof(System.DateTime);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(120, 23);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(261, 22);
            this.txtMaDocGia.TabIndex = 3;
            // 
            // btnThoatNangCao
            // 
            this.btnThoatNangCao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatNangCao.Location = new System.Drawing.Point(710, 140);
            this.btnThoatNangCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatNangCao.Name = "btnThoatNangCao";
            this.btnThoatNangCao.Size = new System.Drawing.Size(100, 28);
            this.btnThoatNangCao.TabIndex = 6;
            this.btnThoatNangCao.Text = "Thoát";
            this.btnThoatNangCao.UseVisualStyleBackColor = true;
            this.btnThoatNangCao.Click += new System.EventHandler(this.btnThoatNangCao_Click);
            // 
            // btnTimNangCao
            // 
            this.btnTimNangCao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNangCao.Location = new System.Drawing.Point(281, 140);
            this.btnTimNangCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimNangCao.Name = "btnTimNangCao";
            this.btnTimNangCao.Size = new System.Drawing.Size(100, 28);
            this.btnTimNangCao.TabIndex = 5;
            this.btnTimNangCao.Text = "Tìm";
            this.btnTimNangCao.UseVisualStyleBackColor = true;
            this.btnTimNangCao.Click += new System.EventHandler(this.btnTimNangCao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Độc Giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Từ khóa:";
            // 
            // frmTimKiemThongTinMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTimKiemThongTinMuon";
            this.Text = "frmTimKiemTTMuon";
            this.Load += new System.EventHandler(this.frmTimKiemThongTinMuon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSachCoBan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSachNangCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoatCoBan;
        private System.Windows.Forms.Button btnTimCoBan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMuonSachCoBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbLuaChon;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMuonSachNangCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.MaskedTextBox mtbNgayMuon;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Button btnThoatNangCao;
        private System.Windows.Forms.Button btnTimNangCao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNgayTra;
        private System.Windows.Forms.Label label7;
    }
}