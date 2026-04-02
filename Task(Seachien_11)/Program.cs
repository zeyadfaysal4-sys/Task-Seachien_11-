using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Numerics;
using Task_Seachien_11_.Data;
using Task_Seachien_11_.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_Seachien_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();

            var coustmer = _context.Customers.AsQueryable();

            //1 - List all customers' first and last names along with their email addresses. 

            //foreach(var item in coustmer)
            //{
            //    Console.WriteLine($"{item.FirstName} ,{item.LastName} ,{item.Email} ") ;

            //}

            //Console.WriteLine("=================");

            ////2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).


            //var orders = _context.Orders.Where(o=>o.StaffId == 3);

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Order #{item.OrderId} , Status: {item.OrderStatus} , Staff: {item.StaffId} ");

            //}

            //Console.WriteLine("=================");

            //3- Get all products that belong to a category named "Mountain Bikes". 


            //var product = _context.Products.Include(p => p.Category)
            //    .Where(c => c.Category.CategoryName == "Mountain Bikes");

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Category {item.Category.CategoryName}");

            //}

            //Console.WriteLine("=================");

            //4 - Count the total number of orders per store.


            //var orders = _context.Orders.GroupBy(o => o.StoreId).Select(o => new
            //{

            //    StoreId =o.Key,
            //    totalorders = o.Count(),
            //});

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Orders {item.StoreId} , totalorders : {item.totalorders}");
            //}

            //Console.WriteLine("=================");


            //5 - List all orders that have not been shipped yet(shipped_date is null). 

            //var orders = _context.Orders.Where(o => o.ShippedDate == null);


            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Orders {item.OrderId} Not shipped yet");
            //}

            //Console.WriteLine("=================");


            // 6- Display each customer’s full name and the number of orders they have placed. 

            //var customers = _context.Customers.Select(c => new
            //{
            //    FullName = c.FirstName + " " + c.LastName,
            //    Total = c.Orders.Count()
            //});

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"FullName : {item.FullName} ,TotalOrders : {item.Total} ");
            //}

            //Console.WriteLine("=================");


            // 7- List all products that have never been ordered (not found in order_items). 

            //var product = _context.Products.Where(p => _context.OrderItems.Any(oi => oi.ProductId == p.ProductId));

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Product : {item.ProductName} not found in order_items");
            //}

            //Console.WriteLine("=================");


            // 8 - Display products that have a quantity of less than 5 in any store stock.

            //This

            //var product = _context.Products.Where(p => p.Stocks.Any(s => s.Quantity < 5)).ToList();

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Product : {item.ProductName} has low stock");
            //}

            // Or This

            //var product = _context.Products.Join(
            //    _context.Stocks,
            //    p => p.ProductId,
            //    s => s.ProductId,
            //    (p, s) => new
            //    {
            //        product = p,
            //        Stock = s
            //    })
            //.Where(ps => ps.Stock.Quantity < 5).Select(ps => ps.product).ToList().Distinct();

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Product : {item.ProductName} has low stock");
            //}

            //Console.WriteLine("=================");


            // 9- Retrieve the first product from the products table. 

            //var product = _context.Products.FirstOrDefault();

            //var product = _context.Products.Find(1);

            //var product = _context.Products.SingleOrDefault(p => p.ProductId == 1);

            //Console.WriteLine($"{product.ProductId},{product.ProductName}");

            //Console.WriteLine("=================");


            //10 - Retrieve all products from the products table with a certain model year.

            //int year = 2017;
            //var product = _context.Products.Where(p => p.ModelYear == year);
            //foreach(var item in product)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Year : {item.ModelYear}");
            //}
            //Console.WriteLine("=================");


            // 11 - Display each product with the number of times it was ordered.

            //var product = _context.Products.Select(o => new
            //{
            //    productName = o.ProductName,
            //    ordere = o.OrderItems.Count()
            //});

            //foreach(var item in  product)
            //{ 
            // Console.WriteLine($"Product: {item.productName}, Ordered : {item.ordere} times");
            //}
            //Console.WriteLine("=================");

            //12- Count the number of products in a specific category. 

            //var product = _context.Products.GroupBy(p=>p.Category.CategoryName).Select(p => new
            //{

            //    catagory = p.Key,
            //    count = p.Count()
            //});

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Catagory: {item.catagory}, Count : {item.count} times");
            //}

            //Console.WriteLine("=================");

            // 13- Calculate the average list price of products. 

            //var product = _context.Products.Average(p => p.ListPrice);
            //Console.WriteLine($"Avg price: {product}");

            //Console.WriteLine("=================");

            //14 - Retrieve a specific product from the products table by ID.

            //var product = _context.Products.Find(6);

            //if(product!=null)
            //{
            //    Console.WriteLine($"{product.ProductId},{product.ProductName}");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Product not found");
            //}

            //Console.WriteLine("=================");

            // 15- List all products that were ordered with a quantity greater than 3 in any order. 

            //var product = _context.OrderItems.Where(oi => oi.Quantity > 3).Select(op => op.Product)
            //    .Distinct();

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Id : {item.ProductId},Product : {item.ProductName} ");
            //}

            //Console.WriteLine("=================")

            //16 - Display each staff member’s name and how many orders they processed. 

            //var staff = _context.Orders.GroupBy(s=>s.Staff).Select(s => new
            //{
            //    Full = s.Key.FirstName + " " + s.Key.LastName,
            //    Count = s.Count()
            //});


            //foreach (var item in staff)
            //{
            //    Console.WriteLine($"Name: {item.Full}, Count : {item.Count} ");
            //}

            //Console.WriteLine("=================")

            // 17 - List active staff members only(active = true) along with their phone numbers.

            //var staff = _context.Staffs.Where(s => s.Active == 1).Select(s => new
            //{
            //    FullName = s.FirstName + " " + s.LastName,
            //    s.Phone
            //});

            //foreach (var item in staff)
            //{
            //    Console.WriteLine($"Name: {item.FullName}, Number : {item.Phone} ");
            //}

            //Console.WriteLine("=================")

            // 18- List all products with their brand name and category name. 

            //var product = _context.Products.Include(p => p.Category).Include(p => p.Brand).Select(p => new
            //{
            //    p.ProductName,
            //    p.Category.CategoryName,
            //    p.Brand.BrandName
            //});

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"product: {item.ProductName}, Category : {item.CategoryName} , Brand : {item.BrandName}");
            //}

            //Console.WriteLine("=================")

            //19- Retrieve orders that are completed. 

            //var completedOrders = _context.Orders.Where(o => o.OrderStatus == 1);

            //foreach (var item in completedOrders)
            //{
            //    Console.WriteLine($"Id : {item.OrderId}, Status : {item.OrderStatus} ");
            //}

            //Console.WriteLine("=================")

            //20- List each product with the total quantity sold (sum of quantity from order_items). 

            var Product = _context.OrderItems.GroupBy(o => o.Product).Select(p => new
            {

                Name = p.Key.ProductName,
                Totlquantity = p.Sum(q => q.Quantity)

            }).OrderByDescending(p => p.Totlquantity);

            foreach (var item in Product)
            {
                Console.WriteLine($"Id : {item.Name}, Total Quantity : {item.Totlquantity} ");
            }
            _context.SaveChanges();

        }
    }
}
