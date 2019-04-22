using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.Service
{
    class DocGiaService
    {
        private ConnectService connectSer = new ConnectService();
        public DocGiaService()
        {
            connectSer.Connect();
        }

        public Object getModel(string maDG)
        {
            string sql = "select ID from tblDocGia where MADG='" + maDG + "'";
            return connectSer.getValueModel(sql);
        }

        public void getAll(DataGridView dgv)
        {
            string sql = "Select MADG,HOTEN,NGAYSINH,GIOITINH,LOP,DIACHI,EMAIL,GHICHU from tblDocGia";
            connectSer.LoadDataDataGridView(dgv, sql);
        }

        public void createModel(tblDocGiaModel docGia)
        {
            string sql = "Insert Into tblDocGia(MADG,HOTEN,NGAYSINH,GIOITINH,LOP,DIACHI,EMAIL,GHICHU) values ('" + docGia.MaDocGia + "',N'" + docGia.HoTen + "','" + docGia.NgaySinh + "',N'" + docGia.GioiTinh + "','" + docGia.Lop + "',N'" + docGia.DiaChi + "','" + docGia.Email + "',N'" + docGia.GhiChu + "')";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void updateModel(tblDocGiaModel docGia)
        {
            string sql = "Update tblDocGia set HOTEN=N'" + docGia.HoTen + "',NGAYSINH='" + docGia.NgaySinh + "',GIOITINH=N'" + docGia.GioiTinh + "',LOP='" + docGia.Lop + "',DIACHI=N'" + docGia.DiaChi + "',EMAIL='" + docGia.Email + "',GHICHU=N'" + docGia.GhiChu + "' where MADG='" + docGia.MaDocGia + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void deleteModel(string maDocGia)
        {
            string sql = "Delete from tblDocGia where MADG='" + maDocGia + "'";
            connectSer.ThucThiSQLTheoKetNoi(sql);
        }

        public void searchModelBasic(string luaChon, string tuKhoa, DataGridView data)
        {
            string sql = "select MADG,HOTEN,NGAYSINH,GIOITINH,LOP,DIACHI,EMAIL,GHICHU from tblDocGia where " + luaChon + " like N'%" + tuKhoa + "%'";
            connectSer.LoadDataDataGridView(data, sql);
        }
    }
}
