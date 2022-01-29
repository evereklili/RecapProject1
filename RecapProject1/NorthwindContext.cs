using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    public class NorthwindContext : DbContext
    {
        //bir nesnem var o şu veritabanında kaşrılık gelri demeliyiz. 
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}
