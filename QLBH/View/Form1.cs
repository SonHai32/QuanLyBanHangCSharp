namespace QLBH
{
    using QLBH.Controller;
    using QLBH.Forms;
    using QLBH.Modal;
    using QLBH.View;

    using System;
    using System.Collections;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="MainForm" />.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Defines the defaultGridView.
        /// </summary>
        private Bunifu.Framework.UI.BunifuCustomDataGrid defaultGridView;

        /// <summary>
        /// Defines the currentSqlCommand.
        /// </summary>
        private String currentSqlCommand = "";

        /// <summary>
        /// Defines the querySanPham.
        /// </summary>
        internal string querySanPham = "SELECT tenSP,L.loaiSP,noiDung,ndTomTat,maSP,L.maLoai,daDuyet,hinhDD,giaBan,ngayDang,taiKhoan,giamGia,nhaSanXuat FROM sanPham SP INNER JOIN loaiSP L ON SP.maLoai = L.maLoai";

        /// <summary>
        /// Defines the queryDonHang.
        /// </summary>
        internal string queryDonHang = "select soDH, tk.taiKhoan, ngayDat, daKichHoat, ngayDat, ngayGH, diaChiGH, dh.ghiChu, tk.tenTV, kh.tenKH from donHang dh inner join khachHang kh on dh.maKH = kh.maKH inner join taiKhoanTV tk on tk.taiKhoan = dh.taiKhoan";

        /// <summary>
        /// Defines the <see cref="lightColor" />.
        /// </summary>

        internal string queryKhachHang = "select maKH, tenKH, soDT, email, diaChi, kh.maQH, qh.tenQH, qh.tinhThanh, ngaySinh, gioiTinh, kh.ghiChu from khachHang kh inner join quanHuyen qh on kh.maQH = qh.maQH";
        private struct lightColor
        {
            /// <summary>
            /// Defines the color1.
            /// </summary>
            public static Color color1 = Color.FromArgb(36, 29, 60);

            /// <summary>
            /// Defines the color2.
            /// </summary>
            public static Color color2 = Color.FromArgb(56, 50, 86);

            /// <summary>
            /// Defines the color3.
            /// </summary>
            public static Color color3 = Color.FromArgb(111, 108, 114);
        }

        //
        /// <summary>
        /// Defines the <see cref="CustomTabControl" />.
        /// </summary>
        internal class CustomTabControl : TabControl
        {
            /// <summary>
            /// The WndProc.
            /// </summary>
            /// <param name="m">The m<see cref="Message"/>.</param>
            protected override void WndProc(ref Message m)
            {
                // Hide tabs by trapping the TCM_ADJUSTRECT message
                if (m.Msg == 0x1328 && !DesignMode)
                    m.Result = (IntPtr)1;
                else
                    base.WndProc(ref m);
            }
        }

        /// <summary>
        /// Defines the listSanPham.
        /// </summary>
        private ArrayList listSanPham;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.defaultGridView = this.grvData;
            this.currentSqlCommand = querySanPham;
            // set default active button
            this.activeButton(this.btnSanPham);

            loadDataSanPham();
            loadDataGridView("sanPham");
        }

        /// <summary>
        /// The loadDataGridView.
        /// </summary>
        /// <param name="dboName">The dboName<see cref="String"/>.</param>
        public void loadDataGridView(String dboName)
        {
            DAO dao = new DAO();
            switch (dboName)
            {
                case "sanPham":
                    this.grvData.Columns.Clear();
                    this.grvData = new DataGridViewStruct(this.grvData).grvSanPham();
                    this.grvData.DataSource = dao.getDataSource(dao.getDataAdapter(this.currentSqlCommand));
                    break;
                case "donHang":
                    this.grvData.Columns.Clear();
                    this.grvData = new DataGridViewStruct(this.grvData).grvDonHang();
                    this.grvData.DataSource = dao.getDataSource(dao.getDataAdapter(this.currentSqlCommand));
                    break;

                case "khachHang":
                    this.grvData.Columns.Clear();
                    this.grvData = new DataGridViewStruct(this.grvData).grvKhachHang();
                    this.grvData.DataSource = dao.getDataSource(dao.getDataAdapter(this.currentSqlCommand));
                    break;
                default: break;
            }
        }

        

        /// <summary>
        /// The loadListSanPham.
        /// </summary>
        public void loadListSanPham()
        {
            string sqlCommand = "SELECT tenSP,L.loaiSP,noiDung,ndTomTat,maSP,L.maLoai,daDuyet,hinhDD,giaBan,ngayDang,taiKhoan,giamGia,nhaSanXuat FROM sanPham SP INNER JOIN loaiSP L ON SP.maLoai = L.maLoai";
            var result = new DAO().sqlReader(sqlCommand);

            listSanPham = new ArrayList();
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
                listSanPham.Add(sanPham);
            }
        }

        //add dataBase schema
        /// <summary>
        /// The loadDataSanPham.
        /// </summary>
        public void loadDataSanPham()
        {
            if (listSanPham != null)
            {
                this.tpSanPham1.Controls.Clear();
                foreach (SanPham sanPham in listSanPham)
                {
                    QLBH.User_Controls.User_Control_SanPham sp = new QLBH.User_Controls.User_Control_SanPham(sanPham, this);
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
            else
            {
                this.loadListSanPham();
                loadDataSanPham();
            }
        }

        /// <summary>
        /// The btnSanPham_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            this.switchSanPham.Visible = true;
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            this.currentSqlCommand = this.querySanPham;
            this.tabControl1.SelectedIndex = 0;
        }

        /// <summary>
        /// The activeButton.
        /// </summary>
        /// <param name="btn">The btn<see cref="Bunifu.Framework.UI.BunifuFlatButton"/>.</param>
        private void activeButton(Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            this.activeBorder.Location = new Point(this.activeBorder.Location.X, btn.Location.Y);
            defaultButton();
            btn.Normalcolor = lightColor.color2;
        }

        /// <summary>
        /// The defaultButton.
        /// </summary>
        private void defaultButton()
        {
            this.btnBaiViet.Normalcolor = lightColor.color1;
            this.btnDonHang.Normalcolor = lightColor.color1;
            this.btnSanPham.Normalcolor = lightColor.color1;
            this.btnKhachHang.Normalcolor = lightColor.color1;
            this.btnCaiDat.Normalcolor = lightColor.color1;
        }

        /// <summary>
        /// The btnDonHang_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            this.switchSanPham.Visible = false;
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            this.tabControl1.SelectedIndex = 1;
            this.currentSqlCommand = this.queryDonHang;
            this.loadDataGridView("donHang");
        }

        /// <summary>
        /// The btnBaiViet_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnBaiViet_Click(object sender, EventArgs e)
        {
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            this.switchSanPham.Visible = false;
        }

        /// <summary>
        /// The btnKhachHang_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            this.currentSqlCommand = this.queryKhachHang;
            this.loadDataGridView("khachHang");
            this.switchSanPham.Visible = false;
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        /// <summary>
        /// The btnCaiDat_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnCaiDat_Click_1(object sender, EventArgs e)
        {
            this.switchSanPham.Visible = false;
            this.tabControl1.SelectedIndex = 2;
            activeButton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        /// <summary>
        /// The controlHide_MouseHover.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void controlHide_MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("Thu nhỏ", (PictureBox)sender);
        }

        /// <summary>
        /// The controlClose_MouseHover.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void controlClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("Thoát", (PictureBox)sender);
        }

        /// <summary>
        /// The controlClose_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void controlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The MainForm_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The grvData_CellContentClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/>.</param>
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

        /// <summary>
        /// The showListSanPham_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void showListSanPham_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        /// <summary>
        /// The showTableSanPham_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void showTableSanPham_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            this.currentSqlCommand = this.querySanPham;
            this.loadDataGridView("sanPham");
        }

        private void controlWinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void paneDashboardHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(235, 241, 255);

        }

        private void paneDashboardLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(248, 249, 251);
        }


        private void paneBaiViet_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }
        private void paneTaiKhoan_Click(object sender, EventArgs e)
        {
            new FormTaiKhoan().ShowDialog();
        }

        private void tpAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
