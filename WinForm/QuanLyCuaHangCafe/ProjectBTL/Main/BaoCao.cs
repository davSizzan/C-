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
    public partial class BaoCao : UserControl
    {
        private static BaoCao _instance;
        public static BaoCao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BaoCao();
                return _instance;
            }
        }
        public BaoCao()
        {
            InitializeComponent();
        }

        private void btnBCKQKD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnTHCHPDN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }

        private void btnDGCH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần này chưa được xử lý!", "Thông báo");
        }
    }
}
