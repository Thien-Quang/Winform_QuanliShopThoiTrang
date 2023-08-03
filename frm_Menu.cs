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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nhanvien = new frm_NhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void quầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLy_Quan"] == null)
            {
                frm_QuanLy_Quan quan = new frm_QuanLy_Quan();
                quan.MdiParent = this;
                quan.Show();
            }
            else Application.OpenForms["frm_QuanLy_Quan"].Activate();
        }

        private void áoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLy_Ao"] == null)
            {
                frm_QuanLy_Ao ao = new frm_QuanLy_Ao();
                ao.MdiParent = this;
                ao.Show();
            }
            else Application.OpenForms["frm_QuanLy_Ao"].Activate();
        }

        private void phụKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLy_PhuKien"] == null)
            {
                frm_QuanLy_PhuKien phukien = new frm_QuanLy_PhuKien();
                phukien.MdiParent = this;
                phukien.Show();
            }
            else Application.OpenForms["frm_QuanLy_PhuKien"].Activate();
        }
        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongTinUngDung"] == null)
            {
                frm_ThongTinUngDung nhanvien = new frm_ThongTinUngDung();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else Application.OpenForms["frm_ThongTinUngDung"].Activate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng các form con và giải phóng tài nguyên
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
                childForm.Dispose();
            }

            // Load lại form cha
            this.Refresh();
        }
        /*private void frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hỏi người dùng có muốn thoát chương trình hay không
          
        }*/

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát chương trình",
                " Thông báo khẩn ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) { Application.Exit(); }
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslb_timer.Text = DateTime.Now.ToString();
        }

        private void accountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TaiKhoanDangNhap"] == null)
            {
                frm_TaiKhoanDangNhap taikhoan = new frm_TaiKhoanDangNhap();
                taikhoan.MdiParent = this;
                taikhoan.Show();
            }
            else Application.OpenForms["frm_TaiKhoanDangNhap"].Activate();
        }

        private void frm_Menu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
