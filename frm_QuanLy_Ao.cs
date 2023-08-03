using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopQuanAo
{
    public partial class frm_QuanLy_Ao : Form
    {

        LopDungChung dungchung = new LopDungChung();
        public frm_QuanLy_Ao()
        {
            InitializeComponent();
        }

        private void btn_ThemAo_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dtp_NgayNhap.Value;
            String ngayNhapDB = ngayNhap.ToString();
            string kieuDang = cbx_KieuDang.SelectedItem.ToString();
            string tinhTrang = cbx_TinhTrang.SelectedItem.ToString();

            string sql = "Insert into AO values ('" + txt_MaSanPham.Text + "',N'" + txt_TenSanPham.Text + "',N'" + kieuDang + "', '" + ngayNhapDB + "',N'" +tinhTrang + "','" + txt_Sldaban.Text + "','" + txt_SLconlai.Text + "','" + txt_Gianhap.Text + "','" + txt_Giaxuat.Text + "',N'" + txt_HangSanXuat.Text + "') ";
            int kq = dungchung.ThemSuaXoa(sql);
            if(kq >= 1)
                MessageBox.Show("Thêm áo thành công");
            else MessageBox.Show("Thêm áo thất bại");
            LoadAO();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dtp_NgayNhap.Value;
            String ngayNhapDB = ngayNhap.ToString("MM/dd/yyyy");

            string kieuDang = cbx_KieuDang.SelectedItem.ToString();
            string tinhTrang = cbx_TinhTrang.SelectedItem.ToString();

            string sql = "Update AO set TenSanPham=N'" + txt_TenSanPham.Text + "', KieuDang = N'" + kieuDang + "',NgayNhap= '" + ngayNhapDB + "',TinhTrang= N'" + tinhTrang + "',SoLuongBan='" + txt_Sldaban.Text + "',SoLuongConLai ='" + txt_SLconlai.Text + "',GiaNhap='" + txt_Gianhap.Text + "',GiaXuat='" + txt_Giaxuat.Text + "',HangSanXuat='" + txt_HangSanXuat.Text + "' where MaSP='"+txt_MaSanPham.Text+"' ";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Sửa áo thành công");
            else MessageBox.Show("Sửa áo thất bại");
            LoadAO();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete AO where MaSP = '" + txt_MaSanPham.Text + "'";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Xóa áo thành công");
            else MessageBox.Show("Xóa áo thất bại");
            LoadAO();
        }

        private void btn_ThoatAo_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát chương trình dễ thương này ư ???", "Thông báo khẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Hide();
        }

        public void LoadAO()
        {
            string sqlAO = "Select MaSP AS 'Mã Sản Phẩm',TenSanPham AS 'Tên Sản Phẩm',KieuDang AS 'Kiểu Dáng' , CONVERT(varchar(10), NgayNhap, 103) AS 'Ngày Nhập',TinhTrang AS 'Tình Trạng', SoLuongBan AS 'SL Đã Bán' , SoLuongConLai AS 'SL Còn Lại',GiaNhap AS 'Giá Nhập',GiaXuat AS 'Giá Xuất',HangSanXuat AS 'Hãng Sản Xuất' FROM AO ";
           
            dt_Ao.DataSource = dungchung.LoadDL(sqlAO);
        }

        private void dt_Ao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_MaSanPham.Text = dt_Ao.CurrentRow.Cells[0].Value.ToString();
           txt_TenSanPham.Text = dt_Ao.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
           txt_Gianhap.Text = dt_Ao.CurrentRow.Cells["Giá Nhập"].Value.ToString();
           txt_Giaxuat.Text = dt_Ao.CurrentRow.Cells["Giá Xuất"].Value.ToString();
           txt_Sldaban.Text = dt_Ao.CurrentRow.Cells["SL Đã Bán"].Value.ToString();
           txt_SLconlai.Text = dt_Ao.CurrentRow.Cells["SL Còn Lại"].Value.ToString();
           txt_HangSanXuat.Text = dt_Ao.CurrentRow.Cells["Hãng Sản Xuất"].Value.ToString();


            string ngayNhapStr = dt_Ao.CurrentRow.Cells["Ngày Nhập"].Value.ToString();
            DateTime NgayNhap = DateTime.ParseExact(ngayNhapStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtp_NgayNhap.Value = NgayNhap;


            string kieuDang = dt_Ao.CurrentRow.Cells["Kiểu Dáng"].Value.ToString();
            cbx_KieuDang.SelectedItem = kieuDang;



            string tinhtrang = dt_Ao.CurrentRow.Cells["Tình Trạng"].Value.ToString();         
            cbx_TinhTrang.SelectedItem = tinhtrang;
            

        }

        private void frm_QuanLy_Ao_Load(object sender, EventArgs e)
        {
            LoadAO();
        }

       
    }
}
