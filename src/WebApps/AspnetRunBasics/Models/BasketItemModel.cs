﻿namespace AspnetRunBasics.Models
{
    public class BasketItemModel
    {
        //ShoppingCartItem related fields
        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

    }
}