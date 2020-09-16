using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;

using QLBH.Modal;
using QLBH.Controller;
using QLBH.Forms;


namespace QLBH
{
    public partial class MainForm : Form 
    {

        private struct lightColor{
            public static Color color1 = Color.FromArgb(36, 29, 60); 
            public static Color color2 = Color.FromArgb(56, 50, 86); 
            public static Color color3 = Color.FromArgb(111, 108, 114); 
        }
        //
        class CustomTabControl : TabControl
        {
            protected override void WndProc(ref Message m)
            {
                // Hide tabs by trapping the TCM_ADJUSTRECT message
                if (m.Msg == 0x1328 && !DesignMode)
                    m.Result = (IntPtr)1;
                else
                    base.WndProc(ref m);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.grvData = new DataGridViewStruct(this.grvData).grvSanPham();
            // set default active button
            this.activeButton(this.btnSanPham);

            string sqlCommand = "SELECT tenSP,L.loaiSP,noiDung,ndTomTat,maSP,L.maLoai,daDuyet,hinhDD,giaBan,ngayDang,taiKhoan,giamGia,nhaSanXuat FROM sanPham SP INNER JOIN loaiSP L ON SP.maLoai = L.maLoai";
            loadDataSanPham(sqlCommand);
            loadDataGridView();
        }


        public void loadDataGridView()
        {
            string sqlCommand = "SELECT tenSP,L.loaiSP,noiDung,ndTomTat,maSP,L.maLoai,daDuyet,hinhDD,giaBan,ngayDang,taiKhoan,giamGia,nhaSanXuat FROM sanPham SP INNER JOIN loaiSP L ON SP.maLoai = L.maLoai";
            DAO dao = new DAO();
            this.grvData.DataSource = dao.getDataSource(dao.getDataAdapter(sqlCommand));
        }

        //add dataBase schema
        public void loadDataSanPham(String query)
        {
            var result = new DAO().sqlReader(query);
            ArrayList dataList = new ArrayList();
            while (result.Read())
            {
                SanPham sanPham = new SanPham(
                    result["maSP"].ToString(),
                    result["tenSP"].ToString(),
                    result["hinhDD"].ToString(),
                    result["ndTomTat"].ToString(),
                    result["nhaSanXuat"].ToString(),
                    DateTime.Parse(result["ngayDang"].ToString()),
                    int.Parse(result["maLoai"].ToString()),
                    result["noiDung"].ToString(),
                    result["taiKhoan"].ToString(),
                    double.Parse(result["giaBan"].ToString()),
                    float.Parse(result["giamGia"].ToString()),
                    result["daDuyet"].ToString() == "1" ? true : false
                    );
                dataList.Add(sanPham);
            }

            foreach (SanPham sanPham in dataList)
            {
                QLBH.User_Controls.User_Control_SanPham sp = new QLBH.User_Controls.User_Control_SanPham(sanPham);
                sp.Dock = System.Windows.Forms.DockStyle.Top;
                sp.Name = "sanPham" + sanPham.MaSP;

                Panel line = new Panel();
                line.Size = new Size(200, 1);
                line.BackColor = Color.FromArgb(0, 0, 0);
                line.Dock = DockStyle.Top;

                tpSanPham1.Controls.Add(sp);
                tpSanPham1.Controls.Add(line);
            }


        }


        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }


        private void activeButton(Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            this.activeBorder.Location = new Point(this.activeBorder.Location.X, btn.Location.Y);
            defaultButton();
            btn.Normalcolor = lightColor.color2; 
        }

        private void defaultButton()
        {
            this.btnBaiViet.Normalcolor = lightColor.color1;
            this.btnDonHang.Normalcolor = lightColor.color1;
            this.btnSanPham.Normalcolor = lightColor.color1;
            this.btnKhachHang.Normalcolor = lightColor.color1;
            this.btnCaiDat.Normalcolor = lightColor.color1;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            this.tabControl1.SelectedIndex = 2;
        }

        private void btnBaiViet_Click(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnCaiDat_Click_1(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void controlHide_MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("Thu nhỏ", (PictureBox)sender);
        }

        private void controlClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("Thoát", (PictureBox)sender);
        }

        private void controlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow currentDataGrv = this.grvData.Rows[e.RowIndex];


                SanPham sp = new SanPham(
                    currentDataGrv.Cells["maSP"].Value.ToString(),
                    currentDataGrv.Cells["tenSP"].Value.ToString(),
                    currentDataGrv.Cells["hinhDD"].Value.ToString(),
                    currentDataGrv.Cells["ndTomTat"].Value.ToString(),
                    currentDataGrv.Cells["nhaSanXuat"].Value.ToString(),
                    DateTime.Parse(currentDataGrv.Cells["ngayDang"].Value.ToString()),
                    int.Parse(currentDataGrv.Cells["maLoai"].Value.ToString()),
                    currentDataGrv.Cells["noiDung"].Value.ToString(),
                    currentDataGrv.Cells["taiKhoan"].Value.ToString(),
                    double.Parse(currentDataGrv.Cells["giaBan"].Value.ToString()),
                    float.Parse(currentDataGrv.Cells["giamGia"].Value.ToString()),
                    (currentDataGrv.Cells["daDuyet"].Value.ToString() == "1" ? true : false));

                new FormSanPham(sp, "UPDATE", this).ShowDialog();


            }
        }
    }
}
