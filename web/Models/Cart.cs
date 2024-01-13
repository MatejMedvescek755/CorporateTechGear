using System;
using System.Collections.Generic;

namespace web.Models{
    public class Cart
    {
        public int id {get; set;}
        public string user_id {get; set;}
        public decimal total {get; set;}
        public string product_id {get; set;}
        public string product_name {get; set;}
    }
}

/* 
    CREATE TABLE `cart` (
  `id` int PRIMARY KEY,
  `user_id` int,
  `total` decimal
);
*/