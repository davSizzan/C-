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
    public partial class FormThemNV : Form
    {
        DataBaseSQL dataBase = new DataBaseSQL();
        Functions func = new Functions();
        String sql = null;
        MaHoaMK mk = new MaHoaMK();
        public FormThemNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text == "")
            {
                MessageBox.Show("Không được để trống Số điện thoại", "Thông báo");
                return;
            }
            if (dataBase.DataReturnTable("Select * from NHANVIEN where SDT = '" + txtSDT.Text + "'").Rows.Count != 0)
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo");
                txtSDT.Focus();
            }
            else
            {
                string mnv = func.SinhMaTuDong("NHANVIEN", "MANV", "NV");
                /*      Thêm vào bảng nhân viên*/
                sql = ("insert NHANVIEN (MaNV,TenNV,GioiTinh,NgaySinh,DiaChi,SDT,Luong,GhiChu) values ('" + mnv
                    + "',N'");
                sql += txtHoTen.Text + "',N'" + cbGioiTinh.Text + "','" + dateTimePicker1.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" +
                    txtLuong.Text + "',N'" + txtGhiChu.Text + "')";
                dataBase.DataChange(sql);
                /*   thêm vào bảng tài khoản*/
                sql = "insert TAIKHOAN (MaTK, MaNV, MatKhau) values ('" + txtSDT.Text + "','" + mnv + "','" + mk.MaHoa("123456") + "')";
                dataBase.DataChange(sql);
                MessageBox.Show("Successfully", " Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
