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
using QLBH.Forms;
using QLBH.View;
using QLBH.Controller;
namespace QLBH.User_Controls
{
    public partial class User_Control_SanPham : UserControl
    {
        private SanPham sanPham;
        private MainForm mainForm;
        public User_Control_SanPham(SanPham sanPham, MainForm mainForm)
        {
            this.sanPham = sanPham;
            this.mainForm = mainForm;
            InitializeComponent();
            this.txtTenSP.Text = this.sanPham.TenSP;
            this.txtSoLuong.Text = this.sanPham.GiamGia.ToString();
            this.txtNhaSX.Text = this.sanPham.NhaSanXuat;
            this.txtNoiDung.Text = this.sanPham.NoiDung;

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

            new FormSanPham(sanPham, "UPDATE", this.mainForm).ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new MyMessageBox(new DAOSanPham().delectData(this.sanPham.MaSP)).ShowDialog();
            this.mainForm.loadDataGridView("sanPham");
            this.mainForm.loadListSanPham();
            this.mainForm.loadDataSanPham();

        }
    }
}
