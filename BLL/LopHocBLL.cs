using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LopHocBLL
    {
        public List<LopHoc>GetAlllop()
        {
            LopHocDAL dal = new LopHocDAL();
            return dal.getAlllop();
        }
      
        public bool ThemMoiLopHoc(LopHoc lop)
        {
            if (lop.MaLop.Length != 5) { return false; }

            if (lop.TenLop.Length < 10) { return false; }
            // gọi dal lưu moi
            LopHocDAL dal = new LopHocDAL();
            return dal.ThemMoiLopHoc(lop);
        }
        
    }
   
}
