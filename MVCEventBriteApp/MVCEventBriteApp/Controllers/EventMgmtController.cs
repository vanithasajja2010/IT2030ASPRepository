using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEventBriteApp.Models;

namespace MVCEventBriteApp.Controllers
{
    public class EventMgmtController : Controller
    {
        private EventBriteDB db = new EventBriteDB();

        // GET: EventMgmt
        public ActionResult Index()
        {
            var events = db.Events.Include(a => a.EventType);
            return View(events.ToList());
        }

        // GET: EventMgmt/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: EventMgmt/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Type");
            return View();
        }

        // POST: EventMgmt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,EventTypeId,EventTitle,EventDescription,EventStartDate,EventStartTime,EventEndDate,EventEndTime,EventLocation,OrganizerName,OrganizerContactInfo,MaxTickets,AvailableTickets")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Type", @event.EventTypeId);
            return View(@event);
        }

        // GET: EventMgmt/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Type", @event.EventTypeId);
            return View(@event);
        }

        // POST: EventMgmt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,EventTypeId,EventTitle,EventDescription,EventStartDate,EventStartTime,EventEndDate,EventEndTime,EventLocation,OrganizerName,OrganizerContactInfo,MaxTickets,AvailableTickets")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Type", @event.EventTypeId);
            return View(@event);
        }

        // GET: EventMgmt/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: EventMgmt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
