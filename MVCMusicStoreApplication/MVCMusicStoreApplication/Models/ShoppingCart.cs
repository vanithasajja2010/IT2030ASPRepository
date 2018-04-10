﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;
        private const string CartSessionKey = "CartId";
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public string GetCartId(HttpContextBase context)
        {
            string cartId;
            if (context.Session[CartSessionKey] == null)
            {
                //Create a cart id and add it to the session variable
                cartId = Guid.NewGuid().ToString();
                context.Session[CartSessionKey] = cartId;
            }
            else
            {
                //retrieve cart id
                cartId = context.Session[CartSessionKey].ToString();

            }
            return cartId;
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(cart => cart.CartId == ShoppingCartId).ToList();
        }

        public decimal GetCartTotal()
        {
            decimal? total = (from cartItems in db.Carts
                              where cartItems.CartId == ShoppingCartId
                              select cartItems.AlbumSelected.Price * (int?)cartItems.Count).Sum();
            return total ?? decimal.Zero;
        }

        public void AddToCart(int id)
        {

            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == ShoppingCartId && c.AlbumId == id);

            //CartItem does not exist in the db => add CartItem to database
            if (cartItem == null)
            {
                Album album = db.Albums.SingleOrDefault(a => a.AlbumId == id);
                cartItem = new Cart()
                {
                    CartId = ShoppingCartId,
                    AlbumId = id,
                    AlbumSelected = album,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                db.Carts.Add(cartItem);
            }
            //CartItem already exists in db => Update Count
            else
            {
                cartItem.Count++;
            }
            db.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            Cart cartItem = db.Carts.SingleOrDefault(cart => cart.RecordId == id);
            int count = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    count = cartItem.Count;
                }
                else
                {
                    db.Carts.Remove(cartItem);
                }
                db.SaveChanges();
            }
            return count;
        }
    }
}



 
