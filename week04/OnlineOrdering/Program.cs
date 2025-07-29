using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.AddProduct("Seagate Portable 2 TB External Hard Drive HDD",
                        "EHD2000", 70, 1);
        order1.AddProduct("AMD Ryzen 7 9800x3D",
                        "AR79800", 472.50f, 1);
        order1.AddProduct("Corsair Vengeance LPX DDR4 RAM 32GB",
                        "CVL3200", 52.30f, 2);
        order1.SetCustomerName("Michael T. York");
        order1.SetCustomerAddress("15505 Somland Ln NE",
                                    "Bainbridge Island", "WA",
                                    "United States");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Cart:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Customer's Name: {order1.GetShippingLabel()}");
        Console.WriteLine($"Total: {order1.GetTotalPrice():0.00}");
        Console.WriteLine();


        Order order2 = new Order();
        order2.AddProduct("Disamer Summer Dresses Vacation Sleeveless Beach Swimsuit Cover",
                        "BSC2025", 24.90f, 3);
        order2.AddProduct("Wrangler Authentics Women's Stretch Denim Jacket",
                        "WDJ2025", 40, 1);
        order2.AddProduct("Retro Oval Sunglasses Chic Cat Eye 90's",
                        "CCE0090", 16.20f, 1);
        order2.SetCustomerName("Laura S. Jhonson");
        order2.SetCustomerAddress("2617 Danventry Dr",
                                    "Maryville", "TN",
                                    "United States");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Cart:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Customer's Name: {order2.GetShippingLabel()}");
        Console.WriteLine($"Total: {order2.GetTotalPrice():0.00}");
        Console.WriteLine();


        Order order3 = new Order();
        order3.AddProduct("Mens Ankle Running Socks",
                        "ARS0652", 4.50f, 5);
        order3.AddProduct("Wireless Earbuds HiFi Stereo",
                        "HFS0054", 25, 1);
        order3.SetCustomerName("Jonathan Alvarez");
        order3.SetCustomerAddress("5ta. Calle A 2-05",
                                    "Quetzaltenango", "Quetzaltenango",
                                    "Guatemala");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Cart:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"Customer's Name: {order3.GetShippingLabel()}");
        Console.WriteLine($"Total: ${order3.GetTotalPrice():0.00}");
        Console.WriteLine();
    }
}