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
using Excel = Microsoft.Office.Interop.Excel;


namespace BTL_LTTQ_K60
{
    public partial class FormDSHangHoaSearch : Form
    {
        DataBaseSQL dtBase = new DataBaseSQL();
        //DataTable dtHang = new DataTable();
        Functions func = new Functions();
        public FormDSHangHoaSearch()
        {
            InitializeComponent();
            btnTimKiem.FlatStyle = FlatStyle.Flat;
        }
        void enableTK()
        {
            if (dtpTimTuNgay.Text ==  dtpTimDenNgay.Text  && txtTimMaH.Text == "" &&
                txtTimTenH.Text == "" && txtSL.Text == "" && txtLoai.Text == "")
            {
                btnTimKiem.Enabled = false;
                btnTimKiem.BackColor = Color.LightGray;
            }
            else
            {
                btnTimKiem.Enabled = true;
                btnTimKiem.BackColor = Color.LightCyan;
            }
        }
        void LoadTable()
        {
            dgvDSCanTim.DataSource = dtBase.DataReturnTable("Select top (100) * from DanhSachHang ");
        }
        private void FormDSHangHoaSearch_Load(object sender, EventArgs e)
        {
            enableTK();
            LoadTable();
            grbSearch.Enabled = true;
            grbSearch.Visible = true;
            panel1.Enabled = false;
            panel1.Visible = false;
        }
        private void labelHienDKLoc_Click(object sender, EventArgs e)
        {
            if (grbSearch.Enabled)
            {

                grbSearch.Enabled = false;
                grbSearch.Visible = false;
                panel1.Enabled = true;
                panel1.Visible = true;
            }
            else
            {
                grbSearch.Enabled = true;
                grbSearch.Visible = true;
                panel1.Enabled = false;
                panel1.Visible = false;
            }    
        }

        private void txtTimMaH_TextChanged(object sender, EventArgs e)
        {
            enableTK();
        }

        private void grbHiendk_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from DanhSachHang  where MaHang is not null";
            if (dtpTimTuNgay.Text != dtpTimDenNgay.Text)
            {
                sql += " and NgayNhap <= '" + dtpTimDenNgay.Value.ToString() + "' and NgayNhap >= '" + dtpTimTuNgay.Value.ToString() + "'";
            }
            if (txtTimMaH.Text != "")
            {
                sql += " and MaHang Like N'%" + txtTimMaH.Text.Trim() + "%'";
            }
            if (txtTimTenH.Text != "")
            {
                sql += " and TenHang Like N'%" + txtTimTenH.Text.Trim() + "%'";
            }
            
            if (txtLoai.Text != "")
            {
                sql += " and Loai Like N'%" + txtLoai.Text.Trim() + "%'";
            }
            dgvDSCanTim.DataSource = dtBase.DataReturnTable(sql);
            //dtHang = dtBase.DataReturnTable(sql);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void dgvDSCanTim_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.DataChange("delete from Hang where MaHang = N'" + dgvDSCanTim.CurrentRow.Cells[0].Value.ToString() +
                    "'");
                LoadTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*dtBase.DataChange("insert Hang (MaHang,TenHang,Loai,GiaNhap,GiaBan) values ('" + func.SinhMaTuDong("Hang", "MaHang", "H")
              + "',' ',' ',0,0)");
            LoadTable();
            dgvDSCanTim.ClearSelection();
            dgvDSCanTim.Focus();
            dgvDSCanTim.CurrentCell = dgvDSCanTim.Rows[0].Cells[1];
            dgvDSCanTim.Rows[0].Cells[1].Selected = true;*/
            FormThemMoiHangHoa hangHoa = new FormThemMoiHangHoa();
            hangHoa.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvDSCanTim.Rows.Count > 0)
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook =exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
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
                header.Value = "DANH SÁCH HÀNG HOÁ";
                //Định dạng tiêu đề bảng
                exSheet.get_Range("A6:J6").Font.Bold = true;
                exSheet.get_Range("A6:J6").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A6").Value = "STT";
                exSheet.get_Range("B6").Value = "Mã Hàng";
                exSheet.get_Range("B6").ColumnWidth = 20;
                exSheet.get_Range("C6").Value = "Tên Hàng";
                exSheet.get_Range("C6").ColumnWidth = 20;
                exSheet.get_Range("D6").Value = "Loại";
                exSheet.get_Range("D6").ColumnWidth = 20;
                exSheet.get_Range("E6").Value = "Chất Lượng";
                exSheet.get_Range("E6").ColumnWidth = 20;
                exSheet.get_Range("F6").Value = "Giá Nhập";
                exSheet.get_Range("F6").ColumnWidth = 18;
                exSheet.get_Range("G6").Value = "Giá Bán";
                exSheet.get_Range("G6").ColumnWidth = 18;
          
                for (int i = 0; i < dgvDSCanTim.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).HorizontalAlignment 
                    = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dgvDSCanTim.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 8).ToString()).Value =dgvDSCanTim.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 8).ToString()).Value =dgvDSCanTim.Rows[i].Cells[2].Value;
                    exSheet.get_Range("E" + (i + 8).ToString()).Value =dgvDSCanTim.Rows[i].Cells[3].Value;
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dgvDSCanTim.Rows[i].Cells[4].Value;
                    exSheet.get_Range("G" + (i + 8).ToString()).Value =dgvDSCanTim.Rows[i].Cells[5].Value;
                }
                exSheet.Name = "HANG";
                exBook.Activate();
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1; 
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
             }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = (DataTable)dgvDSCanTim.DataSource;
            string s;
            for (int i =0; i< table.Rows.Count-1; i++)
            {
                s = " update HANG set TenHang = N'" + table.Rows[i]["TenHang"] + "', GiaNhap = '" + table.Rows[i]["GiaNhap"]
                    + "', GiaBan = '" + table.Rows[i]["GiaBan"] + "' where MaHang = '"+ table.Rows[i]["MaHang"]+"'";
                dtBase.DataChange(s);
            }
            MessageBox.Show("Lưu thành công", "Thông báo");
            LoadTable();
        }

        private void btnicSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from DanhSachHang where MaHang is not null";

            if (txtMaHang.Text != "")
            {
                sql += " and MaHang Like N'%" + txtMaHang.Text.Trim() + "%'";
            }
             
            if (txtTenHang.Text != "")
            {
                sql += " and TenHang Like N'%" + txtTenHang.Text.Trim() + "%'";
            }
            dgvDSCanTim.DataSource = dtBase.DataReturnTable(sql);
        }

        private void dtpTimTuNgay_ValueChanged(object sender, EventArgs e)
        {
            enableTK();
        }

        private void txtTimMaH_TextChanged_2(object sender, EventArgs e)
        {
            enableTK();
        }

        private void txtTimTenH_TextChanged(object sender, EventArgs e)
        {
            enableTK();
        }

        private void txtLoai_TextChanged_1(object sender, EventArgs e)
        {
            enableTK();
        }
    }
}
