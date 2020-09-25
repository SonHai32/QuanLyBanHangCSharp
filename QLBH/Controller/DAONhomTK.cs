using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using QLBH.Modal;

namespace QLBH.Controller
{
    class DAONhomTK
    {
        public MyMessage inserData(NhomTK nhomTK)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO nhomTk VALUES(@tenNhom, @ghiChu)";
                cmd.Parameters.Add("@tenNhom", System.Data.SqlDbType.NVarChar).Value = nhomTK.TenNhom;
                cmd.Parameters.Add("@ghiChu", System.Data.SqlDbType.NVarChar).Value = nhomTK.GhiChu;
                int result = cmd.ExecuteNonQuery();

                return new MyMessage(result >= 0, (result >= 0 ? "Thêm Thành Công " + nhomTK.TenNhom : "Thêm Thất Bại " + nhomTK.TenNhom));
            }
            catch (SqlException ex)
            {
                return new MyMessage(false, ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public MyMessage updateData(NhomTK nhomTK)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE nhomTk set tenNhom=@tenNhom, ghiChu=@ghiChu WHERE maNhom=@maNhom";
                cmd.Parameters.Add("@maNhom", System.Data.SqlDbType.Int).Value = nhomTK.MaNhom;
                cmd.Parameters.Add("@tenNhom", System.Data.SqlDbType.NVarChar).Value = nhomTK.TenNhom;
                cmd.Parameters.Add("@ghiChu", System.Data.SqlDbType.NVarChar).Value = nhomTK.GhiChu;
                int result = cmd.ExecuteNonQuery();

                return new MyMessage(result >= 0, (result >= 0 ? "Sửa Thành Công " + nhomTK.TenNhom : "Sửa Thất Bại " + nhomTK.TenNhom));
            }
            catch (SqlException ex)
            {
                return new MyMessage(false, ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public MyMessage deleteData(NhomTK nhomTK)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM nhomTk WHERE maNhom=@maNhom";
                cmd.Parameters.Add("@maNhom", System.Data.SqlDbType.Int).Value = nhomTK.MaNhom;
                int result = cmd.ExecuteNonQuery();
                return new MyMessage(result >= 0, (result >= 0 ? "Xóa Thành Công " + nhomTK.MaNhom : "Xóa Thất Bại " + nhomTK.MaNhom));
            }
            catch (SqlException ex)
            {
                return new MyMessage(false, ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    
    }
}
