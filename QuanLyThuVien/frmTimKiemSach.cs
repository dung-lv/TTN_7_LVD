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
        }

        private void btnTimCoBan_Click(object sender, EventArgs e)
        {
            sachSer.searchModelBasic(cbLuaChon.Text, txtTuKhoa.Text, dgvSachCoBan);
        }

        private void btnThoatCoBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
