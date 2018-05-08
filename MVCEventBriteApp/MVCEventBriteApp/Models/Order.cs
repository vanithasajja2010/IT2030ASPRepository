using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEventBriteApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }
        public string UserId { get; set; }
        public int EventId { get; set; }
        [Display(Name = "Number Of Tickets")]
        public int Count { get; set; }
        [Display(Name = "Date Ordered")]
        public virtual Event EventSelected { get; set; }
        public DateTime DateOrdered { get; set; }
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }
    }
}
