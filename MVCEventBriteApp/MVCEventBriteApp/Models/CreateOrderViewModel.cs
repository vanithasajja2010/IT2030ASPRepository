using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEventBriteApp.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        public List<Order> RegisteredItems;
        public decimal TotalTickets;
    }
}