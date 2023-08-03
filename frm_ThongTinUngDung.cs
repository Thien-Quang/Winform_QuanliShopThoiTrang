using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopQuanAo
{
    public partial class frm_ThongTinUngDung : Form
    {
        public frm_ThongTinUngDung()
        {
            InitializeComponent();
        }

        private void frm_ThongTinUngDung_Load(object sender, EventArgs e)
        {                               
                string filepath = @"D:\laptrinhC#\laptrinhungdungdotnet\DoAnCaNhan_LiêuThiệnQuang_0285_QLShopQuanAo\ThongTinUngDung.txt";
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string content = sr.ReadToEnd();
                    lb_Thongtinungdung.Text = content;
                }           
        }
    }
}
