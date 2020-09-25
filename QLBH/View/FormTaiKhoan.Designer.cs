using System;
namespace QLBH.View
{
    partial class FormTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        internal class CustomTabControl : System.Windows.Forms.TabControl
        {
            /// <summary>
            /// The WndProc.
            /// </summary>
            /// <param name="m">The m<see cref="Message"/>.</param>
            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                // Hide tabs by trapping the TCM_ADJUSTRECT message
                if (m.Msg == 0x1328 && !DesignMode)
                    m.Result = (IntPtr)1;
                else
                    base.WndProc(ref m);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tabControl1 = new QLBH.View.FormTaiKhoan.CustomTabControl();
            this.tabPageTaiKhoan = new System.Windows.Forms.TabPage();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbNhomTK = new System.Windows.Forms.ComboBox();
            this.cbQuanHuyen = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.placeGhiChu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeSoDT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeMatKhau = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeTaiKhoan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeDiaChi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placeHoDem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNgaySinh = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSoDT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMatKhau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTaiKhoan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHoDem = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tabPageDanhSachTK = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.grvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.hoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNhomTK = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnListTab = new System.Windows.Forms.Button();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageTaiKhoan.SuspendLayout();
            this.tabPageDanhSachTK.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNhomTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTaiKhoan);
            this.tabControl1.Controls.Add(this.tabPageDanhSachTK);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 688);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageTaiKhoan
            // 
            this.tabPageTaiKhoan.Controls.Add(this.btnAddNhomTK);
            this.tabPageTaiKhoan.Controls.Add(this.cbTrangThai);
            this.tabPageTaiKhoan.Controls.Add(this.bunifuCustomLabel7);
            this.tabPageTaiKhoan.Controls.Add(this.btnSubmit);
            this.tabPageTaiKhoan.Controls.Add(this.cbNhomTK);
            this.tabPageTaiKhoan.Controls.Add(this.cbQuanHuyen);
            this.tabPageTaiKhoan.Controls.Add(this.cbGioiTinh);
            this.tabPageTaiKhoan.Controls.Add(this.placeGhiChu);
            this.tabPageTaiKhoan.Controls.Add(this.placeSoDT);
            this.tabPageTaiKhoan.Controls.Add(this.placeEmail);
            this.tabPageTaiKhoan.Controls.Add(this.placeMatKhau);
            this.tabPageTaiKhoan.Controls.Add(this.placeTaiKhoan);
            this.tabPageTaiKhoan.Controls.Add(this.placeDiaChi);
            this.tabPageTaiKhoan.Controls.Add(this.placeTen);
            this.tabPageTaiKhoan.Controls.Add(this.placeHoDem);
            this.tabPageTaiKhoan.Controls.Add(this.txtGhiChu);
            this.tabPageTaiKhoan.Controls.Add(this.bunifuCustomLabel4);
            this.tabPageTaiKhoan.Controls.Add(this.txtNgaySinh);
            this.tabPageTaiKhoan.Controls.Add(this.bunifuCustomLabel3);
            this.tabPageTaiKhoan.Controls.Add(this.txtSoDT);
            this.tabPageTaiKhoan.Controls.Add(this.txtEmail);
            this.tabPageTaiKhoan.Controls.Add(this.bunifuCustomLabel2);
            this.tabPageTaiKhoan.Controls.Add(this.bunifuCustomLabel1);
            this.tabPageTaiKhoan.Controls.Add(this.txtMatKhau);
            this.tabPageTaiKhoan.Controls.Add(this.txtTen);
            this.tabPageTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.tabPageTaiKhoan.Controls.Add(this.txtDiaChi);
            this.tabPageTaiKhoan.Controls.Add(this.txtHoDem);
            this.tabPageTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoan.Name = "tabPageTaiKhoan";
            this.tabPageTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaiKhoan.Size = new System.Drawing.Size(752, 659);
            this.tabPageTaiKhoan.TabIndex = 0;
            this.tabPageTaiKhoan.Text = "tabPage1";
            this.tabPageTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrangThai.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.ItemHeight = 21;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Vô hiệu hóa",
            "Đã kích hoạt"});
            this.cbTrangThai.Location = new System.Drawing.Point(138, 259);
            this.cbTrangThai.MaximumSize = new System.Drawing.Size(221, 0);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(187, 29);
            this.cbTrangThai.TabIndex = 55;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(22, 245);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(110, 54);
            this.bunifuCustomLabel7.TabIndex = 54;
            this.bunifuCustomLabel7.Text = "Trạng thái";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(227, 593);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(311, 60);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Tạo tài khoản";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbNhomTK
            // 
            this.cbNhomTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cbNhomTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNhomTK.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbNhomTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.cbNhomTK.FormattingEnabled = true;
            this.cbNhomTK.ItemHeight = 21;
            this.cbNhomTK.Location = new System.Drawing.Point(136, 415);
            this.cbNhomTK.MaximumSize = new System.Drawing.Size(221, 0);
            this.cbNhomTK.Name = "cbNhomTK";
            this.cbNhomTK.Size = new System.Drawing.Size(145, 29);
            this.cbNhomTK.TabIndex = 53;
            // 
            // cbQuanHuyen
            // 
            this.cbQuanHuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cbQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuanHuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuanHuyen.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbQuanHuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.cbQuanHuyen.FormattingEnabled = true;
            this.cbQuanHuyen.ItemHeight = 21;
            this.cbQuanHuyen.Items.AddRange(new object[] {
            ""});
            this.cbQuanHuyen.Location = new System.Drawing.Point(535, 104);
            this.cbQuanHuyen.MaximumSize = new System.Drawing.Size(221, 0);
            this.cbQuanHuyen.Name = "cbQuanHuyen";
            this.cbQuanHuyen.Size = new System.Drawing.Size(187, 29);
            this.cbQuanHuyen.TabIndex = 52;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGioiTinh.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.ItemHeight = 21;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGioiTinh.Location = new System.Drawing.Point(535, 259);
            this.cbGioiTinh.MaximumSize = new System.Drawing.Size(221, 0);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(187, 29);
            this.cbGioiTinh.TabIndex = 51;
            // 
            // placeGhiChu
            // 
            this.placeGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeGhiChu.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeGhiChu.Location = new System.Drawing.Point(25, 487);
            this.placeGhiChu.Name = "placeGhiChu";
            this.placeGhiChu.Size = new System.Drawing.Size(698, 96);
            this.placeGhiChu.TabIndex = 50;
            this.placeGhiChu.Text = "Ghi chú";
            this.placeGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeGhiChu.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeSoDT
            // 
            this.placeSoDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeSoDT.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeSoDT.Location = new System.Drawing.Point(422, 322);
            this.placeSoDT.Name = "placeSoDT";
            this.placeSoDT.Size = new System.Drawing.Size(300, 54);
            this.placeSoDT.TabIndex = 49;
            this.placeSoDT.Text = "Số DT";
            this.placeSoDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeSoDT.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeEmail
            // 
            this.placeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeEmail.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeEmail.Location = new System.Drawing.Point(25, 322);
            this.placeEmail.Name = "placeEmail";
            this.placeEmail.Size = new System.Drawing.Size(300, 54);
            this.placeEmail.TabIndex = 48;
            this.placeEmail.Text = "Email";
            this.placeEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeEmail.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeMatKhau
            // 
            this.placeMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeMatKhau.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeMatKhau.Location = new System.Drawing.Point(423, 168);
            this.placeMatKhau.Name = "placeMatKhau";
            this.placeMatKhau.Size = new System.Drawing.Size(300, 54);
            this.placeMatKhau.TabIndex = 47;
            this.placeMatKhau.Text = "Mật khẩu";
            this.placeMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeMatKhau.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeTaiKhoan
            // 
            this.placeTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeTaiKhoan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeTaiKhoan.Location = new System.Drawing.Point(25, 168);
            this.placeTaiKhoan.Name = "placeTaiKhoan";
            this.placeTaiKhoan.Size = new System.Drawing.Size(300, 54);
            this.placeTaiKhoan.TabIndex = 46;
            this.placeTaiKhoan.Text = "Tài khoản";
            this.placeTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeTaiKhoan.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeDiaChi
            // 
            this.placeDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeDiaChi.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeDiaChi.Location = new System.Drawing.Point(25, 90);
            this.placeDiaChi.Name = "placeDiaChi";
            this.placeDiaChi.Size = new System.Drawing.Size(300, 54);
            this.placeDiaChi.TabIndex = 45;
            this.placeDiaChi.Text = "Địa Chỉ";
            this.placeDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeDiaChi.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeTen
            // 
            this.placeTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeTen.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeTen.Location = new System.Drawing.Point(423, 13);
            this.placeTen.Name = "placeTen";
            this.placeTen.Size = new System.Drawing.Size(300, 54);
            this.placeTen.TabIndex = 44;
            this.placeTen.Text = "Tên";
            this.placeTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeTen.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // placeHoDem
            // 
            this.placeHoDem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.placeHoDem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.placeHoDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.placeHoDem.Location = new System.Drawing.Point(25, 13);
            this.placeHoDem.Name = "placeHoDem";
            this.placeHoDem.Size = new System.Drawing.Size(300, 54);
            this.placeHoDem.TabIndex = 43;
            this.placeHoDem.Text = "Họ và đệm";
            this.placeHoDem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeHoDem.Click += new System.EventHandler(this.placeHolderClick);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtGhiChu.Location = new System.Drawing.Point(23, 487);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(700, 96);
            this.txtGhiChu.TabIndex = 42;
            this.txtGhiChu.Text = "";
            this.txtGhiChu.Leave += new System.EventHandler(this.richTextBox_Leave);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(419, 401);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(110, 54);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.Text = "Ngày Sinh";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtNgaySinh.BorderRadius = 0;
            this.txtNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtNgaySinh.FormatCustom = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(536, 401);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(187, 54);
            this.txtNgaySinh.TabIndex = 40;
            this.txtNgaySinh.Value = new System.DateTime(2020, 9, 17, 17, 4, 10, 73);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 401);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(109, 54);
            this.bunifuCustomLabel3.TabIndex = 39;
            this.bunifuCustomLabel3.Text = "Nhóm TK";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSoDT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSoDT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSoDT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSoDT.BorderThickness = 3;
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtSoDT.isPassword = false;
            this.txtSoDT.Location = new System.Drawing.Point(422, 322);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(301, 54);
            this.txtSoDT.TabIndex = 38;
            this.txtSoDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoDT.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(24, 322);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 54);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(419, 245);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(110, 54);
            this.bunifuCustomLabel2.TabIndex = 36;
            this.bunifuCustomLabel2.Text = "Giới tính";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(419, 90);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 54);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Quận huyện";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtMatKhau.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtMatKhau.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtMatKhau.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtMatKhau.BorderThickness = 3;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtMatKhau.isPassword = true;
            this.txtMatKhau.Location = new System.Drawing.Point(422, 168);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(301, 54);
            this.txtMatKhau.TabIndex = 34;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTen.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTen.BorderThickness = 3;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtTen.isPassword = false;
            this.txtTen.Location = new System.Drawing.Point(422, 13);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(301, 54);
            this.txtTen.TabIndex = 33;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTaiKhoan.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTaiKhoan.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTaiKhoan.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtTaiKhoan.BorderThickness = 3;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtTaiKhoan.isPassword = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(23, 168);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(302, 54);
            this.txtTaiKhoan.TabIndex = 32;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaiKhoan.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDiaChi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDiaChi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDiaChi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDiaChi.BorderThickness = 3;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.Location = new System.Drawing.Point(23, 90);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(302, 54);
            this.txtDiaChi.TabIndex = 31;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChi.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // txtHoDem
            // 
            this.txtHoDem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtHoDem.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtHoDem.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtHoDem.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtHoDem.BorderThickness = 3;
            this.txtHoDem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoDem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.txtHoDem.isPassword = false;
            this.txtHoDem.Location = new System.Drawing.Point(23, 13);
            this.txtHoDem.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(300, 54);
            this.txtHoDem.TabIndex = 30;
            this.txtHoDem.TabStop = false;
            this.txtHoDem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHoDem.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // tabPageDanhSachTK
            // 
            this.tabPageDanhSachTK.Controls.Add(this.panel4);
            this.tabPageDanhSachTK.Controls.Add(this.grvTaiKhoan);
            this.tabPageDanhSachTK.Location = new System.Drawing.Point(4, 25);
            this.tabPageDanhSachTK.Name = "tabPageDanhSachTK";
            this.tabPageDanhSachTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDanhSachTK.Size = new System.Drawing.Size(752, 659);
            this.tabPageDanhSachTK.TabIndex = 1;
            this.tabPageDanhSachTK.Text = "tabPage2";
            this.tabPageDanhSachTK.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 104);
            this.panel4.TabIndex = 15;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Montserrat Alternates", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Tìm kiếm";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(201)))), ((int)(((byte)(216)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(458, 31);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(271, 38);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grvTaiKhoan
            // 
            this.grvTaiKhoan.AllowUserToAddRows = false;
            this.grvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.grvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.grvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvTaiKhoan.ColumnHeadersHeight = 50;
            this.grvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoDem,
            this.tenTV,
            this.taiKhoanTV,
            this.matKhau,
            this.maNhom,
            this.ngaySinh,
            this.gioiTinh,
            this.tenNhom,
            this.soDT,
            this.email,
            this.diaChi,
            this.maQH,
            this.trangThai,
            this.ghiChu,
            this.tenQH});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvTaiKhoan.EnableHeadersVisualStyles = false;
            this.grvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.grvTaiKhoan.Location = new System.Drawing.Point(3, 146);
            this.grvTaiKhoan.Name = "grvTaiKhoan";
            this.grvTaiKhoan.ReadOnly = true;
            this.grvTaiKhoan.RowHeadersVisible = false;
            this.grvTaiKhoan.RowHeadersWidth = 500;
            this.grvTaiKhoan.RowTemplate.Height = 24;
            this.grvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTaiKhoan.Size = new System.Drawing.Size(746, 510);
            this.grvTaiKhoan.TabIndex = 0;
            this.grvTaiKhoan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.grvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.grvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grvTaiKhoan.ThemeStyle.HeaderStyle.Height = 50;
            this.grvTaiKhoan.ThemeStyle.ReadOnly = true;
            this.grvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.grvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grvTaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.grvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.grvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grvTaiKhoan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTaiKhoan_CellEnter);
            // 
            // hoDem
            // 
            this.hoDem.DataPropertyName = "hoDem";
            this.hoDem.HeaderText = "Họ đệm";
            this.hoDem.MinimumWidth = 6;
            this.hoDem.Name = "hoDem";
            this.hoDem.ReadOnly = true;
            this.hoDem.Width = 104;
            // 
            // tenTV
            // 
            this.tenTV.DataPropertyName = "tenTV";
            this.tenTV.HeaderText = "Tên thành viên";
            this.tenTV.MinimumWidth = 6;
            this.tenTV.Name = "tenTV";
            this.tenTV.ReadOnly = true;
            this.tenTV.Width = 152;
            // 
            // taiKhoanTV
            // 
            this.taiKhoanTV.DataPropertyName = "taiKhoan";
            this.taiKhoanTV.FillWeight = 800F;
            this.taiKhoanTV.HeaderText = "Tài khoản";
            this.taiKhoanTV.MinimumWidth = 6;
            this.taiKhoanTV.Name = "taiKhoanTV";
            this.taiKhoanTV.ReadOnly = true;
            this.taiKhoanTV.Width = 113;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            this.matKhau.Visible = false;
            this.matKhau.Width = 113;
            // 
            // maNhom
            // 
            this.maNhom.DataPropertyName = "maNhom";
            this.maNhom.HeaderText = "Mã Nhóm";
            this.maNhom.MinimumWidth = 6;
            this.maNhom.Name = "maNhom";
            this.maNhom.ReadOnly = true;
            this.maNhom.Visible = false;
            this.maNhom.Width = 119;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            this.ngaySinh.Width = 118;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.Width = 105;
            // 
            // tenNhom
            // 
            this.tenNhom.DataPropertyName = "tenNhom";
            this.tenNhom.HeaderText = "Tên nhóm";
            this.tenNhom.MinimumWidth = 6;
            this.tenNhom.Name = "tenNhom";
            this.tenNhom.ReadOnly = true;
            this.tenNhom.Width = 117;
            // 
            // soDT
            // 
            this.soDT.DataPropertyName = "soDT";
            this.soDT.HeaderText = "Số ĐT";
            this.soDT.MinimumWidth = 6;
            this.soDT.Name = "soDT";
            this.soDT.ReadOnly = true;
            this.soDT.Width = 87;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 81;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 92;
            // 
            // maQH
            // 
            this.maQH.DataPropertyName = "maQH";
            this.maQH.HeaderText = "Mã quận huyện";
            this.maQH.MinimumWidth = 6;
            this.maQH.Name = "maQH";
            this.maQH.ReadOnly = true;
            this.maQH.Visible = false;
            this.maQH.Width = 162;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 116;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            this.ghiChu.Width = 98;
            // 
            // tenQH
            // 
            this.tenQH.DataPropertyName = "tenQH";
            this.tenQH.HeaderText = "Tên quận huyện";
            this.tenQH.MinimumWidth = 6;
            this.tenQH.Name = "tenQH";
            this.tenQH.ReadOnly = true;
            this.tenQH.Width = 163;
            // 
            // btnAddNhomTK
            // 
            this.btnAddNhomTK.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNhomTK.Image = global::QLBH.Properties.Resources.add_new_32px;
            this.btnAddNhomTK.Location = new System.Drawing.Point(296, 415);
            this.btnAddNhomTK.Name = "btnAddNhomTK";
            this.btnAddNhomTK.Size = new System.Drawing.Size(29, 29);
            this.btnAddNhomTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNhomTK.TabIndex = 101;
            this.btnAddNhomTK.TabStop = false;
            this.btnAddNhomTK.Click += new System.EventHandler(this.btnAddNhomTK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::QLBH.Properties.Resources.delete_bin_32px1;
            this.btnDelete.Location = new System.Drawing.Point(90, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = global::QLBH.Properties.Resources.edit_file_32px1;
            this.btnEdit.Location = new System.Drawing.Point(52, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::QLBH.Properties.Resources.add_new_32px;
            this.btnAdd.Location = new System.Drawing.Point(14, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox11.Image = global::QLBH.Properties.Resources.search_32px1;
            this.pictureBox11.Location = new System.Drawing.Point(419, 36);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 1;
            this.pictureBox11.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnListTab);
            this.bunifuGradientPanel1.Controls.Add(this.btnAddTab);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(760, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(335, 688);
            this.bunifuGradientPanel1.TabIndex = 26;
            // 
            // btnListTab
            // 
            this.btnListTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnListTab.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnListTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnListTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTab.ForeColor = System.Drawing.Color.White;
            this.btnListTab.Location = new System.Drawing.Point(12, 590);
            this.btnListTab.Name = "btnListTab";
            this.btnListTab.Size = new System.Drawing.Size(311, 60);
            this.btnListTab.TabIndex = 6;
            this.btnListTab.Text = "Danh sách tài khoản";
            this.btnListTab.UseVisualStyleBackColor = false;
            this.btnListTab.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnAddTab.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnAddTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(121)))));
            this.btnAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTab.ForeColor = System.Drawing.Color.White;
            this.btnAddTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTab.Location = new System.Drawing.Point(12, 512);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(311, 60);
            this.btnAddTab.TabIndex = 5;
            this.btnAddTab.Text = "Tạo tài khoản";
            this.btnAddTab.UseVisualStyleBackColor = false;
            this.btnAddTab.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 420);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(332, 49);
            this.bunifuCustomLabel6.TabIndex = 4;
            this.bunifuCustomLabel6.Text = "Tài Khoản TV";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::QLBH.Properties.Resources.group;
            this.pictureBox2.Location = new System.Drawing.Point(42, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 43);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(332, 49);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "Welcome";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QLBH.Properties.Resources.cancel_32px;
            this.pictureBox1.Location = new System.Drawing.Point(300, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 688);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaiKhoan";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPageTaiKhoan.ResumeLayout(false);
            this.tabPageDanhSachTK.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNhomTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TabPage tabPageTaiKhoan;
        private System.Windows.Forms.ComboBox cbNhomTK;
        private System.Windows.Forms.ComboBox cbQuanHuyen;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private Bunifu.Framework.UI.BunifuCustomLabel placeGhiChu;
        private Bunifu.Framework.UI.BunifuCustomLabel placeSoDT;
        private Bunifu.Framework.UI.BunifuCustomLabel placeEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel placeMatKhau;
        private Bunifu.Framework.UI.BunifuCustomLabel placeTaiKhoan;
        private Bunifu.Framework.UI.BunifuCustomLabel placeDiaChi;
        private Bunifu.Framework.UI.BunifuCustomLabel placeTen;
        private Bunifu.Framework.UI.BunifuCustomLabel placeHoDem;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker txtNgaySinh;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoDT;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMatKhau;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTen;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTaiKhoan;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHoDem;
        private System.Windows.Forms.TabPage tabPageDanhSachTK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox pictureBox11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Guna.UI2.WinForms.Guna2DataGridView grvTaiKhoan;
        private System.Windows.Forms.Button btnListTab;
        private System.Windows.Forms.Button btnAddTab;
        private CustomTabControl tabControl1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQH;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQH;
        private System.Windows.Forms.PictureBox btnAddNhomTK;
    }
}