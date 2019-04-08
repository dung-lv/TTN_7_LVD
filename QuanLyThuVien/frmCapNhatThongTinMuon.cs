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
    public partial class frmCapNhatThongTinMuon : Form
    {
        public frmCapNhatThongTinMuon()
        {
            InitializeComponent();
        }
        private ConnectService connectSer = new ConnectService();
        private ThongTinMuonService thongTinMuonSer = new ThongTinMuonService();
        private tblThongTinMuonModel muonMod = new tblThongTinMuonModel();
        private string action = "";

        private void capNhatThongTinMuon_Load(object sender, EventArgs e)
        {
            connectSer.Connect();
            thongTinMuonSer.getAll(dgvThongTinMuon);        
        }

        private void clearText()
        {
            txtMaDG.Text = "";
            txtMaSach.Text = "";
            txtSoPhieuMuon.Text = "";
            mktNgayMuon.Text = "";
            mktNgayTra.Text = "";
            rtbGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearText();
            txtMaDG.Enabled = true;
            txtMaSach.Enabled = true;
            txtSoPhieuMuon.Enabled = true;
            mktNgayMuon.Enabled = true;
            mktNgayTra.Enabled = true;
            rtbGhiChu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "add";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thongTinMuonSer.deleteModel(txtMaDG.Text);
                thongTinMuonSer.getAll(dgvThongTinMuon);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void dgvThongTinMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaSach.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoPhieuMuon.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[2].Value.ToString();
            mktNgayMuon.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[3].Value.ToString();
            mktNgayTra.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbXacNhan.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[5].Value.ToString();
            rtbGhiChu.Text = dgvThongTinMuon.Rows[e.RowIndex].Cells[6].Value.ToString();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            cbXacNhan.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtMaDG.Enabled = true;
            txtMaSach.Enabled = true;
            txtSoPhieuMuon.Enabled = true;
            mktNgayMuon.Enabled = true;
            mktNgayTra.Enabled = true;
            rtbGhiChu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "update";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            muonMod.MaDocGia = txtMaDG.Text;
            muonMod.MaSach = txtMaSach.Text;
            muonMod.SoPhieuMuon = Convert.ToInt32(txtSoPhieuMuon.Text);
            muonMod.NgayMuon = mktNgayMuon.Text;
            muonMod.NgayTra = mktNgayTra.Text;
            muonMod.XacNhanTra = cbXacNhan.Text;
            muonMod.GhiChu = rtbGhiChu.Text;
            if (action == "add")
            {
                thongTinMuonSer.createModel(muonMod);
                MessageBox.Show("Lưu thành công");
                thongTinMuonSer.getAll(dgvThongTinMuon);
                clearText();
                txtMaSach.Enabled = false;
                txtMaDG.Enabled = false;
                txtMaSach.Enabled = false;
                txtSoPhieuMuon.Enabled = false;
                mktNgayMuon.Enabled = false;
                mktNgayTra.Enabled = false;
                rtbGhiChu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                thongTinMuonSer.updateModel(muonMod);
                MessageBox.Show("Lưu thành công");
                thongTinMuonSer.getAll(dgvThongTinMuon);
                clearText();
                txtMaSach.Enabled = false;
                txtMaDG.Enabled = false;
                txtMaSach.Enabled = false;
                txtSoPhieuMuon.Enabled = false;
                mktNgayMuon.Enabled = false;
                mktNgayTra.Enabled = false;
                rtbGhiChu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cls.LoadData2Label(label9, "select count(*)from tblMuon where MASACH='" + comboBox1.Text + "'");
        //}
    }
}
