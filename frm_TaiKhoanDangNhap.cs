using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopQuanAo
{
    public partial class frm_TaiKhoanDangNhap : Form
    {
        LopDungChung dungchung = new LopDungChung();
        public frm_TaiKhoanDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TAIKHOAN value('"+txt_TaiKhoanThemXoa.Text+"','"+txt_MatKhauThemXoa.Text+"')";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm tài khoản thành công");
            else MessageBox.Show("Thêm tài khoản thất bại");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete TAIKOAN where TenTaiKhoan = '"+txt_TaiKhoanThemXoa.Text+"'";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Xóa tài khoản thành công");
            else MessageBox.Show("Xóa tài khoản thất bại");
        }

        private void btn_DoimatKhau_Click(object sender, EventArgs e)
        {
            
            
            string sql = "Select COUNT (*) from TAIKHOAN where TenTaiKhoan= '"+txt_TaiKhoanDoi.Text+"' and MatKhau='" + txt_MatKhauDoiCu.Text+"'" ;
            int kq = (int)dungchung.Scalar(sql);
            if(kq >= 1)
            {
                string sql1 = "Update TAIKHOAN set  MatKhau = '" + txt_MatKhauDoiMoi.Text + "' where TenTaiKhoan='"+txt_TaiKhoanDoi.Text+"'";
                int kq1 = dungchung.ThemSuaXoa(sql1);
                if(kq1 >= 1) MessageBox.Show("Thay đổi mật khẩu thành công");
                else MessageBox.Show("Thay đổi mật khẩu thất bại");
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát chương trình dễ thương này ư ???", "Thông báo khẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Hide();
        }
    }
}
