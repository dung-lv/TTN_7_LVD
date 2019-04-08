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
    public partial class frmCapNhatSach : Form
    {
        public frmCapNhatSach()
        {
            InitializeComponent();
        }

        private ConnectService connectSer = new ConnectService();
        private SachService sachSer = new SachService();
        private tblSachModel sachMod = new tblSachModel();
        private string action = "";

        private void capNhatSach_Load(object sender, EventArgs e)
        {
            connectSer.Connect();
            sachSer.getAll(dgvSach);
            connectSer.LoadDataCombobox(cbMaLinhVuc, "select MALV from tblLinhVuc");
            connectSer.LoadDataCombobox(cbTenLinhVuc, "select TENLV from tblLinhVuc");
        }

        private void clearText()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNhaXuatBan.Text = "";
            cbMaLinhVuc.Text = "";
            txtNamXuatBan.Text = "";
            txtSoTrang.Text = "";
            txtSoLuong.Text = "";
            txtSoSachHong.Text = "";
            mtbNgayNhap.Text = "";
            rtbGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearText();
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNhaXuatBan.Enabled = true;
            cbMaLinhVuc.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtSoTrang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtSoSachHong.Enabled = true;
            mtbNgayNhap.Enabled = true;
            rtbGhiChu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "add";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNhaXuatBan.Enabled = true;
            cbMaLinhVuc.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtSoTrang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtSoSachHong.Enabled = true;
            mtbNgayNhap.Enabled = true;
            rtbGhiChu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "update";
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTacGia.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbMaLinhVuc.Text = dgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSoTrang.Text = dgvSach.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtSoSachHong.Text = dgvSach.Rows[e.RowIndex].Cells[8].Value.ToString();
            mtbNgayNhap.Text = dgvSach.Rows[e.RowIndex].Cells[9].Value.ToString();
            rtbGhiChu.Text = dgvSach.Rows[e.RowIndex].Cells[10].Value.ToString();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sachSer.deleteModel(txtMaSach.Text);
                sachSer.getAll(dgvSach);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void txtSoSachHong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cbTenLinhVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaLinhVuc.SelectedIndex = cbTenLinhVuc.SelectedIndex;
        }

        private void cbMaLinhVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenLinhVuc.SelectedIndex = cbMaLinhVuc.SelectedIndex;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sachMod.MaSach = txtMaSach.Text;
            sachMod.TenSach = txtTenSach.Text;
            sachMod.TacGia = txtTacGia.Text;
            sachMod.NhaXuatBan = txtNhaXuatBan.Text;
            sachMod.MaLinhVuc = cbMaLinhVuc.Text;
            sachMod.NamXuatBan = txtNamXuatBan.Text;
            sachMod.SoTrang = Convert.ToInt32(txtSoTrang.Text);
            sachMod.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            sachMod.SoSachHong = Convert.ToInt32(txtSoSachHong.Text);
            sachMod.NgayNhap = mtbNgayNhap.Text;
            sachMod.GhiChu = rtbGhiChu.Text;
            if (action == "add")
            {
                Object obj = sachSer.getModel(txtMaSach.Text);
                if (obj != null)
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else
                {
                    sachSer.createModel(sachMod);             
                    MessageBox.Show("Lưu thành công");
                    sachSer.getAll(dgvSach);
                    clearText();
                    txtMaSach.Enabled = false;
                    txtTenSach.Enabled = false;
                    txtTacGia.Enabled = false;
                    txtNhaXuatBan.Enabled = false;
                    cbMaLinhVuc.Enabled = false;
                    txtNamXuatBan.Enabled = false;
                    txtSoTrang.Enabled = false;
                    txtSoLuong.Enabled = false;
                    txtSoSachHong.Enabled = false;
                    mtbNgayNhap.Enabled = false;
                    rtbGhiChu.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                sachSer.updateModel(sachMod);
                MessageBox.Show("Lưu thành công");
                sachSer.getAll(dgvSach);
                clearText();
                txtMaSach.Enabled = false;
                txtTenSach.Enabled = false;
                txtTacGia.Enabled = false;
                txtNhaXuatBan.Enabled = false;
                cbMaLinhVuc.Enabled = false;
                txtNamXuatBan.Enabled = false;
                txtSoTrang.Enabled = false;
                txtSoLuong.Enabled = false;
                txtSoSachHong.Enabled = false;
                mtbNgayNhap.Enabled = false;
                rtbGhiChu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
        }
    }
}
