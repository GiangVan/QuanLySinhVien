﻿using System;
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
    }
}
