namespace QLBH.View
{
    partial class MyMessageBox
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainPane = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtMessage = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPane.SuspendLayout();
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
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mainPane
            // 
            this.mainPane.AutoSize = true;
            this.mainPane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPane.BackgroundImage")));
            this.mainPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPane.Controls.Add(this.txtMessage);
            this.mainPane.Controls.Add(this.btnOK);
            this.mainPane.Controls.Add(this.lblStatus);
            this.mainPane.Controls.Add(this.pictureBox1);
            this.mainPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPane.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.mainPane.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.mainPane.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.mainPane.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.mainPane.Location = new System.Drawing.Point(0, 0);
            this.mainPane.Name = "mainPane";
            this.mainPane.Quality = 10;
            this.mainPane.Size = new System.Drawing.Size(396, 410);
            this.mainPane.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Transparent;
            this.txtMessage.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, 227);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(372, 93);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 50;
            this.btnOK.ActiveFillColor = System.Drawing.Color.White;
            this.btnOK.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.btnOK.ActiveLineColor = System.Drawing.Color.White;
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "OK";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 50;
            this.btnOK.IdleFillColor = System.Drawing.Color.White;
            this.btnOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(173)))));
            this.btnOK.IdleLineColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(58, 343);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(276, 62);
            this.btnOK.TabIndex = 2;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 187);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(372, 40);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng Thái";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QLBH.Properties.Resources.dead;
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(396, 410);
            this.Controls.Add(this.mainPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.TopMost = true;
            this.mainPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel mainPane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStatus;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label txtMessage;
    }
}