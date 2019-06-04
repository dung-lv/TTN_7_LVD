using QuanLyThuVien.Model;
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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private NhanVienService nhanvienSer = new NhanVienService();
        private tblNhanVienModel nhanvienMod = new tblNhanVienModel();

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            nhanvienSer.getAll(dgvTaiKhoan);
        }

        private void clearText()
        {
            txtTenTaiKhoan.Text = "";
            cbPhanQuyen.Text = "";
            cbPhanQuyen.Enabled = false;
            btnSave.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nhanvienMod.TaiKhoan = txtTenTaiKhoan.Text;
            nhanvienMod.PhanQuyen = cbPhanQuyen.Text;
            nhanvienSer.updateModel(nhanvienMod);

            MessageBox.Show("Lưu thành công");
            nhanvienSer.getAll(dgvTaiKhoan);
            clearText();
        }

        private void dgvLinhVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbPhanQuyen.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();

            cbPhanQuyen.Enabled = true;
            btnSave.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhanvienSer.deleteModel(txtTenTaiKhoan.Text);
                MessageBox.Show("Xóa thành công");
                clearText();
                nhanvienSer.getAll(dgvTaiKhoan);
            }
        }
    }
}
