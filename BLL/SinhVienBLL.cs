﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SinhVienBLL
    {
        public List<SinhVien> GetAllSV()
        {
            SinhVienDAL dal = new SinhVienDAL();
            return dal.getAllSV();
        }

        public bool ThemMoiSinhVien(SinhVien sv)
        {
           
            SinhVienDAL dal = new SinhVienDAL();
            return dal.ThemMoiSinhVien(sv);
        }
    }
}
