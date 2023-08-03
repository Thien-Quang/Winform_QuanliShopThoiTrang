using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLShopQuanAo
{
    internal class LopDungChung
    {
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\laptrinhC#\laptrinhungdungdotnet\DoAnCaNhan_LiêuThiệnQuang _ 0285_QLShopQuanAo\DataOfShop.mdf"";Integrated Security=True";
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
            
        }
        public object Scalar(string sql)
        {

            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(String sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        
    }
}
