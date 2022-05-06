using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBTL.Model
{
    class Functions
    {
        DataBaseSQL dtb = new DataBaseSQL();

        public string SinhMaTuDong(string Bang, string TruongMa, string MaBatDau)
        {
            int id = 1;
            bool dung = false;
            DataTable dt = new DataTable();
            while (dung == false)
            {
                dt = dtb.DataReturnTable("Select * from " + Bang + " where " + TruongMa + "= '" + MaBatDau + id.ToString() + "'");
                if (dt.Rows.Count == 0)
                    dung = true;
                else
                {
                    id++;
                    dung = false;
                }
            }
            return (MaBatDau + id.ToString());
        }
    }
}
