using System;
using System.Collections.Generic;


/*

CREATE TABLE `products` (
  `id` int PRIMARY KEY,
  `name` string,
  `price` int,
  `rating` int,
  `stock` int,
  `category` int,
  `description` string,
  `brand` int
);

*/

namespace web.Models
{
    public class Product
    {
        public int id {get; set;}
        public string name {get; set;}
        public int price {get; set;}
        public int rating {get; set;}
        public int stock {get; set;}
        public int category {get; set;}
        public string description {get; set;}
        public int brand {get; set;}

    }
}


