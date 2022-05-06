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
    public partial class FormHoaDonBanHang : Form
    {
        Model.DataBaseSQL dtBase = new Model.DataBaseSQL();
        Model.Functions fc = new Model.Functions();
        public FormHoaDonBanHang()
        {
            InitializeComponent();
        }

        void Reset(Boolean x)
        {
            cbbTenH.Text = "";
            cbbLoaiH.SelectedIndex = -1;
            txtSL.Text = "";
            txtKM.Text = "";
            if (x == true)
            {
                txtSoHD.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                cbbNV.SelectedIndex = -1;
                txtTongCong.Text = "";
                txtTienHang.Text = "";
            }
            btnThem.Enabled = false;
        }

        double TienHang(int csl, int cgia, int ckm)
        {
            double km, tong = 0;
            if (dgvHDB.CurrentRow.Cells[ckm].Value.ToString() == "")
                km = 0;
            else
                km = double.Parse(dgvHDB.CurrentRow.Cells[ckm].Value.ToString());
            tong += double.Parse(dgvHDB.CurrentRow.Cells[cgia].Value.ToString()) * int.Parse(dgvHDB.CurrentRow.Cells[csl].Value.ToString()) * (1 - km / 100);
            return tong;
        }

        double TongTienHang(int csl, int cgia, int ckm)
        {
            double km, tong;
            tong = 0;
            for (int i = 0; i < dgvHDB.Rows.Count - 1; i++)
            {
                if (dgvHDB.Rows[i].Cells[ckm].Value.ToString() == "")
                    km = 0;
                else
                    km = double.Parse(dgvHDB.Rows[i].Cells[ckm].Value.ToString());

                tong += double.Parse(dgvHDB.Rows[i].Cells[cgia].Value.ToString()) * int.Parse(dgvHDB.Rows[i].Cells[csl].Value.ToString()) * (1 - km / 100);
            }
            return tong;
        }

        void LoadHang()
        {
            dgvHang.DataSource = dtBase.DataReturnTable("select TenHang from Hang");
            dgvHang.ClearSelection();
        }

        void LoadHDBan(string sql)
        {
            dgvHDB.DataSource = "";
            dgvHDB.DataSource = dtBase.DataReturnTable("select hdb.SoHDB, MaNV, hdb.MaKH, NgayBan, TenHang, SoLuongBan, GiaBan, KhuyenMai from HoaDonBan as hdb " +
            "  join CT_Ban as ctb on ctb.SoHDB = hdb.SoHDB join Hang as h on h.MaHang = ctb.MaHang " + sql);
            txtTongCong.Text = TongTienHang(5, 6, 7).ToString();
        }

        void LoadCTBan()
        {
            dgvHDB.DataSource = dtBase.DataReturnTable("Select TenHang, NgayBan, SoLuongBan, GiaBan, KhuyenMai " +
                " from HoaDonBan as hdb join CT_Ban as ctb on ctb.SoHDB = hdb.SoHDB join Hang as h on h.MaHang = ctb.MaHang" +
                " where hdb.SoHDB = N'" + txtSoHD.Text + "'");
            dgvHDB.ClearSelection();
            txtTongCong.Text = TongTienHang(2, 3, 4).ToString();
        }

        private void FormHoaDonBanHang_Load(object sender, EventArgs e)
        {
            btnLuu.Visible = false;
            LoadHang();
            tlbTinhTien.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.ReadOnly = true;
            dgvHDB.ReadOnly = true;
            cbbTenH.DataSource = dtBase.DataReturnTable("select * from Hang");
            cbbTenH.DisplayMember = "TenHang";
            cbbLoaiH.DataSource = dtBase.DataReturnTable("select DISTINCT Loai from Hang");
            cbbLoaiH.DisplayMember = "Loai";
            cbbNV.DataSource = dtBase.DataReturnTable("Select * from NHANVIEN");
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";
            cbbLoaiH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNV.DropDownStyle = ComboBoxStyle.DropDownList;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            txtSoHD.Enabled = false;
            btnHuyDon.Enabled = false;
            Reset(true);
            txtTongCong.ForeColor = Color.Red;
            txtTienTraLai.ForeColor = Color.Red;
            txtTongCong.Enabled = false;
            txtTienHang.Enabled = false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
                Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên đương");
                e.Handled = true; //Bắt  phím được nhấn, ko hiển thị ký tự của phím đó ra
            }
        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSL_KeyPress(sender, e);
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if ((dgvHang.SelectedCells.Count == 1 || dgvHang.SelectedRows.Count == 1) && txtSL.Text != "" && btnHuyDon.Enabled == true
                && cbbNV.SelectedIndex != -1 && txtTenKH.Text != "")
            {
                btnThem.Enabled = true;
            }
            else
                btnThem.Enabled = false;
            if (btnLuu.Visible == true)
            {
                int r = dgvHDB.CurrentRow.Index;
                if (dgvHDB.Columns.Count > 6)
                {
                    if (txtSL.Text != dgvHDB.Rows[r].Cells[5].Value.ToString() || txtKM.Text != dgvHDB.Rows[r].Cells[7].Value.ToString() ||
                        cbbNV.SelectedValue != dgvHDB.Rows[r].Cells[1].Value)
                    {
                        btnLuu.Enabled = true;
                    }
                }
                else
                {
                    if (txtSL.Text != dgvHDB.Rows[r].Cells[2].Value.ToString() || txtKM.Text != dgvHDB.Rows[r].Cells[4].Value.ToString())
                    {
                        btnLuu.Enabled = true;
                    }
                }
            }
        }

        private void cbbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSL_TextChanged(sender, e);
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            txtSL_TextChanged(sender, e);
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            txtSL_TextChanged(sender, e);
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSL_TextChanged(sender, e);
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDB.Rows.Count > 1 && dgvHDB.CurrentCell.RowIndex != dgvHDB.Rows.Count - 1)
            {
                if (dgvHDB.Columns.Count > 6)
                {
                    DataTable dtnv = dtBase.DataReturnTable("Select * from NHANVIEN where MaNV = '" + dgvHDB.CurrentRow.Cells[1].Value.ToString() + "'");
                    DataTable dtkh = dtBase.DataReturnTable("Select * from KhachHang where MaKH = N'" + dgvHDB.CurrentRow.Cells[2].Value.ToString() + "'");
                    DataTable dth = dtBase.DataReturnTable("Select * from HANG where TenHang = N'" + dgvHDB.CurrentRow.Cells[4].Value.ToString() + "'");
                    txtSoHD.Text = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                    txtTenKH.Text = dtkh.Rows[0]["TenKH"].ToString();
                    cbbNV.Text = dtnv.Rows[0]["TenNV"].ToString();
                    txtSL.Text = dgvHDB.CurrentRow.Cells[5].Value.ToString();
                    if (dgvHDB.CurrentRow.Cells[7].Value.ToString() != "")
                        txtKM.Text = dgvHDB.CurrentRow.Cells[7].Value.ToString();
                    else
                        txtKM.Text = "";
                    txtTienHang.Text = TienHang(5, 6, 7).ToString();
                    txtSDT.Text = dtkh.Rows[0]["SDT"].ToString();
                    for (int i = 0; i < dgvHang.Rows.Count - 1; i++)
                    {
                        if (dgvHDB.CurrentRow.Cells[4].Value.ToString() == dgvHang.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvHang.ClearSelection();
                            dgvHang.Rows[i].Cells[0].Selected = true;
                            break;
                        }
                    }

                }
                else
                {
                    txtSL.Text = dgvHDB.CurrentRow.Cells[2].Value.ToString();
                    if (dgvHDB.CurrentRow.Cells[4].Value.ToString() != "")
                        txtKM.Text = dgvHDB.CurrentRow.Cells[4].Value.ToString();
                    else
                        txtKM.Text = "";
                    txtTienHang.Text = TienHang(2, 3, 4).ToString();
                    for (int i = 0; i < dgvHang.Rows.Count - 1; i++)
                    {
                        if (dgvHDB.CurrentRow.Cells[0].Value.ToString() == dgvHang.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvHang.ClearSelection();
                            dgvHang.Rows[i].Cells[0].Selected = true;
                            break;
                        }
                    }
                }
            }
            if (dgvHDB.Rows.Count > 1 && dgvHDB.CurrentCell.RowIndex == dgvHDB.Rows.Count - 1)
            {
                string a = txtTongCong.Text;
                Reset(true);
                txtTongCong.Text = a;
            }

        }

        private void dgvHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDB.Rows.Count > 1 && dgvHDB.CurrentCell.RowIndex != dgvHDB.Rows.Count - 1)
            {
                LoadHDBan("where hdb.SoHDB = N'" + dgvHDB.CurrentRow.Cells[0].Value.ToString() + "'");
            }
        }

        private void cbbTenH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenH.Text != "" || cbbLoaiH.SelectedIndex != -1)
            {
                btnTimKiem.Enabled = true;
                btnTimKiem.BackColor = Color.LightCyan;
            }
            else
            {
                btnTimKiem.Enabled = false;
                btnTimKiem.BackColor = Color.LightGray;
            }
        }

        private void cbbLoaiH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenH_SelectedIndexChanged(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = false;
            string sql = "select TenHang from Hang where ";
            if (cbbTenH.Text != "")
            {
                sql += "TenHang like N'%" + cbbTenH.Text + "%'";
                if (cbbLoaiH.SelectedIndex != -1)
                    sql += " and Loai = N'" + cbbLoaiH.Text + "'";
            }
            else
            {
                sql += "Loai = N'" + cbbLoaiH.Text + "'";
            }
            dgvHang.DataSource = dtBase.DataReturnTable(sql);
            Reset(false);
        }

        private void linklblLamMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadHang();
        }

        void KhoaDon(Boolean x)
        {
            btnDonMoi.Enabled = !x;
            btnHuyDon.Enabled = x;
        }

        void KhoaNV_KH(Boolean x)
        {
            cbbNV.Enabled = x;
            txtTenKH.Enabled = x;
        }

        private void btnDonMoi_Click(object sender, EventArgs e)
        {
            if (btnHuyDon.Enabled == false)
            {
                if (MessageBox.Show("Bạn có muốn tạo hóa đơn mới không?", "Thông báo", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn lưu hóa đơn đang dùng và tạo hóa đơn mới không?", "Thông báo", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            Reset(true);
            txtSoHD.Text = fc.SinhMaTuDong("CT_Ban", "SoHDB", "");
            dtBase.DataChange("insert HoaDonBan (SoHDB,MaNV,MaKH,NgayBan) values ('" + txtSoHD.Text +
                "',null,null,'" + DateTime.Today.Date.ToString("yyyy-MM-dd") + "')");
            LoadCTBan();
            KhoaDon(true);
            KhoaNV_KH(true);
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtSoHD.Text = fc.SinhMaTuDong("CT_Ban", "SoHDB", "");
                dtBase.DataChange("delete from CT_Ban where SoHDB = '" + txtSoHD.Text + "'");
                dtBase.DataChange("delete from HoaDonBan where SoHDB = '" + txtSoHD.Text + "'");
                Reset(true);
                KhoaDon(false);
                dgvHDB.DataSource = "";
            }
        }

        DataTable KH(string sdt)
        {
            return dtBase.DataReturnTable("Select * from KhachHang where SDT = N'" + sdt + "'");
        }

        int SLcon()
        {
            DataTable dtn, dtb;
            if (dgvHDB.Columns.Count > 6)
            {
                dtn = dtBase.DataReturnTable("Select MaHang from Hang where TenHang = N'" + dgvHang.CurrentRow.Cells[4].Value.ToString() + "'");
            }
            else
            {
                dtn = dtBase.DataReturnTable("Select MaHang from Hang where TenHang = N'" + dgvHang.CurrentRow.Cells[0].Value.ToString() + "'");
            }
            string mah = dtn.Rows[0]["MaHang"].ToString();
            dtn = dtBase.DataReturnTable("Select Sum(SoLuongNhap) as SLNhap from ct_nhap where MaHang = N'" + mah + "'");
            dtb = dtBase.DataReturnTable("Select Sum(SoLuongBan) as SLBan from ct_ban where MaHang = N'" + mah + "'");
            if (dtb.Rows[0]["SLBan"].ToString() == "")
            {
                return int.Parse(dtn.Rows[0]["SLNhap"].ToString());
            }
            else
                return int.Parse(dtn.Rows[0]["SLNhap"].ToString()) - int.Parse(dtb.Rows[0]["SLBan"].ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SLcon() < int.Parse(txtSL.Text))
            {
                MessageBox.Show(dgvHang.CurrentRow.Cells[0].Value.ToString() + " trong kho chỉ còn " + SLcon());
                return;
            }
            DataTable dth = dtBase.DataReturnTable("Select MaHang,TenHang,GiaBan from HANG where TenHang = N'" + dgvHang.CurrentRow.Cells[0].Value.ToString() + "'");
            for (int i = 0; i < dgvHDB.Rows.Count - 1; i++)
            {
                if (dgvHang.CurrentRow.Cells[0].Value.ToString() == dgvHDB.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show(dth.Rows[0]["TenHang"].ToString() + " đã có trong hóa đơn này!");
                    return;
                }
            }

            if (dgvHDB.Rows.Count == 1)
            {
                dtBase.DataChange("update HoaDonBan set MaNV = N'" + cbbNV.SelectedValue.ToString() + "' where SoHDB = N'" + txtSoHD.Text + "'");
            }
            DataTable dtkh;
            dtkh = KH(txtSDT.Text);
            if (dtkh.Rows.Count > 0)
            {
                dtBase.DataChange("update HoaDonBan set MaKH = N'" + dtkh.Rows[0]["MaKH"] + "' where SoHDB = N'" + txtSoHD.Text + "'");
            }
            else
            {
                string makh = fc.SinhMaTuDong("KhachHang", "MaKH", "");
                if (txtSDT.Text == "")
                {
                    dtBase.DataChange("insert KHACHHANG (MaKH,TenKH,SDT) values ('" + makh + "','" +
                        txtTenKH.Text + "',null)");
                    dtBase.DataChange("update HoaDonBan set MaKH = N'" + makh + "' where SoHDB = N'" + txtSoHD.Text + "'");
                }
                else
                {
                    dtBase.DataChange("insert KHACHHANG (MaKH,TenKH,SDT) values ('" + makh + "','" +
                        txtTenKH.Text + "',N'" + txtSDT.Text + "')");
                    dtBase.DataChange("update HoaDonBan set MaKH = N'" + makh + "' where SoHDB = N'" + txtSoHD.Text + "'");
                    txtSDT.Enabled = false;
                }
            }
            string km;
            if (txtKM.Text != "")
            {
                km = "N'" + txtKM.Text + "'";
                txtTienHang.Text = (double.Parse(dth.Rows[0]["GiaBan"].ToString()) * int.Parse(txtSL.Text) * (1 - double.Parse(txtKM.Text) / 100)).ToString();
            }
            else
            {
                km = "null";
                txtTienHang.Text = (double.Parse(dth.Rows[0]["GiaBan"].ToString()) * int.Parse(txtSL.Text)).ToString();
            }
            dtBase.DataChange("insert CT_ban (SoHDB,MaHang,SoLuongBan,KhuyenMai) values (N'" + txtSoHD.Text + "',N'" +
                dth.Rows[0]["MaHang"] + "',N'" + txtSL.Text + "'," + km + ")");
            LoadCTBan();
            KhoaNV_KH(false);
            Reset(false);
            if (dgvHDB.Rows.Count > 1)
            {
                btnDonMoi.Enabled = true;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (dgvHDB.Rows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa hóa đơn đang lập để xem tất cả hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    dtBase.DataChange("delete from HoaDonBan where SoHDB = '" + txtSoHD.Text + "'");
                    Reset(true);
                    LoadHDBan("");
                    KhoaDon(false);
                    return;
                }
                else
                {
                    return;
                }
            }
            if (btnHuyDon.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn rời khỏi và lưu hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            Reset(true);
            KhoaDon(false);
            string sql = "select hdb.SoHDB,MaNV,hdb.MaKH,NgayBan,TenHang,SoLuongBan,GiaBan,KhuyenMai from HoaDonBan as hdb join CT_Ban as ctb on ctb.SoHDB = hdb.SoHDB " +
                " join Hang as h on h.MaHang = ctb.MaHang";
            if (txtSDT.Text != "")
            {
                sql += " join Khachhang as kh on kh.MaKH = hdb.MaKH where SDT = N'" + txtSDT.Text + "'";
            }
            dgvHDB.DataSource = dtBase.DataReturnTable(sql);
            txtTongCong.Text = TongTienHang(5, 6, 7).ToString();
            dgvHDB.ClearSelection();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvHDB.Columns.Count > 6)
            {
                if (dgvHDB.Rows.Count > 1) //TH có dữ liệu để ghi
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
                    header.Value = "CHI TIẾT DANH SÁCH BÁN";
                    //Định dạng tiêu đề bảng
                    exSheet.get_Range("A7:J7").Font.Bold = true;
                    exSheet.get_Range("A7:J7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exSheet.get_Range("B7").Value = "Số HDB";
                    exSheet.get_Range("C7").Value = "Mã nhân viên";
                    exSheet.get_Range("C7").ColumnWidth = 20;
                    exSheet.get_Range("D7").Value = "Mã Khách hàng";
                    exSheet.get_Range("D7").ColumnWidth = 20;
                    exSheet.get_Range("E7").Value = "Ngày bán";
                    exSheet.get_Range("E7").ColumnWidth = 20;
                    exSheet.get_Range("F7").Value = "Tên hàng";
                    exSheet.get_Range("F7").ColumnWidth = 20;
                    exSheet.get_Range("G7").Value = "SL bán";
                    exSheet.get_Range("G7").ColumnWidth = 18;
                    exSheet.get_Range("H7").Value = "Giá Bán";
                    exSheet.get_Range("H7").ColumnWidth = 20;
                    exSheet.get_Range("I7").Value = "Khuyến mãi";
                    exSheet.get_Range("I7").ColumnWidth = 13;
                    //In dữ liệu
                    int i;
                    for (i = 0; i < dgvHDB.Rows.Count - 1; i++)
                    {
                        exSheet.get_Range("A" + (i + 8).ToString() + ":J" + (i + 8).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 8).ToString() + ":J" + (i + 8).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        exSheet.get_Range("B" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[0].Value;
                        exSheet.get_Range("C" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[1].Value;
                        exSheet.get_Range("D" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[2].Value;
                        exSheet.get_Range("E" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[3].Value;
                        exSheet.get_Range("F" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[4].Value;
                        exSheet.get_Range("G" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[5].Value;
                        exSheet.get_Range("H" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[6].Value;
                        exSheet.get_Range("I" + (i + 8).ToString()).Value = dgvHDB.Rows[i].Cells[7].Value;
                    }
                    i = dgvHDB.Rows.Count + 8;
                    exSheet.get_Range("H" + (i).ToString()).Value = "Tổng cộng: ";
                    exSheet.get_Range("H" + (i).ToString()).Font.Bold = true;
                    exSheet.get_Range("I" + (i).ToString()).Value = txtTongCong.Text;
                    exSheet.Name = "HangBan";
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
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa hoàn thiện");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            btnLuu.Enabled = false;
        }

        private void XóaMotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dth;
            if (btnHuyDon.Enabled == true)
            {
                dth = dtBase.DataReturnTable("Select MaHang,TenHang from HANG where TenHang = N'" + dgvHDB.CurrentRow.Cells[0].Value.ToString() + "'");
                dtBase.DataChange("delete from CT_Ban where SoHDB = N'" + txtSoHD.Text + "' and MaHang = N'" +
                    dth.Rows[0]["MaHang"] + "'");
                LoadCTBan();
            }
            else
            {
                dth = dtBase.DataReturnTable("Select MaHang,TenHang from HANG where TenHang = N'" + dgvHDB.CurrentRow.Cells[4].Value.ToString() + "'");
                string sohd = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                dtBase.DataChange("delete from CT_Ban where SoHDB = N'" + sohd + "' and MaHang = N'" +
                     dth.Rows[0]["MaHang"] + "'");
                LoadHDBan("");
                short d = 0;
                for (int i = 0; i < dgvHDB.Rows.Count - 1; i++)
                {
                    if (sohd == dgvHDB.Rows[i].Cells[0].Value.ToString())
                    {
                        d++;
                        break;
                    }
                }
                if (d == 0)
                {
                    dtBase.DataChange("delete from HoaDonBan where SoHDB = '" + sohd + "'");
                }
            }
        }

        private void XoaHettoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa hết dữ liệu liên quan tới hóa đơn " + txtSoHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (btnHuyDon.Enabled == true)
                {
                    dtBase.DataChange("delete from CT_Ban where SoHDB = '" + txtSoHD.Text + "'");
                    dtBase.DataChange("delete from HoaDonBan where SoHDB = '" + txtSoHD.Text + "'");
                    Reset(true);
                    dgvHDB.DataSource = "";
                }
                else
                {
                    string sohd = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                    dtBase.DataChange("delete from CT_Ban where SoHDB = N'" + sohd + "'");
                    dtBase.DataChange("delete from HoaDonBan where SoHDB = N'" + sohd + "'");
                    LoadHDBan("");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu hóa đơn " + txtSoHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DataTable dth = dtBase.DataReturnTable("Select MaHang from Hang where TenHang = N'" + dgvHang.CurrentCell.Value.ToString() + "'");
                DataTable dthcu;
                if (dgvHDB.Columns.Count > 6)
                {
                    dthcu = dtBase.DataReturnTable("Select MaHang from Hang where TenHang = N'" + dgvHDB.CurrentRow.Cells[4].Value.ToString() + "'");
                }
                else
                {
                    dthcu = dtBase.DataReturnTable("Select MaHang from Hang where TenHang = N'" + dgvHDB.CurrentRow.Cells[0].Value.ToString() + "'");
                }
                string mah = dth.Rows[0]["MaHang"].ToString();
                dtBase.DataChange("update CT_Ban set MaHang = N'" + mah + "' where SoHDB = N'" + txtSoHD.Text + "' and MaHang = N'" + dthcu.Rows[0]["MaHang"].ToString() + "'");
                DataTable dtkh = KH(txtSDT.Text);
                if (dtkh.Rows.Count > 0)
                {
                    dtBase.DataChange(" update HoaDonBan set MaNV = N'" + cbbNV.SelectedValue.ToString() + "' where SoHDB = N'" + txtSoHD.Text + "' " +
                        " update HoaDonBan set MaKH = N'" + dtkh.Rows[0]["MaKH"].ToString() + "' where SoHDB = N'" + txtSoHD.Text + "' ");
                }
                else
                {
                    string makh = fc.SinhMaTuDong("KhachHang", "MaKH", "");
                    if (txtSDT.Text == "")
                    {
                        dtBase.DataChange("insert KHACHHANG (MaKH,TenKH,SDT) values ('" + makh + "','" +
                            txtTenKH.Text + "',null)");
                    }
                    else
                    {
                        dtBase.DataChange("insert KHACHHANG (MaKH,TenKH,SDT) values ('" + makh + "','" +
                            txtTenKH.Text + "',N'" + txtSDT.Text + "')");
                    }
                    dtBase.DataChange(" update HoaDonBan set MaNV = N'" + cbbNV.SelectedValue.ToString() + "' where SoHDB = N'" + txtSoHD.Text + "' " +
                        " update HoaDonBan set MaKH = N'" + makh + "' where SoHDB = N'" + txtSoHD.Text + "' ");
                }
                string km;
                if (txtKM.Text == "")
                {
                    km = "null";
                }
                else
                    km = txtKM.Text;
                dtBase.DataChange(" update CT_Ban set SoLuongBan = N'" + txtSL.Text + "' where SoHDB = N'" + txtSoHD.Text + "' and MaHang = N'" + mah + "' " +
                    " update CT_Ban set KhuyenMai = " + km + " where SoHDB = N'" + txtSoHD.Text + "' and MaHang = N'" + mah + "' ");
                btnLuu.Visible = false;
                LoadHDBan("");
            }
        }
    }
}
