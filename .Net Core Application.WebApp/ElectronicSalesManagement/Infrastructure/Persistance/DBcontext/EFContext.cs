using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DBcontext
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options)
           : base(options)
        {

        }
      
          
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>().HasKey(p =>new
            {
                p.ID_Admin,
                p.ID_Function
            });
            modelBuilder.Entity<DetailOrder>().HasKey(p => new
            {
                p.ID_Order,
                p.ID_Product
            });
        }
        public DbSet<Authorization> Authorizations { get; set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StockReceipt> StockReceipts { get; set; }


        public DbSet<DetailOrder> DetailOrders { get; set; }

    }
}
