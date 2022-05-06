using BaiTapLon.Areas.Admin.Code;
using BaiTapLon.Models;
using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        DBWebShop db = new DBWebShop();
        // GET: Admin/Home

        public ActionResult Index(UserSession user)
        {
            //thông tin ngày
            ViewBag.SLDatHangNgay = SoLuongDatHangNgay().Count;
            ViewBag.TongTienNgay = TongTienNgay();
            ViewBag.SoLuongThanhToanNgay = SoLuongThanhToanNgay();
            ViewBag.TongTienThanhToanNgay = TongTienThanhToanNgay();
            ViewBag.SLHoanTienNgay = SoLuongHoanTienNgay();
            ViewBag.HoanTienNgay = HoanTienNgay();
            //thong tin tuan
            ViewBag.SlDatHangTuan = SoLuongDatHangTuan().Count;
            ViewBag.TongTienTuan = TongTienTuan();
            ViewBag.SLThanhToanTuan = SoLuongThanhToanTuan();
            ViewBag.TongTienThanhToanTuan = TongTienThanhToanTuan();
            ViewBag.SLHoanTienTuan = SoLuongHoanTienTuan();
            ViewBag.HoanTienTuan = HoanTienTuan();
            return View();
        }

        public List<tblDonHang> SoLuongDatHangNgay()
        {
            List<tblDonHang> listDons = (List<tblDonHang>)db.tblDonHang.Where(n => n.NgayDatHang == DateTime.Today).OrderBy(n => n.DonHangID).ToList();

            return listDons;
        }
        public int TongTienNgay()
        {
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang on p.tblDonHang_DonHangID equals c.DonHangID
                           where c.NgayDatHang == DateTime.Today
                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan
                           };
            foreach (var item in products)
            {
                tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public int SoLuongThanhToanNgay()
        {
            return SoLuongDatHangNgay().Where(n => n.TrangThaiThanhToan == true).OrderBy(n => n.DonHangID).Count();
        }
        public int TongTienThanhToanNgay()
        {
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang.OrderBy(n => n.DonHangID) on p.tblDonHang_DonHangID equals c.DonHangID
                           where c.NgayDatHang == DateTime.Today && c.TrangThaiThanhToan == true
                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan
                           };
            foreach (var item in products)
            {
                tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public int SoLuongHoanTienNgay()
        {
            return SoLuongDatHangNgay().Where(n => n.TrangThaiThanhToan == false && n.TrangThaiGiaoHang == true).OrderBy(n => n.DonHangID).Count();
        }
        public int HoanTienNgay()
        {
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang.OrderBy(n => n.DonHangID) on p.tblDonHang_DonHangID equals c.DonHangID
                           where c.NgayDatHang == DateTime.Today && c.TrangThaiThanhToan == false && c.TrangThaiGiaoHang == true
                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan
                           };
            foreach (var item in products)
            {
                tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public List<tblDonHang> SoLuongDatHangTuan()
        {
            DateTime week = DateTime.Today.AddDays(-7);
            List<tblDonHang> listDons = db.tblDonHang.Where(n => n.NgayDatHang >= week).OrderBy(n => n.DonHangID).ToList();
            return listDons;
        }
        public int TongTienTuan()
        {
            DateTime week = DateTime.Today.AddDays(-7);
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang on p.tblDonHang_DonHangID equals c.DonHangID

                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan,
                               ngay = c.NgayDatHang
                           };
            foreach (var item in products)
            {
                if (item.ngay.Date >= week)
                    tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public int SoLuongThanhToanTuan()
        {
            return SoLuongDatHangTuan().Where(n => n.TrangThaiThanhToan == true).OrderBy(n => n.DonHangID).Count();
        }
        public int TongTienThanhToanTuan()
        {
            DateTime week = DateTime.Today.AddDays(-7);
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang.OrderBy(n => n.DonHangID) on p.tblDonHang_DonHangID equals c.DonHangID
                           where c.TrangThaiThanhToan == true
                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan,
                               ngay = c.NgayDatHang
                           };
            foreach (var item in products)
            {
                if (item.ngay.Date >= week)
                    tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public int SoLuongHoanTienTuan()
        {
            return SoLuongDatHangTuan().Where(n => n.TrangThaiThanhToan == false && n.TrangThaiGiaoHang == true).OrderBy(n => n.DonHangID).Count();
        }
        public int HoanTienTuan()
        {
            DateTime week = DateTime.Today.AddDays(-7);
            int tongtien = 0;
            var products = from p in db.tblChiTietDonHang
                           join c in db.tblDonHang.OrderBy(n => n.DonHangID) on p.tblDonHang_DonHangID equals c.DonHangID
                           where c.TrangThaiThanhToan == false && c.TrangThaiGiaoHang == true
                           select new
                           {
                               id = p.ChiTietDonHangID,
                               soluong = p.SoLuong,
                               giaban = p.GiaBan,
                               ngay = c.NgayDatHang
                           };
            foreach (var item in products)
            {
                if (item.ngay.Date >= week)
                    tongtien += item.soluong * Convert.ToInt32(item.giaban);

            }
            return tongtien;
        }
        public ActionResult Logout()
        {

            return RedirectToAction("LoginAdmin", "Index");
        }
    }
}