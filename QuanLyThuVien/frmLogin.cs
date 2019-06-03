using QuanLyThuVien.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private ConnectService connectSer = new ConnectService();
        private NhanVienService nhanVienSer = new NhanVienService();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                connectSer.Connect();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối");
            }
        }

        public static string tenTaiKhoan, matKhauCu;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            }
            else
            {
                object obj = nhanVienSer.logIn(txtTenTaiKhoan.Text, txtMatKhau.Text);
                if (obj == null)
                {
                    MessageBox.Show("Sai tài khoản");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    tenTaiKhoan = txtTenTaiKhoan.Text;
                    matKhauCu = txtMatKhau.Text;
                    frmMain main = new frmMain();
                    main.ShowDialog();
                    txtTenTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                }
            }
        }

        private void frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
