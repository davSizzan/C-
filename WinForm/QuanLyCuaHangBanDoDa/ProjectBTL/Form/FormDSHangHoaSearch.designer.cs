
namespace BTL_LTTQ_K60
{
    partial class FormDSHangHoaSearch
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
            this.grbChucnangDS = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnicSearch = new FontAwesome.Sharp.IconButton();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnDong = new FontAwesome.Sharp.IconButton();
            this.grbHiendk = new System.Windows.Forms.GroupBox();
            this.labelHienDKLoc = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtTimTenH = new System.Windows.Forms.TextBox();
            this.txtTimMaH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSCanTim = new System.Windows.Forms.DataGridView();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.grbChucnangDS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbHiendk.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCanTim)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChucnangDS
            // 
            this.grbChucnangDS.BackColor = System.Drawing.Color.Tan;
            this.grbChucnangDS.Controls.Add(this.panel1);
            this.grbChucnangDS.Controls.Add(this.btnLuu);
            this.grbChucnangDS.Controls.Add(this.btnSua);
            this.grbChucnangDS.Controls.Add(this.btnThem);
            this.grbChucnangDS.Controls.Add(this.btnExport);
            this.grbChucnangDS.Controls.Add(this.btnDong);
            this.grbChucnangDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbChucnangDS.Location = new System.Drawing.Point(0, 413);
            this.grbChucnangDS.Name = "grbChucnangDS";
            this.grbChucnangDS.Size = new System.Drawing.Size(884, 48);
            this.grbChucnangDS.TabIndex = 6;
            this.grbChucnangDS.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnicSearch);
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 29);
            this.panel1.TabIndex = 51;
            // 
            // btnicSearch
            // 
            this.btnicSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnicSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnicSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnicSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnicSearch.IconColor = System.Drawing.Color.Black;
            this.btnicSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnicSearch.IconSize = 22;
            this.btnicSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnicSearch.Location = new System.Drawing.Point(467, 3);
            this.btnicSearch.Name = "btnicSearch";
            this.btnicSearch.Size = new System.Drawing.Size(32, 24);
            this.btnicSearch.TabIndex = 12;
            this.btnicSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnicSearch.UseVisualStyleBackColor = true;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(279, 5);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(182, 20);
            this.txtTenHang.TabIndex = 12;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(61, 5);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(157, 20);
            this.txtMaHang.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hàng:";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Blue;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 15;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(670, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 23);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 16;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(518, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 23);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Làm mới";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnThem.IconColor = System.Drawing.Color.Green;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 15;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(589, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnExport.IconColor = System.Drawing.Color.Blue;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 16;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(736, 19);
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
            this.btnDong.Location = new System.Drawing.Point(807, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 23);
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grbHiendk
            // 
            this.grbHiendk.BackColor = System.Drawing.Color.Tan;
            this.grbHiendk.Controls.Add(this.labelHienDKLoc);
            this.grbHiendk.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.grbHiendk.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbHiendk.Location = new System.Drawing.Point(0, 0);
            this.grbHiendk.Name = "grbHiendk";
            this.grbHiendk.Size = new System.Drawing.Size(884, 36);
            this.grbHiendk.TabIndex = 8;
            this.grbHiendk.TabStop = false;
            this.grbHiendk.Enter += new System.EventHandler(this.grbHiendk_Enter);
            this.grbHiendk.MouseCaptureChanged += new System.EventHandler(this.labelHienDKLoc_Click);
            // 
            // labelHienDKLoc
            // 
            this.labelHienDKLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHienDKLoc.AutoSize = true;
            this.labelHienDKLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHienDKLoc.ForeColor = System.Drawing.Color.Blue;
            this.labelHienDKLoc.Location = new System.Drawing.Point(316, 16);
            this.labelHienDKLoc.Name = "labelHienDKLoc";
            this.labelHienDKLoc.Size = new System.Drawing.Size(189, 20);
            this.labelHienDKLoc.TabIndex = 4;
            this.labelHienDKLoc.Text = "Ẩn/Hiện Điều Kiện Lọc";
            this.labelHienDKLoc.Click += new System.EventHandler(this.labelHienDKLoc_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.BackColor = System.Drawing.Color.Tan;
            this.grbSearch.Controls.Add(this.dtpTimDenNgay);
            this.grbSearch.Controls.Add(this.dtpTimTuNgay);
            this.grbSearch.Controls.Add(this.txtLoai);
            this.grbSearch.Controls.Add(this.txtSL);
            this.grbSearch.Controls.Add(this.lblLoai);
            this.grbSearch.Controls.Add(this.lblSL);
            this.grbSearch.Controls.Add(this.txtTimTenH);
            this.grbSearch.Controls.Add(this.txtTimMaH);
            this.grbSearch.Controls.Add(this.label6);
            this.grbSearch.Controls.Add(this.btnTimKiem);
            this.grbSearch.Controls.Add(this.label5);
            this.grbSearch.Controls.Add(this.label4);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch.Location = new System.Drawing.Point(0, 36);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(884, 94);
            this.grbSearch.TabIndex = 10;
            this.grbSearch.TabStop = false;
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(282, 12);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(127, 20);
            this.dtpTimDenNgay.TabIndex = 16;
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(88, 12);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(117, 20);
            this.dtpTimTuNgay.TabIndex = 15;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(470, 39);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(99, 20);
            this.txtLoai.TabIndex = 14;
            this.txtLoai.TextChanged += new System.EventHandler(this.txtLoai_TextChanged_1);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(470, 13);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(99, 20);
            this.txtSL.TabIndex = 13;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(415, 42);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(27, 13);
            this.lblLoai.TabIndex = 12;
            this.lblLoai.Text = "Loại";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(415, 16);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(49, 13);
            this.lblSL.TabIndex = 11;
            this.lblSL.Text = "Số lượng";
            // 
            // txtTimTenH
            // 
            this.txtTimTenH.Location = new System.Drawing.Point(88, 65);
            this.txtTimTenH.Name = "txtTimTenH";
            this.txtTimTenH.Size = new System.Drawing.Size(321, 20);
            this.txtTimTenH.TabIndex = 10;
            this.txtTimTenH.TextChanged += new System.EventHandler(this.txtTimTenH_TextChanged);
            // 
            // txtTimMaH
            // 
            this.txtTimMaH.Location = new System.Drawing.Point(88, 39);
            this.txtTimMaH.Name = "txtTimMaH";
            this.txtTimMaH.Size = new System.Drawing.Size(321, 20);
            this.txtTimMaH.TabIndex = 9;
            this.txtTimMaH.TextChanged += new System.EventHandler(this.txtTimMaH_TextChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 37;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(754, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 44);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dgvDSCanTim
            // 
            this.dgvDSCanTim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCanTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCanTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCanTim.Location = new System.Drawing.Point(0, 130);
            this.dgvDSCanTim.Name = "dgvDSCanTim";
            this.dgvDSCanTim.Size = new System.Drawing.Size(884, 283);
            this.dgvDSCanTim.TabIndex = 11;
            this.dgvDSCanTim.DoubleClick += new System.EventHandler(this.dgvDSCanTim_DoubleClick);
            // 
            // FormDSHangHoaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvDSCanTim);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbHiendk);
            this.Controls.Add(this.grbChucnangDS);
            this.Name = "FormDSHangHoaSearch";
            this.Text = "FormDSHangHoaSearch";
            this.Load += new System.EventHandler(this.FormDSHangHoaSearch_Load);
            this.grbChucnangDS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbHiendk.ResumeLayout(false);
            this.grbHiendk.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCanTim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbChucnangDS;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnDong;
        private System.Windows.Forms.GroupBox grbHiendk;
        private System.Windows.Forms.Label labelHienDKLoc;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtTimTenH;
        private System.Windows.Forms.TextBox txtTimMaH;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSCanTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnicSearch;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}