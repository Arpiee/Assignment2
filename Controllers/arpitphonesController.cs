using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{[Authorize(Roles = "Asministrator")]
    public class arpitphonesController : Controller
    {
        private Model1 db = new Model1();

        // GET: arpitphones
        public ActionResult Index()
        {
            return View(db.arpitphones.ToList());
        }

        [AllowAnonymous]
        // GET: arpitphones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arpitphone arpitphone = db.arpitphones.Find(id);
            if (arpitphone == null)
            {
                return HttpNotFound();
            }
            return View(arpitphone);
        }

        // GET: arpitphones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: arpitphones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "s_no,Phone,models,Price")] arpitphone arpitphone)
        {
            if (ModelState.IsValid)
            {
                db.arpitphones.Add(arpitphone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arpitphone);
        }

        // GET: arpitphones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arpitphone arpitphone = db.arpitphones.Find(id);
            if (arpitphone == null)
            {
                return HttpNotFound();
            }
            return View(arpitphone);
        }

        // POST: arpitphones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "s_no,Phone,models,Price")] arpitphone arpitphone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arpitphone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arpitphone);
        }

        // GET: arpitphones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arpitphone arpitphone = db.arpitphones.Find(id);
            if (arpitphone == null)
            {
                return HttpNotFound();
            }
            return View(arpitphone);
        }

        // POST: arpitphones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            arpitphone arpitphone = db.arpitphones.Find(id);
            db.arpitphones.Remove(arpitphone);
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
