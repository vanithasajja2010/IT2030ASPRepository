using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEventBriteApp.Models;
using System.Net;
using System.Data;
using System.Data.Entity;



namespace MVCEventBriteApp.Controllers
{
    public class EventController : Controller
    {
        private EventBriteDB db = new EventBriteDB();
        public ActionResult Index()
        {
            return View();
        }


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
            List<Event> deals = GetLastMinuteDeals();

            if (deals.Count > 0)
            {
                return PartialView("_LastMinuteDeals", deals);
            }

            else
            {
                return PartialView("_NoDealsMessage");
            }
        }

        private List<Event> GetLastMinuteDeals()
        {
            //var deals = db.Events.Where(a => a.EventStartDate == DateTime.Today.AddDays(-2)).ToList();
            //var deals = db.Events.Where(a => a.EventStartDate >= DateTime.Now && a.EventStartDate == DbFunctions.AddDays(2)).ToList();
            var deals = db.Events.Where(a => a.EventStartDate >= DateTime.Today && a.EventStartDate <= DbFunctions.AddDays(DateTime.Today,2)).ToList();
            return deals;
        }
    

    }
}
   