using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "RTX 2080 Gigabyte 12 GB",
                    Description="sadasdj",
                    Price = 2000,
                    PictureUrl = "/images/products/rtx2080gigabyte",
                    Type = "Graphics Card",
                    Brand = "Nvidia",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "Intel Core i7 9770k",
                    Description="sadasdjsdadsada",
                    Price = 500,
                    PictureUrl = "/images/products/i79770k",
                    Type = "Processor",
                    Brand = "Intel",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Radeon Rx580",
                    Description="sadasdj",
                    Price = 900,
                    PictureUrl = "/images/products/rx580",
                    Type = "Graphics Card",
                    Brand = "AMD",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "SSD 500gb",
                    Description="sadasdj",
                    Price = 150,
                    PictureUrl = "/images/products/rtx2080gigabyte",
                    Type = "Memory",
                    Brand = "Intel",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "Ryzen 5",
                    Description="sadasdj",
                    Price = 300,
                    PictureUrl = "/images/products/rryzen5",
                    Type = "Processor",
                    Brand = "AMD",
                    QuantityInStock = 45
                }
            }; 

            foreach(var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}