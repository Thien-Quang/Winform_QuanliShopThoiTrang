namespace QLShopQuanAo
{
    partial class frm_NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_Thongtinnhanvien = new System.Windows.Forms.GroupBox();
            this.txt_ChucVu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_NhanVien = new System.Windows.Forms.DataGridView();
            this.grb_Thongtinnhanvien.SuspendLayout();
            this.grb_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(362, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // grb_Thongtinnhanvien
            // 
            this.grb_Thongtinnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_ChucVu);
            this.grb_Thongtinnhanvien.Controls.Add(this.label9);
            this.grb_Thongtinnhanvien.Controls.Add(this.dtp_NgayVaoLam);
            this.grb_Thongtinnhanvien.Controls.Add(this.dtp_NgaySinh);
            this.grb_Thongtinnhanvien.Controls.Add(this.rdo_Nu);
            this.grb_Thongtinnhanvien.Controls.Add(this.rdo_Nam);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_SoDienThoai);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_Email);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_HoVaTen);
            this.grb_Thongtinnhanvien.Controls.Add(this.txt_Id);
            this.grb_Thongtinnhanvien.Controls.Add(this.label8);
            this.grb_Thongtinnhanvien.Controls.Add(this.label7);
            this.grb_Thongtinnhanvien.Controls.Add(this.label6);
            this.grb_Thongtinnhanvien.Controls.Add(this.label5);
            this.grb_Thongtinnhanvien.Controls.Add(this.label4);
            this.grb_Thongtinnhanvien.Controls.Add(this.label2);
            this.grb_Thongtinnhanvien.Controls.Add(this.label3);
            this.grb_Thongtinnhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Thongtinnhanvien.ForeColor = System.Drawing.Color.Red;
            this.grb_Thongtinnhanvien.Location = new System.Drawing.Point(69, 103);
            this.grb_Thongtinnhanvien.Name = "grb_Thongtinnhanvien";
            this.grb_Thongtinnhanvien.Size = new System.Drawing.Size(711, 303);
            this.grb_Thongtinnhanvien.TabIndex = 3;
            this.grb_Thongtinnhanvien.TabStop = false;
            this.grb_Thongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Location = new System.Drawing.Point(500, 197);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(211, 27);
            this.txt_ChucVu.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Chức Vụ";
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(131, 254);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(241, 27);
            this.dtp_NgayVaoLam.TabIndex = 17;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(131, 197);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(241, 27);
            this.dtp_NgaySinh.TabIndex = 16;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(624, 260);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(50, 23);
            this.rdo_Nu.TabIndex = 15;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Location = new System.Drawing.Point(517, 260);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(62, 23);
            this.rdo_Nam.TabIndex = 14;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(489, 112);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(241, 27);
            this.txt_SoDienThoai.TabIndex = 13;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(489, 49);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(241, 27);
            this.txt_Email.TabIndex = 12;
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.Location = new System.Drawing.Point(131, 121);
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.Size = new System.Drawing.Size(241, 27);
            this.txt_HoVaTen.TabIndex = 9;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(131, 52);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(241, 27);
            this.txt_Id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Vào Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
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
            this.grb_ChucNang.Location = new System.Drawing.Point(804, 103);
            this.grb_ChucNang.Name = "grb_ChucNang";
            this.grb_ChucNang.Size = new System.Drawing.Size(200, 303);
            this.grb_ChucNang.TabIndex = 4;
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
            // dt_NhanVien
            // 
            this.dt_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_NhanVien.Location = new System.Drawing.Point(80, 429);
            this.dt_NhanVien.Name = "dt_NhanVien";
            this.dt_NhanVien.RowHeadersWidth = 51;
            this.dt_NhanVien.RowTemplate.Height = 24;
            this.dt_NhanVien.Size = new System.Drawing.Size(909, 220);
            this.dt_NhanVien.TabIndex = 5;
            this.dt_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_NhanVien_CellClick);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_marlon_martinez_1450082;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 743);
            this.Controls.Add(this.dt_NhanVien);
            this.Controls.Add(this.grb_ChucNang);
            this.Controls.Add(this.grb_Thongtinnhanvien);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.grb_Thongtinnhanvien.ResumeLayout(false);
            this.grb_Thongtinnhanvien.PerformLayout();
            this.grb_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grb_Thongtinnhanvien;
        private System.Windows.Forms.GroupBox grb_ChucNang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DataGridView dt_NhanVien;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_ChucVu;
        private System.Windows.Forms.Label label9;
    }
}