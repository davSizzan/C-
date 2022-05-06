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
    public class ProductController : ApiController
    {
       
        DBShopDataContext db = new DBShopDataContext();
        [HttpGet]
        // Lấy ra danh sách sản phẩm sale từ lớn đến bé 
        public IEnumerable<SanPham> Get()
        {
            List<SanPham> list = db.SanPhams.OrderByDescending(n => n.Sale).ToList();
            return list;
        }
        //Sản phẩm mới 
       [HttpPost]
        public IEnumerable<SanPham> Sanphambanchay()
        {
            
            List<SanPham> list = db.SanPhams.OrderByDescending(n => n.NgayTao).ToList();
            return list;
        }
        //Lấy sản phẩm theo id 
        public IEnumerable<SanPham> Get(int id)
        {
            List<SanPham> list;
            if (id == 0)
            {
                list = db.SanPhams.OrderByDescending(n => n.Sale).Where(n => n.Loai == 1 || n.Loai ==2).ToList();
            }
            else
            { list = db.SanPhams.OrderByDescending(n => n.Sale).Where(n => n.Loai == id ).ToList(); }    
            return list;
        }
        [HttpPut]
        //Lấy sản phẩm theo id
        public SanPham getid(int id)
        {
            return db.SanPhams.FirstOrDefault(n => n.id == id);
        }
        
        [HttpPost]
        public bool InsertNewProduct(int id, string name, int gia, int sale, int loai, string mota,
            string anh, DateTime ngaytao, int createID)
        {
            try
            {
                DBShopDataContext dBProduct = new DBShopDataContext();
                SanPham product = new SanPham();
                product.id = id;
                product.TenSanPham = name;
                product.Gia = gia;
                product.Sale = sale;
                product.Loai = loai;
                product.MoTa = mota;
                product.Anh = anh;
                product.NgayTao = ngaytao;
                product.createdbyID = createID;
                dBProduct.SanPhams.InsertOnSubmit(product);
                dBProduct.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPut]
        public bool UpdateCustomer(int id, string name, int gia, int sale, int loai, string mota,
            string anh, DateTime ngaytao, int createID)
        {
            try
            {
                
                SanPham product = db.SanPhams.FirstOrDefault(n => n.id == id);
                if (product == null) { return false; }
                product.id = id;
                product.TenSanPham = name;
                product.Gia = gia;
                product.Sale = sale;
                product.Loai = loai;
                product.MoTa = mota;
                product.Anh = anh;
                product.NgayTao = ngaytao;
                product.createdbyID = createID;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
        public bool DeleteCustomers(int id)
        {
            try
            {
               
                SanPham product = db.SanPhams.FirstOrDefault(n => n.id == id);
                if (product == null) { return false; }
                db.SanPhams.DeleteOnSubmit(product);
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
