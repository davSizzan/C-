using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_LTTQ_K60;
using ProjectBTL.Main;
using ProjectBTL.Model;

namespace ProjectBTL
{
    public partial class TrangChu : Form
    {
        DataTable table = new DataTable();
        DataBaseSQL dtBase = new DataBaseSQL();
        String acc = null;
        String manv = null;
        MaHoaMK mk = new MaHoaMK();
        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(string account)
        {
            InitializeComponent();
            acc = account;
        }

        public void resetColor()
        {
            btnBaoCao.BackColor = Color.FromArgb(54, 34, 34);
            btnDanhMuc.BackColor = Color.FromArgb(54, 34, 34);
            btnHeThong.BackColor = Color.FromArgb(54, 34, 34);
            btnQLBH.BackColor = Color.FromArgb(54, 34, 34);
            btnQLMH.BackColor = Color.FromArgb(54, 34, 34);
            btnKhuyenMai.BackColor = Color.FromArgb(54, 34, 34);
        }
  

        private void lblLogo_Click_1(object sender, EventArgs e)
        {
            resetColor();
            if (!pnMain.Controls.Contains(Home.Instance))
            {
                pnMain.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnMain.Controls.Add(Home.Instance);
            Home.Instance.Dock = DockStyle.Fill;
            Home.Instance.BringToFront();
            hideCH(false);
            lbAccount.Text = acc;
            this.MaximizeBox = false;
        }


        public void hide(Boolean t)
        {
            txtDiaChi.Enabled = t;
            txtHoTen.Enabled = t;
            txtGhiChu.Enabled = t;
            txtGioiTinh.Enabled = t;
            txtSDT.Enabled = t;
            txtTenDangNhap.Enabled = false;
            dtNgaySinh.Enabled = t;
            txtMatKhau.Enabled = t;
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            resetColor();
            btnHeThong.BackColor = Color.FromArgb(92, 61, 46);
            pnMain.Controls.Add(tCt);
            tCt.BringToFront();
            table = dtBase.DataReturnTable("Select * from thongTinNV where MaTK = '" + acc + "'");
            if (table.Rows[0]["PhanQuyen"].ToString() != "admin")
            {
                tCt.TabPages.Remove(tPPhanQuyen);
            }
            manv = table.Rows[0]["MaNV"].ToString();
            txtHoTen.Text = table.Rows[0]["TenNV"].ToString();
            dtNgaySinh.Value = (DateTime)(table.Rows[0]["NgaySinh"]);
            txtGioiTinh.Text = table.Rows[0]["GioiTinh"].ToString();
            txtSDT.Text = table.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            txtTenDangNhap.Text = table.Rows[0]["MaTK"].ToString();
           
            txtMatKhau.Text = mk.GiaiMa(table.Rows[0]["MatKhau"].ToString());
            hide(false);
            dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
           /* dgvDSNV.Columns[0].Width = 50;
            dgvDSNV.Columns[2].Width = 80;*/
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {

            resetColor();
            btnDanhMuc.BackColor = Color.FromArgb(92, 61, 46);
            if (!pnMain.Controls.Contains(DanhMuc.Instance))
            {
                pnMain.Controls.Add(DanhMuc.Instance);
                DanhMuc.Instance.Dock = DockStyle.Fill;
                DanhMuc.Instance.BringToFront();
            }
            else
                DanhMuc.Instance.BringToFront();
        }

        private void btnQLBH_Click(object sender, EventArgs e)
        {

            resetColor();
            btnQLBH.BackColor = Color.FromArgb(92, 61, 46);
            if (!pnMain.Controls.Contains(QuanLyBanHang.Instance))
            {
                pnMain.Controls.Add(QuanLyBanHang.Instance);
                QuanLyBanHang.Instance.Dock = DockStyle.Fill;
                QuanLyBanHang.Instance.BringToFront();
            }
            else
                QuanLyBanHang.Instance.BringToFront();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {

            resetColor();
            btnQLMH.BackColor = Color.FromArgb(92, 61, 46);
            if (!pnMain.Controls.Contains(QuanLyMuaHang.Instance))
            {
                pnMain.Controls.Add(QuanLyMuaHang.Instance);
                QuanLyMuaHang.Instance.Dock = DockStyle.Fill;
                QuanLyMuaHang.Instance.BringToFront();
            }
            else
                QuanLyMuaHang.Instance.BringToFront();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {

            resetColor();
            btnKhuyenMai.BackColor = Color.FromArgb(92, 61, 46);
            if (!pnMain.Controls.Contains(KhuyenMai.Instance))
            {
                pnMain.Controls.Add(KhuyenMai.Instance);
                KhuyenMai.Instance.Dock = DockStyle.Fill;
                KhuyenMai.Instance.BringToFront();
            }
            else
                KhuyenMai.Instance.BringToFront();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

            resetColor();
            btnBaoCao.BackColor = Color.FromArgb(92, 61, 46);
            if (!pnMain.Controls.Contains(BaoCao.Instance))
            {
                pnMain.Controls.Add(BaoCao.Instance);
                BaoCao.Instance.Dock = DockStyle.Fill;
                BaoCao.Instance.BringToFront();
            }
            else
                BaoCao.Instance.BringToFront();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap dangNhap = new FormDangNhap();
            dangNhap.ShowDialog();
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hide(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql = null;
            sql = "update NHANVIEN set TenNV = N'"+ txtHoTen.Text +"', NgaySinh = '"+ dtNgaySinh.Value.ToString() + 
               "', GioiTinh = '"+ txtGioiTinh.Text+"', SDT = '"+ txtSDT.Text+ "', DiaChi = N'"+txtDiaChi.Text+"', GhiChu = N'"+ txtGhiChu.Text +"' where MaNV = '"+manv+"'";
            dtBase.DataChange(sql);
            hide(false);
            dtBase.DataChange("UPDATE TAIKHOAN set MatKhau = N'" + mk.MaHoa(txtMatKhau.Text) + "' where MaTK = '" + txtTenDangNhap.Text + "'");
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Enabled)
            {
                txtHoTen.Text = table.Rows[0]["TenNV"].ToString();
                dtNgaySinh.Value = (DateTime)(table.Rows[0]["NgaySinh"]);
                txtGioiTinh.Text = table.Rows[0]["GioiTinh"].ToString();
                txtSDT.Text = table.Rows[0]["SDT"].ToString();
                txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
                txtTenDangNhap.Text = table.Rows[0]["MaTK"].ToString();
                txtMatKhau.Text = mk.GiaiMa(table.Rows[0]["MatKhau"].ToString());
            }
        }
        private void hideCH(Boolean t)
        {
            txtDiaChiCH.Enabled = t;
            txtSdtCH.Enabled = t;
            txtTenCH.Enabled = t;
            txtMaSoThue.Enabled = t;
        }
        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            hideCH(true);
        }

        private void btnApDungCH_Click(object sender, EventArgs e)
        {
            lblTextTop.Text = txtTenCH.Text;
            lblSDT.Text = txtSDT.Text;
            lblDiaChi.Text = txtDiaChiCH.Text;
            hideCH(false);
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'admin'");
            dgvPhanQuyen.Columns[0].Width = 50;
            dgvPhanQuyen.Columns[2].Width = 80;
        }

        private void rdbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'employee'");
            dgvPhanQuyen.Columns[0].Width = 50;
            dgvPhanQuyen.Columns[2].Width = 80;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDanhSachNhanVien dsnv = new FormDanhSachNhanVien();
            dsnv.ShowDialog();
        }

        private void btnApQuyen_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                dtBase.DataChange("update TAIKHOAN set PhanQuyen = 'admin' where MaNV ='"+ dgvDSNV.CurrentRow.Cells[0].Value.ToString()+ "'");
                dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'admin'");
                dgvPhanQuyen.Columns[0].Width = 50;
                dgvPhanQuyen.Columns[2].Width = 80;
                dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }    
            if(rdbEmployee.Checked)
            {
                dtBase.DataChange("update TAIKHOAN set PhanQuyen = 'employee' where MaNV ='" + dgvDSNV.CurrentRow.Cells[0].Value.ToString()+"'");
                dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'employee'");
                dgvPhanQuyen.Columns[0].Width = 50;
                dgvPhanQuyen.Columns[2].Width = 80;
                dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }    
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                dtBase.DataChange("update TAIKHOAN set PhanQuyen = '' where MaNV ='" + dgvPhanQuyen.CurrentRow.Cells[0].Value.ToString()+ "'");
                dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'admin'");
                dgvPhanQuyen.Columns[0].Width = 50;
                dgvPhanQuyen.Columns[2].Width = 80;
                dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }
            if (rdbEmployee.Checked)
            {
                dtBase.DataChange("update TAIKHOAN set PhanQuyen = '' where MaNV ='" + dgvPhanQuyen.CurrentRow.Cells[0].Value.ToString()+"'");
                dgvPhanQuyen.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV where PhanQuyen = 'employee'");
                dgvPhanQuyen.Columns[0].Width = 50;
                dgvPhanQuyen.Columns[2].Width = 80;
                dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }
        }

