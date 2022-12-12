using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DM_LinhVucHoatDongController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/DM_LinhVucHoatDong
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            var recordsTotal = db.DM_LinhVucHoatDongs.ToList().Count();
            if (searchnow == "")
            {
                /*offset($batdau)->limit($sodong)->get();*/
                /*var data = db.Danhmucsanphams.Where(i=>i.Id > start).Take(length).ToList();*/


                var data = db.DM_LinhVucHoatDongs.OrderBy(x => x.Id).Skip(start).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.DM_LinhVucHoatDongs.Where(i => i.Id > start).Where(i => i.TenLinhVucHoatDong.Contains(searchnow)).Take(length).ToList();
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

            DM_LinhVucHoatDong data = db.DM_LinhVucHoatDongs.Find(id);
            db.DM_LinhVucHoatDongs.Remove(data);
            db.SaveChanges();
            return Json(new { status = true });

        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string TenLinhVucHoatDong, int id)
        {
            try
            {
                DM_LinhVucHoatDong Menu = db.DM_LinhVucHoatDongs.Find(id);

                Menu.TenLinhVucHoatDong = TenLinhVucHoatDong;

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
        public ActionResult Create(string TenLinhVucHoatDong)
        {
            try
            {
                DM_LinhVucHoatDong myItem = new DM_LinhVucHoatDong();
                myItem.TenLinhVucHoatDong = TenLinhVucHoatDong;
                myItem.Status = 1;
                myItem.CreateById = null;
                myItem.LastUpdateById = null;
                myItem.CreateByDate = null;
                myItem.LastUpdateDate = null;


                db.DM_LinhVucHoatDongs.Add(myItem);
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