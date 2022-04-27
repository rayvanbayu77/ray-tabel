using bayu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bayu.Controllers
{
    [Authorize]
    public class RayController : Controller
    {
        public ActionResult Index()
        {
            //Mengambil data mahasiswa//
            List<Tabel> r;
            using (var s = new RayvanEntities())
            {
                r = s.Tabels.ToList();
            }
            return View();
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                s.Tabels.Add(model);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult index()
        {
            List<Tabel> r;
            using (var s = new RayvanEntities())
            {
                r = s.Tabels.ToList();
            }
            return View(r);
        }
        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                model = s.Tabels.Where(x => x.NomorID == nomorid).FirstOrDefault();
            }
            return View(model);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                model = s.Tabels.Where(x => x.NomorID == nomorid).FirstOrDefault();
                TryUpdateModel(model);
                s.SaveChanges();
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Details(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                model = s.Tabels.FirstOrDefault(x => x.NomorID == nomorid);

            }
            return View(model);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Delete_Post(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                var m = s.Tabels.FirstOrDefault(x => x.NomorID == nomorid);
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Details1 (string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                model = s.Tabels.FirstOrDefault(x => x.NomorID == nomorid);
            }
            return View(model);
        }
        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                model = s.Tabels.FirstOrDefault(x => x.NomorID == nomorid);

            }
            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post1(string nomorid)
        {
            var model = new Tabel();
            TryUpdateModel(model);
            using (var s = new RayvanEntities())
            {
                var m = s.Tabels.Remove(s.Tabels.FirstOrDefault(x => x.NomorID == nomorid));
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("index");
        }
    }
}
