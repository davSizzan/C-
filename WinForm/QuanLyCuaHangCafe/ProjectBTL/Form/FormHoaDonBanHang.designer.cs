
namespace ProjectBTL
{
    partial class FormHoaDonBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linklblLamMoi = new System.Windows.Forms.LinkLabel();
            this.cbbTenH = new System.Windows.Forms.ComboBox();
            this.cbbLoaiH = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyDon = new FontAwesome.Sharp.IconButton();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnAll = new FontAwesome.Sharp.IconButton();
            this.btnDonMoi = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnDong = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tlbTinhTien = new System.Windows.Forms.TableLayoutPanel();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.txtTienTraLai = new System.Windows.Forms.TextBox();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XóaMotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaHettoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tlbTinhTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linklblLamMoi);
            this.groupBox1.Controls.Add(this.cbbTenH);
            this.groupBox1.Controls.Add(this.cbbLoaiH);
            this.groupBox1.Controls.Add(this.lblLoai);
            this.groupBox1.Controls.Add(this.dgvHang);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // linklblLamMoi
            // 
            this.linklblLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linklblLamMoi.AutoSize = true;
            this.linklblLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLamMoi.Location = new System.Drawing.Point(63, 428);
            this.linklblLamMoi.Name = "linklblLamMoi";
            this.linklblLamMoi.Size = new System.Drawing.Size(59, 16);
            this.linklblLamMoi.TabIndex = 20;
            this.linklblLamMoi.TabStop = true;
            this.linklblLamMoi.Text = "Làm mới";
            this.linklblLamMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLamMoi_LinkClicked);
            // 
            // cbbTenH
            // 
            this.cbbTenH.FormattingEnabled = true;
            this.cbbTenH.Location = new System.Drawing.Point(65, 13);
            this.cbbTenH.Name = "cbbTenH";
            this.cbbTenH.Size = new System.Drawing.Size(129, 21);
            this.cbbTenH.TabIndex = 19;
            this.cbbTenH.SelectedIndexChanged += new System.EventHandler(this.cbbTenH_SelectedIndexChanged);
            // 
            // cbbLoaiH
            // 
            this.cbbLoaiH.FormattingEnabled = true;
            this.cbbLoaiH.Location = new System.Drawing.Point(66, 41);
            this.cbbLoaiH.Name = "cbbLoaiH";
            this.cbbLoaiH.Size = new System.Drawing.Size(99, 21);
            this.cbbLoaiH.TabIndex = 18;
            this.cbbLoaiH.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiH_SelectedIndexChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(6, 44);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(54, 13);
            this.lblLoai.TabIndex = 17;
            this.lblLoai.Text = "Loại hàng";
            // 
            // dgvHang
            // 
            this.dgvHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(6, 70);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.Size = new System.Drawing.Size(188, 350);
            this.dgvHang.TabIndex = 6;
            this.dgvHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 18;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(170, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(24, 22);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.cbbNV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSoHD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnHuyDon);
            this.groupBox2.Controls.Add(this.lblSL);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.btnDonMoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(200, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 233);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Blue;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 15;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(217, 103);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 23);
            this.btnLuu.TabIndex = 92;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(75, 104);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(128, 22);
            this.txtSDT.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 124;
            this.label10.Text = "SĐT";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(75, 75);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(202, 22);
            this.txtTenKH.TabIndex = 123;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(75, 44);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(202, 21);
            this.cbbNV.TabIndex = 13;
            this.cbbNV.SelectedIndexChanged += new System.EventHandler(this.cbbNV_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "Tên KH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "Tên NV";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Location = new System.Drawing.Point(75, 13);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(68, 22);
            this.txtSoHD.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Số hóa đơn";
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDon.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHuyDon.IconColor = System.Drawing.Color.Gray;
            this.btnHuyDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyDon.IconSize = 30;
            this.btnHuyDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDon.Location = new System.Drawing.Point(26, 186);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(90, 35);
            this.btnHuyDon.TabIndex = 118;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyDon.UseVisualStyleBackColor = true;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(154, 18);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(49, 13);
            this.lblSL.TabIndex = 114;
            this.lblSL.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(209, 13);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(68, 22);
            this.txtSL.TabIndex = 115;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnThem.IconColor = System.Drawing.Color.Green;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 15;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(217, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 23);
            this.btnThem.TabIndex = 116;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.IconChar = FontAwesome.Sharp.IconChar.Fill;
            this.btnAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAll.IconSize = 30;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAll.Location = new System.Drawing.Point(165, 186);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(90, 35);
            this.btnAll.TabIndex = 113;
            this.btnAll.Text = "Tất cả hóa đơn";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDonMoi
            // 
            this.btnDonMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDonMoi.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnDonMoi.IconColor = System.Drawing.Color.Green;
            this.btnDonMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonMoi.IconSize = 30;
            this.btnDonMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDonMoi.Location = new System.Drawing.Point(96, 135);
            this.btnDonMoi.Name = "btnDonMoi";
            this.btnDonMoi.Size = new System.Drawing.Size(90, 35);
            this.btnDonMoi.TabIndex = 112;
            this.btnDonMoi.Text = "Đơn mới";
            this.btnDonMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonMoi.UseVisualStyleBackColor = true;
            this.btnDonMoi.Click += new System.EventHandler(this.btnDonMoi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnDong);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(488, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 58);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnExport.IconColor = System.Drawing.Color.Blue;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 16;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(15, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(65, 30);
            this.btnExport.TabIndex = 115;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 16;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(124, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 30);
            this.btnPrint.TabIndex = 116;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.btnDong.IconColor = System.Drawing.Color.Red;
            this.btnDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDong.IconSize = 16;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(233, 16);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 30);
            this.btnDong.TabIndex = 114;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tlbTinhTien);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(488, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 182);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính tiền";
            // 
            // tlbTinhTien
            // 
            this.tlbTinhTien.ColumnCount = 2;
            this.tlbTinhTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlbTinhTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlbTinhTien.Controls.Add(this.txtThanhToan, 1, 3);
            this.tlbTinhTien.Controls.Add(this.label6, 0, 4);
            this.tlbTinhTien.Controls.Add(this.label3, 0, 0);
            this.tlbTinhTien.Controls.Add(this.label4, 0, 2);
            this.tlbTinhTien.Controls.Add(this.label5, 0, 1);
            this.tlbTinhTien.Controls.Add(this.label7, 0, 3);
            this.tlbTinhTien.Controls.Add(this.txtKM, 1, 0);
            this.tlbTinhTien.Controls.Add(this.txtTongCong, 1, 2);
            this.tlbTinhTien.Controls.Add(this.txtTienHang, 1, 1);
            this.tlbTinhTien.Controls.Add(this.txtTienTraLai, 1, 4);
            this.tlbTinhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbTinhTien.Location = new System.Drawing.Point(3, 16);
            this.tlbTinhTien.Name = "tlbTinhTien";
            this.tlbTinhTien.RowCount = 5;
            this.tlbTinhTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbTinhTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbTinhTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbTinhTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbTinhTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbTinhTien.Size = new System.Drawing.Size(306, 163);
            this.tlbTinhTien.TabIndex = 107;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhToan.Location = new System.Drawing.Point(94, 99);
            this.txtThanhToan.Multiline = true;
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(209, 26);
            this.txtThanhToan.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiền trả lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khuyến mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng cộng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thanh toán";
            // 
            // txtKM
            // 
            this.txtKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKM.Location = new System.Drawing.Point(94, 3);
            this.txtKM.Multiline = true;
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(209, 26);
            this.txtKM.TabIndex = 5;
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged);
            this.txtKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKM_KeyPress);
            // 
            // txtTongCong
            // 
            this.txtTongCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongCong.Location = new System.Drawing.Point(94, 67);
            this.txtTongCong.Multiline = true;
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(209, 26);
            this.txtTongCong.TabIndex = 94;
            // 
            // txtTienHang
            // 
            this.txtTienHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTienHang.Location = new System.Drawing.Point(94, 35);
            this.txtTienHang.Multiline = true;
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.Size = new System.Drawing.Size(209, 26);
            this.txtTienHang.TabIndex = 94;
            // 
            // txtTienTraLai
            // 
            this.txtTienTraLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTienTraLai.Location = new System.Drawing.Point(94, 131);
            this.txtTienTraLai.Multiline = true;
            this.txtTienTraLai.Name = "txtTienTraLai";
            this.txtTienTraLai.Size = new System.Drawing.Size(209, 29);
            this.txtTienTraLai.TabIndex = 94;
            // 
            // dgvHDB
            // 
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.ContextMenuStrip = this.cms1;
            this.dgvHDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHDB.Location = new System.Drawing.Point(200, 0);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.Size = new System.Drawing.Size(600, 217);
            this.dgvHDB.TabIndex = 2;
            this.dgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellClick);
            this.dgvHDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellDoubleClick);
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.cms1.Name = "contextMenuStrip1";
            this.cms1.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XóaMotToolStripMenuItem,
            this.XoaHettoolStripMenuItem});
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // XóaMotToolStripMenuItem
            // 
            this.XóaMotToolStripMenuItem.Name = "XóaMotToolStripMenuItem";
            this.XóaMotToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.XóaMotToolStripMenuItem.Text = "Xóa Một hàng";
            this.XóaMotToolStripMenuItem.Click += new System.EventHandler(this.XóaMotToolStripMenuItem_Click);
            // 
            // XoaHettoolStripMenuItem
            // 
            this.XoaHettoolStripMenuItem.Name = "XoaHettoolStripMenuItem";
            this.XoaHettoolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.XoaHettoolStripMenuItem.Text = "Xóa hết Số HD này";
            this.XoaHettoolStripMenuItem.Click += new System.EventHandler(this.XoaHettoolStripMenuItem_Click);
            // 
            // FormHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvHDB);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormHoaDonBanHang";
            this.Text = "FormHoaDonBanHang";
            this.Load += new System.EventHandler(this.FormHoaDonBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tlbTinhTien.ResumeLayout(false);
            this.tlbTinhTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnDonMoi;
        private FontAwesome.Sharp.IconButton btnAll;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSL;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconButton btnDong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tlbTinhTien;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.TextBox txtTienTraLai;
        private System.Windows.Forms.ComboBox cbbLoaiH;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cbbTenH;
        private System.Windows.Forms.DataGridView dgvHDB;
        private FontAwesome.Sharp.IconButton btnHuyDon;
        private System.Windows.Forms.LinkLabel linklblLamMoi;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XóaMotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaHettoolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnLuu;
    }
}