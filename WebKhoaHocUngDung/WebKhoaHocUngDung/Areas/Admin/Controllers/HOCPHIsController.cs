using PagedList;
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
    public class HOCPHIsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/HOCPHIs
        public ActionResult Index(int? page)
        {
            var hOCPHIs = db.HOCPHIs.Include(h => h.MONHOC);
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(hOCPHIs.ToList().OrderBy(t => t.MaHP).ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/HOCPHIs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCPHI hOCPHI = db.HOCPHIs.Find(id);
            if (hOCPHI == null)
            {
                return HttpNotFound();
            }
            return View(hOCPHI);
        }

        // GET: Admin/HOCPHIs/Create
        public ActionResult Create()
        {
            ViewBag.MaMon = new SelectList(db.MONHOCs, "MaMonHoc", "TenMonHoc");
            return View();
        }

        // POST: Admin/HOCPHIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHP,NgayApDung,MaMon,DonGia,SoBuoi,SiSo")] HOCPHI hOCPHI)
        {
            if (ModelState.IsValid)
            {
                db.HOCPHIs.Add(hOCPHI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMon = new SelectList(db.MONHOCs, "MaMonHoc", "TenMonHoc", hOCPHI.MaMon);
            return View(hOCPHI);
        }

        // GET: Admin/HOCPHIs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCPHI hOCPHI = db.HOCPHIs.Find(id);
            if (hOCPHI == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMon = new SelectList(db.MONHOCs, "MaMonHoc", "TenMonHoc", hOCPHI.MaMon);
            return View(hOCPHI);
        }

        // POST: Admin/HOCPHIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHP,NgayApDung,MaMon,DonGia,SoBuoi,SiSo")] HOCPHI hOCPHI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hOCPHI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMon = new SelectList(db.MONHOCs, "MaMonHoc", "TenMonHoc", hOCPHI.MaMon);
            return View(hOCPHI);
        }

        // GET: Admin/HOCPHIs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCPHI hOCPHI = db.HOCPHIs.Find(id);
            if (hOCPHI == null)
            {
                return HttpNotFound();
            }
            return View(hOCPHI);
        }

        // POST: Admin/HOCPHIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HOCPHI hOCPHI = db.HOCPHIs.Find(id);
            db.HOCPHIs.Remove(hOCPHI);
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
