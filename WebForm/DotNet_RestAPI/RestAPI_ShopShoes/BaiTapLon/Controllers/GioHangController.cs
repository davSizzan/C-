using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BaiTapLon.Data;
using BaiTapLon.Models;
namespace BaiTapLon.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GioHangController : ApiController
    {

        IDKhach idkhach = new IDKhach();
        // GET: api/GioHang
        DBShopDataContext db = new DBShopDataContext();
        public List<SanPham> Get()
        {
            if (IDKhach.khachhangid == 0)            
                return null;
            int idkhach = IDKhach.khachhangid;
            IEnumerable<GioHang> giohang = db.GioHangs.Where(n => n.KhachHangID == idkhach).OrderBy(n => n.id);
            var products = from p in giohang
                           join c in db.SanPhams.OrderBy(n => n.id) on p.SanPhamID equals c.id
                           select new
                           {
                               id = c.id,
                              tensanpham = c.TenSanPham,
                              gia = c.Gia,
                              sale = c.Sale,
                              loai = c.Loai,
                              mota = c.MoTa,
                              anh = c.Anh,
                              ngaytao = c.NgayTao,
                              createby = c.createdbyID,
                           };

            List<SanPham> list = new List<SanPham>();
            foreach(var item in products)
            {
                SanPham sp = new SanPham();
                sp.id = item.id;
                sp.TenSanPham = item.tensanpham;
                sp.Gia = item.gia;
                sp.Sale = item.sale;
                sp.Loai = item.loai;
                sp.MoTa = item.mota;
                sp.Anh = item.anh;
                sp.NgayTao = item.ngaytao;
                sp.createdbyID = item.createby;
                list.Add(sp);
            }
            return list ;
        }


        // POST: api/GioHang
        public Boolean Post(int id, int khachhangid)
        {
            GioHang gioHang = new GioHang();
            gioHang.KhachHangID = khachhangid;
            gioHang.SanPhamID = id;
            db.GioHangs.InsertOnSubmit(gioHang);
            db.SubmitChanges();
            return true;
        }

        // PUT: api/GioHang/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GioHang/5
        [HttpDelete]
        public void Delete(int id)
        {
           GioHang gio = db.GioHangs.FirstOrDefault(n => n.SanPhamID == id && n.KhachHangID == IDKhach.khachhangid);
            db.GioHangs.DeleteOnSubmit(gio);
            db.SubmitChanges();
        }
        [HttpDelete]
        public void Delete()
        {
            int id = IDKhach.khachhangid;

            IEnumerable<GioHang> giohang = db.GioHangs.Where(n => n.KhachHangID == id).OrderBy(n => n.id);
            foreach (var item in giohang)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.KhachHangID = item.KhachHangID;
                hoaDon.SanPhamID = item.SanPhamID;
                hoaDon.SoLuong = 1;
                db.HoaDons.InsertOnSubmit(hoaDon);
                db.SubmitChanges();
            }

            db.GioHangs.DeleteAllOnSubmit(db.GioHangs.Where(n => n.KhachHangID == id));
            db.SubmitChanges();
        }
    }
}
