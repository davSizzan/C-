using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBTL
{
    public partial class FormChiTietHDN : Form
    {
        Model.DataBaseSQL dtBase = new Model.DataBaseSQL();
        public FormChiTietHDN()
        {
            InitializeComponent();
        }

        void reset()
        {
            cbbMaH.SelectedIndex = -1;
            cbbTenH.SelectedIndex = -1;
            cbbSoHD.SelectedIndex = -1;
            cbbNCC.SelectedIndex = -1;
            cbbNV.SelectedIndex = -1;
            radiobtnK.Checked = false;
            radiobtnCo.Checked = false;
        }

        void LoadTable()
        {
            dgvChiTietHDN.DataSource = dtBase.DataReturnTable("Select hdn.SoHDN,MaNV,ncc.MaNCC,ncc.SDT,h.MaHang,SoLuongNhap,NgayNhap,KhuyenMai,GiaNhap" +
                " from HoaDonNhap as hdn join CT_NHAP as ctn on ctn.SoHDN = hdn.SoHDN join NHACUNGCAP as ncc on ncc.MaNCC = hdn.MaNCC " +
                "join Hang as h on h.MaHang = ctn.MaHang");
        }

        void AnHTimKiem(bool x)
        {
            btnTimKiem.Enabled = x;
            if (x == false)
            {
                btnTimKiem.BackColor = Color.LightGray;
                btnTimKiem.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btnTimKiem.BackColor = Color.LightCyan;
                btnTimKiem.FlatStyle = FlatStyle.Flat;
            }
        }

        private void FormChiTietHDN_Load(object sender, EventArgs e)
        {
            LoadTable();
            AnHTimKiem(false);
            dgvChiTietHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHDN.ReadOnly = true;
            cbbSoHD.DataSource = dtBase.DataReturnTable("select * from HoaDonNhap");
            cbbSoHD.DisplayMember = "SoHDN";
            cbbSoHD.ValueMember = "SoHDN";
            cbbNCC.DataSource = dtBase.DataReturnTable("select * from NHACUNGCAP");
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
            cbbNV.DataSource = dtBase.DataReturnTable("select * from NHANVIEN");
            cbbNV.DisplayMember = "MaNV";
            cbbNV.ValueMember = "MaNV";
            cbbMaH.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbMaH.DisplayMember = "MaHang";
            cbbMaH.ValueMember = "MaHang";
            cbbTenH.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbTenH.DisplayMember = "TenHang";
            cbbTenH.ValueMember = "TenHang";
            cbbNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSoHD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenH.DropDownStyle = ComboBoxStyle.DropDownList;
            datetpTu.Format = DateTimePickerFormat.Short;
            datetpDen.Format = DateTimePickerFormat.Short;
            reset();
        }

        private void cbbSoHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMaH.SelectedIndex != -1 || cbbTenH.SelectedIndex != -1 || cbbNCC.SelectedIndex != -1 || 
                cbbSoHD.SelectedIndex != -1 || cbbNV.SelectedIndex != -1 || radiobtnCo.Checked == true )
            {
                AnHTimKiem(true);
            }
            else
            {
                AnHTimKiem(false);
            }
        }

        private void cbbMaH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void cbbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void cbbTenH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void radiobtnCo_CheckedChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void radiobtnK_CheckedChanged(object sender, EventArgs e)
        {
            cbbSoHD_SelectedIndexChanged(sender, e);
        }

        private void linkLblLamMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTable();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            AnHTimKiem(false);
            if(datetpTu.Value > datetpDen.Value)
            {
                MessageBox.Show("Ngày đến phải lớn hơn ngày bắt đấu!");
            }
            string sql = "Select hdn.SoHDN,MaNV,ncc.MaNCC,ncc.SDT,h.MaHang,SoLuongNhap,NgayNhap,KhuyenMai,GiaNhap" +
                " from HoaDonNhap as hdn join CT_NHAP as ctn on ctn.SoHDN = hdn.SoHDN join NHACUNGCAP as ncc on ncc.MaNCC = hdn.MaNCC " +
                "join Hang as h on h.MaHang = ctn.MaHang where ";
            int d = 0;
            if(cbbSoHD.Text != "")
            {
                d++;
                sql += " hdn.SoHDN = N'" + cbbSoHD.Text + "' ";
            }
            if(cbbNV.Text != "")
            {
                if (d != 0)
                    sql += " and ";
                sql += " MaNV = N'" + cbbNV.Text + "'";
                d++;
            }
            if (cbbNCC.SelectedIndex != -1)
            {
                if (d != 0)
                    sql += " and "; 
                sql += " ncc.MaNCC = N'" + cbbNCC.SelectedValue.ToString() + "'";
                d++;
            }
            if (cbbMaH.Text != "")
            {
                if (d != 0)
                    sql += " and ";
                sql += " h.MaHang = N'" + cbbMaH.Text + "'";
                d++;
            }
            if (cbbTenH.Text != "")
            {
                if (d != 0)
                    sql += " and ";
                sql += " TenHang = N'" + cbbTenH.Text + "'";
                d++;
            }
            if(radiobtnCo.Checked == true)
            {
                if (d != 0)
                    sql += " and ";
                sql += "NgayNhap >= '"+ datetpTu.Value.ToString("yyyy-MM-dd")+ "' and NgayNhap <= '"+ datetpDen.Value.ToString("yyyy-MM-dd") + "'";
            }
            dgvChiTietHDN.DataSource = dtBase.DataReturnTable(sql);
            reset();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
