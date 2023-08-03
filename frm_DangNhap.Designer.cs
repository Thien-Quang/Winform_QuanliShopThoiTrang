namespace QLShopQuanAo
{
    partial class frm_DangNhap
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
            this.lb_ThongBao = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_LamTrong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_Hienmatkhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(345, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG QUẦN ÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(448, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(476, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.AutoSize = true;
            this.lb_ThongBao.Location = new System.Drawing.Point(829, 619);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(0, 16);
            this.lb_ThongBao.TabIndex = 3;
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(683, 394);
            this.txt_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(281, 27);
            this.txt_TenTaiKhoan.TabIndex = 4;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(683, 458);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.MaxLength = 7;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(281, 27);
            this.txt_MatKhau.TabIndex = 6;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(543, 538);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(133, 39);
            this.btn_DangNhap.TabIndex = 6;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_LamTrong
            // 
            this.btn_LamTrong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamTrong.Location = new System.Drawing.Point(720, 538);
            this.btn_LamTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamTrong.Name = "btn_LamTrong";
            this.btn_LamTrong.Size = new System.Drawing.Size(133, 39);
            this.btn_LamTrong.TabIndex = 7;
            this.btn_LamTrong.Text = "Làm Trống";
            this.btn_LamTrong.UseVisualStyleBackColor = true;
            this.btn_LamTrong.Click += new System.EventHandler(this.btn_LamTrong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(888, 538);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(133, 39);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cb_Hienmatkhau
            // 
            this.cb_Hienmatkhau.AutoSize = true;
            this.cb_Hienmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.cb_Hienmatkhau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hienmatkhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb_Hienmatkhau.Location = new System.Drawing.Point(1014, 452);
            this.cb_Hienmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Hienmatkhau.Name = "cb_Hienmatkhau";
            this.cb_Hienmatkhau.Size = new System.Drawing.Size(201, 37);
            this.cb_Hienmatkhau.TabIndex = 9;
            this.cb_Hienmatkhau.Text = "Hiện mật khẩu";
            this.cb_Hienmatkhau.UseVisualStyleBackColor = false;
            this.cb_Hienmatkhau.CheckedChanged += new System.EventHandler(this.cb_Hienmatkhau_CheckedChanged);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_mohan_reddy_4388593;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1439, 883);
            this.Controls.Add(this.cb_Hienmatkhau);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamTrong);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenTaiKhoan);
            this.Controls.Add(this.lb_ThongBao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ThongBao;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_LamTrong;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox cb_Hienmatkhau;
    }
}