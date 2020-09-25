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
namespace QLBH.View
{
    public partial class FormSP : Form
    {
        private SanPham sanPham;
        private bool options;
        private readonly MainForm mainForm;
        public FormSP(SanPham sanPham, bool options, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.sanPham = sanPham;
            this.options = options;
            this.loadData();
        }
        public void loadData()
        {
            this.txtGiaBan.Text = String.Format("{0:0,0}", this.sanPham.GiaBan);
            this.txtGiamGia.Text = this.sanPham.GiamGia.ToString();
            this.txtMaSP.Text = this.sanPham.MaSP;
            this.txtNdTomTat.Text = this.sanPham.NdTomTat;
            this.txtNgayDang.Text = this.sanPham.NgayDang.ToString("dd/MM/yyyy");
            this.txtNhaSX.Text = this.sanPham.NhaSanXuat;
            this.txtNoiDung.Text = this.sanPham.NoiDung;
            this.txtTenSP.Text = this.sanPham.TenSP;

            if (this.options)
            {
                this.btnSubmit.Text = "Thêm";
                this.txtMaSP.Enabled = true;
                this.showPlaceHolder();
            }
            else
            {
                this.btnSubmit.Text = "Cập nhật";
                this.txtMaSP.Enabled = false;
                this.hidePlaceHolder();
                
            }

            this.loadCBLoaiSP();
     //      this.loadCBQUanHuyen();
     //      this.loadCBNhomTK();
     //      this.loadGrvTaiKhoan("Select [taiKhoan], [matKhau], tk.[maNhom],[hoDem],[tenTV],[ngaysinh],[gioiTinh],[soDT],[email],[diaChi], tk.[maQH],[trangThai], tk.[ghiChu], qh.[tenQH],nhom.[tenNhom]from dbo.taiKhoanTV tk INNER JOIN nhomTk nhom on tk.maNhom = nhom.maNhom INNER JOIN quanHuyen qh on qh.maQH = tk.maQH");
        }
        public void loadCBLoaiSP()
        {
            this.cbLoaiSP.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT loaiSP, maLoai from dbo.loaiSP")).DefaultView;
            this.cbLoaiSP.DisplayMember = "loaiSP";
            if (options)
                this.cbLoaiSP.SelectedIndex = 0;
            else
                this.cbLoaiSP.SelectedIndex = this.sanPham.MaLoai - 1;
        }

        private void showPlaceHolder()
        {
            this.placeGiaBan.Visible = true;
            this.placeGiamGia.Visible = true;
            this.placeMaSP.Visible = true;
            this.placeNdTomTat.Visible = true;
            this.placeNhaSX.Visible = true;
            this.placeNoiDung.Visible = true;
            this.placeTenSP.Visible = true;
        }
        private void hidePlaceHolder()
        {
            this.placeGiaBan.Visible = false;
            this.placeGiamGia.Visible = false;
            this.placeMaSP.Visible = false;
            this.placeNdTomTat.Visible = false;
            this.placeNhaSX.Visible = false;
            this.placeNoiDung.Visible = false;
            this.placeTenSP.Visible = false;
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            switch (((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Name)
            {
                case "txtGiaBan":
                    if (this.txtGiaBan.Text == "")
                        this.placeGiaBan.Visible = true;
                    else
                        this.txtGiaBan.Text = String.Format("{0:0,0}", txtGiaBan.Text);
                    break;
                case "txtGiamGia":
                    if (this.txtGiamGia.Text == "")
                        this.placeGiamGia.Visible = true;
                    break;
                case "txtMaSP":
                    if (this.txtMaSP.Text == "")
                        this.placeMaSP.Visible = true;
                    break;
                case "txtNdTomTat":
                    if (this.txtNdTomTat.Text == "")
                        this.placeNdTomTat.Visible = true;
                    break;
                case "txtNhaSX":
                    if (this.txtNhaSX.Text == "")
                        this.placeNhaSX.Visible = true;
                    break;
                case "txtNoiDung":
                    if (this.txtNoiDung.Text == "")
                        this.placeNoiDung.Visible = true;
                    break;
                case "txtTenSP":
                    if (this.txtTenSP.Text == "")
                        this.placeTenSP.Visible = true;
                    break;
            }
        }
        private void placeHolderClick(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Visible = false;
            switch (((Bunifu.Framework.UI.BunifuCustomLabel)sender).Name)
            {

                case "placeGiaBan":
                    this.txtGiaBan.Focus();
                    break;
                case "placeGiamGia":
                    this.txtGiamGia.Focus();
                    break;
                case "placeMaSP":
                    this.txtMaSP.Focus();
                    break;
                case "placeNdTomTat":
                    this.txtNdTomTat.Focus();
                    break;
                case "placeNhaSX":
                    this.txtNhaSX.Focus();
                    break;
                case "placeNoiDung":
                    this.txtNoiDung.Focus();
                    break;
                case "placeTenSP":
                    this.txtTenSP.Focus();
                    break;
            }
        }
        private void richTextBox_Leave(object sender, EventArgs e)
        {
            if(((RichTextBox)sender).Name == "txtNoiDung")
            {
                if (this.txtNoiDung.Text == "")
                    this.placeNoiDung.Visible = true;
            }
            else
            {
                if (this.txtNdTomTat.Text == "")
                    this.placeNdTomTat.Visible = true;
            }
            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Hình Ảnh (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtHinhDD.Text = fileDialog.FileName;
                this.hinhDD.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void txtGiaBan_OnValueChanged(object sender, EventArgs e)
        {
            this.txtGiaBan.Text = String.Format("{0:0,0}", ((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.sanPham = new SanPham();
            this.options = true;
            this.loadData();
            this.showPlaceHolder();
        }

        private void ShowMessageBox(MyMessage message, bool messageIcon)
        {
            new MyMessageBox(message, messageIcon).ShowDialog();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String tenSP = this.txtTenSP.Text;
            String maSP = this.txtMaSP.Text;
            String ndTomTat = this.txtNdTomTat.Text;
            String noiDung = this.txtNoiDung.Text;
            String nhaSX = this.txtNhaSX.Text;
            DateTime ngayDang = this.options ? DateTime.Now : this.sanPham.NgayDang;
            Double giaBan = Double.Parse(this.txtGiaBan.Text);
            float  giamGia = float.Parse(this.txtGiamGia.Text);
            int maLoai = int.Parse(((DataRowView)(cbLoaiSP.SelectedItem))["maLoai"].ToString());
            SanPham sanPham = new SanPham(maSP, tenSP, "aaa", ndTomTat, nhaSX, ngayDang, maLoai, noiDung, "minh", giaBan, giamGia, false);


            MyMessage message = new MyMessage();
            DAOSanPham daoSP = new DAOSanPham();

            if (this.options)
                message =  new DAOSanPham().InsertData(sanPham);
            else
            {
                message = new DAOSanPham().updateData(sanPham);
            }

            this.ShowMessageBox(message, true);
            if (message.Status)
            {
                mainForm.loadDataSanPham();
                mainForm.loadDataGridView("sanPham");
                mainForm.loadListSanPham();
            }
                
            
        }

        private void btnAddLoaiSP_Click(object sender, EventArgs e)
        {
            new FormLoaiSP(new LoaiSanPham(), true, this).Show();
        }
    }
}
