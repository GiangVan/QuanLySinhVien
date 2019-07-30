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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gvLopHoc.Size = new System.Drawing.Size(316, 227);
            this.gvLopHoc.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(403, 131);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(147, 20);
            this.txtMa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ma lop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ten lop";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(403, 166);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(147, 20);
            this.txtTen.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "luu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.gvLopHoc);
            this.Controls.Add(this.btnTaiDanhSachLop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiDanhSachLop;
        private System.Windows.Forms.DataGridView gvLopHoc;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button button1;
    }
}

