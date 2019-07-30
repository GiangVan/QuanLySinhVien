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
    }
}
