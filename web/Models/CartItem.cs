using System;
using System.Collections.Generic;

namespace web.Models{
    
    // CREATE TABLE `cart_item` (
    //   `id` int PRIMARY KEY,
    //   `cart_id` int,
    //   `product_id` int,
    //   `quantity` int
    // );

    public class CartItem
    {
        public int id {get; set;}
        public int cart_id {get; set;}
        public int product_id {get; set;}
        public int quantity {get; set;}

    }
}
