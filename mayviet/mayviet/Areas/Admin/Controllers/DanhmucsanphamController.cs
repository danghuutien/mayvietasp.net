using mayviet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayviet.Areas.Admin.Controllers
{
    public class DanhmucsanphamController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Admin/Danhmucsanpham
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajax(string searchnow, int start, int length)
        {
            if (searchnow == "")
            {
                var data = db.Danhmucsanphams.Where(i=>i.Id >= start).Take(length).ToList();
                
                
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = db.Danhmucsanphams.Where(i => i.Name.Contains(searchnow)).ToList();

                return Json(data, JsonRequestBehavior.AllowGet);

            }




        }



        [HttpPost]
        public ActionResult Delete(int id)
        {
            
                Danhmucsanpham data = db.Danhmucsanphams.Find(id);
                db.Danhmucsanphams.Remove(data);
                db.SaveChanges();
                return Json(new { status = true });
            
        }


        /*public ActionResult ajaxDanhmuc()
        {
             return 
        }*/

        [HttpPost]
        public ActionResult Edit(string Name, int id)
        {
            try
            {
                Danhmucsanpham Menu = db.Danhmucsanphams.Find(id);

                Menu.Name = Name;

                Menu.Create_at = DateTime.Now;

                Menu.Update_at = DateTime.Now;


                db.SaveChanges();
                return Json(new { status = true });
            }
            catch (InvalidCastException e)
            {
                return Json(new { satus = e.Message });
            }
        }

        [HttpPost]
        public ActionResult Create(string name, string slug)
        {
            try
            {
                Danhmucsanpham myItem = new Danhmucsanpham();
                myItem.Name = name;

                
                myItem.Create_at = DateTime.Now;
                db.Danhmucsanphams.Add(myItem);
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