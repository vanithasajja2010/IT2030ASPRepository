using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEventBriteApplication.Models;

namespace MVCEventBriteApplication.Controllers
{
    public class OrganizeEventController : Controller
    {

        [Authorize]
        public ActionResult OrganizeAnEvent()
        {           
            return View();
        }
    }
}