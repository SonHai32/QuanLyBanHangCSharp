using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLBH.Modal;
using QLBH.Controller;
using QLBH.View;
using QLBH.Forms;

namespace QLBH.Forms
{
    public partial class FormSanPham : Form
    {
        private SanPham sanPham;
        private String option;
        
        private readonly MainForm mainForm;
        public FormSanPham(SanPham sp, String option, MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.sanPham = sp;
            this.option = option;

            InitializeComponent();
            if (this.option == "UPDATE")
            {
                this.txtMaSP.Enabled = false;
                this.btnSubmit.ButtonText = "Cập Nhật";
            }
            else
                this.btnSubmit.ButtonText = "Thêm";
            this.loadLoaiSP();
        }


        /// <summary>
        /// Load Data for combobox loaiSP
        /// </summary>
        private void loadLoaiSP()
        {
            this.cbLoaiSP.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT loaiSP, maLoai from dbo.loaiSP")).DefaultView;
            this.cbLoaiSP.DisplayMember = "loaiSP";
            this.cbLoaiSP.SelectedIndex = this.sanPham.MaLoai - 1;
            this.txtGiaBan.Text = this.sanPham.GiaBan.ToString();
            this.txtGiamGia.Text = this.sanPham.GiamGia.ToString();
            this.txtHinhDD.Text = this.sanPham.HinhDD;
            this.txtMaSP.Text = this.sanPham.MaSP;
            this.txtNDTomTat.Text = this.sanPham.NdTomTat;
            this.txtNoiDung.Text = this.sanPham.NoiDung;
            this.txtTenSP.Text = this.sanPham.TenSP;
            this.txtNhaSX.Text = this.sanPham.NhaSanXuat;
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Hình Ảnh (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtHinhDD.Text = fileDialog.FileName;
                this.pictureBox1.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String tenSP = this.txtTenSP.Text;
            String maSP = this.txtMaSP.Text;
            String ndTomTat = this.txtNDTomTat.Text;
            String noiDung = this.txtNoiDung.Text;
            String nhaSX = this.txtNhaSX.Text;
            DateTime ngayDang = DateTime.Now;
            Double giaBan = Double.Parse(this.txtGiaBan.Text);
            float  giamGia = float.Parse(this.txtGiamGia.Text);
            int maLoai = int.Parse(((DataRowView)(cbLoaiSP.SelectedItem))["maLoai"].ToString());


            MyMessage mess;

            SanPham sanPham = new SanPham(maSP, tenSP, "aaa", ndTomTat, nhaSX, ngayDang, maLoai, noiDung, "minh", giaBan, giamGia, false);
            DAOSanPham daoSP = new DAOSanPham();

            if(this.option == "ADD")
            {

            //MessageBox.Show(daoSP.InsertData(sanPham), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                mess = daoSP.updateData(sanPham);
                new MyMessageBox(mess).ShowDialog();
                if (mess.Status)
                {
                    mainForm.loadDataGridView("sanPham");
                    mainForm.loadDataSanPham();
                }    
            }
        }

        private void controlClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNDTomTat_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtHinhDD_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNhaSX_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
