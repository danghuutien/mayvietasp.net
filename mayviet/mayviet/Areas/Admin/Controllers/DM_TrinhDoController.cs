using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DM_TrinhDoController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/DM_TrinhDo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            var recordsTotal = db.DM_TrinhDos.ToList().Count();
            if (searchnow == "")
            {
                /*offset($batdau)->limit($sodong)->get();*/
                /*var data = db.Danhmucsanphams.Where(i=>i.Id > start).Take(length).ToList();*/


                var data = db.DM_TrinhDos.OrderBy(x => x.Id).Skip(start).Take(length).ToList();
                var result = new
                {
                    data = data,
                    recordsTotal = recordsTotal
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.DM_TrinhDos.Where(i => i.Id > start).Where(i => i.TenTrinhDo.Contains(searchnow)).Take(length).ToList();
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

            DM_TrinhDo data = db.DM_TrinhDos.Find(id);
            db.DM_TrinhDos.Remove(data);
            db.SaveChanges();
            return Json(new { status = true });

        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string TenTrinhDo, int id)
        {
            try
            {
                DM_TrinhDo Menu = db.DM_TrinhDos.Find(id);

                Menu.TenTrinhDo = TenTrinhDo;

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
        public ActionResult Create(string TenTrinhDo)
        {
            try
            {
                DM_TrinhDo myItem = new DM_TrinhDo();
                myItem.TenTrinhDo = TenTrinhDo;
                myItem.Status = 1;
                myItem.CreateById = null;
                myItem.LastUpdateById = null;
                myItem.CreateByDate = null;
                myItem.LastUpdateDate = null;


                myItem.CreateByDate = DateTime.Now;

                db.DM_TrinhDos.Add(myItem);
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