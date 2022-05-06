using BaiTapLon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BaiTapLon.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CustomersController : ApiController
    {
        DBShopDataContext dbCustomer = new DBShopDataContext();
        [HttpGet]
        public List<NhanVien> GetCustomerLists()
        {
        
            return dbCustomer.NhanViens.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào đó
        [HttpGet]
        public NhanVien GetCustomer(string id)
        {
            return dbCustomer.NhanViens.FirstOrDefault(x => x.SĐT == id);
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(int id, string name, string phoneNumber, string email, string pass,
        string gioitinh, DateTime day)
        {
            try
            {
                NhanVien customer = new NhanVien();
                customer.id = id;
                customer.HoTen = name;
                customer.SĐT = phoneNumber;
                customer.Email = email;
                customer.MatKhau = pass;
                customer.GioiTinh = gioitinh;
                customer.Ngaysinh = day;

                dbCustomer.NhanViens.InsertOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

      
        //4. httpPut để chỉnh sửa thông tin một khách hàng
        [HttpPut]
        public bool UpdateCustomer(int id, string name, string phoneNumber, string email, string pass,
        string gioitinh, DateTime day)
        {
            try
            {
                //Lấy mã khách đã có
                NhanVien customer = dbCustomer.NhanViens.FirstOrDefault(x => x.id == id);
                if (customer == null) return false;
                customer.id = id;
                customer.HoTen = name;
                customer.SĐT = phoneNumber;
                customer.Email = email;
                customer.MatKhau = pass;
                customer.GioiTinh = gioitinh;
                customer.Ngaysinh = day;
                dbCustomer.SubmitChanges();//Xác nhận chỉnh sửa
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
                NhanVien customer = dbCustomer.NhanViens.FirstOrDefault(x => x.id == id);
                if (customer == null) return false;

                dbCustomer.NhanViens.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
