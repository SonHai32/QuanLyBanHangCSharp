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
    public partial class FormNhomTK : Form
    {
        
        private NhomTK nhomTK;
        private bool options;
        private readonly FormTaiKhoan formTaiKhoan;

        private int currentSelectedIndex = -1;
        public FormNhomTK(NhomTK nhomTK,bool options, FormTaiKhoan formTaiKhoan)
        {
            InitializeComponent();
            this.nhomTK = nhomTK;
            this.options = options;
            this.formTaiKhoan = formTaiKhoan;
            this.loadGrvTenNhom();
            this.loadData();
        }

        private void loadGrvTenNhom()
        {
            this.grvData.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT * FROM nhomTk"));
        }

        private void loadData()
        {
            this.txtTenNhom.Text = this.nhomTK.TenNhom;
            this.txtGhiChu.Text = this.nhomTK.GhiChu;
            if (this.options)
            {
                this.btnSubmit.Text = "Thêm";
                this.EnablePlaceHolder();
            }
            else
            {
                this.btnSubmit.Text = "Sửa";
                this.disablePlaceHolder();
                if (this.nhomTK.GhiChu == "")
                    this.placeGhiChu.Visible = true;
            }

        }
        private  void disablePlaceHolder()
        {
            this.placeGhiChu.Visible = false; 
            this.placeTenNhom.Visible = false; 
        }
        private  void EnablePlaceHolder()
        {
            this.placeGhiChu.Visible = true; 
            this.placeTenNhom.Visible = true; 
        }
        private void richTextBox_Leave(object sender, EventArgs e)
        {
            if (this.txtGhiChu.Text == "")
                this.placeGhiChu.Visible = true;
        }
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (this.txtTenNhom.Text == "")
            this.placeTenNhom.Visible = true;
        }

        private void placeHolderClick(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Visible = false;
            switch (((Bunifu.Framework.UI.BunifuCustomLabel)sender).Name)
            {
                    
                case "placeGhiChu":
                    this.txtGhiChu.Focus();
                    break;
                case "placeTenNhom":
                    this.txtTenNhom.Focus();
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
            this.nhomTK = new NhomTK();
            this.options = true;
            this.loadData();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.nhomTK = new NhomTK();
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
                this.nhomTK = new NhomTK(this.txtTenNhom.Text, this.txtGhiChu.Text);
                message = new DAONhomTK().inserData(this.nhomTK);
            }
            else
            {
                this.nhomTK  = new NhomTK(this.nhomTK.MaNhom, this.txtTenNhom.Text, this.txtGhiChu.Text);
                message = new DAONhomTK().updateData(this.nhomTK);
            }

            this.showMessageBox(message, true);

            if (message.Status)
            {
                this.options = false;
                this.loadData();
                this.loadGrvTenNhom();
                this.formTaiKhoan.loadCBNhomTK(); 
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.nhomTK = new NhomTK();
            this.options = true;
            this.loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.nhomTK = new NhomTK();
            this.options = true;
            this.tabControl1.SelectedIndex = 0;
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
                this.nhomTK = new NhomTK(
                    int.Parse(this.grvData.Rows[currentSelectedIndex].Cells["maNhom"].Value.ToString()),
                    this.grvData.Rows[currentSelectedIndex].Cells["tenNhom"].Value.ToString(),
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

                NhomTK loaiSP = new NhomTK(
                    int.Parse(this.grvData.Rows[index].Cells["maNhom"].Value.ToString()),
                    this.grvData.Rows[index].Cells["tenNhom"].Value.ToString(),
                    this.grvData.Rows[index].Cells["ghiChu"].Value.ToString()
                );
                MyMessage message = new DAONhomTK().deleteData(loaiSP);
                if (message.Status)
                    deleteedCount++;

                showMessage += message.MessageText + "\n";
            }

            this.showMessageBox(new MyMessage(true, showMessage), false);
            this.loadGrvTenNhom();
            this.formTaiKhoan.loadCBNhomTK(); 
                    
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
