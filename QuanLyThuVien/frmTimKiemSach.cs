using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Service;
using QuanLyThuVien.Model;

namespace QuanLyThuVien
{
    public partial class frmTimKiemSach : Form
    {
        private ConnectService connectSer = new ConnectService();
        public frmTimKiemSach()
        {
            InitializeComponent();
            connectSer.Connect();
        }

        private SachService sachSer = new SachService();
        private tblSachModel sachMod = new tblSachModel();

        private void timKiem_Load(object sender, EventArgs e)
        {
            sachSer.getAll(dgvSachCoBan);
            sachSer.getAll(dgvSachNangCao);
        }

        private void btnTimCoBan_Click(object sender, EventArgs e)
        {
            sachSer.searchModelBasic(cbLuaChon.Text, txtTuKhoa.Text, dgvSachCoBan);
        }

        private void btnThoatCoBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimNangCao_Click(object sender, EventArgs e)
        {
            sachMod.MaSach = txtMaSach.Text;
            sachMod.TenSach = txtTenSach.Text;
            sachMod.TacGia = txtTacGia.Text;
            sachMod.NhaXuatBan = txtNXB.Text;
            sachMod.MaLinhVuc = txtMaLinhVuc.Text;
            sachMod.NamXuatBan = txtNamXuatBan.Text;
            sachMod.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            sachMod.NgayNhap = mtbNgayNhap.Text;
            sachSer.searchModelAdvanced(sachMod, dgvSachNangCao);
        }

        private void btnThoatNangCao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
