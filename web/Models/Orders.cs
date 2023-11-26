using System;
using System.Collections.Generic;

namespace web.Models{
    /* 
    CREATE TABLE `order` (
  `id` int PRIMARY KEY,
  `products` int,
  `total` decimal,
  `created_at` timestamp,
  `user_id` int
);
*/

    public class Orders
    {
        public int id {get; set;}
        public int products {get; set;}
        public decimal total {get; set;}
        public DateTime created_at {get; set;}
        public int user_id {get; set;}

    }
}