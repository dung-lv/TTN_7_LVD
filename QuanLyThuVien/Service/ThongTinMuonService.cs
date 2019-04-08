using QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Service
{
    class ThongTinMuonService
    {
        private ConnectService connectSer = new ConnectService();
        public ThongTinMuonService()
        {
            connectSer.Connect();
        }

        public void getAll(DataGridView dgv)
        {
            string sql = "select MADG,MASACH,SOPHIEUMUON,NGAYMUON,NGAYTRA,GHICHU from tblThongTinMuon";
            connectSer.LoadDataDataGridView(dgv, sql);
        }

        public void createModel(tblThongTinMuonModel muon)
        {
            string sql = "Insert Into tblThongTinMuon(MADG,MASACH,SOPHIEUMUON,NGAYMUON,NGAYTRA,GHICHU) values ('" + muon.MaDocGia + "','" + muon.MaSach + "','" + muon.SoPhieuMuon + "','" + muon.NgayMuon + "','" + muon.NgayTra + "',N'" + muon.GhiChu + "')";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void updateModel(tblThongTinMuonModel muon)
        {
            string sql = "Update tblThongTinMuon set MASACH='" + muon.MaSach + "',SOPHIEUMUON='" + muon.SoPhieuMuon + "',NGAYMUON='" + muon.NgayMuon + "',NGAYTRA='" + muon.NgayTra + "',XACNHANTRA='" + muon.XacNhanTra + "',GHICHU=N'" + muon.GhiChu + "' where MADG='" + muon.MaDocGia + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void deleteModel(string maMuon)
        {
            string sql = "Delete from tblThongTinMuon where MADG='" + maMuon + "'";
            connectSer.ThucThiSQLTheoKetNoi(sql);
        }

        public void searchModelBasic(string luaChon, string tuKhoa, DataGridView data)
        {
            string sql = "select MADG,MASACH,SOPHIEUMUON,NGAYMUON,NGAYTRA,GHICHU from tblThongTinMuon where " + luaChon + " like'%" + tuKhoa + "%'";
            connectSer.LoadDataDataGridView(data, sql);
        }

        public void searchModelAdvanced(tblThongTinMuonModel muon, DataGridView data)
        {
            string sql = "select MADG,MASACH,SOPHIEUMUON,NGAYMUON,NGAYTRA,GHICHU from tblThongTinMuon where MADG like'%" + muon.MaDocGia + "%'or MASACH like'%" + muon.MaSach + "%'or NGAYMUON = '" + muon.NgayMuon + "'or NGAYTRA = '" + muon.NgayTra + "'";
            connectSer.LoadDataDataGridView(data, sql);
        }
    }
}
