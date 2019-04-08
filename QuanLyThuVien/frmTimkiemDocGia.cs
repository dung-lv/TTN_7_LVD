using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.Service;
using QuanLyThuVien.Model;

namespace QuanLyThuVien
{
    public partial class frmTimkiemDocGia : Form
    {
        private ConnectService connectSer = new ConnectService();
        public frmTimkiemDocGia()
        {
            InitializeComponent();
            connectSer.Connect();
        }

        private DocGiaService docGiaSer = new DocGiaService();
        private tblDocGiaModel docGiaMod = new tblDocGiaModel();

        private void btnTimCoBan_Click(object sender, EventArgs e)
        {
            docGiaSer.searchModelBasic(cbLuaChon.Text, txtTuKhoa.Text, dgvDocGiaCoBan);
        }

        private void btnTimNangCao_Click(object sender, EventArgs e)
        {
            docGiaMod.MaDocGia = txtMaDocGia.Text;
            docGiaMod.HoTen = txtHoTen.Text;
            docGiaMod.NgaySinh = mtbNgaySinh.Text;
            docGiaMod.GioiTinh = tbGioiTinh.Text;
            docGiaMod.Lop = txtLop.Text;
            docGiaMod.DiaChi = txtDiaChi.Text;
            docGiaSer.searchModelAdvanced(docGiaMod, dgvDocGiaNangCao);
        }

        private void btnThoatNangCao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoatCoBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimkiemDocGia_Load(object sender, EventArgs e)
        {
            docGiaSer.getAll(dgvDocGiaCoBan);
            docGiaSer.getAll(dgvDocGiaNangCao);
        }
    }
}
