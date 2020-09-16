using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Modal;
namespace QLBH.User_Controls
{
    public partial class User_Control_SanPham : UserControl
    {
        private SanPham sanPham;
        public User_Control_SanPham(SanPham sanPham)
        {
            this.sanPham = sanPham;
            InitializeComponent();
            this.txtTenSP.Text = this.sanPham.TenSP;
            this.txtSoLuong.Text = this.sanPham.GiamGia.ToString();
            this.txtNhaSX.Text = this.sanPham.NhaSanXuat;
            this.txtNoiDung.Text = this.sanPham.NoiDung;

        }

    }
}
