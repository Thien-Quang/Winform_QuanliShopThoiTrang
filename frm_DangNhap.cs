using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopQuanAo
{
    public partial class frm_DangNhap : Form
    {
      
        int dem = 0;
        LopDungChung lopchung = new LopDungChung();
        public frm_DangNhap()
        {
            InitializeComponent();          
        }
   
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
             string sql = "Select COUNT(*) FROM TAIKHOAN WHERE TenTaiKhoan ='" +txt_TenTaiKhoan.Text+ "' AND MatKhau ='" +txt_MatKhau.Text+ "' ";
             int kq = (int)lopchung.Scalar(sql);
            if(kq >=1 )
            { 

                frm_Menu main = new frm_Menu();
                main.Show();
                this.Hide();
               
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khấu . Số lần bạn đã nhập sai là : " + (dem));
                txt_TenTaiKhoan.ResetText();
                txt_MatKhau.ResetText();
            }
            if (dem == 3) this.Close();
        }

        private void btn_LamTrong_Click(object sender, EventArgs e)
        {
            txt_TenTaiKhoan.ResetText();
            txt_MatKhau.ResetText();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát chương trình dễ thương này ư ???" , "Thông báo khẩn",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) this.Close();
        }

        private void cb_Hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_Hienmatkhau.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_MatKhau.Text.Length >= 6 && e.KeyChar != (char)Keys.Back )
                {
                e.Handled = true;
                MessageBox.Show("Bạn đã nhập quá số lượng cho phép");

                 }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
