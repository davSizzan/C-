using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBTL.Main
{
    public partial class QuanLyBanHang : UserControl
    {
        private static QuanLyBanHang _instance;
        public static QuanLyBanHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QuanLyBanHang();
                return _instance;
            }
        }
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        private void btnMHTT_Click(object sender, EventArgs e)
        {
            FormHoaDonBanHang hoaDonBanHang = new FormHoaDonBanHang();
            hoaDonBanHang.ShowDialog();
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            FormBangGiaSP bangGiaSP = new FormBangGiaSP();
            bangGiaSP.ShowDialog();
        }

        private void btnTKHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnBCDTTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnBCDTTT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnBCCTBH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }
    }
}
