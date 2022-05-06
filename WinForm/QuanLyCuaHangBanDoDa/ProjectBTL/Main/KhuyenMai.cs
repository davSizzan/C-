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
    public partial class KhuyenMai : UserControl
    {
        private static KhuyenMai _instance;
        public static KhuyenMai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhuyenMai();
                return _instance;
            }
        }
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnDoiDiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnKMTHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnKMTHH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnDSKM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnKHTAKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }
    }
}
