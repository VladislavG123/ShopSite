using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ShopApp.Context;
using ShopApp.DTO;
using ShopApp.Models;
using ShopApp.Services;

namespace ShopApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly ShopContext context;
        private readonly PayPalService payPalService;

        public BasketsController(ShopContext context, PayPalService payPalService)
        {
            this.context = context;
            this.payPalService = payPalService;
        }

        // GET: api/Basket
        [HttpGet]
        public async Task<ActionResult> GetProductsInBasket()
        {
            var basket = await context.Baskets.FirstOrDefaultAsync();

            (basket.Products as List<Product>).AddRange(await context.Products.Where(product => product.Basket.Id == basket.Id).ToListAsync());

            var products = new List<ProductDTO>();

            foreach (var item in basket.Products)
            {
                products.Add(new ProductDTO
                {
                    Cost = item.Cost,
                    Description = item.Description,
                    Name = item.Name
                });
            }

            return Ok(products);
        }


        // PUT: api/Baskets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpGet]
        public async Task<IActionResult> PutToBasket(string productId)
        {
            var product = (await context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == productId));

            if (product is null) return NoContent();

            var basket = await context.Baskets.FirstOrDefaultAsync();

            product.Basket = basket;

            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<string> PayBasket()
        {
            var basket = await context.Baskets.FirstOrDefaultAsync();

            (basket.Products as List<Product>).AddRange(await context.Products.Where(product => product.Basket.Id == basket.Id).ToListAsync());

            var url = await payPalService.CreateInvoice(basket);

            return url;
        }


    }
}
