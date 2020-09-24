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

    class DAOLoaiSP
    {
        public MyMessage inserData(LoaiSanPham loaiSanPham)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO loaiSanPham VALUES(@loaiSP, @ghiChu)";
                cmd.Parameters.Add("@loaiSanPham", System.Data.SqlDbType.NVarChar).Value = loaiSanPham.LoaiSP;
                cmd.Parameters.Add("@ghiChu", System.Data.SqlDbType.NVarChar).Value = loaiSanPham.GhiChu;
                int result = cmd.ExecuteNonQuery();

                return new MyMessage(result >= 0, (result >= 0 ? "Thêm Thành Công " + loaiSanPham.LoaiSP : "Thêm Thất Bại " + loaiSanPham.LoaiSP));
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

        public MyMessage updateData(LoaiSanPham loaiSanPham)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE loaiSanPham set loaiSP=@loaiSP, ghiChu=@ghiChu WHERE maLoai=@maLoai)";
                cmd.Parameters.Add("@maLoai", System.Data.SqlDbType.Int).Value = loaiSanPham.MaLoai;
                cmd.Parameters.Add("@loaiSanPham", System.Data.SqlDbType.NVarChar).Value = loaiSanPham.LoaiSP;
                cmd.Parameters.Add("@ghiChu", System.Data.SqlDbType.NVarChar).Value = loaiSanPham.GhiChu;
                int result = cmd.ExecuteNonQuery();

                return new MyMessage(result >= 0, (result >= 0 ? "Sửa Thành Công " + loaiSanPham.LoaiSP : "Sửa Thất Bại " + loaiSanPham.LoaiSP));
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
        public MyMessage deleteData(LoaiSanPham loaiSanPham)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM loaiSP WHERE maLoai=@maLoai)";
                cmd.Parameters.Add("@maLoai", System.Data.SqlDbType.Int).Value = loaiSanPham.MaLoai;
                int result = cmd.ExecuteNonQuery();
                return new MyMessage(result >= 0, (result >= 0 ? "Xóa Thành Công " + loaiSanPham.LoaiSP : "Xóa Thất Bại " + loaiSanPham.LoaiSP));
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
