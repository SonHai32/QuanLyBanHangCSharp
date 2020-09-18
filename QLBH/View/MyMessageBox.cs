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
        public MyMessageBox(MyMessage mess)
        {
            
            this.mess = mess;
            InitializeComponent();
            this.lblMessage.Text = mess.MessageText;
            this.lblStatus.Text = mess.Status ? "SUCCESS" : "FAIL"; 
            if(mess.Status)
                this.pictureBox1.Image = global::QLBH.Properties.Resources.smile__1_;
            else
                this.pictureBox1.Image = global::QLBH.Properties.Resources.sad__1_;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
