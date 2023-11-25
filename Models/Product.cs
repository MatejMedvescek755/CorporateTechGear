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

namespace Models
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

        public Product(int id, string name, int price, int rating, int stock, int category, string description, int brand)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.rating = rating;
            this.stock = stock;
            this.category = category;
            this.description = description;
            this.brand = brand;
        }
    }
}


