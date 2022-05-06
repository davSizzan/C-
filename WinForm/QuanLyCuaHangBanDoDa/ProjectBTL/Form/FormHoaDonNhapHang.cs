using ProjectBTL.Model;
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

namespace BTL_LTTQ_K60
{
    public partial class FormHoaDonNhapHang : Form
    {
        DataBaseSQL dtBase = new DataBaseSQL();
        Functions func = new Functions();
        public FormHoaDonNhapHang()
        {
            InitializeComponent();
            dgvHoaDonNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtTien.Enabled = false;
            txtTongTienTra.Enabled = false;
            dateNgayLap.Format = DateTimePickerFormat.Short;
            for (int i = 25; i < 100; i += 25)
                cbbKhuyenMai.Items.Add(i);
        }

        double TienHang()
        {
            double km, tong = 0;
            if (dgvHoaDonNhapHang.CurrentRow.Cells[7].Value.ToString() == "")
                km = 0;
            else
                km = double.Parse(dgvHoaDonNhapHang.CurrentRow.Cells[7].Value.ToString());
            tong += double.Parse(dgvHoaDonNhapHang.CurrentRow.Cells[8].Value.ToString()) * int.Parse(dgvHoaDonNhapHang.CurrentRow.Cells[5].Value.ToString()) * (1 - km / 100);
            return tong;
        }

        double TongTienHang()
        {
            double km, tong;
            tong = 0;
            for (int i = 0; i < dgvHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dgvHoaDonNhapHang.Rows[i].Cells[7].Value.ToString() == "")
                    km = 0;
                else
                    km = double.Parse(dgvHoaDonNhapHang.Rows[i].Cells[7].Value.ToString());

                tong += double.Parse(dgvHoaDonNhapHang.Rows[i].Cells[8].Value.ToString()) * int.Parse(dgvHoaDonNhapHang.Rows[i].Cells[5].Value.ToString()) * (1 - km / 100);
            }
            return tong;
        }

        void LoadTable()
        {
            dgvHoaDonNhapHang.DataSource = dtBase.DataReturnTable("Select hdn.SoHDN,MaNV,ncc.MaNCC,ncc.SDT,h.MaHang,SoLuongNhap,NgayNhap,KhuyenMai,GiaNhap" + 
               " from HoaDonNhap as hdn join CT_NHAP as ctn on ctn.SoHDN = hdn.SoHDN "+
               " join NHACUNGCAP as ncc on ncc.MaNCC = hdn.MaNCC join HANG as h on h.MaHang = ctn.MaHang");
            dgvHoaDonNhapHang.ClearSelection();
            txtTongTienTra.Text = TongTienHang().ToString();
        }

        void LoadCTThem()
        {
            dgvHoaDonNhapHang.DataSource = dtBase.DataReturnTable("Select hdn.SoHDN,MaNV,ncc.MaNCC,ncc.SDT,h.MaHang,SoLuongNhap,NgayNhap,KhuyenMai,GiaNhap" +
                " from HoaDonNhap as hdn join CT_NHAP as ctn on ctn.SoHDN = hdn.SoHDN join NHACUNGCAP as ncc on ncc.MaNCC = hdn.MaNCC join Hang as h on h.MaHang = ctn.MaHang" +
                " where hdn.SoHDN = N'" + txtSoHD.Text + "'");
            dgvHoaDonNhapHang.ClearSelection();
            if (dgvHoaDonNhapHang.Rows.Count > 1)
                txtTongTienTra.Text = TongTienHang().ToString();
            else
                txtTongTienTra.Text = "";
        }

        void Reset()
        {
            txtSoHD.Text = "";
            txtSoHD.Focus();
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cbbNV.SelectedIndex = -1;
            cbbHang.SelectedIndex = -1;
            txtSLNhap.Text = "";
            cbbKhuyenMai.Text = "";
            txtTien.Text = "";
            txtTongTienTra.Text = "";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cbbNCC.Enabled = true;
            cbbNV.Enabled = true;
        }

        void khoa(bool a)
        {
            cbbNCC.Enabled = a;
            cbbNV.Enabled = a;
            dateNgayLap.Enabled = a;
            cbbHang.Enabled = a;
            txtSLNhap.Enabled = a;
            cbbKhuyenMai.Enabled = a;
        }

