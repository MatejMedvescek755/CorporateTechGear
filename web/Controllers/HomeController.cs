﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Data;
using web.Models;
using Microsoft.EntityFrameworkCore;

namespace web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ShopContext _context;

    public HomeController(ILogger<HomeController> logger, ShopContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return _context.Products != null ? 
            View(await _context.Products.ToListAsync()) :
            Problem("Entity set 'ShopContext.Products'  is null.");
    }

    public async Task<IActionResult> To_Cart(int productId)
    {   
        var existingCartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.cart_id == 3 && ci.product_id == productId);

         if (existingCartItem != null)
        {
            // If the item exists, increase the quantity
            existingCartItem.quantity++;
        }
        else
        {
            // If the item doesn't exist, create a new CartItem
            var newCartItem = new CartItem
            {
                cart_id = 3,
                product_id = productId,
                quantity = 1 // or any initial quantity
            };

            _context.CartItems.Add(newCartItem);
        }
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}