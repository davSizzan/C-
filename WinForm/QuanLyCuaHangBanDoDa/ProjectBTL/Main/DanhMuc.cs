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
    public partial class DanhMuc : UserControl
    {
        private static DanhMuc _instance;
        public static DanhMuc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhMuc();
                return _instance;
            }
        }
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void btnDSHH_Click(object sender, EventArgs e)
        {

        }

        private void btnTMNCC_Click(object sender, EventArgs e)
        {

        }

        private void btnDSHH_Click_1(object sender, EventArgs e)
        {
            FormDSHangHoaSearch hh = new FormDSHangHoaSearch();
            hh.ShowDialog();
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            FormDoiTac doiTac = new FormDoiTac();
            doiTac.ShowDialog();
        }

        private void btnTMHH_Click(object sender, EventArgs e)
        {
            FormThemMoiHangHoa formThemMoiHangHoa = new FormThemMoiHangHoa();
            formThemMoiHangHoa.ShowDialog();
        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnTMNCC_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }
    }
}
