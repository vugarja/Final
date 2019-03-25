using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sport.DAL;
using Sport.Models;

namespace Sport.Areas.Control.Controllers
{
    public class LocationsController : Controller
    {
        private SportContext db = new SportContext();

        // GET: Control/Locations
        public ActionResult Index()
        {
            var locations = db.Locations.Include(l => l.Category).Include(l => l.Region).Include(l => l.Station);
            return View(locations.ToList());
        }

        // GET: Control/Locations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Include(mbox=>mbox.Station).Include(m=>m.Category).Include(m=>m.Region).FirstOrDefault(x=>x.Id==id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Control/Locations/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.RegionId = new SelectList(db.Regions, "Id", "Name");
            ViewBag.StationId = new SelectList(db.Stations, "Id", "Name");
            return View();
        }

        // POST: Control/Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,City,Village,StreetName,StreetNo,RegionId,StationId,CategoryId,DailyPrice,MonthlyPrice,Image,Phone,Phone2,Email,Facebook,Instagram,Webpage,Discount,Info")] Location location)
        {
            if (ModelState.IsValid)
            {
                db.Locations.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", location.CategoryId);
            ViewBag.RegionId = new SelectList(db.Regions, "Id", "Name", location.RegionId);
            ViewBag.StationId = new SelectList(db.Stations, "Id", "Name", location.StationId);
            return View(location);
        }

        // GET: Control/Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", location.CategoryId);
            ViewBag.RegionId = new SelectList(db.Regions, "Id", "Name", location.RegionId);
            ViewBag.StationId = new SelectList(db.Stations, "Id", "Name", location.StationId);
            return View(location);
        }

        // POST: Control/Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,City,Village,StreetName,StreetNo,RegionId,StationId,CategoryId,DailyPrice,MonthlyPrice,Image,Phone,Phone2,Email,Facebook,Instagram,Webpage,Discount,Info")] Location location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", location.CategoryId);
            ViewBag.RegionId = new SelectList(db.Regions, "Id", "Name", location.RegionId);
            ViewBag.StationId = new SelectList(db.Stations, "Id", "Name", location.StationId);
            return View(location);
        }

        // GET: Control/Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Control/Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
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
