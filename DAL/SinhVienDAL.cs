using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SinhVienDAL:DatabaseService
    {
        public List<SinhVien> getAllSV()
        {
            SqlDataReader reader = ReadData("select * from SinhVien");
            List<SinhVien> dsSinhVien = new List<SinhVien>();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string tensv = reader.GetString(1);
                string malop = reader.GetString(2);
                SinhVien sv = new SinhVien();
                sv.MaSV = masv;
                sv.TenSV = tensv;
                sv.MaLop = malop;
                dsSinhVien.Add(sv);//ggg
            }
            reader.Close();
            return dsSinhVien;
        }
        public bool ThemMoiSinhVien(SinhVien sv)
        {
            string sql = "insert into SinhVien values(@masv, @tensv, @malop)";
            SqlParameter parMaSV = new SqlParameter("@masv", SqlDbType.NVarChar);
            parMaSV.Value = sv.MaSV;
            SqlParameter parTenSV = new SqlParameter("@tensv", SqlDbType.NVarChar);
            parTenSV.Value = sv.TenSV;
            SqlParameter parMaLop = new SqlParameter("@malop", SqlDbType.NVarChar);
            parMaLop.Value = sv.MaLop;

            bool kq = WriteData(sql, new[] { parMaSV, parTenSV, parMaLop });
            return true;
        }
    }
}
