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
{
    public class C2arpitphonesController : Controller
    {
        private Model1 db = new Model1();

        // GET: C2arpitphones
        public ActionResult Index()
        {
            return View(db.C2arpitphones.ToList());
        }

        // GET: C2arpitphones/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C2arpitphones c2arpitphones = db.C2arpitphones.Find(id);
            if (c2arpitphones == null)
            {
                return HttpNotFound();
            }
            return View(c2arpitphones);
        }

        // GET: C2arpitphones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C2arpitphones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Phone,s_no,Condition,Rating")] C2arpitphones c2arpitphones)
        {
            if (ModelState.IsValid)
            {
                db.C2arpitphones.Add(c2arpitphones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c2arpitphones);
        }

        // GET: C2arpitphones/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C2arpitphones c2arpitphones = db.C2arpitphones.Find(id);
            if (c2arpitphones == null)
            {
                return HttpNotFound();
            }
            return View(c2arpitphones);
        }

        // POST: C2arpitphones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Phone,s_no,Condition,Rating")] C2arpitphones c2arpitphones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c2arpitphones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c2arpitphones);
        }

        // GET: C2arpitphones/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C2arpitphones c2arpitphones = db.C2arpitphones.Find(id);
            if (c2arpitphones == null)
            {
                return HttpNotFound();
            }
            return View(c2arpitphones);
        }

        // POST: C2arpitphones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            C2arpitphones c2arpitphones = db.C2arpitphones.Find(id);
            db.C2arpitphones.Remove(c2arpitphones);
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
