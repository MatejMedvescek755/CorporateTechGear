using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


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
    public int id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
    public int rating { get; set; }
    public int stock { get; set; }
    public int category { get; set; }
    public string description { get; set; }
    public int brand { get; set; }

    private readonly web.Data.ShopContext _context;
  }

  public class ProductModel : PageModel
  {
    private readonly web.Data.ShopContext _context;

    public ProductModel(web.Data.ShopContext context)
    {
      _context = context;
    }

    public IActionResult OnGetProductClicked(int productId)
    {
      
        // Retrieve product data based on productId
        Product product = _context.Products.Find(productId);

        if (product == null)
        {
            // Handle the case where the product is not found
            return RedirectToPage("/Index");
        }
        // Redirect to the product description page with product data as query parameters
        return RedirectToPage("/ProductDescription", new { id = product.id, name = product.name, description = product.description });
    }
  }
}


