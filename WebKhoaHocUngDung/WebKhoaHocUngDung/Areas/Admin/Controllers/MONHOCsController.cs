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
    public class MONHOCsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/MONHOCs
        public ActionResult Index(int? page)
        {
            var mONHOCs = db.MONHOCs.Include(m => m.KHOI);
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(mONHOCs.ToList().OrderBy(t => t.MaMonHoc).ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/MONHOCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // GET: Admin/MONHOCs/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoi = new SelectList(db.KHOIs, "MaKhoi", "TenKhoi");
            return View();
        }

        // POST: Admin/MONHOCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMonHoc,MaKhoi,TenMonHoc")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.MONHOCs.Add(mONHOC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhoi = new SelectList(db.KHOIs, "MaKhoi", "TenKhoi", mONHOC.MaKhoi);
            return View(mONHOC);
        }

        // GET: Admin/MONHOCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoi = new SelectList(db.KHOIs, "MaKhoi", "TenKhoi", mONHOC.MaKhoi);
            return View(mONHOC);
        }

        // POST: Admin/MONHOCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMonHoc,MaKhoi,TenMonHoc")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mONHOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoi = new SelectList(db.KHOIs, "MaKhoi", "TenKhoi", mONHOC.MaKhoi);
            return View(mONHOC);
        }

        // GET: Admin/MONHOCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // POST: Admin/MONHOCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MONHOC mONHOC = db.MONHOCs.Find(id);
            db.MONHOCs.Remove(mONHOC);
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
