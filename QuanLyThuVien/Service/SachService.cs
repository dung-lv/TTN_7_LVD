using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using QuanLyThuVien.Model;
using System.Windows.Forms;

namespace QuanLyThuVien.Service
{
    class SachService
    {
        private ConnectService connectSer = new ConnectService();
        public SachService()
        {
            connectSer.Connect();
        }

        public Object getModel(string maSach)
        {
            string sql = "select ID from tblSach where MASACH='" + maSach + "'";
            return connectSer.getValueModel(sql);
        }

        public void getAll(DataGridView dgv)
        {
            string sql = "select MASACH,TENSACH,TACGIA,NHAXUATBAN,MALV,NAMXB,SOTRANG,SOLUONG,SOSACHHONG,NGAYNHAP,GHICHU from tblSach";
            connectSer.LoadDataDataGridView(dgv, sql);
        }

        public void createModel(tblSachModel sach)
        {
            string sql = "Insert Into tblSach(MASACH,TENSACH,TACGIA,NHAXUATBAN,MALV,NAMXB,SOTRANG,SOLUONG,SOSACHHONG,NGAYNHAP,GHICHU) values ('" + sach.MaSach + "',N'" + sach.TenSach + "',N'" + sach.TacGia + "',N'" + sach.NhaXuatBan + "','" + sach.MaLinhVuc + "','" + sach.NamXuatBan + "','" + sach.SoTrang + "','" + sach.SoLuong + "','" + sach.SoSachHong + "','" + sach.NgayNhap + "',N'" + sach.GhiChu + "')";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void updateModel(tblSachModel sach)
        {
            string sql = "Update tblSach set TENSACH=N'" + sach.TenSach + "',TACGIA=N'" + sach.TacGia + "',NHAXUATBAN=N'" + sach.NhaXuatBan + "',MALV='" + sach.MaLinhVuc + "',NAMXB='" + sach.NamXuatBan + "',SOTRANG='" + sach.SoTrang + "',SOLUONG='" + sach.SoLuong + "',SOSACHHONG='" + sach.SoSachHong + "',NGAYNHAP='" + sach.NgayNhap + "',GHICHU=N'" + sach.GhiChu + "' where MASACH='" + sach.MaSach + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void deleteModel(string maSach)
        {
            string sql = "Delete from tblSach where MASACH='" + maSach + "'";
            connectSer.ThucThiSQLTheoKetNoi(sql);
        }

        public void searchModelBasic(string luaChon, string tuKhoa, DataGridView data)
        {
            string sql = "select MASACH,TENSACH,TACGIA,NHAXUATBAN,MALV,NAMXB,SOTRANG,SOLUONG,SOSACHHONG,NGAYNHAP,GHICHU from tblSach where " + luaChon + " like N'%" + tuKhoa + "%'";
            connectSer.LoadDataDataGridView(data, sql);
        }
    }
}
