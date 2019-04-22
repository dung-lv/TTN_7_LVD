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
    public partial class frmTimKiemThongTinMuon : Form
    {
        private ConnectService connectSer = new ConnectService();
        public frmTimKiemThongTinMuon()
        {
            InitializeComponent();
            connectSer.Connect();
        }

        private ThongTinMuonService thongTinMuonSer = new ThongTinMuonService();
        private tblThongTinMuonModel muonMod = new tblThongTinMuonModel();


        private void frmTimKiemThongTinMuon_Load(object sender, EventArgs e)
        {
            thongTinMuonSer.getAll(dgvMuonSachCoBan);
        }

        private void btnTimCoBan_Click(object sender, EventArgs e)
        {
            thongTinMuonSer.searchModelBasic(cbLuaChon.Text, txtTuKhoa.Text, dgvMuonSachCoBan);
        }

        private void btnThoatCoBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
