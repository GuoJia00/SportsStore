using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext //数据库上下文
    {
        public DbSet<Product> Products { get; set; }//product类映射到一张名为productd 表上 
    }
}
