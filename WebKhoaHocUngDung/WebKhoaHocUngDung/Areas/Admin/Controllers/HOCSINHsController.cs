using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebKhoaHocUngDung.Models;

namespace WebKhoaHocUngDung.Areas.Admin.Controllers
{
    public class HOCSINHsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/HOCSINHs
        public ActionResult Index()
        {
            return View(db.HOCSINHs.ToList());
        }

        // GET: Admin/HOCSINHs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCSINH hOCSINH = db.HOCSINHs.Find(id);
            if (hOCSINH == null)
            {
                return HttpNotFound();
            }
            return View(hOCSINH);
        }

        // GET: Admin/HOCSINHs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HOCSINHs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHS,HoTen,NgaySinh,GioiTinh,Khoi,SDT,SDTPH,DiaChi,NgayVaoHoc,TinhTrang")] HOCSINH hOCSINH)
        {
            if (ModelState.IsValid)
            {
                db.HOCSINHs.Add(hOCSINH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hOCSINH);
        }

        // GET: Admin/HOCSINHs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCSINH hOCSINH = db.HOCSINHs.Find(id);
            if (hOCSINH == null)
            {
                return HttpNotFound();
            }
            return View(hOCSINH);
        }

        // POST: Admin/HOCSINHs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHS,HoTen,NgaySinh,GioiTinh,Khoi,SDT,SDTPH,DiaChi,NgayVaoHoc,TinhTrang")] HOCSINH hOCSINH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hOCSINH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hOCSINH);
        }

        // GET: Admin/HOCSINHs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCSINH hOCSINH = db.HOCSINHs.Find(id);
            if (hOCSINH == null)
            {
                return HttpNotFound();
            }
            return View(hOCSINH);
        }

        // POST: Admin/HOCSINHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HOCSINH hOCSINH = db.HOCSINHs.Find(id);
            db.HOCSINHs.Remove(hOCSINH);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
