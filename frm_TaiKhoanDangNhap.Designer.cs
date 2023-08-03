namespace QLShopQuanAo
{
    partial class frm_TaiKhoanDangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MatKhauThemXoa = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoanThemXoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DoimatKhau = new System.Windows.Forms.Button();
            this.txt_MatKhauDoiMoi = new System.Windows.Forms.TextBox();
            this.txt_MatKhauDoiCu = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoanDoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_MatKhauThemXoa);
            this.groupBox1.Controls.Add(this.txt_TaiKhoanThemXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(50, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm và Xóa tài khoản";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.Location = new System.Drawing.Point(174, 304);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(96, 37);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Location = new System.Drawing.Point(25, 304);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(96, 37);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MatKhauThemXoa
            // 
            this.txt_MatKhauThemXoa.Location = new System.Drawing.Point(25, 200);
            this.txt_MatKhauThemXoa.Name = "txt_MatKhauThemXoa";
            this.txt_MatKhauThemXoa.Size = new System.Drawing.Size(239, 22);
            this.txt_MatKhauThemXoa.TabIndex = 3;
            // 
            // txt_TaiKhoanThemXoa
            // 
            this.txt_TaiKhoanThemXoa.Location = new System.Drawing.Point(25, 101);
            this.txt_TaiKhoanThemXoa.Name = "txt_TaiKhoanThemXoa";
            this.txt_TaiKhoanThemXoa.Size = new System.Drawing.Size(239, 22);
            this.txt_TaiKhoanThemXoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_DoimatKhau);
            this.groupBox2.Controls.Add(this.txt_MatKhauDoiMoi);
            this.groupBox2.Controls.Add(this.txt_MatKhauDoiCu);
            this.groupBox2.Controls.Add(this.txt_TaiKhoanDoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(380, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi Mật Khẩu";
            // 
            // btn_DoimatKhau
            // 
            this.btn_DoimatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DoimatKhau.Location = new System.Drawing.Point(104, 279);
            this.btn_DoimatKhau.Name = "btn_DoimatKhau";
            this.btn_DoimatKhau.Size = new System.Drawing.Size(151, 34);
            this.btn_DoimatKhau.TabIndex = 6;
            this.btn_DoimatKhau.Text = "Đổi Mật Khẩu";
            this.btn_DoimatKhau.UseVisualStyleBackColor = true;
            this.btn_DoimatKhau.Click += new System.EventHandler(this.btn_DoimatKhau_Click);
            // 
            // txt_MatKhauDoiMoi
            // 
            this.txt_MatKhauDoiMoi.Location = new System.Drawing.Point(62, 231);
            this.txt_MatKhauDoiMoi.MaxLength = 6;
            this.txt_MatKhauDoiMoi.Name = "txt_MatKhauDoiMoi";
            this.txt_MatKhauDoiMoi.Size = new System.Drawing.Size(239, 22);
            this.txt_MatKhauDoiMoi.TabIndex = 6;
            // 
            // txt_MatKhauDoiCu
            // 
            this.txt_MatKhauDoiCu.Location = new System.Drawing.Point(62, 145);
            this.txt_MatKhauDoiCu.Name = "txt_MatKhauDoiCu";
            this.txt_MatKhauDoiCu.Size = new System.Drawing.Size(239, 22);
            this.txt_MatKhauDoiCu.TabIndex = 5;
            // 
            // txt_TaiKhoanDoi
            // 
            this.txt_TaiKhoanDoi.Location = new System.Drawing.Point(55, 68);
            this.txt_TaiKhoanDoi.Name = "txt_TaiKhoanDoi";
            this.txt_TaiKhoanDoi.Size = new System.Drawing.Size(250, 22);
            this.txt_TaiKhoanDoi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Tài Khoản";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(607, 405);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(96, 37);
            this.btn_Dong.TabIndex = 7;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_TaiKhoanDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_mohan_reddy_4388593;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TaiKhoanDangNhap";
            this.Text = "frm_TaiKhoanDangNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MatKhauThemXoa;
        private System.Windows.Forms.TextBox txt_TaiKhoanThemXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DoimatKhau;
        private System.Windows.Forms.TextBox txt_MatKhauDoiMoi;
        private System.Windows.Forms.TextBox txt_MatKhauDoiCu;
        private System.Windows.Forms.TextBox txt_TaiKhoanDoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dong;
    }
}