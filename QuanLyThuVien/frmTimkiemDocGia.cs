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

        private void frmTimkiemDocGia_Load(object sender, EventArgs e)
        {
            docGiaSer.getAll(dgvDocGiaCoBan);
        }

        private void btnThoatCoBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            docGiaSer.searchModelBasic(cbLuaChon.Text, txtTuKhoa.Text, dgvDocGiaCoBan);
        }
    }
}
