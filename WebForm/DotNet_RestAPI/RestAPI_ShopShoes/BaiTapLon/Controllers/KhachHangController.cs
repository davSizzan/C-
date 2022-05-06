using BaiTapLon.Data;
using BaiTapLon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BaiTapLon.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class KhachHangController : ApiController
    {
        DBShopDataContext db = new DBShopDataContext();
        IDKhach idkhach = new IDKhach();
        public IEnumerable<KhachHang> Get()
        {
            return db.KhachHangs.ToList();
        }

        // GET: api/GioHang/5
        public KhachHang Get(string id)
        {
            KhachHang khach = db.KhachHangs.FirstOrDefault(n => n.SĐT == id);
            if(khach == null)
            {
                return null;
            }
            
            IDKhach.khachhangid = khach.id;
            return khach;
        }
        
        [HttpPost]
        public List<KhachHang> GetKhachHang(string name)
        {
            if(name == null)
            {
                return null;
            }
            return db.KhachHangs.Where(n => n.HoTen.Contains(name)).ToList();
        }
        // POST: api/GioHang
        [HttpPost]
        public bool InsertNewCustomer(int id, string name, string phoneNumber, string email, string pass,
        string gioitinh, DateTime day)
        {
            try
            {
           
                KhachHang customer = new KhachHang();
                customer.id = id;
                customer.HoTen = name;
                customer.SĐT = phoneNumber;
                customer.Email = email;
                customer.MatKhau = pass;
                customer.GioiTinh = gioitinh;
                customer.Ngaysinh = day;

                db.KhachHangs.InsertOnSubmit(customer);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // PUT: api/GioHang/5
        [HttpPut]
        public bool UpdateCustomer(int id, string name, string phoneNumber, string email, string pass,
        string gioitinh, DateTime day)
        {
            try
            {
             
                //Lấy mã khách đã có
                KhachHang customer = db.KhachHangs.FirstOrDefault(x => x.id == id);
                if (customer == null) return false;
                customer.id = id;
                customer.HoTen = name;
                customer.SĐT = phoneNumber;
                customer.Email = email;
                customer.MatKhau = pass;
                customer.GioiTinh = gioitinh;
                customer.Ngaysinh = day;
                db.SubmitChanges();//Xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }
        //5.httpDelete để xóa một Khách hàng
        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            try
            {
              
                //Lấy mã khách đã có
                KhachHang customer = db.KhachHangs.FirstOrDefault(x => x.id == id);
                if (customer == null) return false;

                db.KhachHangs.DeleteOnSubmit(customer);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
