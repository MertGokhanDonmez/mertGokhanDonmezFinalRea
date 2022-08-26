using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-Q640SRQG; Database=examDB; Trusted_Connection=true");

        }

        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<tag> tags { get; set; }
        public DbSet<tag_product> tag_products { get; set; }
    }
}
