using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEventBriteApp.Models
{
    public class RegistrationCart
    {
        public string RegistrationCartId;
        private const string CartSessionKey = "CartId";
        EventBriteDB db = new EventBriteDB();

        public static RegistrationCart GetCart(HttpContextBase context)
        {
            RegistrationCart cart = new RegistrationCart();
            cart.RegistrationCartId = cart.GetCartId(context);
            return cart;
        }

        /*public string GetCartId(HttpContextBase context)
        {
            string cartId;

            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                   
                    cartId = context.User.Identity.Name;
                }

                else
                {
                    cartId = Guid.NewGuid().ToString();
              
                }
            }

            else
            {
                cartId = context.Session[CartSessionKey].ToString();
            }

                return cartId;
        }*/

        public string GetCartId(HttpContextBase context)
        {
            string cartId;

            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {

                    cartId = context.User.Identity.Name;
                }
                else
               {
                    cartId = Guid.NewGuid().ToString();
                }

                context.Session[CartSessionKey] = cartId;
            }

            else
            {
                cartId = context.Session[CartSessionKey].ToString();
            }
            return cartId;
         }


        public List<Order> GetRegistrationItems()
        {
           return db.Orders.Where(cart => cart.UserId == RegistrationCartId).ToList();
        }


        public decimal GetTotalTickets()
        {
            /*decimal? count = (from cartItems in db.Orders
                             where cartItems.UserId == RegistrationCartId
                             select cartItems.Count).Sum();*/
            return decimal.Zero;           
        }

        public void AddToCart(int id)
        {
           Order cartItem = db.Orders.SingleOrDefault(c => c.UserId == RegistrationCartId && c.EventId == id);          

            if(cartItem == null)
            {
                Event evnt = db.Events.SingleOrDefault(a => a.EventId == id);
                cartItem = new Order()
                {
                    UserId = RegistrationCartId,
                    EventId = id,
                    EventSelected = evnt,
                    Count = 1,
                    DateOrdered = DateTime.Now
                };

                db.Orders.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            db.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            Order cartItem = db.Orders.SingleOrDefault(cart => cart.OrderId == id);
            int count = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                }
                else
                {
                    db.Orders.Remove(cartItem);
                    count = 0;
                }
                db.SaveChanges();
            }
            return count;
        }
    }

}
