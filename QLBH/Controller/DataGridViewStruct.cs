using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Controller
{
    class DataGridViewStruct
    {

        // dbo.DonHang
        private Bunifu.Framework.UI.BunifuCustomDataGrid grv;
        private  DataGridViewColumn maKH = new DataGridViewTextBoxColumn();
        private DataGridViewColumn tenKH = new DataGridViewTextBoxColumn();
        private DataGridViewColumn ngayDat = new DataGridViewTextBoxColumn();
        private DataGridViewCheckBoxColumn daKichHoat = new DataGridViewCheckBoxColumn();
        private DataGridViewColumn soDH = new DataGridViewTextBoxColumn();
        private DataGridViewColumn ngayGH = new DataGridViewTextBoxColumn();
        private DataGridViewColumn diaChiGH = new DataGridViewTextBoxColumn();
        private DataGridViewColumn ghiChu = new DataGridViewTextBoxColumn();
        private DataGridViewColumn taiKhoan = new DataGridViewTextBoxColumn();


        // dbo.sanPham
        private DataGridViewColumn tenSP = new DataGridViewTextBoxColumn();
        private DataGridViewColumn loaiSP = new DataGridViewTextBoxColumn();
        private DataGridViewColumn noiDung = new DataGridViewTextBoxColumn();
        private DataGridViewColumn ndTomTat = new DataGridViewTextBoxColumn();
        private DataGridViewColumn maSP = new DataGridViewTextBoxColumn();
        private DataGridViewColumn maLoai = new DataGridViewTextBoxColumn();
        private DataGridViewCheckBoxColumn daDuyet = new DataGridViewCheckBoxColumn();
        private DataGridViewColumn hinhDD = new DataGridViewTextBoxColumn();
        private DataGridViewColumn giaBan = new DataGridViewTextBoxColumn();
        private DataGridViewColumn ngayDang = new DataGridViewTextBoxColumn();
        private DataGridViewColumn giamGia = new DataGridViewTextBoxColumn();
        private DataGridViewColumn nhaSanXuat = new DataGridViewTextBoxColumn();


        //dbo.taiKhoan

       private DataGridViewColumn matKhau  = new DataGridViewTextBoxColumn();         
       private DataGridViewColumn maNhom = new DataGridViewTextBoxColumn();
       private DataGridViewColumn hoDem = new DataGridViewTextBoxColumn();
       private DataGridViewColumn tenTV = new DataGridViewTextBoxColumn();
       private DataGridViewColumn ngaysinh = new DataGridViewTextBoxColumn();
       private DataGridViewColumn gioiTinh = new DataGridViewCheckBoxColumn();
       private DataGridViewColumn soDT = new DataGridViewTextBoxColumn();
       private DataGridViewColumn email = new DataGridViewTextBoxColumn();
       private DataGridViewColumn diaChi = new DataGridViewTextBoxColumn();
       private DataGridViewColumn maQH = new DataGridViewTextBoxColumn(); 
       private DataGridViewCheckBoxColumn trangThai = new DataGridViewCheckBoxColumn();

        public DataGridViewStruct(Bunifu.Framework.UI.BunifuCustomDataGrid grv)
        {
            this.grv = grv;
            ///
            ///taiKhoan
            ///
            taiKhoan.HeaderText = "Tài Khoản";
            taiKhoan.MinimumWidth = 6;
            taiKhoan.Name = "taiKhoan";
            taiKhoan.ReadOnly = true;
            ///
            ///tenKh
            ///
            tenKH.DataPropertyName = "tenKH";
            tenKH.HeaderText = "Tên Khách Hàng";
            tenKH.MinimumWidth = 6;
            tenKH.Name = "tenKH";
            tenKH.ReadOnly = true;
            tenKH.Visible = true;

            // 
            // soDH
            //
            soDH.DataPropertyName = "soHD";
            soDH.HeaderText = "Số Hóa Đơn";
            soDH.MinimumWidth = 6;
            soDH.Name = "soHD";
            soDH.ReadOnly = true;
            // 
            // maKH
            // 
            maKH.DataPropertyName = "maKH";
            maKH.HeaderText = "Mã Khách Hàng";
            maKH.MinimumWidth = 36;
            maKH.Name = "maKH";
            maKH.ReadOnly = true;
            // 
            // tenKH
            // 
            tenKH.DataPropertyName = "tenKH";
            tenKH.HeaderText = "Tên Khách Hàng";
            tenKH.MinimumWidth = 6;
            tenKH.Name = "tenKH";
            tenKH.ReadOnly = true;
            tenKH.Visible = true;
            // 
            // ngayDat
            // 
            ngayDat.DataPropertyName = "ngayDat";
            ngayDat.HeaderText = "Ngày Đặt";
            ngayDat.MinimumWidth = 6;
            ngayDat.Name = "ngayDat";
            ngayDat.ReadOnly = true;
            ngayDat.Visible = false;
            // 
            // ngayGH
            // 
            ngayGH.DataPropertyName = "ngayGH";
            ngayGH.HeaderText = "Ngày Giao Hàng";
            ngayGH.MinimumWidth = 6;
            ngayGH.Name = "ngayGH";
            ngayGH.ReadOnly = true;
            // 
            // diaChiGH
            // 
            diaChiGH.DataPropertyName = "diaChiGH";
            diaChiGH.HeaderText = "Địa Chỉ GH";
            diaChiGH.MinimumWidth = 6;
            diaChiGH.Name = "diaChiGH";
            diaChiGH.ReadOnly = true;
            // 
            // daKichHoat
            // 
            daKichHoat.DataPropertyName = "daKichHoat";
            daKichHoat.FalseValue = "0";
            daKichHoat.HeaderText = "Đã Kích Hoạt";
            daKichHoat.MinimumWidth = 6;
            daKichHoat.Name = "daKichHoat";
            daKichHoat.ReadOnly = true;
            daKichHoat.TrueValue = "1";

            // 
            // ghiChu
            // 
            ghiChu.DataPropertyName = "ghiChu";
            ghiChu.HeaderText = "Ghi Chú";
            ghiChu.MinimumWidth = 6;
            ghiChu.Name = "ghiChu";
            ghiChu.ReadOnly = true;
            ghiChu.Visible = true;


            maSP.DataPropertyName = "maSP";
            maSP.HeaderText = "Mã SP";
            maSP.MinimumWidth = 6;
            maSP.Name = "maSP";
            maSP.ReadOnly = true;
            maSP.Visible = false;
            // 
            // tenSP
            // 
            tenSP.DataPropertyName = "tenSP";
            tenSP.HeaderText = "Tên Sản Phẩm";
            tenSP.MinimumWidth = 36;
            tenSP.Name = "tenSP";
            tenSP.ReadOnly = true;
            // 
            // loaiSP
            // 
            loaiSP.DataPropertyName = "loaiSP";
            loaiSP.HeaderText = "Loại SP";
            loaiSP.MinimumWidth = 6;
            loaiSP.Name = "loaiSP";
            loaiSP.ReadOnly = true;
            loaiSP.Visible = true;
            // 
            // noiDung
            // 
            noiDung.DataPropertyName = "noiDung";
            noiDung.HeaderText = "Nội Dung";
            noiDung.MinimumWidth = 6;
            noiDung.Name = "noiDung";
            noiDung.ReadOnly = true;
            noiDung.Visible = false;
            // 
            // ndTomTat
            // 
            ndTomTat.DataPropertyName = "ndTomTat";
            ndTomTat.HeaderText = "ND Tóm Tắt";
            ndTomTat.MinimumWidth = 6;
            ndTomTat.Name = "ndTomTat";
            ndTomTat.ReadOnly = true;
            ndTomTat.Visible = false;
            // 
            // maSP
            // 
            // 
            // maLoai
            // 
            maLoai.DataPropertyName = "maLoai";
            maLoai.HeaderText = "Mã Loại";
            maLoai.MinimumWidth = 6;
            maLoai.Name = "maLoai";
            maLoai.ReadOnly = true;
            maLoai.Visible = false;
            // 
            // daDuyet
            // 
            daDuyet.DataPropertyName = "daDuyet";
            daDuyet.FalseValue = "0";
            daDuyet.HeaderText = "Đã Duyệt";
            daDuyet.MinimumWidth = 6;
            daDuyet.Name = "daDuyet";
            daDuyet.ReadOnly = true;
            daDuyet.TrueValue = "1";
            daDuyet.Visible = false;
            // 
            // hinhDD
            // 
            hinhDD.DataPropertyName = "hinhDD";
            hinhDD.HeaderText = "Hình Minh Họa";
            hinhDD.MinimumWidth = 6;
            hinhDD.Name = "hinhDD";
            hinhDD.ReadOnly = true;
            hinhDD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            hinhDD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            hinhDD.Visible = false;
            // 
            // giaBan
            // 
            giaBan.DataPropertyName = "giaBan";
            giaBan.HeaderText = "Giá Bán";
            giaBan.MinimumWidth = 6;
            giaBan.Name = "giaBan";
            giaBan.ReadOnly = true;
            // 
            // ngayDang
            // 
            ngayDang.DataPropertyName = "ngayDang";
            ngayDang.HeaderText = "Ngày Đăng";
            ngayDang.MinimumWidth = 6;
            ngayDang.Name = "ngayDang";
            ngayDang.ReadOnly = true;
            // 
            // taiKhoan
            // 
            taiKhoan.DataPropertyName = "taiKhoan";
            taiKhoan.HeaderText = "Tài Khoản";
            taiKhoan.MinimumWidth = 6;
            taiKhoan.Name = "taiKhoan";
            taiKhoan.ReadOnly = true;
            taiKhoan.Visible = false;
            // 
            // giamGia
            // 
            giamGia.DataPropertyName = "giamGia";
            giamGia.HeaderText = "Giảm Giá";
            giamGia.MinimumWidth = 6;
            giamGia.Name = "giamGia";
            giamGia.ReadOnly = true;
            // 
            // nhaSanXuat
            // 
            nhaSanXuat.DataPropertyName = "nhaSanXuat";
            nhaSanXuat.HeaderText = "Nhà Sản Xuất";
            nhaSanXuat.MinimumWidth = 6;
            nhaSanXuat.Name = "nhaSanXuat";
            nhaSanXuat.ReadOnly = true;
            nhaSanXuat.Visible = true;
          
            
            ///dbo.taiKhoanTK
            matKhau.DataPropertyName = "matKhau";
            matKhau.HeaderText = "Mật khẩu";
            matKhau.MinimumWidth = 6;
            matKhau.Name = "matKhau";
            matKhau.ReadOnly = true;
            matKhau.Visible = false;

            maNhom.DataPropertyName = "maNhom";
            maNhom.HeaderText = "Mã Nhóm";
            maNhom.MinimumWidth = 6;
            maNhom.Name = "maNhom";
            maNhom.ReadOnly = true;
            maNhom.Visible = false;

            hoDem.DataPropertyName = "hoDem";
            hoDem.HeaderText = "Họ Đệm";
            hoDem.MinimumWidth = 6;
            hoDem.Name = "hoDem";
            hoDem.ReadOnly = true;
            hoDem.Visible = false;

            tenTV.DataPropertyName = "tenTV";
            tenTV.HeaderText = "Tên TV";
            tenTV.MinimumWidth = 6;
            tenTV.Name = "tenTV";
            tenTV.ReadOnly = true;
            tenTV.Visible = false;

            ngaysinh.DataPropertyName = "ngaySinh";
            ngaysinh.HeaderText = "Ngày Sinh";
            ngaysinh.MinimumWidth = 6;
            ngaysinh.Name = "ngaySinh";
            ngaysinh.ReadOnly = true;
            ngaysinh.Visible = false;

            gioiTinh.DataPropertyName = "gioiTinh";
            gioiTinh.HeaderText = "Giới Tính";
            gioiTinh.MinimumWidth = 6;
            gioiTinh.Name = "gioiTinh";
            gioiTinh.ReadOnly = true;
            gioiTinh.Visible = false;

            soDT.DataPropertyName = "soDT";
            soDT.HeaderText = "Số DT";
            soDT.MinimumWidth = 6;
            soDT.Name = "soDT";
            soDT.ReadOnly = true;
            soDT.Visible = false;

            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Visible = false;

            diaChi.DataPropertyName = "diaChi";
            diaChi.HeaderText = "Địa Chỉ";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            diaChi.Visible = false;

            maQH.DataPropertyName = "maQH";
            maQH.HeaderText = "Mã Quận Huyện`";
            maQH.MinimumWidth = 6;
            maQH.Name = "maQH";
            maQH.ReadOnly = true;
            maQH.Visible = false;

            trangThai.DataPropertyName = "trangThai";
            trangThai.HeaderText = "Trạng Thái";
            trangThai.MinimumWidth = 6;
            trangThai.Name = "trangThai";
            trangThai.ReadOnly = true;
            trangThai.Visible = false;
            trangThai.TrueValue = "1";
            trangThai.FalseValue = "0";
        }
        public Bunifu.Framework.UI.BunifuCustomDataGrid grvDonHang()
        {
            
            


            this.grv.Columns.AddRange(new DataGridViewColumn[] {
            soDH
            ,maKH
            ,taiKhoan
            ,ngayDat
            ,daKichHoat
            ,ngayGH
            ,diaChiGH
            ,ghiChu
            
            });
            return this.grv;
        }
        public Bunifu.Framework.UI.BunifuCustomDataGrid grvSanPham()
        {
            


            this.grv.Columns.AddRange(new DataGridViewColumn[] {
                tenSP,
                giaBan,
                loaiSP,
                giamGia,
                noiDung,
                ndTomTat,
                maSP,
                maLoai,
                daDuyet,
                hinhDD,
                ngayDang,
                taiKhoan,
                nhaSanXuat,
            });

            return this.grv;
        }
    }
}
