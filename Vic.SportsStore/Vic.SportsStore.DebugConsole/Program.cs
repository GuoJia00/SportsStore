using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext()) //ctx wei database
            {
                for (int i = 0; i < 10; i++)
                {
                    var product = new Product()
                    {
                        Name = $"p{i}",
                        Price = 1.2m,
                        Description = $"des{i}",
                        Category = $"c{i}"

                    };

                ctx.Products.Add(product);//product as list 在debugconsole的app.config里run设置setup后运行
                }
               
                
                ctx.SaveChanges();
            }
            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
