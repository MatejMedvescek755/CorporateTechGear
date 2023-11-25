using System;
using System.Collections.Generic;

namespace Models{
    public class Cart
    {
        public int id {get; set;}
        public int user_id {get; set;}
        public decimal total {get; set;}

        public Cart(int id, int user_id, decimal total)
        {
            this.id = id;
            this.user_id = user_id;
            this.total = total;
        }
    }
}

/* 
    CREATE TABLE `cart` (
  `id` int PRIMARY KEY,
  `user_id` int,
  `total` decimal
);
*/