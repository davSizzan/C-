using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProjectBTL
{
    public partial class FormBangGiaSP : Form
    {
        Model.DataBaseSQL dtBase = new Model.DataBaseSQL();
        public FormBangGiaSP()
        {
            InitializeComponent();
        }

        void LoadTable()
        {
            dgvGiaSP.DataSource = dtBase.DataReturnTable("Select MaHang,TenHang,Loai,GiaBan from Hang");
        }

        void AnHTimKiem(bool x)
        {
            btnTimKiem.Enabled = x;
            if(x == false)
            {
                btnTimKiem.BackColor = Color.LightGray;
                btnTimKiem.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btnTimKiem.BackColor = Color.LightCyan;
                btnTimKiem.FlatStyle = FlatStyle.Flat;
            }
        }

        void reset()
        {
            txtGiaTu.Text = "";
            txtGiaDen.Text = "";
            cbbMaH.SelectedIndex = -1;
            cbbLoaiH.SelectedIndex = -1;
            cbbTenH.SelectedIndex = -1;
            AnHTimKiem(false);
        }

        private void FormBangGiaSP_Load(object sender, EventArgs e)
        {
            dgvGiaSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaSP.ReadOnly = true;
            cbbMaH.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbMaH.DisplayMember = "MaHang";
            cbbTenH.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbTenH.DisplayMember = "TenHang";
            cbbLoaiH.DataSource = dtBase.DataReturnTable("select DISTINCT Loai from Hang");
            cbbLoaiH.DisplayMember = "Loai";
            cbbMaH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaiH.DropDownStyle = ComboBoxStyle.DropDownList;
            reset();
            LoadTable();
        }

        private void txtGiaTu_TextChanged(object sender, EventArgs e)
        {
            if(txtGiaTu.Text != "" || txtGiaDen.Text != "" || cbbMaH.SelectedIndex != -1 ||
                cbbLoaiH.SelectedIndex != -1 || cbbTenH.SelectedIndex != -1)
            {
                AnHTimKiem(true);
            }
            else
            {
                AnHTimKiem(false);
            }
        }

        private void txtGiaDen_TextChanged(object sender, EventArgs e)
        {
            txtGiaTu_TextChanged(sender, e);
        }

        private void cbbMaH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaTu_TextChanged(sender, e);
        }

        private void cbbLoaiH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaTu_TextChanged(sender, e);
        }

        private void cbbTenH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaTu_TextChanged(sender, e);
        }

        void NhapSo(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
                Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên đương");
                e.Handled = true; //Bắt  phím được nhấn, ko hiển thị ký tự của phím đó ra
            }
        }

        private void txtGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            NhapSo(sender,e);
        }

        private void txtGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            NhapSo(sender,e);
        }

        string And(int d, string sql, string s)
        {
            if (d != 0)
                sql = sql + " and ";
            return sql + s;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "Select MaHang,TenHang,Loai,GiaBan from Hang where ";
            int d = 0;
            if (txtGiaTu.Text != "")
            {
                sql = sql + " GiaBan >= " + txtGiaTu.Text + " ";
                d++;
            }
            if (txtGiaDen.Text != "")
            {
                sql = And(d, sql, " GiaBan <= " + txtGiaDen.Text + " ");
                d++;
            }
            if (cbbMaH.SelectedIndex != -1)
            {
                sql = And(d, sql, " MaHang = N'" + cbbMaH.Text + "' ");
                d++;
            }
            if (cbbTenH.SelectedIndex != -1)
            {
                sql = And(d, sql, " TenHang = N'" + cbbTenH.Text + "' ");
                d++;
            }
            if (cbbLoaiH.SelectedIndex != -1)
            {
                sql = And(d, sql, " Loai = N'" + cbbLoaiH.Text + "'");
            }
            dgvGiaSP.DataSource = dtBase.DataReturnTable(sql);
            reset();
        }

        private void linkLblLamMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTable();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvGiaSP.Rows.Count > 1) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                exSheet.Cells.Style.Font.Name = "Times New Roman";

                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "CỬA HÀNG BÁN ĐỒ DA DHP";
                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: Số 3, đường Cầu Giấy, Quận Cầu Giấy, Hà Nội";
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0988888888";
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:J5").Merge(true);
                header.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH ĐƠN GIÁ SẢN PHẨM";
                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:J7").Font.Bold = true;
                exSheet.get_Range("A7:J7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("B7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã hàng";
                exSheet.get_Range("C7").Value = "Tên hàng";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Loại hàng";
                exSheet.get_Range("D7").ColumnWidth = 16;
                exSheet.get_Range("E7").Value = "Giá Bán";
                exSheet.get_Range("E7").ColumnWidth = 16;
                //In dữ liệu
                int i;
                for (i = 0; i < dgvGiaSP.Rows.Count - 1; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("A" + (i + 8).ToString() + ":E" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString() + ":E" + (i + 8).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dgvGiaSP.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dgvGiaSP.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dgvGiaSP.Rows[i].Cells[2].Value;
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dgvGiaSP.Rows[i].Cells[3].Value;
                }
                exSheet.Name = "GiaBan";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx |Word Document(*.doc)" +
                "| *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                    }
                    catch
                    {
                        MessageBox.Show("Không thể truy cập file! Vui lòng đóng file nếu còn mở", "Thông báo");
                    }
                }
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
