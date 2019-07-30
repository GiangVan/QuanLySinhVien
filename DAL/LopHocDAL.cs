using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class LopHocDAL:DatabaseService
    {
        public List<LopHoc> getAlllop()
        {
            SqlDataReader reader = ReadData("select * from Lop");
            List<LopHoc> dsLop = new List<LopHoc>();
            while(reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                LopHoc lh = new LopHoc();
                lh.MaLop = ma;
                lh.TenLop = ten;
                dsLop.Add(lh);
            }
            reader.Close();
            return dsLop;
        }
        public bool ThemMoiLopHoc(LopHoc lop)
        {
            // tuong tac voi co so du lieu
        }
    }
}