        private void lbAccount_Click(object sender, EventArgs e)
        {
        /*    giống với nút hệ thống*/
            resetColor();
            btnHeThong.BackColor = Color.FromArgb(92, 61, 46);
            pnMain.Controls.Add(tCt);
            tCt.BringToFront();
            table = dtBase.DataReturnTable("Select * from thongTinNV where MaTK = '" + acc + "'");
            if (table.Rows[0]["PhanQuyen"].ToString() != "admin")
            {
                tCt.TabPages.Remove(tPPhanQuyen);
            }
            txtHoTen.Text = table.Rows[0]["TenNV"].ToString();
            dtNgaySinh.Value = (DateTime)(table.Rows[0]["NgaySinh"]);
            txtGioiTinh.Text = table.Rows[0]["GioiTinh"].ToString();
            txtSDT.Text = table.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            txtTenDangNhap.Text = table.Rows[0]["MaTK"].ToString();
            txtMatKhau.Text = table.Rows[0]["MatKhau"].ToString();
            hide(false);
            dgvDSNV.DataSource = dtBase.DataReturnTable("select MaNV, TenNV, PhanQuyen from thongTinNV");
            
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string sql = "SELECT top (100) MaNV, TenNV, PhanQuyen from thongTinNV where  ";
            
            //kiem tra TenSP 
            if (txtSearchTenNV.Text.Trim() != "")
            {
                sql += " TenNV like N'%" + txtSearchTenNV.Text + "%'";
                dgvDSNV.DataSource = dtBase.DataReturnTable(sql);
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }
            //Load dữ liệu lên dataGridView
            else
            {
                dgvDSNV.DataSource = dtBase.DataReturnTable("SELECT top (100) MaNV, TenNV, PhanQuyen from thongTinNV");
                dgvDSNV.Columns[0].Width = 50;
                dgvDSNV.Columns[2].Width = 80;
            }
        }
    }
}
