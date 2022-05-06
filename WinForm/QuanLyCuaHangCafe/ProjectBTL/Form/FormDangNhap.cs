using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBTL;
using ProjectBTL.Model;

namespace BTL_LTTQ_K60
{
    public partial class FormDangNhap : Form
    {
        DataTable bd = new DataTable();
        DataBaseSQL dtBase = new DataBaseSQL();
        MaHoaMK mahoa = new MaHoaMK();
        public FormDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnDNhap_Click(object sender, EventArgs e)
        {
          
            bd = dtBase.DataReturnTable("Select * from TAIKHOAN where MaTK = '" + txtTK.Text + "'");
            if(bd.Rows.Count !=0)
            {
                String mk = mahoa.GiaiMa(bd.Rows[0]["MatKhau"].ToString());
                if ( mk == txtMK.Text)
                {
                    this.Hide();
                    TrangChu ft = new TrangChu(bd.Rows[0]["MaTK"].ToString());
                    ft.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(" Sai mật khẩu!", "Thông báo");
                    txtMK.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đăng nhập sai!", "Thông báo");
                txtTK.Focus();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           if (txtMK.UseSystemPasswordChar )
                txtMK.UseSystemPasswordChar = false;
           else
                txtMK.UseSystemPasswordChar = true;
        }
    }
}
