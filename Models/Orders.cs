using System;
using System.Collections.Generic;

namespace Models{
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

        public Orders(int id, int products, decimal total, DateTime created_at, int user_id)
        {
            this.id = id;
            this.products = products;
            this.total = total;
            this.created_at = created_at;
            this.user_id = user_id;
        }
    }
}