        private void FormHoaDonMuaHang_Load(object sender, EventArgs e)
        {
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            txtSoHD.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnLuu.Visible = false;
            dgvHoaDonNhapHang.ReadOnly = true;
            cbbHang.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbHang.DisplayMember = "TenHang";
            cbbHang.ValueMember = "MaHang";
            cbbNCC.DataSource = dtBase.DataReturnTable("select * from NHACUNGCAP");
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
            cbbNV.DataSource = dtBase.DataReturnTable("select * from NHANVIEN");
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";
            cbbNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHang.SelectedIndex = -1;
            cbbNCC.SelectedIndex = -1;
            cbbNV.SelectedIndex = -1;
            Reset();
            LoadTable();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            khoa(true);
            if (dgvHoaDonNhapHang.Rows.Count == 1)
            {
                MessageBox.Show("Bạn chưa có gì trong hóa đơn! Xin hãy nhập vào hoặc xóa!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn tạo hóa đơn mới không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
                txtSoHD.Text = func.SinhMaTuDong("CT_Nhap", "SoHDN", "");
                dtBase.DataChange("insert HoaDonNhap (SoHDN,MaNV,MaNCC,NgayNhap) values ('" + txtSoHD.Text + "',null,null,null)");
                LoadCTThem();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập nhà cung câp!");
                return;
            }
            if (cbbNV.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập nhân viên!");
                return;
            }
            if (cbbHang.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập hàng!");
                return;
            }
            if (txtSLNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập sô lượng!");
                return;
            }
            string sohd = txtSoHD.Text;
            if (dgvHoaDonNhapHang.Rows.Count == 1)
            {
                dtBase.DataChange("delete from HoaDonNhap where SoHDN = '" + sohd + "'");
                DataTable dtncc = dtBase.DataReturnTable("Select * from NHACUNGCAP where MaNCC = '" + cbbNCC.SelectedValue.ToString() + "'");
                DataTable dtnv = dtBase.DataReturnTable("Select * from NHANVIEN where MaNV = '" + cbbNV.SelectedValue.ToString() + "'");
                string manv = dtnv.Rows[0]["MaNV"].ToString();
                string mancc = dtncc.Rows[0]["MaNCC"].ToString();
                dtBase.DataChange("insert HoaDonNhap (SoHDN,MaNV,MaNCC,NgayNhap) values ('" + sohd + "','" + manv + "','" + mancc + "','" +
                    dateNgayLap.Value.Date.ToString("yyyy-MM-dd") + "')");
            }
            DataTable dth = dtBase.DataReturnTable("Select * from HANG where MaHang = '" + cbbHang.SelectedValue.ToString() + "'");
            for (int i = 0; i < dgvHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dth.Rows[0]["MaHang"].ToString() == dgvHoaDonNhapHang.Rows[i].Cells[4].Value.ToString())
                {
                    MessageBox.Show(dth.Rows[0]["MaHang"].ToString()+" đã có trong hóa đơn này!");
                    return;
                }
            }
            string mah = dth.Rows[0]["MaHang"].ToString();
            if (cbbKhuyenMai.Text == "")
            {
                dtBase.DataChange("insert CT_NHAP (SoHDN,MaHang,SoLuongNhap,KhuyenMai) values ('" + sohd + "','" + mah + "'," +
                 txtSLNhap.Text + ",null)");
            }
            else
            {
                dtBase.DataChange("insert CT_NHAP (SoHDN,MaHang,SoLuongNhap,KhuyenMai) values ('" + sohd + "','" + mah + "'," +
                 txtSLNhap.Text + ",'" + cbbKhuyenMai.Text + "')");
            }
            LoadCTThem();
            string km;
            if (cbbKhuyenMai.Text != "")
            {
                km = "N'" + cbbKhuyenMai.Text + "'";
                txtTien.Text = (double.Parse(dth.Rows[0]["GiaNhap"].ToString()) * int.Parse(txtSLNhap.Text) * (1 - double.Parse(cbbKhuyenMai.Text) / 100)).ToString();
            }
            else
            {
                km = "null";
                txtTien.Text = (double.Parse(dth.Rows[0]["GiaNhap"].ToString()) * int.Parse(txtSLNhap.Text)).ToString();
            }
            dgvHoaDonNhapHang.ClearSelection();
            cbbHang.SelectedIndex = -1;
            txtSLNhap.Text = "";
            cbbKhuyenMai.Text = "";
            cbbNCC.Enabled = false;
            cbbNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa hết dữ liệu liên quan tới hóa đơn "+txtSoHD.Text+" không?", "Thông báo", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.DataChange("delete from CT_NHAP where SoHDN = '" + txtSoHD.Text + "'");
                dtBase.DataChange("delete from HoaDonNhap where SoHDN = '" + txtSoHD.Text + "'");
                Reset();
                dgvHoaDonNhapHang.DataSource = "";
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhapHang.Rows.Count > 1) //TH có dữ liệu để ghi
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
                header.Value = "CHI TIẾT DANH SÁCH HÀNG NHẬP";
                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:J7").Font.Bold = true;
                exSheet.get_Range("A7:J7").HorizontalAlignment =  Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("B7").Value = "Số HDN";
                exSheet.get_Range("C7").Value = "Mã nhân viên";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Mã cung cấp";
                exSheet.get_Range("D7").ColumnWidth = 20;
                exSheet.get_Range("E7").Value = "SĐT";
                exSheet.get_Range("F7").Value = "Mã hàng";
                exSheet.get_Range("G7").Value = "SL nhập";
                exSheet.get_Range("G7").ColumnWidth = 18;
                exSheet.get_Range("H7").Value = "Ngày nhập";
                exSheet.get_Range("H7").ColumnWidth = 12;
                exSheet.get_Range("I7").Value = "Khuyến mãi";
                exSheet.get_Range("I7").ColumnWidth = 13;
                exSheet.get_Range("J7").Value = "Giá nhập";
                exSheet.get_Range("J7").ColumnWidth = 20;
                //In dữ liệu
                int i;
                for (i = 0; i < dgvHoaDonNhapHang.Rows.Count - 1; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":J" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString() + ":J" + (i + 8).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[2].Value;
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[3].Value;
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[4].Value;
                    exSheet.get_Range("G" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[5].Value;
                    exSheet.get_Range("H" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[6].Value;
                    exSheet.get_Range("I" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[7].Value;
                    exSheet.get_Range("J" + (i + 8).ToString()).Value = dgvHoaDonNhapHang.Rows[i].Cells[8].Value;
                }
                i = dgvHoaDonNhapHang.Rows.Count + 8;
                exSheet.get_Range("I" + (i).ToString()).Value = "Tổng: ";
                exSheet.get_Range("I" + (i).ToString()).Font.Bold = true;
                exSheet.get_Range("J" + (i).ToString()).Value = txtTongTienTra.Text;
                exSheet.Name = "HangNhap";
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

        private void lbLamMoi_Click(object sender, EventArgs e)
        {
            if(dgvHoaDonNhapHang.Rows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn đóng hóa đơn đang lập để xem danh sách chi tiết nhập không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    dtBase.DataChange("delete from HoaDonNhap where SoHDN = '" + txtSoHD.Text + "'");
                    Reset();
                    LoadTable();
                }
            }
            else
            {
                Reset();
                LoadTable();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void cbbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvHoaDonNhapHang.Rows.Count > 1)
            {
                if (btnLuu.Enabled == false)
                {
                    if (dgvHoaDonNhapHang.CurrentRow.Cells[1].Value.ToString() != cbbNV.SelectedValue.ToString() ||
                        dgvHoaDonNhapHang.CurrentRow.Cells[2].Value.ToString() != cbbNCC.SelectedValue.ToString() ||
                        dgvHoaDonNhapHang.CurrentRow.Cells[4].Value.ToString() != cbbHang.SelectedValue.ToString() ||
                        dgvHoaDonNhapHang.CurrentRow.Cells[5].Value.ToString() != txtSLNhap.Text ||
                        dgvHoaDonNhapHang.CurrentRow.Cells[7].Value.ToString() != cbbKhuyenMai.Text)
                    {
                        btnLuu.Enabled = true;
                    }
                }
            }
        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedIndex == -1 )
            {
                txtDiaChi.Text = "";
            }
            else
            {
                DataTable dtncc = dtBase.DataReturnTable("Select * from NHACUNGCAP where MaNCC = '" + cbbNCC.SelectedValue.ToString() + "'");
                if(dtncc.Rows.Count != 0)
                {
                    txtDiaChi.Text = dtncc.Rows[0]["DiaChi"].ToString();
                    txtSDT.Text = dtncc.Rows[0]["SDT"].ToString();
                }
            }
            cbbNV_SelectedIndexChanged(sender, e);
        }

        private void cbbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNV_SelectedIndexChanged(sender, e);
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            cbbNV_SelectedIndexChanged(sender, e);
        }
        
        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNV_SelectedIndexChanged(sender, e);
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

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            NhapSo(sender,e);
        }

        private void cbbKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            NhapSo(sender, e);
        }

        void XoaMotHang()
        {
            if (MessageBox.Show("Bạn có muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtTongTienTra.Text = (double.Parse(txtTongTienTra.Text) - TienHang()).ToString();
                dtBase.DataChange("delete from CT_NHAP where SoHDN = N'" + dgvHoaDonNhapHang.CurrentRow.Cells[0].Value.ToString() +
                    "' and MaHang = N'" + dgvHoaDonNhapHang.CurrentRow.Cells[4].Value.ToString() + "'");
                if (btnThem.Enabled == true)
                {
                    LoadCTThem();
                }
                else
                {
                    string sohd = dgvHoaDonNhapHang.CurrentRow.Cells[0].Value.ToString();
                    LoadTable();
                    int d = 0;
                    for (int i = 0; i < dgvHoaDonNhapHang.Rows.Count - 1; i++)
                    {
                        if (sohd == dgvHoaDonNhapHang.Rows[i].Cells[0].Value.ToString())
                        {
                            d++;
                            break;
                        }
                    }
                    if (d == 0)
                    {
                        dtBase.DataChange("delete from HoaDonNhap where SoHDN = '" + sohd + "'");
                    }
                }
                txtTien.Text = "";
            }
        }

        private void dgvHoaDonNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XoaMotHang();
        }

        string imgName;
        private void dgvHoaDonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dtncc = dtBase.DataReturnTable("Select * from NHACUNGCAP where MaNCC = '" + dgvHoaDonNhapHang.CurrentRow.Cells[2].Value.ToString() + "'");
                DataTable dtnv = dtBase.DataReturnTable("Select * from NHANVIEN where MaNV = '" + dgvHoaDonNhapHang.CurrentRow.Cells[1].Value.ToString() + "'");
                DataTable dth = dtBase.DataReturnTable("Select * from HANG where MaHang = '" + dgvHoaDonNhapHang.CurrentRow.Cells[4].Value.ToString() + "'");
                txtSoHD.Text = dgvHoaDonNhapHang.CurrentRow.Cells[0].Value.ToString();
                cbbNV.Text = dtnv.Rows[0]["TenNV"].ToString();
                cbbNCC.Text = dtncc.Rows[0]["TenNCC"].ToString();
                cbbHang.Text = dth.Rows[0]["TenHang"].ToString();
                txtSLNhap.Text = dgvHoaDonNhapHang.CurrentRow.Cells[5].Value.ToString();
                txtTien.Text = TienHang().ToString();
                if (dgvHoaDonNhapHang.CurrentRow.Cells[6].Value.ToString() != "")
                    dateNgayLap.Value = DateTime.Parse(dgvHoaDonNhapHang.CurrentRow.Cells[6].Value.ToString());
                else
                    dateNgayLap.Value = DateTime.Now;
                if (dgvHoaDonNhapHang.CurrentRow.Cells[7].Value.ToString() != "")
                    cbbKhuyenMai.Text = dgvHoaDonNhapHang.CurrentRow.Cells[7].Value.ToString();
                else
                    cbbKhuyenMai.Text = "";
                if (btnThem.Enabled == false)
                    khoa(false);
                DataTable dtAnh = dtBase.DataReturnTable("Select * from Hang where MaHang = N'" + dgvHoaDonNhapHang.CurrentRow.Cells[4].Value.ToString() + "'");
                imgName = dtAnh.Rows[0]["Anh"].ToString();
                picAnh.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\" + imgName);
            }
            catch
            {

            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                khoa(true);
                btnLuu.Visible = true;
                btnLuu.Enabled = false;
            }
            else
            {
                btnThem.Enabled = false;
                btnLuu.Visible = true;
                btnLuu.Enabled = false;
            }
        }

        private void DelOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaMotHang();
        }

        private void DelAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
            lbLamMoi_Click(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Lưu không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.DataChange("update CT_NHAP set MaHang = N'" + cbbHang.SelectedValue.ToString() + "' where SoHDN = N'" + txtSoHD.Text + "' and MaHang = N'"+ dgvHoaDonNhapHang.CurrentRow.Cells[4].Value.ToString()+"'");
                dtBase.DataChange("update CT_NHAP set SoLuongNhap = N'" + txtSLNhap.Text + "' where SoHDN = N'" + txtSoHD.Text + "' and MaHang = N'" + cbbHang.SelectedValue.ToString() + "' ");
                string km;
                if (cbbKhuyenMai.Text == "")
                    km = null;
                else
                    km = cbbKhuyenMai.Text;
                dtBase.DataChange("update CT_NHAP set KhuyenMai = N'" + km + "' where SoHDN = N'" + txtSoHD.Text + "' and MaHang = N'" + cbbHang.SelectedValue.ToString() + "' ");
                MessageBox.Show("Đã lưu thành công!");
                btnLuu.Visible = false;
                if (btnXoa.Enabled == false)
                {
                    dtBase.DataChange("update HoaDonNhap set MaNV = N'" + cbbNV.SelectedValue.ToString() + "' where SoHDN = N'" + txtSoHD.Text + "'");
                    dtBase.DataChange("update HoaDonNhap set MaNCC = N'" + cbbNCC.SelectedValue.ToString() + "' where SoHDN = N'" + txtSoHD.Text + "'");
                    lbLamMoi_Click(sender, e);
                }
                else
                {
                    LoadCTThem();
                    cbbHang.SelectedIndex = -1;
                    txtSLNhap.Text = "";
                    btnThem.Enabled = true;
                }
            }
        }
    }
}
