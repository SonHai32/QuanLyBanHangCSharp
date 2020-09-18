using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Modal;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLBH.Controller
{
    class DAOTaiKhoanTV
    {
        public MyMessage InsertData(TaiKhoanTV taiKhoan)
        {

            SqlConnection con = new DAO().getConnection();
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO dbo.taiKhoanTV ( taiKhoan, matKhau,  hoDem,  tenTV, soDT, email, diaChi, ghiChu, maNhom, maQH, ngaySinh, gioiTinh, trangThai ) " +
                "values('"+taiKhoan.TaiKhoan+"', '"+taiKhoan.MatKhau+"', N'"+taiKhoan.HoDem+"', N'"+taiKhoan.TenTV+"', '"+taiKhoan.SoDT+"', '"+taiKhoan.Email+"', N'"+taiKhoan.DiaChi+"', N'"+taiKhoan.GhiChu+"', "+taiKhoan.MaNhom+", "+taiKhoan.MaQH+", "+taiKhoan.NgaySinh.ToString("yyyy-MM-dd")+", "+(taiKhoan.GioiTinh ? 1 : 0 )+", "+(taiKhoan.TrangThai ? 1 : 0)+")";


            /* command.Parameters.AddWithValue("@maSP", sanPham.MaSP);
             command.Parameters.AddWithValue("@tenSP", sanPham.TenSP);
             command.Parameters.AddWithValue("@hinhDD", sanPham.HinhDD);
             command.Parameters.AddWithValue("@ndTomTat", sanPham.NdTomTat);
             command.Parameters.AddWithValue("@nhaSanXuat", sanPham.NhaSanXuat);
             command.Parameters.AddWithValue("@ngayDang", sanPham.NgayDang);
             command.Parameters.AddWithValue("@maLoai", sanPham.MaLoai);
             command.Parameters.AddWithValue("@noiDung", sanPham.NoiDung);
             command.Parameters.AddWithValue("@taiKhoan", sanPham.TaiKhoan);
             command.Parameters.AddWithValue("@giaBan", sanPham.GiaBan);
             command.Parameters.AddWithValue("@giamGia", sanPham.GiamGia);
             command.Parameters.AddWithValue("@daDuyet", sanPham.DaDuyet ? 1 : 0);*/

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

        public MyMessage updateData(SanPham sanPham)
        {
            SqlConnection con = new DAO().getConnection();

            try
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "UPDATE dbo.taiKhoanTV set tenSP = N'" + sanPham.TenSP + "', hinhDD = '" + sanPham.HinhDD + "',ndTomTat = N'" + sanPham.NdTomTat + "', nhaSanXuat = '" + sanPham.NhaSanXuat + "', ngayDang = " + sanPham.NgayDang.To("yyyy-MM-dd") + "" +
                ", " +
                "maLoai = " + sanPham.MaLoai + ", noiDung = N'" + sanPham.NoiDung + "', taiKhoan ='" + sanPham.TaiKhoan + "', giaBan =  " + sanPham.GiaBan + ", giamGia = " + sanPham.GiamGia + ", daDuyet =  " + (sanPham.DaDuyet ? 1 : 0) + "WHERE maSP ="+sanPham.MaSP+" ";
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

        public MyMessage delectData(TaiKhoanTV taiKhoan)
        {
            SqlConnection con = new DAO().getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM dbo.sanPham WHERE maSP = " + maSP + "";
                int result = cmd.ExecuteNonQuery();
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
