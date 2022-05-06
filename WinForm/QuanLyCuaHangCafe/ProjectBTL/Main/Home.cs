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
    public partial class Home : UserControl
    {
        private static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 1; i < 31; i++)
            {
                DoanhThuThang.Series["Triệu VND"].Points.AddXY(i, rd.Next(2, 50));
            };
            for(int i=1; i<13;i++)
                DoanhThu12Thang.Series["Triệu VND"].Points.AddXY(i, rd.Next(80, 700));
            SPBanChay.Series["SP"].Points.AddXY("Sản phẩm 1",2000);
            SPBanChay.Series["SP"].Points.AddXY("Sản phẩm 2", 5000);
            SPBanChay.Series["SP"].Points.AddXY("Sản phẩm 3", 2200);
            SPBanChay.Series["SP"].Points.AddXY("Sản phẩm 4", 1200);
            SPBanChay.Series["SP"].Points.AddXY("Sản phẩm 5", 8600);
        

        }

    }
}
