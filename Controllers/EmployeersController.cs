using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200_golec.Models;

namespace MIS4200_golec.Controllers
{
    public class EmployeersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employeers
        public ActionResult Index()
        {
            var employeers = db.Employeers.Include(e => e.Employee);
            return View(employeers.ToList());
        }

        // GET: Employeers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employeer employeer = db.Employeers.Find(id);
            if (employeer == null)
            {
                return HttpNotFound();
            }
            return View(employeer);
        }

        // GET: Employeers/Create
        public ActionResult Create()
        {
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName");
            return View();
        }

        // POST: Employeers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "employeerId,lastName,firstName,employeeId")] Employeer employeer)
        {
            if (ModelState.IsValid)
            {
                db.Employeers.Add(employeer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", employeer.employeeId);
            return View(employeer);
        }

        // GET: Employeers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employeer employeer = db.Employeers.Find(id);
            if (employeer == null)
            {
                return HttpNotFound();
            }
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", employeer.employeeId);
            return View(employeer);
        }

        // POST: Employeers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "employeerId,lastName,firstName,employeeId")] Employeer employeer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", employeer.employeeId);
            return View(employeer);
        }

        // GET: Employeers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employeer employeer = db.Employeers.Find(id);
            if (employeer == null)
            {
                return HttpNotFound();
            }
            return View(employeer);
        }

        // POST: Employeers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employeer employeer = db.Employeers.Find(id);
            db.Employeers.Remove(employeer);
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
