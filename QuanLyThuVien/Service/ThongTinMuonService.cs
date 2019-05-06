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
        private SachService sachSer = new SachService();

        public Object getModel(string maDG, string maSach)
        {
            string sql = "select * from tblThongTinMuon where MADG='" + maDG + "' and MASACH='" + maSach + "'";
            return connectSer.getValueModel(sql);
        }

        public ThongTinMuonService()
        {
            connectSer.Connect();
        }

        public void getAll(DataGridView dgv)
        {
            string sql = "select MADG,MASACH,SOLUONGMUON,NGAYMUON,NGAYTRA,XACNHANTRA,GHICHU from tblThongTinMuon";
            connectSer.LoadDataDataGridView(dgv, sql);
        }

        public void createModel(tblThongTinMuonModel muon)
        {
            string sql = "Insert Into tblThongTinMuon(MADG,MASACH,SOLUONGMUON,NGAYMUON,NGAYTRA,XACNHANTRA,GHICHU) values ('" + muon.MaDocGia + "','" + muon.MaSach + "','" + muon.SoLuongMuon + "','" + muon.NgayMuon + "','" + muon.NgayTra + "', N'Chưa trả'" + ", N'" + muon.GhiChu + "')";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
            sachSer.updateModelByCondition(muon.MaSach, false);
        }

        public void updateModel(tblThongTinMuonModel muon)
        {
            string sql = "Update tblThongTinMuon set XACNHANTRA=N'" + muon.XacNhanTra + "',GHICHU=N'" + muon.GhiChu + "' where MADG='" + muon.MaDocGia + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
            if (muon.XacNhanTra.Equals("Đã trả"))
            {
                sachSer.updateModelByCondition(muon.MaSach, true);
            }
        }

        public void deleteModel(string maDG, string maSach, string soluongmuon)
        {
            string sqlDe = "Delete from tblThongTinMuon where MASACH='" + maSach + "' and MADG='" + maDG + "'";
            connectSer.ThucThiSQLTheoKetNoi(sqlDe);
            string sqlUp = "Update tblThongTinMuon set SOLUONGMUON='" + (Convert.ToInt32(soluongmuon)-1) + "' where MADG='" + maDG + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sqlUp);
            sachSer.updateModelByCondition(maSach, true);
        }

        public void searchModelBasic(string luaChon, string tuKhoa, DataGridView data)
        {
            string sql = "select MADG,MASACH,SOLUONGMUON,NGAYMUON,NGAYTRA,GHICHU from tblThongTinMuon where " + luaChon + " like N'%" + tuKhoa + "%'";
            connectSer.LoadDataDataGridView(data, sql);
        }
    }
}
