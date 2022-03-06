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
                    Name = "GIGABYTE GeForceRTX 2080 Super Windforce 8G",
                    Description="Powered by GeForce RTX 2080 SUPER. Nvidia Turing architecture & Real time Ray Tracing",
                    Price = 120000,
                    PictureUrl = "/images/products/rtx2080gigabyte.jpg",
                    Type = "Graphics Card",
                    Brand = "Nvidia",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "Intel Core i7-9700K Desktop Processor",
                    Description="8 Cores / 8 Threads. 3.60 GHz up to 4.90 GHz / 12 MB Cache.Compatible only with Motherboards based on Intel 300 Series Chipsets",
                    Price = 50000,
                    PictureUrl = "/images/products/i79700k.jpg",
                    Type = "Processor",
                    Brand = "Intel",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Sapphire Pulse Radeon RX 580",
                    Description="DirectX 12 11265-05-20T 8GB 256-Bit GDDR5 PCI Express 3.0 x16 CrossFireX Support ATX Video Card",
                    Price = 90000,
                    PictureUrl = "/images/products/rx580.jpg",
                    Type = "Graphics Card",
                    Brand = "AMD",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "Intel SSD 3.84TB 3D NAND",
                    Description="Form Factor: 2.5 inch. Random Read (100% span): 97, 000 IOPS",
                    Price = 75599,
                    PictureUrl = "/images/products/intelssd.jpg",
                    Type = "Memory",
                    Brand = "Intel",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "AMD Ryzen 5 5600X 6-core",
                    Description="AMD's fastest 6 core processor for mainstream desktop, with 12 processing threads",
                    Price = 29999,
                    PictureUrl = "/images/products/ryzen5600x.jpg",
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