using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DM_NganhNgheController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/DM_NganhNghe
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            var recordsTotal = db.DM_NganhNghes.ToList().Count();
            if (searchnow == "")
            {
                /*offset($batdau)->limit($sodong)->get();*/
                /*var data = db.Danhmucsanphams.Where(i=>i.Id > start).Take(length).ToList();*/


                var data = db.DM_NganhNghes.OrderBy(x => x.Id).Skip(start).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.DM_NganhNghes.Where(i => i.Id > start).Where(i => i.TenNganhNghe.Contains(searchnow)).Take(length).ToList();
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

            DM_NganhNghe data = db.DM_NganhNghes.Find(id);
            db.DM_NganhNghes.Remove(data);
            db.SaveChanges();
            return Json(new { status = true });

        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string TenNganhNghe, int id)
        {
            try
            {
                DM_NganhNghe Menu = db.DM_NganhNghes.Find(id);

                Menu.TenNganhNghe = TenNganhNghe;

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
        public ActionResult Create(string TenNganhNghe)
        {
            try
            {
                DM_NganhNghe myItem = new DM_NganhNghe();
                myItem.TenNganhNghe = TenNganhNghe;
                myItem.Status = 1;
                myItem.CreateById = null;
                myItem.LastUpdateById = null;
                myItem.CreateByDate = null;
                myItem.LastUpdateDate = null;


                myItem.CreateByDate = DateTime.Now;

                db.DM_NganhNghes.Add(myItem);
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