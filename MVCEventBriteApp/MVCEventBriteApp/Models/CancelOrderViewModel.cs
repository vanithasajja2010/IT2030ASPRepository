using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEventBriteApp.Models.ViewModels
{
    public class CancelOrderViewModel
    {
        public int DeleteId { get; set; }
        public int ItemCount { get; set; }
        public int CartCount { get; set; }
        public string Message { get; set; }
        public string OrderStatus { get; set; }
    }
}