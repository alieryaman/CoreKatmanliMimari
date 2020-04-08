using CoreKatmanliMimari.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using CoreKatmanliMimari.Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatmanliMimari.DataAccess.Concrete.EntityFrameworkCore
{
    public class TestProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NV0GSA0\SQLEXPRESS;Database=CoreKatmanli;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
        
        }
    }
}
