using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DM_MoHinhHoatDongController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/DM_MoHinhHoatDong
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            var recordsTotal = db.DM_MoHinhHoatDongs.ToList().Count();
            if (searchnow == "")
            {
                /*offset($batdau)->limit($sodong)->get();*/
                /*var data = db.Danhmucsanphams.Where(i=>i.Id > start).Take(length).ToList();*/


                var data = db.DM_MoHinhHoatDongs.OrderBy(x => x.Id).Skip(start).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.DM_MoHinhHoatDongs.Where(i => i.Id > start).Where(i => i.TenMoHinhHoatDong.Contains(searchnow)).Take(length).ToList();
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

            DM_MoHinhHoatDong data = db.DM_MoHinhHoatDongs.Find(id);
            db.DM_MoHinhHoatDongs.Remove(data);
            db.SaveChanges();
            return Json(new { status = true });

        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string TenMoHinhHoatDong, int id)
        {
            try
            {
                DM_MoHinhHoatDong Menu = db.DM_MoHinhHoatDongs.Find(id);

                Menu.TenMoHinhHoatDong = TenMoHinhHoatDong;

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
        public ActionResult Create(string TenMoHinhHoatDong)
        {
            try
            {DM_MoHinhHoatDong myItem = new DM_MoHinhHoatDong();
                myItem.TenMoHinhHoatDong = TenMoHinhHoatDong;
                myItem.Status = 1;
                myItem.CreateById = null;
                myItem.LastUpdateById = null;
                myItem.CreateByDate = null;
                myItem.LastUpdateDate = null;


                db.DM_MoHinhHoatDongs.Add(myItem);
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