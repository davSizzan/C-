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

namespace ProjectBTL.Main
{
    public partial class QuanLyMuaHang : UserControl
    {
        private static QuanLyMuaHang _instance;
        public static QuanLyMuaHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QuanLyMuaHang();
                return _instance;
            }
        }
        public QuanLyMuaHang()
        {
            InitializeComponent();
        }

        private void btnHDNH_Click(object sender, EventArgs e)
        {
            FormHoaDonNhapHang mh = new FormHoaDonNhapHang();
            mh.ShowDialog();
        }

        private void btnCTMH_Click(object sender, EventArgs e)
        {
            FormChiTietHDN formChiTietHDN = new FormChiTietHDN();
            formChiTietHDN.ShowDialog();
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnPTHNCC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnTKHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnSQTM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnSQTNH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }
    }
}
