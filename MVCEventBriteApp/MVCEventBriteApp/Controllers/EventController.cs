using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEventBriteApp.Models;
using System.Net;

namespace MVCEventBriteApp.Controllers
{
    public class EventController : Controller
    {
        private EventBriteDB db = new EventBriteDB();
        public ActionResult Index()
        {
            return View();
        }

        /*// GET: Event
         public ActionResult Search(string q)
         {
             var events = GetEvents(q);
             return PartialView(events);
         }

         private List<Event> GetEvents(string searchstring)
         {
             var events = db.Events.Where(a => a.EventTitle.Contains(searchstring) || a.EventType.Type == searchstring).ToList();
             return events;
         }*/

       public ActionResult Search(string q, string p)
        {
            var events = from e in db.Events
                         select e;
            if (!string.IsNullOrEmpty(q))
            {
                events = events.Where(e => e.EventTitle.Contains(q) || e.EventType.Type.Contains(q));
            }
            if (!string.IsNullOrEmpty(p))
            {
                events = events.Where(e => e.EventLocation.Contains(p));
            }
            return PartialView(events);
        }
        


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


        public ActionResult Register(int id)
        {
            var eventRegistered = db.Events.Where(e => e.EventId == id);
            return PartialView("_Register", eventRegistered);
        }

        public ActionResult LastMinuteDeals()
        {
            var deals = GetLastMinuteDeals();

            return PartialView("_LastMinuteDeals", deals);
        }

        private Event GetLastMinuteDeals()
        {
            var deals = db.Events.OrderBy(a => System.Guid.NewGuid()).First();
            return deals;
        }

    }
}
   