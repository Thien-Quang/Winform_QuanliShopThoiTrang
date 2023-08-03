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
    public partial class frm_QuanLy_Quan : Form
    {
        LopDungChung dungchung = new LopDungChung();
        public void LoadQuan()
        {
            string sqlAO = "Select MaSP AS 'Mã Sản Phẩm',TenSanPham AS 'Tên Sản Phẩm',KieuDang AS 'Kiểu Dáng' , CONVERT(varchar(10), NgayNhap, 103) AS 'Ngày Nhập',TinhTrang AS 'Tình Trạng', SoLuongBan AS 'SL Đã Bán' , SoLuongConLai AS 'SL Còn Lại',GiaNhap AS 'Giá Nhập',GiaXuat AS 'Giá Xuất',HangSanXuat AS 'Hãng Sản Xuất' FROM QUAN ";

            dt_Quan.DataSource = dungchung.LoadDL(sqlAO);
        }
        public frm_QuanLy_Quan()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dtp_NgayNhap.Value;
            String ngayNhapDB = ngayNhap.ToString();
            string kieuDang = cbx_KieuDang.SelectedItem.ToString();
            string tinhTrang = cbx_TinhTrang.SelectedItem.ToString();

            string sql = "Insert into QUAN values ('" + txt_MaSanPham.Text + "',N'" + txt_TenSanPham.Text + "',N'" + kieuDang + "', '" + ngayNhapDB + "',N'" + tinhTrang + "','" + txt_Sldaban.Text + "','" + txt_SLconlai.Text + "','" + txt_Gianhap.Text + "','" + txt_Giaxuat.Text + "',N'" + txt_HangSanXuat.Text + "') ";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm quần thành công");
            else MessageBox.Show("Thêm quần thất bại");
            LoadQuan();
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dtp_NgayNhap.Value;
            String ngayNhapDB = ngayNhap.ToString("MM/dd/yyyy");

            string kieuDang = cbx_KieuDang.SelectedItem.ToString();
            string tinhTrang = cbx_TinhTrang.SelectedItem.ToString();

            string sql = "Update QUAN set TenSanPham=N'" + txt_TenSanPham.Text + "', KieuDang = N'" + kieuDang + "',NgayNhap= '" + ngayNhapDB + "',TinhTrang= N'" + tinhTrang + "',SoLuongBan='" + txt_Sldaban.Text + "',SoLuongConLai ='" + txt_SLconlai.Text + "',GiaNhap='" + txt_Gianhap.Text + "',GiaXuat='" + txt_Giaxuat.Text + "',HangSanXuat='" + txt_HangSanXuat.Text + "' where MaSP='" + txt_MaSanPham.Text + "' ";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Sửa quần thành công");
            else MessageBox.Show("Sửa quần thất bại");
            LoadQuan();
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            string sql = "Delete QUAN where MaSP = '" + txt_MaSanPham.Text + "'";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Xóa quân thành công");
            else MessageBox.Show("Xóa quần thất bại");
            LoadQuan();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát chương trình dễ thương này ư ???", "Thông báo khẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Hide();
        }

        private void dt_Quan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSanPham.Text = dt_Quan.CurrentRow.Cells[0].Value.ToString();
            txt_TenSanPham.Text = dt_Quan.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
            txt_Gianhap.Text = dt_Quan.CurrentRow.Cells["Giá Nhập"].Value.ToString();
            txt_Giaxuat.Text = dt_Quan.CurrentRow.Cells["Giá Xuất"].Value.ToString();
            txt_Sldaban.Text = dt_Quan.CurrentRow.Cells["SL Đã Bán"].Value.ToString();
            txt_SLconlai.Text = dt_Quan.CurrentRow.Cells["SL Còn Lại"].Value.ToString();
            txt_HangSanXuat.Text = dt_Quan.CurrentRow.Cells["Hãng Sản Xuất"].Value.ToString();


            string ngayNhapStr = dt_Quan.CurrentRow.Cells["Ngày Nhập"].Value.ToString();
            DateTime NgayNhap = DateTime.ParseExact(ngayNhapStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtp_NgayNhap.Value = NgayNhap;


            string kieuDang = dt_Quan.CurrentRow.Cells["Kiểu Dáng"].Value.ToString();
            cbx_KieuDang.SelectedItem = kieuDang;



            string tinhtrang = dt_Quan.CurrentRow.Cells["Tình Trạng"].Value.ToString();
            cbx_TinhTrang.SelectedItem = tinhtrang;
        }

        private void frm_QuanLy_Quan_Load(object sender, EventArgs e)
        {
            LoadQuan();
        }
    }
}
