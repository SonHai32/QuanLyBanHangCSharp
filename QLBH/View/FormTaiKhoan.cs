using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.View
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
        }

        private void richTextBox_Leave(object sender, EventArgs e)
        {
            if (this.txtGhiChu.Text == "")
                this.placeGhiChu.Visible = true;
        }
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
           switch(((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Name)
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
                    case "txtNhapLaiMK":
                        if (this.txtNhapLaiMK.Text == "")
                            this.placeNhapLaiMK.Visible = true;
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
            switch(((Bunifu.Framework.UI.BunifuCustomLabel)sender).Name)
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
                    case "placeNhapLaiMK":
                            this.txtNhapLaiMK.Focus();
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
    }
}
