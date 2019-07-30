namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaiDanhSachLop = new System.Windows.Forms.Button();
            this.gvLopHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiDanhSachLop
            // 
            this.btnTaiDanhSachLop.Location = new System.Drawing.Point(30, 26);
            this.btnTaiDanhSachLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaiDanhSachLop.Name = "btnTaiDanhSachLop";
            this.btnTaiDanhSachLop.Size = new System.Drawing.Size(118, 29);
            this.btnTaiDanhSachLop.TabIndex = 0;
            this.btnTaiDanhSachLop.Text = "Tải Danh Sách Lớp";
            this.btnTaiDanhSachLop.UseVisualStyleBackColor = true;
            this.btnTaiDanhSachLop.Click += new System.EventHandler(this.BtnTaiDanhSachLop_Click);
            // 
            // gvLopHoc
            // 
            this.gvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLopHoc.Location = new System.Drawing.Point(30, 92);
            this.gvLopHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvLopHoc.Name = "gvLopHoc";
            this.gvLopHoc.RowHeadersWidth = 51;
            this.gvLopHoc.RowTemplate.Height = 24;
            this.gvLopHoc.Size = new System.Drawing.Size(428, 227);
            this.gvLopHoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(553, 92);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(255, 20);
            this.txtMaLop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(553, 142);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(255, 20);
            this.txtTenLop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Location = new System.Drawing.Point(893, 211);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(115, 34);
            this.btnAddSV.TabIndex = 5;
            this.btnAddSV.Text = "Thêm Mới SV";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.BtnAddSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã SV:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(893, 100);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(224, 20);
            this.txtMa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên SV:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(894, 139);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(224, 20);
            this.txtTen.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 439);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLopHoc);
            this.Controls.Add(this.btnTaiDanhSachLop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiDanhSachLop;
        private System.Windows.Forms.DataGridView gvLopHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
    }
}

