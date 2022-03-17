using HomeWorkProduct.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkProduct.DAL
{
    public class WorkDbContext:DbContext
    {
        public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
