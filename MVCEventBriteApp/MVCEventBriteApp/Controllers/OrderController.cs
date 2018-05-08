using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEventBriteApp.Models.ViewModels;
using MVCEventBriteApp.Models;

namespace MVCEventBriteApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        EventBriteDB db = new EventBriteDB();
        public ActionResult Index()
        {
            RegistrationCart cart = RegistrationCart.GetCart(this.HttpContext);
            CreateOrderViewModel vm = new CreateOrderViewModel()
            {
                RegisteredItems = cart.GetRegistrationItems(),
                TotalTickets = cart.GetTotalTickets()
            };
            return View(vm);
        }
        public ActionResult Create(int id)
        {
            RegistrationCart cart = RegistrationCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Cancel(int id)
        {
            RegistrationCart cart = RegistrationCart.GetCart(this.HttpContext);
            
            int itemCnt = cart.RemoveFromCart(id);
            CancelOrderViewModel vm = new CancelOrderViewModel()
            {
                ItemCount = itemCnt,
                DeleteId = id,
                CartCount = 0,
                Message = "Your ticket has been cancelled",
                OrderStatus = "Cancelled"
            };

            return Json(vm);
        }
        public ActionResult TicketsOrdered()
        {
            RegistrationCart cart = RegistrationCart.GetCart(this.HttpContext);
            return View();
        }

        public ActionResult OrderSummary(int id)
        {
            //RegistrationCart cart = RegistrationCart.GetCart(this.HttpContext);
            //List<Order> myOrder = cart.GetRegistrationItems();
            //Order orderItem = (Order)myOrder.SingleOrDefault(a => a.EventId == id);
            //OrderSummaryViewModel vm = new OrderSummaryViewModel()
            //{
            //    EventRegistered = orderItem.EventSelected,
            //    NumberOfTickets = orderItem.Count,
            //    OrderNumber = orderItem.OrderNumber                  
            //};

            return View();
        }

    }
}