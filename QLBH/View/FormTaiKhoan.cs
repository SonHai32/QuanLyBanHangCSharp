using System;
using System.Collections;
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
    public partial class FormTaiKhoan : Form
    {

        private ArrayList listSeleted = new ArrayList();
        private TaiKhoanTV taiKhoan;
        private bool options;
        private int currentRowSelect = -1;
        public FormTaiKhoan(TaiKhoanTV taiKhoan, bool options)
        {
            this.taiKhoan = taiKhoan;
            this.options = options;

            InitializeComponent();
            cbGioiTinh.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            loadData();
            this.tabControl1.SelectedIndex = 1;
        }

        private void loadData()
        {
            this.txtDiaChi.Text = this.taiKhoan.DiaChi;
            this.txtEmail.Text = this.taiKhoan.Email;
            this.txtGhiChu.Text = this.taiKhoan.GhiChu;
            this.txtHoDem.Text = this.taiKhoan.HoDem;
            this.txtTen.Text = this.taiKhoan.TenTV;
            this.txtTaiKhoan.Text = this.taiKhoan.TaiKhoan;
            this.txtMatKhau.Text = this.taiKhoan.MatKhau;
            this.txtSoDT.Text = this.taiKhoan.SoDT;
            this.cbGioiTinh.SelectedIndex = this.taiKhoan.GioiTinh ? 1 : 0;
            this.cbTrangThai.SelectedIndex = this.taiKhoan.TrangThai ? 1 : 0;

            if (this.options)
            {
                this.btnSubmit.Text = "Thêm";
                this.placeDiaChi.Visible = true;
                this.placeEmail.Visible = true;
                this.placeGhiChu.Visible = true;
                this.placeHoDem.Visible = true;
                this.placeMatKhau.Visible = true;
                this.placeSoDT.Visible = true;
                this.placeTaiKhoan.Visible = true;
                this.placeTen.Visible = true;
            }
            else
            {
                this.btnSubmit.Text = "Cập nhật";

                this.placeDiaChi.Visible = false;
                this.placeEmail.Visible = false;
                this.placeGhiChu.Visible = false;
                this.placeHoDem.Visible = false;
                this.placeMatKhau.Visible = false;
                this.placeSoDT.Visible = false;
                this.placeTaiKhoan.Visible = false;
                this.placeTen.Visible = false;
                this.txtTaiKhoan.Enabled = false;
            }
            this.loadCBQUanHuyen();
            this.loadCBNhomTK();
            this.loadGrvTaiKhoan("Select [taiKhoan], [matKhau], tk.[maNhom],[hoDem],[tenTV],[ngaysinh],[gioiTinh],[soDT],[email],[diaChi], tk.[maQH],[trangThai], tk.[ghiChu], qh.[tenQH],nhom.[tenNhom]from dbo.taiKhoanTV tk INNER JOIN nhomTk nhom on tk.maNhom = nhom.maNhom INNER JOIN quanHuyen qh on qh.maQH = tk.maQH");
        }


        private void loadGrvTaiKhoan(String query)
        {
            this.grvTaiKhoan.DataSource = new DAO().getDataSource(new DAO().getDataAdapter(query));
        }
        private void loadCBQUanHuyen()
        {

            this.cbQuanHuyen.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT maQH, tenQH from dbo.quanHuyen")).DefaultView;
            this.cbQuanHuyen.DisplayMember = "tenQH";
            this.cbQuanHuyen.ValueMember = "maQH";

            this.cbQuanHuyen.SelectedIndex = this.taiKhoan.MaQH - 1;
        }
        private void loadCBNhomTK()
        {

            this.cbNhomTK.DataSource = new DAO().getDataSource(new DAO().getDataAdapter("SELECT maNhom, tenNhom from dbo.nhomTk")).DefaultView;
            this.cbNhomTK.DisplayMember = "tenNhom";
            this.cbNhomTK.ValueMember = "maNhom";

            this.cbNhomTK.SelectedIndex = this.taiKhoan.MaNhom - 1;
        }
        
        private void richTextBox_Leave(object sender, EventArgs e)
        {
            if (this.txtGhiChu.Text == "")
                this.placeGhiChu.Visible = true;
        }
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            switch (((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Name)
            {

                case "txtHoDem":
                    if (this.txtHoDem.Text == "")
                        this.placeHoDem.Visible = true;
                    break;
                case "txtTen":
                    if (this.txtTen.Text == "")
                        this.placeTen.Visible = true;
                    break;
                case "txtDiaChi":
                    if (this.txtDiaChi.Text == "")
                        this.placeDiaChi.Visible = true;
                    break;
                case "txtMatKhau":
                    if (this.txtMatKhau.Text == "")
                        this.placeMatKhau.Visible = true;
                    break;
                case "txtTaiKhoan":
                    if (this.txtTaiKhoan.Text == "")
                        this.placeTaiKhoan.Visible = true;
                    break;
                case "txtEmail":
                    if (this.txtEmail.Text == "")
                        this.placeEmail.Visible = true;
                    break;
                case "txtSoDT":
                    if (this.txtSoDT.Text == "")
                        this.placeSoDT.Visible = true;
                    break;
                case "txtGhiChu":
                    if (this.txtGhiChu.Text == "")
                        this.placeGhiChu.Visible = true;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void placeHolderClick(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Visible = false;
            switch (((Bunifu.Framework.UI.BunifuCustomLabel)sender).Name)
            {

                case "placeHoDem":
                    this.txtHoDem.Focus();
                    break;
                case "placeTen":
                    this.txtTen.Focus();
                    break;
                case "placeDiaChi":
                    this.txtDiaChi.Focus();
                    break;
                case "placeMatKhau":
                    this.txtMatKhau.Focus();
                    break;
                case "placeTaiKhoan":
                    this.txtTaiKhoan.Focus();
                    break;
                case "placeEmail":
                    this.txtEmail.Focus();
                    break;
                case "placeSoDT":
                    this.txtSoDT.Focus();
                    break;
                case "placeGhiChu":
                    this.txtGhiChu.Focus();
                    break;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.taiKhoan = new TaiKhoanTV();
            this.options = true;
            this.loadData();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TaiKhoanTV tk = new TaiKhoanTV(
            txtTaiKhoan.Text,
            txtMatKhau.Text,
            txtHoDem.Text,
            txtTen.Text,
            txtSoDT.Text,
            txtEmail.Text,
            txtDiaChi.Text,
            txtGhiChu.Text,
            int.Parse(((DataRowView)cbNhomTK.SelectedItem)["maNhom"].ToString()),
            int.Parse(((DataRowView)cbQuanHuyen.SelectedItem)["maQH"].ToString()),
            DateTime.Parse(this.txtNgaySinh.Value.ToString()),
            cbGioiTinh.SelectedIndex == 1 ? true : false,
            cbTrangThai.SelectedIndex == 1 ? true : false
            );
            if (this.options)
                this.showMessageBox(new DAOTaiKhoanTV().InsertData(tk));
            else
                this.showMessageBox(new DAOTaiKhoanTV().updateData(tk));

            this.taiKhoan = tk;
            this.options = true;
            this.loadData();
        }

        private void showMessageBox(MyMessage message)
        {
            new MyMessageBox(message).ShowDialog();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.taiKhoan = new TaiKhoanTV();
            this.tabControl1.SelectedIndex = 0;
            this.options = true;
            this.loadData();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentRowSelect >= 0)
            {
                DataGridViewRow currentDataGrv = this.grvTaiKhoan.Rows[currentRowSelect];
                this.taiKhoan = new TaiKhoanTV(
                    currentDataGrv.Cells["taiKhoanTV"].Value.ToString(),
                    currentDataGrv.Cells["matKhau"].Value.ToString(),
                    currentDataGrv.Cells["hoDem"].Value.ToString(),
                    currentDataGrv.Cells["tenTV"].Value.ToString(),
                    currentDataGrv.Cells["soDT"].Value.ToString(),
                    currentDataGrv.Cells["email"].Value.ToString(),
                    currentDataGrv.Cells["diaChi"].Value.ToString(),
                    currentDataGrv.Cells["ghiChu"].Value.ToString(),
                    int.Parse(currentDataGrv.Cells["maNhom"].Value.ToString()),
                    int.Parse(currentDataGrv.Cells["maQH"].Value.ToString()),
                    DateTime.Parse(currentDataGrv.Cells["ngaySinh"].Value.ToString()),
                    bool.Parse(currentDataGrv.Cells["gioiTinh"].Value.ToString()),
                    bool.Parse(currentDataGrv.Cells["trangThai"].Value.ToString())
               );
                Console.WriteLine(listSeleted.Count);

                this.options = false;
                this.tabControl1.SelectedIndex = 0;
                this.loadData();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> listSelected = grvTaiKhoan.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();

            int deletedData = 0;
            string errorMessage = "";

            foreach (int x in listSelected)
            {
                try
                {
                    DAOTaiKhoanTV dao = new DAOTaiKhoanTV();
                    if(dao.delectData(grvTaiKhoan.Rows[x].Cells["taiKhoanTV"].Value.ToString()).Status)
                        deletedData++;
                }
                catch (Exception ex)
                {
                    errorMessage += ex;
                }


            }
            if (deletedData > 0)
            {
                this.showMessageBox(new MyMessage(true, "" + deletedData + " Tài khoản đã được xóa"));
                this.taiKhoan = new TaiKhoanTV();
                this.loadData();
            }
            if(listSelected.Count != deletedData)
                new MyMessageBox(new MyMessage(false, "Có lỗi xảy ra !!!\nXóa thất bại\n"+errorMessage+"")).ShowDialog();
        }
       
    }
}
