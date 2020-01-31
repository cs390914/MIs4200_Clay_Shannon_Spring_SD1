using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIs4200_Clay_Shannon_Spring_SD1.DAL;
using MIs4200_Clay_Shannon_Spring_SD1.Models;

namespace MIs4200_Clay_Shannon_Spring_SD1.Controllers
{
    public class TrainingSessionsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: TrainingSessions
        public ActionResult Index()
        {
            var trainingSessions = db.TrainingSessions.Include(t => t.Client);
            return View(trainingSessions.ToList());
        }

        // GET: TrainingSessions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingSessions trainingSessions = db.TrainingSessions.Find(id);
            if (trainingSessions == null)
            {
                return HttpNotFound();
            }
            return View(trainingSessions);
        }

        // GET: TrainingSessions/Create
        public ActionResult Create()
        {
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "FirstName");
            return View();
        }

        // POST: TrainingSessions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingSessionID,Description,TrainingSessionDate,ClientID")] TrainingSessions trainingSessions)
        {
            if (ModelState.IsValid)
            {
                db.TrainingSessions.Add(trainingSessions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "FirstName", trainingSessions.ClientID);
            return View(trainingSessions);
        }

        // GET: TrainingSessions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingSessions trainingSessions = db.TrainingSessions.Find(id);
            if (trainingSessions == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "FirstName", trainingSessions.ClientID);
            return View(trainingSessions);
        }

        // POST: TrainingSessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingSessionID,Description,TrainingSessionDate,ClientID")] TrainingSessions trainingSessions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingSessions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "FirstName", trainingSessions.ClientID);
            return View(trainingSessions);
        }

        // GET: TrainingSessions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingSessions trainingSessions = db.TrainingSessions.Find(id);
            if (trainingSessions == null)
            {
                return HttpNotFound();
            }
            return View(trainingSessions);
        }

        // POST: TrainingSessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrainingSessions trainingSessions = db.TrainingSessions.Find(id);
            db.TrainingSessions.Remove(trainingSessions);
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
