using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DM_NhomSanPhamController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/DM_NhomSanPham
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            var recordsTotal = db.DM_NhomSanPhams.ToList().Count();
            if (searchnow == "")
            {
                /*offset($batdau)->limit($sodong)->get();*/
                /*var data = db.Danhmucsanphams.Where(i=>i.Id > start).Take(length).ToList();*/


                var data = db.DM_NhomSanPhams.OrderBy(x => x.Id).Skip(start).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.DM_NhomSanPhams.Where(i => i.Id > start).Where(i => i.TenNhomSanPham.Contains(searchnow)).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {

            DM_NhomSanPham data = db.DM_NhomSanPhams.Find(id);
            db.DM_NhomSanPhams.Remove(data);
            db.SaveChanges();
            return Json(new { status = true });

        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string TenNhomSanPham, int id)
        {
            try
            {
                DM_NhomSanPham Menu = db.DM_NhomSanPhams.Find(id);

                Menu.TenNhomSanPham = TenNhomSanPham;

                Menu.CreateByDate = DateTime.Now;

                Menu.LastUpdateDate = DateTime.Now;


                db.SaveChanges();
                return Json(new { status = true });
            }
            catch (InvalidCastException e)
            {
                return Json(new { satus = e.Message });
            }
        }

        [HttpPost]
        public ActionResult Create(string TenNhomSanPham)
        {
            try
            {
                DM_NhomSanPham myItem = new DM_NhomSanPham();
                myItem.TenNhomSanPham = TenNhomSanPham;
                myItem.Status = 1;
                myItem.CreateById = null;
                myItem.LastUpdateById = null;
                myItem.CreateByDate = null;
                myItem.LastUpdateDate = null;


                myItem.CreateByDate = DateTime.Now;

                db.DM_NhomSanPhams.Add(myItem);
                db.SaveChanges();
                return Json(new { status = true });
            }
            catch (InvalidCastException e)
            {
                return Json(new { satus = e.Message });
            }
        }
    }
}