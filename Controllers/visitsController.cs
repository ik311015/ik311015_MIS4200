﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ik311015_MIS4200.DAL;
using ik311015_MIS4200.Models;

namespace ik311015_MIS4200.Controllers
{
    public class visitsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: visits
        public ActionResult Index()
        {
            var visits = db.visits.Include(v => v.pet).Include(v => v.vet);
            return View(visits.ToList());
        }

        // GET: visits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // GET: visits/Create
        public ActionResult Create()
        {
            ViewBag.petId = new SelectList(db.pets, "petId", "animalType");
            ViewBag.vetId = new SelectList(db.vets, "vetId", "firstName");
            return View();
        }

        // POST: visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitId,description,visitDate,vetId,petId")] visit visit)
        {
            if (ModelState.IsValid)
            {
                db.visits.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petId = new SelectList(db.pets, "petId", "animalType", visit.petId);
            ViewBag.vetId = new SelectList(db.vets, "vetId", "firstName", visit.vetId);
            return View(visit);
        }

        // GET: visits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            ViewBag.petId = new SelectList(db.pets, "petId", "animalType", visit.petId);
            ViewBag.vetId = new SelectList(db.vets, "vetId", "firstName", visit.vetId);
            return View(visit);
        }

        // POST: visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitId,description,visitDate,vetId,petId")] visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petId = new SelectList(db.pets, "petId", "animalType", visit.petId);
            ViewBag.vetId = new SelectList(db.vets, "vetId", "firstName", visit.vetId);
            return View(visit);
        }

        // GET: visits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visit visit = db.visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // POST: visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            visit visit = db.visits.Find(id);
            db.visits.Remove(visit);
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
