
namespace ProjectBTL
{
    partial class FormChiTietHDN
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
            this.btnDong = new FontAwesome.Sharp.IconButton();
            this.lblLoai = new System.Windows.Forms.Label();
            this.linkLblLamMoi = new System.Windows.Forms.LinkLabel();
            this.cbbTenH = new System.Windows.Forms.ComboBox();
            this.cbbSoHD = new System.Windows.Forms.ComboBox();
            this.cbbMaH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.grbChucnangDS = new System.Windows.Forms.GroupBox();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiobtnK = new System.Windows.Forms.RadioButton();
            this.radiobtnCo = new System.Windows.Forms.RadioButton();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datetpDen = new System.Windows.Forms.DateTimePicker();
            this.datetpTu = new System.Windows.Forms.DateTimePicker();
            this.grbChucnangDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDong.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.btnDong.IconColor = System.Drawing.Color.Red;
            this.btnDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDong.IconSize = 16;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(809, 13);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 23);
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(30, 50);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(66, 13);
            this.lblLoai.TabIndex = 12;
            this.lblLoai.Text = "Số Hóa Đơn";
            // 
            // linkLblLamMoi
            // 
            this.linkLblLamMoi.AutoSize = true;
            this.linkLblLamMoi.Location = new System.Drawing.Point(56, 21);
            this.linkLblLamMoi.Name = "linkLblLamMoi";
            this.linkLblLamMoi.Size = new System.Drawing.Size(46, 13);
            this.linkLblLamMoi.TabIndex = 42;
            this.linkLblLamMoi.TabStop = true;
            this.linkLblLamMoi.Text = "Làm mới";
            this.linkLblLamMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLamMoi_LinkClicked);
            // 
            // cbbTenH
            // 
            this.cbbTenH.FormattingEnabled = true;
            this.cbbTenH.Location = new System.Drawing.Point(106, 80);
            this.cbbTenH.Name = "cbbTenH";
            this.cbbTenH.Size = new System.Drawing.Size(280, 21);
            this.cbbTenH.TabIndex = 17;
            this.cbbTenH.SelectedIndexChanged += new System.EventHandler(this.cbbTenH_SelectedIndexChanged);
            // 
            // cbbSoHD
            // 
            this.cbbSoHD.FormattingEnabled = true;
            this.cbbSoHD.Location = new System.Drawing.Point(106, 47);
            this.cbbSoHD.Name = "cbbSoHD";
            this.cbbSoHD.Size = new System.Drawing.Size(99, 21);
            this.cbbSoHD.TabIndex = 16;
            this.cbbSoHD.SelectedIndexChanged += new System.EventHandler(this.cbbSoHD_SelectedIndexChanged);
            // 
            // cbbMaH
            // 
            this.cbbMaH.FormattingEnabled = true;
            this.cbbMaH.Location = new System.Drawing.Point(287, 47);
            this.cbbMaH.Name = "cbbMaH";
            this.cbbMaH.Size = new System.Drawing.Size(99, 21);
            this.cbbMaH.TabIndex = 15;
            this.cbbMaH.SelectedIndexChanged += new System.EventHandler(this.cbbMaH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 37;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(738, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 60);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grbChucnangDS
            // 
            this.grbChucnangDS.Controls.Add(this.linkLblLamMoi);
            this.grbChucnangDS.Controls.Add(this.btnExport);
            this.grbChucnangDS.Controls.Add(this.btnDong);
            this.grbChucnangDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbChucnangDS.Location = new System.Drawing.Point(0, 433);
            this.grbChucnangDS.Name = "grbChucnangDS";
            this.grbChucnangDS.Size = new System.Drawing.Size(884, 48);
            this.grbChucnangDS.TabIndex = 14;
            this.grbChucnangDS.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnExport.IconColor = System.Drawing.Color.Blue;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 16;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(738, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(65, 23);
            this.btnExport.TabIndex = 41;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Location = new System.Drawing.Point(6, 116);
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.Size = new System.Drawing.Size(872, 307);
            this.dgvChiTietHDN.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến Ngày";
            // 
            // grbSearch
            // 
            this.grbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearch.BackColor = System.Drawing.Color.Tan;
            this.grbSearch.Controls.Add(this.label7);
            this.grbSearch.Controls.Add(this.radiobtnK);
            this.grbSearch.Controls.Add(this.radiobtnCo);
            this.grbSearch.Controls.Add(this.cbbNCC);
            this.grbSearch.Controls.Add(this.cbbNV);
            this.grbSearch.Controls.Add(this.label2);
            this.grbSearch.Controls.Add(this.label3);
            this.grbSearch.Controls.Add(this.datetpDen);
            this.grbSearch.Controls.Add(this.datetpTu);
            this.grbSearch.Controls.Add(this.cbbTenH);
            this.grbSearch.Controls.Add(this.cbbSoHD);
            this.grbSearch.Controls.Add(this.cbbMaH);
            this.grbSearch.Controls.Add(this.lblLoai);
            this.grbSearch.Controls.Add(this.label6);
            this.grbSearch.Controls.Add(this.btnTimKiem);
            this.grbSearch.Controls.Add(this.label5);
            this.grbSearch.Controls.Add(this.label4);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Location = new System.Drawing.Point(0, 0);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(884, 110);
            this.grbSearch.TabIndex = 15;
            this.grbSearch.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Có lọc ngày:";
            // 
            // radiobtnK
            // 
            this.radiobtnK.AutoSize = true;
            this.radiobtnK.Location = new System.Drawing.Point(532, 17);
            this.radiobtnK.Name = "radiobtnK";
            this.radiobtnK.Size = new System.Drawing.Size(56, 17);
            this.radiobtnK.TabIndex = 24;
            this.radiobtnK.TabStop = true;
            this.radiobtnK.Text = "Không";
            this.radiobtnK.UseVisualStyleBackColor = true;
            this.radiobtnK.CheckedChanged += new System.EventHandler(this.radiobtnK_CheckedChanged);
            // 
            // radiobtnCo
            // 
            this.radiobtnCo.AutoSize = true;
            this.radiobtnCo.Location = new System.Drawing.Point(479, 17);
            this.radiobtnCo.Name = "radiobtnCo";
            this.radiobtnCo.Size = new System.Drawing.Size(38, 17);
            this.radiobtnCo.TabIndex = 23;
            this.radiobtnCo.TabStop = true;
            this.radiobtnCo.Text = "Có";
            this.radiobtnCo.UseVisualStyleBackColor = true;
            this.radiobtnCo.CheckedChanged += new System.EventHandler(this.radiobtnCo_CheckedChanged);
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(479, 80);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(99, 21);
            this.cbbNCC.TabIndex = 22;
            this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(479, 47);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(99, 21);
            this.cbbNV.TabIndex = 21;
            this.cbbNV.SelectedIndexChanged += new System.EventHandler(this.cbbNV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã nhân viên";
            // 
            // datetpDen
            // 
            this.datetpDen.Location = new System.Drawing.Point(272, 13);
            this.datetpDen.Name = "datetpDen";
            this.datetpDen.Size = new System.Drawing.Size(114, 20);
            this.datetpDen.TabIndex = 18;
            // 
            // datetpTu
            // 
            this.datetpTu.Location = new System.Drawing.Point(106, 13);
            this.datetpTu.Name = "datetpTu";
            this.datetpTu.Size = new System.Drawing.Size(99, 20);
            this.datetpTu.TabIndex = 18;
            // 
            // FormChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.grbChucnangDS);
            this.Controls.Add(this.dgvChiTietHDN);
            this.Controls.Add(this.grbSearch);
            this.Name = "FormChiTietHDN";
            this.Text = "FormChiTietHDN";
            this.Load += new System.EventHandler(this.FormChiTietHDN_Load);
            this.grbChucnangDS.ResumeLayout(false);
            this.grbChucnangDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDong;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.LinkLabel linkLblLamMoi;
        private System.Windows.Forms.ComboBox cbbTenH;
        private System.Windows.Forms.ComboBox cbbSoHD;
        private System.Windows.Forms.ComboBox cbbMaH;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.GroupBox grbChucnangDS;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietHDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.DateTimePicker datetpDen;
        private System.Windows.Forms.DateTimePicker datetpTu;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radiobtnK;
        private System.Windows.Forms.RadioButton radiobtnCo;
    }
}