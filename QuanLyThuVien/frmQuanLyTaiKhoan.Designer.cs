namespace QuanLyThuVien
{
    partial class frmQuanLyTaiKhoan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TENTAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHANQUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(813, 64);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENTAIKHOAN,
            this.MATKHAU,
            this.PHANQUYEN});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(13, 222);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(813, 359);
            this.dgvTaiKhoan.TabIndex = 26;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinhVuc_CellClick);
            // 
            // TENTAIKHOAN
            // 
            this.TENTAIKHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENTAIKHOAN.DataPropertyName = "TENTAIKHOAN";
            this.TENTAIKHOAN.HeaderText = "Tên tài khoản";
            this.TENTAIKHOAN.Name = "TENTAIKHOAN";
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.Name = "MATKHAU";
            // 
            // PHANQUYEN
            // 
            this.PHANQUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PHANQUYEN.DataPropertyName = "PHANQUYEN";
            this.PHANQUYEN.HeaderText = "Phân quyền";
            this.PHANQUYEN.Name = "PHANQUYEN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbPhanQuyen);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(13, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(813, 134);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(171, 33);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(343, 24);
            this.txtTenTaiKhoan.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(595, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tài khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(24, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phân quyền:";
            // 
            // cbPhanQuyen
            // 
            this.cbPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhanQuyen.Enabled = false;
            this.cbPhanQuyen.FormattingEnabled = true;
            this.cbPhanQuyen.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbPhanQuyen.Location = new System.Drawing.Point(171, 83);
            this.cbPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhanQuyen.Name = "cbPhanQuyen";
            this.cbPhanQuyen.Size = new System.Drawing.Size(343, 26);
            this.cbPhanQuyen.TabIndex = 22;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(595, 73);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(210, 44);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(838, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPhanQuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHANQUYEN;
    }
}