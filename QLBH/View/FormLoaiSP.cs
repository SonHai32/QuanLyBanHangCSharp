using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Controller;
using QLBH.Modal;
namespace QLBH.View
{
    public partial class FormLoaiSP : Form
    {
        private LoaiSanPham loaiSanPham;
        private bool options;
        private readonly FormSP formSP;
        public FormLoaiSP(LoaiSanPham loaiSanPham,bool options, FormSP formSP)
        {
            InitializeComponent();
            this.loaiSanPham = loaiSanPham;
            this.options = options;
            this.formSP = formSP;
            this.loadGrvLoaiSP();
            this.loadData();
        }

        private void loadGrvLoaiSP()
        {
            this.grvData.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT * FROM loaiSP"));
        }

        private void loadData()
        {
            this.txtTenLoai.Text = this.loaiSanPham.LoaiSP;
            this.txtGhiChu.Text = this.loaiSanPham.GhiChu;
            if (this.options)
                this.btnSubmit.Text = "Thêm";
            else
                this.btnSubmit.Text = "Sửa";
        }
        private void richTextBox_Leave(object sender, EventArgs e)
        {
            if (this.txtGhiChu.Text == "")
                this.placeGhiChu.Visible = true;
        }
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (this.txtTenLoai.Text == "")
            this.placeTenLoai.Visible = true;
        }

        private void placeHolderClick(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Visible = false;
            switch (((Bunifu.Framework.UI.BunifuCustomLabel)sender).Name)
            {
                    
                case "placeGhiChu":
                    this.txtGhiChu.Focus();
                    break;
                case "placeTenLoai":
                    this.txtTenLoai.Focus();
                    break;
            }
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnListTab_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.loaiSanPham = new LoaiSanPham();
            this.options = true;
            this.loadData();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.loaiSanPham = new LoaiSanPham();
            this.options = true;
            this.loadData();
        }

        private void showMessageBox(MyMessage message)
        {
            new MyMessageBox(message).ShowDialog();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MyMessage message = new MyMessage();
            if (options)
            {
                this.loaiSanPham = new LoaiSanPham(this.txtTenLoai.Text, this.txtGhiChu.Text);
                message = new DAOLoaiSP().inserData(this.loaiSanPham);
            }
            else
            {
                this.loaiSanPham  = new LoaiSanPham(this.loaiSanPham.MaLoai, this.txtTenLoai.Text, this.txtGhiChu.Text);
                message = new DAOLoaiSP().updateData(this.loaiSanPham);
            }

            this.showMessageBox(message);

            if (message.Status)
            {
                this.options = false;
                this.loadData();
                this.loadGrvLoaiSP();
                this.formSP.loadCBLoaiSP(); 
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.loaiSanPham = new LoaiSanPham();
            this.options = true;
            this.loadData();
        }
    }
}
