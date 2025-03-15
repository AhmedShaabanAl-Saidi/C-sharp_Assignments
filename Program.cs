using DatabaseFrist.Context;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFrist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext context = new NorthwindContext();

            #region Stored Procedure
            //NorthwindContextProcedures contextProcedures = new NorthwindContextProcedures(context);

            //var customers = contextProcedures.SP_GetCustomerOrderHistoryAsync("ALFKI").Result;

            //Console.WriteLine(customers);
            #endregion

            #region Run SQL Query
            // 1- Execute Select Statement
            //var result = context.Categories.FromSqlRaw("Select * from Categories").ToList();

            //foreach (var item in result)
            //    Console.WriteLine($"{item.CategoryName} :: {item.Description}");

            //var category = "Beverages";
            //var result = context.Categories.FromSqlInterpolated($"Select * from Categories where CategoryName = {category}").ToList();

            //foreach (var item in result)
            //    Console.WriteLine($"{item.CategoryName} :: {item.Description}");

            //2- Execute DML Query
            //context.Database.ExecuteSqlInterpolated($"update Products set ProductName = 'Chai2' where ProductId = 1");
            #endregion

            #region Lazy Loading Vs Eager Loading Vs Explicit 
            //var result = context.Products.ToList();

            //foreach (var product in result)
            //    Console.WriteLine($"{product.ProductID} :: {product.UnitPrice} :: {product.Category.CategoryName}");


            //var product = context.Products.Include(x => x.Category).FirstOrDefault();
            //var product = context.Products.Include(x => x.Category).Include(x => x.Supplier).FirstOrDefault();
            //var product = context.Products.Include(x => x.Category).ThenInclude(x => x.Products).FirstOrDefault();

            //var product = context.Products.FirstOrDefault();

            //context.Entry(product).Reference(x => x.Category).Load();
            //context.Entry(product).Collection(x => x.Order_Details).Load();

            //var categoryName = product.Category.CategoryName;
            #endregion

            #region Remote Vs Local
            //context.Products.Load();

            //if (context.Products.Any(x => x.UnitsInStock == 0))
            //    Console.WriteLine("There are Out of Stock Products");
            //else
            //    Console.WriteLine("There are no Out of Stock Products");
            #endregion
        }
    }
}
