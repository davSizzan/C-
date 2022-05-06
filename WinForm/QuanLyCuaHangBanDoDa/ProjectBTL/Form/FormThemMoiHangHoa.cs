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
    public partial class FormThemMoiHangHoa : Form
    {
        DataBaseSQL dataBase = new DataBaseSQL();
        String sql = null;
        Functions functions = new Functions();
        public FormThemMoiHangHoa()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (txtMaH.Text == "" || txtTenH.Text=="" || txtLoai.Text=="" || txtCL.Text=="" || txtGiaB.Text=="" ||txtGiaN.Text=="")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
                return;
            }
           
            /*Thêm vào bảng hàng*/
            sql = ("insert HANG (MaHang,TenHang,Loai,ChatLuong,GiaNhap,GiaBan) values ( N'");
            sql += txtMaH.Text + "',N'" + txtTenH.Text + "','" + txtLoai.Text + "',N'" + txtCL.Text + "','" + txtGiaN.Text + "','" +txtGiaB.Text + "')";
            dataBase.DataChange(sql);
            MessageBox.Show("Thêm mới thành công!", "Thông báo");
            Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThemMoiHangHoa_Load(object sender, EventArgs e)
        {
            txtMaH.Text = functions.SinhMaTuDong("Hang", "MaHang", "H");
            txtMaH.Enabled = false;
        }
    }
}
