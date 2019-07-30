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
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiDanhSachLop
            // 
            this.btnTaiDanhSachLop.Location = new System.Drawing.Point(40, 32);
            this.btnTaiDanhSachLop.Name = "btnTaiDanhSachLop";
            this.btnTaiDanhSachLop.Size = new System.Drawing.Size(157, 36);
            this.btnTaiDanhSachLop.TabIndex = 0;
            this.btnTaiDanhSachLop.Text = "Tải Danh Sách Lớp";
            this.btnTaiDanhSachLop.UseVisualStyleBackColor = true;
            this.btnTaiDanhSachLop.Click += new System.EventHandler(this.BtnTaiDanhSachLop_Click);
            // 
            // gvLopHoc
            // 
            this.gvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLopHoc.Location = new System.Drawing.Point(40, 113);
            this.gvLopHoc.Name = "gvLopHoc";
            this.gvLopHoc.RowHeadersWidth = 51;
            this.gvLopHoc.RowTemplate.Height = 24;
            this.gvLopHoc.Size = new System.Drawing.Size(570, 279);
            this.gvLopHoc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvLopHoc);
            this.Controls.Add(this.btnTaiDanhSachLop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaiDanhSachLop;
        private System.Windows.Forms.DataGridView gvLopHoc;
    }
}

