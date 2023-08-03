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
    public partial class frm_NhanVien : Form
    {
        LopDungChung dungchung = new LopDungChung();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtp_NgaySinh.Value;
            string ngaySinhDB = ngaySinh.ToString("MM/dd/yyyy");

            DateTime ngayVaoLam = dtp_NgayVaoLam.Value;
            string ngayVaoLamDB = ngayVaoLam.ToString("MM/dd/yyyy");

            string GioiTinh;
            if (rdo_Nam.Checked) { GioiTinh = "Nam"; }
            else GioiTinh = "Nữ";


            string sql = "Insert into NHANVIEN values ('" + txt_Id.Text + "',N'" + txt_HoVaTen.Text + "','" + txt_Email.Text + "','" + txt_SoDienThoai.Text + "',N'" + txt_ChucVu.Text + "','" + GioiTinh + "','" + ngaySinhDB + "','" + ngayVaoLamDB + "')";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadNV();
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NHANVIEN where MaNV = '" + txt_Id.Text + "'";
            int kq = dungchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Xóa nhân viên thành công");
            else MessageBox.Show("Xóa nhân viên thất bại");
            LoadNV();
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtp_NgaySinh.Value;
            string ngaySinhDB = ngaySinh.ToString("MM/dd/yyyy");

            DateTime ngayVaoLam = dtp_NgayVaoLam.Value;
            string ngayVaoLamDB = ngayVaoLam.ToString("MM/dd/yyyy");

            string GioiTinh;
            if (rdo_Nam.Checked) { GioiTinh = "Nam"; }
            else GioiTinh = "Nữ";

            string sql = "Update NHANVIEN set HoTen = '" + txt_HoVaTen.Text + "',Email ='" + txt_Email.Text + "',SoDienThoai ='" + txt_SoDienThoai.Text + "',ChucVu =N'" + txt_ChucVu.Text + "',GioiTinh='" + GioiTinh + "',NgaySinh='" + ngaySinhDB + "',NgayVaoLam='" + ngayVaoLamDB + "' where  MaNV = '" + txt_Id.Text + "' ";
            int kq = dungchung.ThemSuaXoa(sql);

            if (kq >= 1)
                MessageBox.Show("Sửa nhân viên thành công");
            else MessageBox.Show("Sửa nhân viên thất bại");
            LoadNV();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát chương trình dễ thương này ư ???", "Thông báo khẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Hide();
        }
        public void LoadNV()
        {

            string sqlNV = "SELECT MaNV AS 'Mã Nhân Viên', HoTen AS 'Họ Và Tên', Email, SoDienThoai AS 'Số Điện Thoại',GioiTinh AS 'Giới Tính' , ChucVu AS 'Chức Vụ',CONVERT(varchar(10), NgaySinh,103) AS 'Ngày Sinh',CONVERT(varchar(10),NgayVaoLam,103)  AS 'Ngày Vào Làm' FROM NHANVIEN";
            dt_NhanVien.DataSource = dungchung.LoadDL(sqlNV);
        }

        private void dt_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dt_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoVaTen.Text = dt_NhanVien.CurrentRow.Cells["Họ Và Tên"].Value.ToString();
            txt_Email.Text = dt_NhanVien.CurrentRow.Cells["Email"].Value.ToString();
            txt_SoDienThoai.Text = dt_NhanVien.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
            txt_ChucVu.Text = dt_NhanVien.CurrentRow.Cells["Chức Vụ"].Value.ToString();

            string ngaySinhStr = dt_NhanVien.CurrentRow.Cells["Ngày Sinh"].Value.ToString();
            DateTime ngaySinh = DateTime.ParseExact(ngaySinhStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtp_NgaySinh.Value = ngaySinh;

            string ngayVaoLamStr = dt_NhanVien.CurrentRow.Cells["Ngày Vào Làm"].Value.ToString();
            DateTime ngayVaolam = DateTime.ParseExact(ngayVaoLamStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtp_NgaySinh.Value = ngayVaolam;

            string gioitinh = dt_NhanVien.CurrentRow.Cells["Giới Tính"].Value.ToString();
            if (gioitinh == "Nam")
            {
                rdo_Nam.Checked = true;
            }
            if(gioitinh=="Nữ") rdo_Nu.Checked = true;
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
    }
}
