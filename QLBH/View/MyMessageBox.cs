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

namespace QLBH.View
{
    public partial class MyMessageBox : Form
    {
        MyMessage mess;
        public MyMessageBox(MyMessage mess, bool messageIcon)
        {

            InitializeComponent();
            this.lblStatus.Text = "THÔNG TIN";
            this.txtMessage.Text = mess.MessageText;
            this.mess = mess;
            if (messageIcon)
            {
                this.lblStatus.Text = mess.Status ? "THÀNH CÔNG" : "THẤT BẠI";

                if(mess.Status)
                {
                    this.pictureBox1.Image = global::QLBH.Properties.Resources.smile__2_;
                    this.mainPane.GradientBottomLeft = Color.FromArgb(156, 220, 120);
                    this.mainPane.GradientBottomRight = Color.FromArgb(123, 220, 168);
                    this.mainPane.GradientTopLeft = Color.FromArgb(156, 220, 120);
                    this.mainPane.GradientTopRight = Color.FromArgb(147, 220, 134);
                }
                else
                {
                    this.pictureBox1.Image = global::QLBH.Properties.Resources.sad__2_;
                    this.mainPane.GradientBottomLeft = Color.FromArgb(255, 189, 158);
                    this.mainPane.GradientBottomRight = Color.FromArgb(255, 145, 158);
                    this.mainPane.GradientTopLeft = Color.FromArgb(255, 148, 158);
                    this.mainPane.GradientTopRight = Color.FromArgb(255, 142, 158);
                }

            }

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
