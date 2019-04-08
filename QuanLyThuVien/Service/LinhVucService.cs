using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.Service
{
    class LinhVucService
    {
        private ConnectService connectSer = new ConnectService();
        public LinhVucService()
        {
            connectSer.Connect();
        }

        public Object getModel(string maLV)
        {
            string sql = "select ID from tblLinhVuc where MALV='" + maLV + "'";
            return connectSer.getValueModel(sql);
        }

        public void getAll(DataGridView dgv)
        {
            string sql = "select MALV,TENLV,GHICHU from tblLinhVuc";
            connectSer.LoadDataDataGridView(dgv, sql);
        }

        public void createModel(tblLinhVucModel linhVuc)
        {
            string sql = "Insert Into tblLinhVuc(MALV,TENLV,GHICHU) values ('" + linhVuc.MaLinhVuc + "',N'" + linhVuc.TenLinhVuc + "',N'" + linhVuc.GhiChu + "')";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void updateModel(tblLinhVucModel linhVuc)
        {
            string sql = "Update tblLinhVuc set TENLV=N'" + linhVuc.TenLinhVuc + "',GHICHU=N'" + linhVuc.GhiChu + "' where MAlV='" + linhVuc.MaLinhVuc + "'";
            connectSer.ThucThiSQLTheoPhiKetNoi(sql);
        }

        public void deleteModel(string maLinhVuc)
        {
            string sql = "Delete from tblLinhVuc where MaLV='" + maLinhVuc + "'";
            connectSer.ThucThiSQLTheoKetNoi(sql);
        }
    }
}
