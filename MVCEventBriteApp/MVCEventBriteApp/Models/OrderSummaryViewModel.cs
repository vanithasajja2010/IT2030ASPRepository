using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEventBriteApp.Models.ViewModels
{
    public class OrderSummaryViewModel
    {
        public int OrderNumber { get; set; }
        public Event EventRegistered { get; set; }
        public int NumberOfTickets { get; set; }
    }
}