using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace RESTdemo
{


    class Program
    {
        
        static void Main()
        {
            using (var context = new testDBEntities())
            {
                //var products = context.Products;
                var count = context.Products.Count();
                Console.WriteLine(count);

                context.Products.Add(new Product() { Id=0, Name="Bags"});
                context.SaveChanges();

                count = context.Products.Count();
                var products = context.Products.Where(a=>a.Name.Contains("Bags")).ToList();

                Console.WriteLine(products.Count());
                Console.ReadLine();
            }
        }
    }


}
