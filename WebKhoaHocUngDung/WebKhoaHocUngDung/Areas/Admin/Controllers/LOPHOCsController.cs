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
    public class LOPHOCsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/LOPHOCs
        public ActionResult Index(int? page)
        {
            var lOPHOCs = db.LOPHOCs.Include(l => l.HOCPHI).Include(l => l.GIAOVIEN);
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(lOPHOCs.ToList().OrderBy(t => t.NgayMoLop).ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/LOPHOCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOPHOC lOPHOC = db.LOPHOCs.Find(id);
            if (lOPHOC == null)
            {
                return HttpNotFound();
            }
            return View(lOPHOC);
        }

        // GET: Admin/LOPHOCs/Create
        public ActionResult Create()
        {
            ViewBag.MaHP = new SelectList(db.HOCPHIs, "MaHP", "MaHP");
            ViewBag.MaGV = new SelectList(db.GIAOVIENs, "MaGV", "HoTenGV");
            return View();
        }

        // POST: Admin/LOPHOCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop,SiSo,MaGV,NgayBD,NgayKT,NgayMoLop,TrangThai,MaHP")] LOPHOC lOPHOC)
        {
            if (ModelState.IsValid)
            {
                db.LOPHOCs.Add(lOPHOC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHP = new SelectList(db.HOCPHIs, "MaHP", "MaHP", lOPHOC.MaHP);
            ViewBag.MaGV = new SelectList(db.GIAOVIENs, "MaGV", "HoTenGV", lOPHOC.MaGV);
            return View(lOPHOC);
        }

        // GET: Admin/LOPHOCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOPHOC lOPHOC = db.LOPHOCs.Find(id);
            if (lOPHOC == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHP = new SelectList(db.HOCPHIs, "MaHP", "MaHP", lOPHOC.MaHP);
            ViewBag.MaGV = new SelectList(db.GIAOVIENs, "MaGV", "HoTenGV", lOPHOC.MaGV);
            return View(lOPHOC);
        }

        // POST: Admin/LOPHOCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop,SiSo,MaGV,NgayBD,NgayKT,NgayMoLop,TrangThai,MaHP")] LOPHOC lOPHOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOPHOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHP = new SelectList(db.HOCPHIs, "MaHP", "MaHP", lOPHOC.MaHP);
            ViewBag.MaGV = new SelectList(db.GIAOVIENs, "MaGV", "HoTenGV", lOPHOC.MaGV);
            return View(lOPHOC);
        }

        // GET: Admin/LOPHOCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOPHOC lOPHOC = db.LOPHOCs.Find(id);
            if (lOPHOC == null)
            {
                return HttpNotFound();
            }
            return View(lOPHOC);
        }

        // POST: Admin/LOPHOCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LOPHOC lOPHOC = db.LOPHOCs.Find(id);
            db.LOPHOCs.Remove(lOPHOC);
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
