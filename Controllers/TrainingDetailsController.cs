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
    public class TrainingDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: TrainingDetails
        public ActionResult Index()
        {
            var trainingDetails = db.TrainingDetails.Include(t => t.Trainer).Include(t => t.TrainingSessions);
            return View(trainingDetails.ToList());
        }

        // GET: TrainingDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingDetail trainingDetail = db.TrainingDetails.Find(id);
            if (trainingDetail == null)
            {
                return HttpNotFound();
            }
            return View(trainingDetail);
        }

        // GET: TrainingDetails/Create
        public ActionResult Create()
        {
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "Description");
            ViewBag.TrainingsessionID = new SelectList(db.TrainingSessions, "TrainingSessionID", "Description");
            return View();
        }

        // POST: TrainingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingDetailID,Equipment,TrainingDuration,WorkoutType,TrainingsessionID,TrainerID")] TrainingDetail trainingDetail)
        {
            if (ModelState.IsValid)
            {
                db.TrainingDetails.Add(trainingDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "Description", trainingDetail.TrainerID);
            ViewBag.TrainingsessionID = new SelectList(db.TrainingSessions, "TrainingSessionID", "Description", trainingDetail.TrainingsessionID);
            return View(trainingDetail);
        }

        // GET: TrainingDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingDetail trainingDetail = db.TrainingDetails.Find(id);
            if (trainingDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "Description", trainingDetail.TrainerID);
            ViewBag.TrainingsessionID = new SelectList(db.TrainingSessions, "TrainingSessionID", "Description", trainingDetail.TrainingsessionID);
            return View(trainingDetail);
        }

        // POST: TrainingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingDetailID,Equipment,TrainingDuration,WorkoutType,TrainingsessionID,TrainerID")] TrainingDetail trainingDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "Description", trainingDetail.TrainerID);
            ViewBag.TrainingsessionID = new SelectList(db.TrainingSessions, "TrainingSessionID", "Description", trainingDetail.TrainingsessionID);
            return View(trainingDetail);
        }

        // GET: TrainingDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingDetail trainingDetail = db.TrainingDetails.Find(id);
            if (trainingDetail == null)
            {
                return HttpNotFound();
            }
            return View(trainingDetail);
        }

        // POST: TrainingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrainingDetail trainingDetail = db.TrainingDetails.Find(id);
            db.TrainingDetails.Remove(trainingDetail);
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
