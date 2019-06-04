using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyThuVien.Service;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private ConnectService connectSer = new ConnectService();
        private NhanVienService nhanVienSer = new NhanVienService();

        private void ThoatTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TaoTaiKhoanTSMI_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQLTK = new frmQuanLyTaiKhoan();
            frmQLTK.Show();
        }

        private void DoiMatKhauTSMI_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.Show();
        }

        private void DangNhapTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatSachTSMI_Click(object sender, EventArgs e)
        {
            frmCapNhatSach frmCNS = new frmCapNhatSach();
            frmCNS.Show();
        }

        private void CapNhatDocGiaTSMI_Click(object sender, EventArgs e)
        {
            frmCapnhatDocGia frmCNDG = new frmCapnhatDocGia();
            frmCNDG.Show();

        }

        private void CapNhatLinhVucTSMI_Click(object sender, EventArgs e)
        {
            frmCapNhatLinhVuc frmCNLV = new frmCapNhatLinhVuc();
            frmCNLV.Show();
        }

        private void CapNhatThongTinMuonTSMI_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTinMuon frmCNTTM = new frmCapNhatThongTinMuon();
            frmCNTTM.Show();
        }


        private void TroGiupTSMI_Click(object sender, EventArgs e)
        {
            frmHelp frmH = new frmHelp();
            frmH.Show();
        }

        private void TimKiemTTMuonTSMI_Click(object sender, EventArgs e)
        {
            frmPhieuMuonQuaHan frmTKTTM = new frmPhieuMuonQuaHan();
            frmTKTTM.Show();
        }

        private void TimKiemTSMI_Click(object sender, EventArgs e)
        {
            frmPhieuMuonQuaHan frmPMQH = new frmPhieuMuonQuaHan();
            frmPMQH.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmLogin.phanQuyen.Equals("Quản lý"))
            {
                QuanLyTaiKhoanTSMI.Enabled = true;
            }
        }
    }
}
