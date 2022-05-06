
namespace ProjectBTL
{
    partial class FormBangGiaSP
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
            this.lblLoai = new System.Windows.Forms.Label();
            this.dgvGiaSP = new System.Windows.Forms.DataGridView();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cbbTenH = new System.Windows.Forms.ComboBox();
            this.cbbLoaiH = new System.Windows.Forms.ComboBox();
            this.cbbMaH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.grbChucnangDS = new System.Windows.Forms.GroupBox();
            this.linkLblLamMoi = new System.Windows.Forms.LinkLabel();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnDong = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSP)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grbChucnangDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(225, 50);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(54, 13);
            this.lblLoai.TabIndex = 12;
            this.lblLoai.Text = "Loại hàng";
            // 
            // dgvGiaSP
            // 
            this.dgvGiaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaSP.Location = new System.Drawing.Point(6, 116);
            this.dgvGiaSP.Name = "dgvGiaSP";
            this.dgvGiaSP.Size = new System.Drawing.Size(872, 307);
            this.dgvGiaSP.TabIndex = 13;
            // 
            // grbSearch
            // 
            this.grbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearch.BackColor = System.Drawing.Color.Tan;
            this.grbSearch.Controls.Add(this.cbbTenH);
            this.grbSearch.Controls.Add(this.cbbLoaiH);
            this.grbSearch.Controls.Add(this.cbbMaH);
            this.grbSearch.Controls.Add(this.lblLoai);
            this.grbSearch.Controls.Add(this.label6);
            this.grbSearch.Controls.Add(this.btnTimKiem);
            this.grbSearch.Controls.Add(this.label5);
            this.grbSearch.Controls.Add(this.label4);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.txtGiaDen);
            this.grbSearch.Controls.Add(this.txtGiaTu);
            this.grbSearch.Location = new System.Drawing.Point(0, 0);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(884, 110);
            this.grbSearch.TabIndex = 11;
            this.grbSearch.TabStop = false;
            // 
            // cbbTenH
            // 
            this.cbbTenH.FormattingEnabled = true;
            this.cbbTenH.Location = new System.Drawing.Point(127, 80);
            this.cbbTenH.Name = "cbbTenH";
            this.cbbTenH.Size = new System.Drawing.Size(257, 21);
            this.cbbTenH.TabIndex = 17;
            this.cbbTenH.SelectedIndexChanged += new System.EventHandler(this.cbbTenH_SelectedIndexChanged);
            // 
            // cbbLoaiH
            // 
            this.cbbLoaiH.FormattingEnabled = true;
            this.cbbLoaiH.Location = new System.Drawing.Point(285, 47);
            this.cbbLoaiH.Name = "cbbLoaiH";
            this.cbbLoaiH.Size = new System.Drawing.Size(99, 21);
            this.cbbLoaiH.TabIndex = 16;
            this.cbbLoaiH.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiH_SelectedIndexChanged);
            // 
            // cbbMaH
            // 
            this.cbbMaH.FormattingEnabled = true;
            this.cbbMaH.Location = new System.Drawing.Point(127, 47);
            this.cbbMaH.Name = "cbbMaH";
            this.cbbMaH.Size = new System.Drawing.Size(92, 21);
            this.cbbMaH.TabIndex = 15;
            this.cbbMaH.SelectedIndexChanged += new System.EventHandler(this.cbbMaH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 83);
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
            this.btnTimKiem.Location = new System.Drawing.Point(574, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 60);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giá từ ";
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Location = new System.Drawing.Point(285, 13);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(99, 20);
            this.txtGiaDen.TabIndex = 3;
            this.txtGiaDen.TextChanged += new System.EventHandler(this.txtGiaDen_TextChanged);
            this.txtGiaDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDen_KeyPress);
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Location = new System.Drawing.Point(127, 13);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(92, 20);
            this.txtGiaTu.TabIndex = 2;
            this.txtGiaTu.TextChanged += new System.EventHandler(this.txtGiaTu_TextChanged);
            this.txtGiaTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTu_KeyPress);
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
            this.grbChucnangDS.TabIndex = 10;
            this.grbChucnangDS.TabStop = false;
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
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // FormBangGiaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.dgvGiaSP);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbChucnangDS);
            this.Name = "FormBangGiaSP";
            this.Text = "FormBangGiaSP";
            this.Load += new System.EventHandler(this.FormBangGiaSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSP)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbChucnangDS.ResumeLayout(false);
            this.grbChucnangDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.DataGridView dgvGiaSP;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaDen;
        private System.Windows.Forms.TextBox txtGiaTu;
        private System.Windows.Forms.GroupBox grbChucnangDS;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnDong;
        private System.Windows.Forms.ComboBox cbbTenH;
        private System.Windows.Forms.ComboBox cbbLoaiH;
        private System.Windows.Forms.ComboBox cbbMaH;
        private System.Windows.Forms.LinkLabel linkLblLamMoi;
    }
}