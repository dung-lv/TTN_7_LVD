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
    public partial class frmCapnhatDocGia : Form
    {
        public frmCapnhatDocGia()
        {
            InitializeComponent();
        }

        private ConnectService connectSer = new ConnectService();
        private DocGiaService docGiaSer = new DocGiaService();
        private tblDocGiaModel docGiaMod = new tblDocGiaModel();
        private string action = "";

        private void capNhatDocGia_Load(object sender, EventArgs e)
        {
            connectSer.Connect();
            docGiaSer.getAll(dgvDocGia);           
        }

        private void clearText()
        {
            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            mtbNgaySinh.Text = "";
            cbGioiTinh.Text = "";
            txtLop.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            rtbGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearText();
            txtMaDocGia.Enabled = true;
            txtHoTen.Enabled = true;
            mtbNgaySinh.Enabled = true;
            cbGioiTinh.Enabled = true;
            txtLop.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
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
                try
                {
                    docGiaSer.deleteModel(txtMaDocGia.Text);
                    docGiaSer.getAll(dgvDocGia);
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Phải xóa những thông tin liên quan đến độc giả này trước");
                };
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtbNgaySinh.Text = dgvDocGia.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbGioiTinh.Text = dgvDocGia.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLop.Text = dgvDocGia.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvDocGia.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvDocGia.Rows[e.RowIndex].Cells[6].Value.ToString();
            rtbGhiChu.Text = dgvDocGia.Rows[e.RowIndex].Cells[7].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = true;
            txtHoTen.Enabled = true;
            mtbNgaySinh.Enabled = true;
            cbGioiTinh.Enabled = true;
            txtLop.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            rtbGhiChu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "update";              
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            docGiaMod.MaDocGia = txtMaDocGia.Text;
            docGiaMod.HoTen = txtHoTen.Text;
            docGiaMod.NgaySinh = mtbNgaySinh.Text;
            docGiaMod.GioiTinh = cbGioiTinh.Text;
            docGiaMod.Lop = txtLop.Text;
            docGiaMod.DiaChi = txtDiaChi.Text;
            docGiaMod.Email = txtEmail.Text;
            docGiaMod.GhiChu = rtbGhiChu.Text;
            if (action == "add")
            {
                Object obj = docGiaSer.getModel(txtMaDocGia.Text);
                if (obj != null)
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else
                {
                    docGiaSer.createModel(docGiaMod);
                    MessageBox.Show("Lưu thành công");
                    docGiaSer.getAll(dgvDocGia);
                    clearText();
                    txtMaDocGia.Enabled = false;
                    txtHoTen.Enabled = false;
                    mtbNgaySinh.Enabled = false;
                    cbGioiTinh.Enabled = false;
                    txtLop.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtEmail.Enabled = false;
                    rtbGhiChu.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                docGiaSer.updateModel(docGiaMod);
                MessageBox.Show("Lưu thành công");
                docGiaSer.getAll(dgvDocGia);
                clearText();
                txtMaDocGia.Enabled = false;
                txtHoTen.Enabled = false;
                mtbNgaySinh.Enabled = false;
                cbGioiTinh.Enabled = false;
                txtLop.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                rtbGhiChu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
        }
    }
}
