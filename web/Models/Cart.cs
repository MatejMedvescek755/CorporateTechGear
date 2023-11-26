using System;
using System.Collections.Generic;

namespace web.Models{
    public class Cart
    {
        public int id {get; set;}
        public int user_id {get; set;}
        public decimal total {get; set;}

    }
}

/* 
    CREATE TABLE `cart` (
  `id` int PRIMARY KEY,
  `user_id` int,
  `total` decimal
);
*/