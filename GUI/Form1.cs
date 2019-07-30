using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTaiDanhSachLop_Click(object sender, EventArgs e)
        {
            LopHocBLL bll = new LopHocBLL();
            gvLopHoc.DataSource = bll.GetAlllop();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LopHocBLL bll = new LopHocBLL();
            LopHoc lop = new LopHoc();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;

            bool kq = bll.ThemMoiLopHoc(lop);
            if(kq == true)
            {
                MessageBox.Show("Lưu Ok");
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void BtnAddSV_Click(object sender, EventArgs e)
        {
            SinhVienBLL bLL = new SinhVienBLL();
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMa.Text;
            sv.TenSV = txtTen.Text;
            sv.MaLop = txtMaLop.Text;
            bool kq = bLL.ThemMoiSinhVien(sv);
            if (kq == true)
            {
                MessageBox.Show("Thêm Ok");
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
