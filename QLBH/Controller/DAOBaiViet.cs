using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using QLBH.Modal;

namespace QLBH.Controller
{
    class DAOBaiViet
    {
        public MyMessage InsertData(BaiViet baiViet)
        {

            SqlConnection con = new DAO().getConnection();
            con.Open();

            SqlCommand command= con.CreateCommand();
            command.CommandText = "INSERT INTO dbo.baiViet VALUES(" +
                "@maBV," +
                "@tenBV" +
                ",@hinhDD," +
                "@ndTomTat," +
                "@ngayDang," +
                "@maLoai," +
                "@noiDung," +
                "@taiKhoan" +
                ",@daDuyet)";

            command.Parameters.Add("@maBV", SqlDbType.VarChar).Value = baiViet.MaBV;
            command.Parameters.Add("@tenBV", SqlDbType.NVarChar).Value = baiViet.TenBV;
            command.Parameters.Add("@hinhDD", SqlDbType.VarChar).Value = baiViet.HinhDD;
            command.Parameters.Add("@ndTomTat", SqlDbType.NVarChar).Value = baiViet.NdTomTat;
            command.Parameters.Add("@ngayDang", SqlDbType.DateTime).Value = baiViet.NgayDang;
            command.Parameters.Add("@maLoai", SqlDbType.Int).Value = baiViet.MaLoai;
            command.Parameters.Add("@noiDung", SqlDbType.NVarChar).Value = baiViet.NoiDung;
            command.Parameters.Add("@taiKhoan", SqlDbType.VarChar).Value = baiViet.TaiKhoan;
            command.Parameters.Add("@daDuyet", SqlDbType.Bit).Value = baiViet.DaDuyet ? 1 : 0;

            MyMessage mess;
            
            try
            {
                int result = command.ExecuteNonQuery();
                mess = new MyMessage(result >= 0, (result >= 0 ? "Thêm Thành Công "+baiViet.TenBV+"" : "Thêm Thất Bại "+baiViet.TenBV+""));

                return mess;
            }
            catch (SqlException e)
            {
                return new MyMessage(false, e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public MyMessage updateData(BaiViet baiViet)
        {
            SqlConnection con = new DAO().getConnection();


            try
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "UPDATE dbo.baiViet set" +
                "tenBV=@tenBV," +
                "hinhDD=@hinhDD," +
                "ndTomTat=@ndTomTat," +
                "ngayDang=@ngayDang," +
                "maLoai=@maLoai," +
                "noiDung=@noiDung," +
                "taiKhoan=@taiKhoan," +
                "daDuyet=@daDuyet" +
                "WHERE maBV=@maBV";
                
                command.Parameters.Add("@maBV", SqlDbType.VarChar).Value = baiViet.MaBV;
                command.Parameters.Add("@tenBV", SqlDbType.NVarChar).Value = baiViet.TenBV;
                command.Parameters.Add("@hinhDD", SqlDbType.VarChar).Value = baiViet.HinhDD;
                command.Parameters.Add("@ndTomTat", SqlDbType.NVarChar).Value = baiViet.NdTomTat;
                command.Parameters.Add("@ngayDang", SqlDbType.DateTime).Value = baiViet.NgayDang;
                command.Parameters.Add("@maLoai", SqlDbType.Int).Value = baiViet.MaLoai;
                command.Parameters.Add("@noiDung", SqlDbType.NVarChar).Value = baiViet.NoiDung;
                command.Parameters.Add("@taiKhoan", SqlDbType.VarChar).Value = baiViet.TaiKhoan;
                
                int result = command.ExecuteNonQuery();
                MyMessage message = new MyMessage(result >= 0, (result >= 0 ? "Sửa Đổi Thành Công "+baiViet.MaBV+""  : "Sửa Đổi Thất Bại "+baiViet.MaBV+""));
                return message;
            }
            catch (SqlException e)
            {
                return new MyMessage(false, e.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public MyMessage delectData(String maBV)
        {
            SqlConnection con = new DAO().getConnection();
            try
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM dbo.baiViet WHERE maBV=@maBV";
                command.Parameters.Add("@maBV", SqlDbType.VarChar).Value = maBV;

                int result = command.ExecuteNonQuery();
                MyMessage message = new MyMessage(result >= 0, (result >= 0 ? "Xóa Thành Công "+maBV+"" : "Xóa Không Thành Công "+maBV+""));
                return message;
            }
            catch(SqlException e)
            {
                return new MyMessage(false, e.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
