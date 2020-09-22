using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Modal;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QLBH.Controller
{
    class DAOTaiKhoanTV
    {
        
        public MyMessage InsertData(TaiKhoanTV taiKhoan)
        {

            SqlConnection con = new DAO().getConnection();
            con.Open();

            SqlCommand command= con.CreateCommand();
            command.CommandText = "INSERT INTO dbo.taiKhoanTV VALUES(@taiKhoan,	@matKhau, @maNhom, @hoDem, @tenTV, @ngaysinh, @gioiTinh, @soDT,	@email,	@diaChi, @maQH,	@trangThai,	@ghiChu)";

            command.Parameters.Add("@taiKhoan", SqlDbType.VarChar).Value = taiKhoan.TaiKhoan;
            command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
            command.Parameters.Add("@hoDem", SqlDbType.NVarChar).Value = taiKhoan.HoDem;
            command.Parameters.Add("@tenTV", SqlDbType.NVarChar).Value = taiKhoan.TenTV;
            command.Parameters.Add("@soDT", SqlDbType.VarChar).Value = taiKhoan.SoDT;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = taiKhoan.Email;
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = taiKhoan.DiaChi;
            command.Parameters.Add("@ghiChu", SqlDbType.NText).Value = taiKhoan.GhiChu;
            command.Parameters.Add("@maNhom", SqlDbType.Int).Value = taiKhoan.MaNhom;
            command.Parameters.Add("@maQH", SqlDbType.Int).Value = taiKhoan.MaQH;
            command.Parameters.Add("@ngaySinh", SqlDbType.DateTime2).Value = taiKhoan.NgaySinh;
            command.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = taiKhoan.GioiTinh ? 1 :0;
            command.Parameters.Add("@trangThai", SqlDbType.Bit).Value = taiKhoan.TrangThai ? 1 : 0;

            /*this.command.Parameters.AddWithValue("@taiKhoan", taiKhoan.TaiKhoan);
            this.command.Parameters.AddWithValue("@maKhau", taiKhoan.MatKhau);
            this.command.Parameters.AddWithValue("@maNhom", taiKhoan.MaNhom);
            this.command.Parameters.AddWithValue("@hoDem", taiKhoan.HoDem);
            this.command.Parameters.AddWithValue("@tenTV", taiKhoan.TenTV);
            this.command.Parameters.AddWithValue("@ngaySinh", taiKhoan.NgaySinh);
            this.command.Parameters.AddWithValue("@gioiTinh", taiKhoan.GioiTinh);
            this.command.Parameters.AddWithValue("@soDT", taiKhoan.SoDT);
            this.command.Parameters.AddWithValue("@email", taiKhoan.Email);
            this.command.Parameters.AddWithValue("@diaChi", taiKhoan.DiaChi);
            this.command.Parameters.AddWithValue("@maQH", taiKhoan.MaQH);
            this.command.Parameters.AddWithValue("@trangThai", taiKhoan.TrangThai);
            this.command.Parameters.AddWithValue("@ghiChu", taiKhoan.GhiChu);*/
            //SqlCommand command = con.CreateCommand();
            //command.CommandText = "INSERT INTO dbo.taiKhoanTV ( taiKhoan, matKhau,  hoDem,  tenTV, soDT, email, diaChi, ghiChu, maNhom, maQH, ngaySinh, gioiTinh, trangThai ) " +
            //   "values('"+taiKhoan.TaiKhoan+"', '"+taiKhoan.MatKhau+"', N'"+taiKhoan.HoDem+"', N'"+taiKhoan.TenTV+"', '"+taiKhoan.SoDT+"', '"+taiKhoan.Email+"', N'"+taiKhoan.DiaChi+"', N'"+taiKhoan.GhiChu+"', "+taiKhoan.MaNhom+", "+taiKhoan.MaQH+", "+taiKhoan.NgaySinh.ToString("yyyy-MM-dd")+", "+(taiKhoan.GioiTinh ? 1 : 0 )+", "+(taiKhoan.TrangThai ? 1 : 0)+")";

            MyMessage mess;
            try
            {
                int result = command.ExecuteNonQuery();
                mess = new MyMessage(result >= 0, (result >= 0 ? "Thêm Thành Công" : "Thất Bại"));
                //return command.ExecuteNonQuery() >= 0 ? "Thêm Thành Công Sản Phẩm " + sanPham.TenSP : "Thêm Đơn Hàng Không Thành Công";
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

        public MyMessage updateData(TaiKhoanTV taiKhoan)
        {
            SqlConnection con = new DAO().getConnection();


            try
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "UPDATE dbo.taiKhoanTV set maNhom=@maNhom, hoDem=@hoDem, tenTV=@tenTV, ngaySinh=@ngaysinh, gioiTinh=@gioiTinh, soDT=@soDT,email=@email,diaChi=@diaChi,maQH=@maQH,trangThai=@trangThai,ghiChu=@ghiChu WHERE taiKhoan=@taiKhoan";

                command.Parameters.Add("@taiKhoan", SqlDbType.VarChar).Value = taiKhoan.TaiKhoan;
                command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
                command.Parameters.Add("@hoDem", SqlDbType.NVarChar).Value = taiKhoan.HoDem;
                command.Parameters.Add("@tenTV", SqlDbType.NVarChar).Value = taiKhoan.TenTV;
                command.Parameters.Add("@soDT", SqlDbType.VarChar).Value = taiKhoan.SoDT;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = taiKhoan.Email;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = taiKhoan.DiaChi;
                command.Parameters.Add("@ghiChu", SqlDbType.NText).Value = taiKhoan.GhiChu;
                command.Parameters.Add("@maNhom", SqlDbType.Int).Value = taiKhoan.MaNhom;
                command.Parameters.Add("@maQH", SqlDbType.Int).Value = taiKhoan.MaQH;
                command.Parameters.Add("@ngaySinh", SqlDbType.DateTime2).Value = taiKhoan.NgaySinh;
                command.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = taiKhoan.GioiTinh ? 1 :0;
                command.Parameters.Add("@trangThai", SqlDbType.Bit).Value = taiKhoan.TrangThai ? 1 : 0;
                
                int result = command.ExecuteNonQuery();
                MyMessage message = new MyMessage(result >= 0, (result >= 0 ? "Sửa Đổi Thành Công" : "Sửa Đổi Thất Bại"));
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

        public MyMessage delectData(String taiKhoan)
        {
            SqlConnection con = new DAO().getConnection();
            try
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM dbo.taiKhoanTV WHERE taiKhoan=@taiKhoan";
                command.Parameters.Add("@taiKhoan", SqlDbType.VarChar).Value = taiKhoan;

                int result = command.ExecuteNonQuery();
                MyMessage message = new MyMessage(result >= 0, (result >= 0 ? "Xóa Thành Công" : "Xóa Không Thành Công"));
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
