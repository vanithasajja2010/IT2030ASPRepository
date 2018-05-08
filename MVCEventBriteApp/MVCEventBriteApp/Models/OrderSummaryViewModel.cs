using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEventBriteApp.Models.ViewModels
{
    public class OrderSummaryViewModel
    {
        [Display(Name = "Order #")]
        public string OrderNumber { get; set; }
        [Display(Name = "Event title")]
        public Event EventRegistered { get; set; }
        [Display(Name = "# of tickets ordered")]
        public int NumberOfTickets { get; set; }
    }
}