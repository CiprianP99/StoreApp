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
                },
                new Product
                {
                    Name = "MSI Gaming GeForce RTX 2070 Super 8GB",
                    Description="Chipset: NVIDIA GeForce RTX 2070 Super. Boost Clock: 1770 MHz . Video Memory: 8GB GDDR6. Memory Interface: 256-bit",
                    Price = 97019,
                    PictureUrl = "/images/products/rtx_2070_msi.jpg",
                    Type = "Graphics Card",
                    Brand = "Nvidia",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "PowerColor Hellhound AMD Radeon RX 6700 XT",
                    Description="The vertical design and increased array of aluminum fins improves heat spread dramatically. With a massive array of fins, the copper heatpipes can collect heat and dissipate it with maximum efficiency.",
                    Price = 89999,
                    PictureUrl = "/images/products/amd_rx6700.jpg",
                    Type = "Graphics Card",
                    Brand = "AMD",
                    QuantityInStock = 23
                },
                new Product
                {
                    Name = "Intel CPU Core i3-10100F / 3.6GHz",
                    Description="Drive innovation that makes the world safer, builds healthy and vibrant communities, and increases productivity.",
                    Price = 8400,
                    PictureUrl = "/images/products/intel_i3.jpg",
                    Type = "Processor",
                    Brand = "Intel",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Corsair Vengeance LPX 16GB (2x8GB) DDR4",
                    Description="Hand-sorted memory chips ensure high performance with generous Overclocking headroom. SPD Speed-2133MHz",
                    Price = 6999,
                    PictureUrl = "/images/products/vengeance_16.jpg",
                    Type = "RAM",
                    Brand = "Corsair",
                    QuantityInStock = 45
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
                },
                new Product
                {
                    Name = "G.Skill Trident Z RGB Series 16GB (2 x 8GB)",
                    Description="Trident Z RGB Series, compatible for AMD Ryzen Series; Intel Z170 and newer.",
                    Price = 8799,
                    PictureUrl = "/images/products/trident.jpg",
                    Type = "RAM",
                    Brand = "GSkill",
                    QuantityInStock = 45
                },
                new Product
                {
                    Name = "Noctua NF-F12 PWM, Premium Quiet Fan",
                    Description="Premium quiet fan, 120x120x25 mm, 12V, 4-pin PWM, max. 1500 RPM, max. 22.4 dB(A), >150,000 h MTTF",
                    Price = 8399,
                    PictureUrl = "/images/products/noctua.jpg",
                    Type = "Cooling",
                    Brand = "Noctua",
                    QuantityInStock = 5
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