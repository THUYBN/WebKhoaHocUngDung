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
    public class CT_LOPHOCController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/CT_LOPHOC
        public ActionResult Index(int? id, int? page)
        {
            var cT_LOPHOC = db.CT_LOPHOC.Include(c => c.HOCSINH).Include(c => c.LOPHOC).Where(c => c.MaLop == id);
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(cT_LOPHOC.ToList().OrderBy(t => t.NgayVaoHoc).ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/CT_LOPHOC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_LOPHOC cT_LOPHOC = db.CT_LOPHOC.Find(id);
            if (cT_LOPHOC == null)
            {
                return HttpNotFound();
            }
            return View(cT_LOPHOC);
        }

        // GET: Admin/CT_LOPHOC/Create
        public ActionResult Create()
        {
            ViewBag.MaHS = new SelectList(db.HOCSINHs, "MaHS", "HoTen");
            ViewBag.MaLop = new SelectList(db.LOPHOCs, "MaLop", "TenLop");
            return View();
        }

        // POST: Admin/CT_LOPHOC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCT,MaLop,MaHS,NgayVaoHoc")] CT_LOPHOC cT_LOPHOC)
        {
            if (ModelState.IsValid)
            {
                cT_LOPHOC.NgayVaoHoc = DateTime.Today;
                db.CT_LOPHOC.Add(cT_LOPHOC);
                db.SaveChanges();
                return RedirectToAction("Index", "LOPHOCs");
            }

            ViewBag.MaHS = new SelectList(db.HOCSINHs, "MaHS", "HoTen", cT_LOPHOC.MaHS);
            ViewBag.MaLop = new SelectList(db.LOPHOCs, "MaLop", "TenLop", cT_LOPHOC.MaLop);
            return View(cT_LOPHOC);
        }

        // GET: Admin/CT_LOPHOC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_LOPHOC cT_LOPHOC = db.CT_LOPHOC.Find(id);
            if (cT_LOPHOC == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHS = new SelectList(db.HOCSINHs, "MaHS", "HoTen", cT_LOPHOC.MaHS);
            ViewBag.MaLop = new SelectList(db.LOPHOCs, "MaLop", "TenLop", cT_LOPHOC.MaLop);
            return View(cT_LOPHOC);
        }

        // POST: Admin/CT_LOPHOC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCT,MaLop,MaHS,NgayVaoHoc")] CT_LOPHOC cT_LOPHOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cT_LOPHOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHS = new SelectList(db.HOCSINHs, "MaHS", "HoTen", cT_LOPHOC.MaHS);
            ViewBag.MaLop = new SelectList(db.LOPHOCs, "MaLop", "TenLop", cT_LOPHOC.MaLop);
            return View(cT_LOPHOC);
        }

        // GET: Admin/CT_LOPHOC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_LOPHOC cT_LOPHOC = db.CT_LOPHOC.Find(id);
            if (cT_LOPHOC == null)
            {
                return HttpNotFound();
            }
            return View(cT_LOPHOC);
        }

        // POST: Admin/CT_LOPHOC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CT_LOPHOC cT_LOPHOC = db.CT_LOPHOC.Find(id);
            db.CT_LOPHOC.Remove(cT_LOPHOC);
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
