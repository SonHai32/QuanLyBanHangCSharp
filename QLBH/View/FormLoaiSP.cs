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

        private int currentSelectedIndex = -1;
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
            {
                this.btnSubmit.Text = "Thêm";
                this.EnablePlaceHolder();
            }
            else
            {
                this.btnSubmit.Text = "Sửa";
                this.disablePlaceHolder();
                if (this.loaiSanPham.GhiChu != "")
                    this.placeGhiChu.Visible = true;
            }

        }
        private  void disablePlaceHolder()
        {
            this.placeGhiChu.Visible = false; 
            this.placeTenLoai.Visible = false; 
        }
        private  void EnablePlaceHolder()
        {
            this.placeGhiChu.Visible = true; 
            this.placeTenLoai.Visible = true; 
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

        private void showMessageBox(MyMessage message, bool messageIcon)
        {
            new MyMessageBox(message, messageIcon).ShowDialog();
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

            this.showMessageBox(message, false);

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.loaiSanPham = new LoaiSanPham();
            this.options = true;
            this.loadData();
        }

        private void grvData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.currentSelectedIndex = e.RowIndex;
        }

        private void grvData_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(currentSelectedIndex >= 0)
            {
                this.loaiSanPham = new LoaiSanPham(
                    int.Parse(this.grvData.Rows[currentSelectedIndex].Cells["maLoai"].Value.ToString()),
                    this.grvData.Rows[currentSelectedIndex].Cells["loaiSP"].Value.ToString(),
                    this.grvData.Rows[currentSelectedIndex].Cells["ghiChu"].Value.ToString()
                );

                this.options = false;
                this.tabControl1.SelectedIndex = 0;
                this.loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> listSelected = grvData.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();

            String showMessage = "";
            int deleteedCount = 0;
            
            foreach(int index in listSelected)
            {

                LoaiSanPham loaiSP = new LoaiSanPham(
                    int.Parse(this.grvData.Rows[index].Cells["maLoai"].Value.ToString()),
                    this.grvData.Rows[index].Cells["loaiSP"].Value.ToString(),
                    this.grvData.Rows[index].Cells["ghiChu"].Value.ToString()
                );
                MyMessage message = new DAOLoaiSP().deleteData(loaiSP);
                if (message.Status)
                    deleteedCount++;

                showMessage += message.MessageText + "\n";
            }

            this.showMessageBox(new MyMessage(true, showMessage), false);
            this.loadGrvLoaiSP();
            this.formSP.loadCBLoaiSP();
                    
        }
    }
}
