namespace QLShopQuanAo
{
    partial class frm_QuanLy_PhuKien
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
            this.dt_PhuKien = new System.Windows.Forms.DataGridView();
            this.grb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grb_Thongtinnhanvien = new System.Windows.Forms.GroupBox();
            this.txt_HangSanXuat = new System.Windows.Forms.TextBox();
            this.txt_Sldaban = new System.Windows.Forms.TextBox();
            this.lb_HangSanXuat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Giaxuat = new System.Windows.Forms.TextBox();
            this.txt_Gianhap = new System.Windows.Forms.TextBox();
            this.cbx_TinhTrang = new System.Windows.Forms.ComboBox();
            this.txt_SLconlai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_KieuDang = new System.Windows.Forms.ComboBox();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PhuKien)).BeginInit();
            this.grb_ChucNang.SuspendLayout();
            this.grb_Thongtinnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_PhuKien
            // 
            this.dt_PhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_PhuKien.Location = new System.Drawing.Point(167, 463);
            this.dt_PhuKien.Name = "dt_PhuKien";
            this.dt_PhuKien.RowHeadersWidth = 51;
            this.dt_PhuKien.RowTemplate.Height = 24;
            this.dt_PhuKien.Size = new System.Drawing.Size(923, 217);
            this.dt_PhuKien.TabIndex = 17;
            this.dt_PhuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_PhuKien_CellClick);
            // 
            // grb_ChucNang
            // 
            this.grb_ChucNang.BackColor = System.Drawing.Color.Transparent;
            this.grb_ChucNang.Controls.Add(this.btn_Thoat);
            this.grb_ChucNang.Controls.Add(this.btn_Xóa);
            this.grb_ChucNang.Controls.Add(this.btn_Sửa);
            this.grb_ChucNang.Controls.Add(this.btn_Them);
            this.grb_ChucNang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ChucNang.ForeColor = System.Drawing.Color.Red;
            this.grb_ChucNang.Location = new System.Drawing.Point(900, 126);
            this.grb_ChucNang.Name = "grb_ChucNang";
            this.grb_ChucNang.Size = new System.Drawing.Size(200, 320);
            this.grb_ChucNang.TabIndex = 16;
            this.grb_ChucNang.TabStop = false;
            this.grb_ChucNang.Text = "Chức Năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(61, 231);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(99, 38);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(61, 172);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(99, 38);
            this.btn_Xóa.TabIndex = 2;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.Location = new System.Drawing.Point(61, 114);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(99, 38);
            this.btn_Sửa.TabIndex = 1;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(61, 47);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 38);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grb_Thongtinnhanvien
            // 
            this.grb_Thongtinnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_HangSanXuat);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_Sldaban);
            this.grb_Thongtinnhanvien.Controls.Add(this.lb_HangSanXuat);
            this.grb_Thongtinnhanvien.Controls.Add(this.label11);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_Giaxuat);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_Gianhap);
            this.grb_Thongtinnhanvien.Controls.Add(this.cbx_TinhTrang);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_SLconlai);
            this.grb_Thongtinnhanvien.Controls.Add(this.label7);
            this.grb_Thongtinnhanvien.Controls.Add(this.label2);
            this.grb_Thongtinnhanvien.Controls.Add(this.label1);
            this.grb_Thongtinnhanvien.Controls.Add(this.cbx_KieuDang);
            this.grb_Thongtinnhanvien.Controls.Add(this.dtp_NgayNhap);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_TenSanPham);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_MaSanPham);
            this.grb_Thongtinnhanvien.Controls.Add(this.label8);
            this.grb_Thongtinnhanvien.Controls.Add(this.label6);
            this.grb_Thongtinnhanvien.Controls.Add(this.label5);
            this.grb_Thongtinnhanvien.Controls.Add(this.label4);
            this.grb_Thongtinnhanvien.Controls.Add(this.label3);
            this.grb_Thongtinnhanvien.Controls.Add(this.label9);
            this.grb_Thongtinnhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Thongtinnhanvien.ForeColor = System.Drawing.Color.Red;
            this.grb_Thongtinnhanvien.Location = new System.Drawing.Point(167, 126);
            this.grb_Thongtinnhanvien.Name = "grb_Thongtinnhanvien";
            this.grb_Thongtinnhanvien.Size = new System.Drawing.Size(711, 331);
            this.grb_Thongtinnhanvien.TabIndex = 15;
            this.grb_Thongtinnhanvien.TabStop = false;
            this.grb_Thongtinnhanvien.Text = "Thông tin sản phẩm";
            // 
            // txt_HangSanXuat
            // 
            this.txt_HangSanXuat.Location = new System.Drawing.Point(572, 262);
            this.txt_HangSanXuat.Name = "txt_HangSanXuat";
            this.txt_HangSanXuat.Size = new System.Drawing.Size(96, 27);
            this.txt_HangSanXuat.TabIndex = 29;
            // 
            // txt_Sldaban
            // 
            this.txt_Sldaban.Location = new System.Drawing.Point(572, 51);
            this.txt_Sldaban.Name = "txt_Sldaban";
            this.txt_Sldaban.Size = new System.Drawing.Size(96, 27);
            this.txt_Sldaban.TabIndex = 28;
            // 
            // lb_HangSanXuat
            // 
            this.lb_HangSanXuat.AutoSize = true;
            this.lb_HangSanXuat.Location = new System.Drawing.Point(443, 265);
            this.lb_HangSanXuat.Name = "lb_HangSanXuat";
            this.lb_HangSanXuat.Size = new System.Drawing.Size(116, 19);
            this.lb_HangSanXuat.TabIndex = 27;
            this.lb_HangSanXuat.Text = "Hãng Sản Xuất";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Số lượng đã bán";
            // 
            // txt_Giaxuat
            // 
            this.txt_Giaxuat.Location = new System.Drawing.Point(572, 211);
            this.txt_Giaxuat.Name = "txt_Giaxuat";
            this.txt_Giaxuat.Size = new System.Drawing.Size(96, 27);
            this.txt_Giaxuat.TabIndex = 25;
            // 
            // txt_Gianhap
            // 
            this.txt_Gianhap.Location = new System.Drawing.Point(572, 158);
            this.txt_Gianhap.Name = "txt_Gianhap";
            this.txt_Gianhap.Size = new System.Drawing.Size(96, 27);
            this.txt_Gianhap.TabIndex = 24;
            // 
            // cbx_TinhTrang
            // 
            this.cbx_TinhTrang.FormattingEnabled = true;
            this.cbx_TinhTrang.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng",
            "Sắp hết "});
            this.cbx_TinhTrang.Location = new System.Drawing.Point(131, 265);
            this.cbx_TinhTrang.Name = "cbx_TinhTrang";
            this.cbx_TinhTrang.Size = new System.Drawing.Size(128, 27);
            this.cbx_TinhTrang.TabIndex = 23;
            // 
            // txt_SLconlai
            // 
            this.txt_SLconlai.Location = new System.Drawing.Point(572, 105);
            this.txt_SLconlai.Name = "txt_SLconlai";
            this.txt_SLconlai.Size = new System.Drawing.Size(96, 27);
            this.txt_SLconlai.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Giá Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Giá Xuất ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số lượng còn lại";
            // 
            // cbx_KieuDang
            // 
            this.cbx_KieuDang.FormattingEnabled = true;
            this.cbx_KieuDang.Items.AddRange(new object[] {
            "Nam",
            "Nữ "});
            this.cbx_KieuDang.Location = new System.Drawing.Point(131, 153);
            this.cbx_KieuDang.Name = "cbx_KieuDang";
            this.cbx_KieuDang.Size = new System.Drawing.Size(128, 27);
            this.cbx_KieuDang.TabIndex = 18;
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(131, 205);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(241, 27);
            this.dtp_NgayNhap.TabIndex = 17;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Location = new System.Drawing.Point(131, 99);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(241, 27);
            this.txt_TenSanPham.TabIndex = 9;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(131, 48);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(241, 27);
            this.txt_MaSanPham.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kiểu Dáng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(504, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Quản Lý Phụ Kiện";
            // 
            // frm_QuanLy_PhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_marlon_martinez_1450082;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 688);
            this.Controls.Add(this.dt_PhuKien);
            this.Controls.Add(this.grb_ChucNang);
            this.Controls.Add(this.grb_Thongtinnhanvien);
            this.Controls.Add(this.label10);
            this.Name = "frm_QuanLy_PhuKien";
            this.Text = "frm_QuanLy_PhuKien";
            this.Load += new System.EventHandler(this.frm_QuanLy_PhuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_PhuKien)).EndInit();
            this.grb_ChucNang.ResumeLayout(false);
            this.grb_Thongtinnhanvien.ResumeLayout(false);
            this.grb_Thongtinnhanvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_PhuKien;
        private System.Windows.Forms.GroupBox grb_ChucNang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grb_Thongtinnhanvien;
        private System.Windows.Forms.TextBox txt_HangSanXuat;
        private System.Windows.Forms.TextBox txt_Sldaban;
        private System.Windows.Forms.Label lb_HangSanXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Giaxuat;
        private System.Windows.Forms.TextBox txt_Gianhap;
        private System.Windows.Forms.ComboBox cbx_TinhTrang;
        private System.Windows.Forms.TextBox txt_SLconlai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_KieuDang;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}