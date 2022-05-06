using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBTL.Model;

namespace ProjectBTL
{
    public partial class FormDanhSachNhanVien : Form
    {
        private DataBaseSQL dt = new DataBaseSQL();
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.DataReturnTable("select * from NHANVIEN");
            btnXoaNV.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormThemNV themNV = new FormThemNV();
            themNV.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dt.DataChange("delete from NHANVIEN where MaNV = N'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                    "'");
                dt.DataChange("delete from TAIKHOAN where MaNV = N'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                   "'");
                dataGridView1.DataSource = dt.DataReturnTable("select * from NHANVIEN");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dt.DataChange("delete from TAIKHOAN where MaNV = N'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                    "'");
                dt.DataChange("delete from NHANVIEN where MaNV = N'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                    "'");

                dataGridView1.DataSource = dt.DataReturnTable("select * from NHANVIEN");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaNV.Enabled = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN where MaNV is not null ";
            //Tim theo MaSP
            if (txtMaNV.Text != "")
            {
                sql += " and MaNV like '%" + txtMaNV.Text + "%'";
            }
            //kiem tra TenSP 
            if (txtTenNV.Text != "")
            {
                sql += " and TenNV like N'%" + txtTenNV.Text + "%'";
            }
            //Load dữ liệu lên dataGridView
            dataGridView1.DataSource = dt.DataReturnTable(sql);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.DataReturnTable("Select * from NHANVIEN");
        }
    }
}
