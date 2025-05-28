using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Project
{
    class EF_Trading_Company : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<Item_Units> ItemUnits { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }

        public DbSet<Delivery_Items> DeliveryItems { get; set; }

        public DbSet<SellingOrder> SellingOrders { get; set; }

        public DbSet<Selling_Items> SellingItems { get; set; }

        public DbSet<Transfer> Transfer { get; set; }

        public DbSet<Transfer_Items> TransferItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=TradingCompanyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasKey(i => new { i.WarehouseID, i.ID });
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Warehouse)
                .WithMany(w => w.Items)
                .HasForeignKey(i => i.WarehouseID);
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Item_Units)
                .WithMany(u => u.Items)
                .HasForeignKey(i => i.Item_UnitsID);
            modelBuilder.Entity<Delivery_Items>()
                .HasOne(di => di.DeliveryOrder)
                .WithMany(DO => DO.Delivery_Items)
                .HasForeignKey(di => di.DeliveryOrderID);
            modelBuilder.Entity<Selling_Items>()
                .HasOne(si => si.SellingOrder)
                .WithMany(SO => SO.Selling_Items)
                .HasForeignKey(si => si.SellingOrderID);
            modelBuilder.Entity<Transfer_Items>()
                .HasOne(ti => ti.Transfer)
                .WithMany(TO => TO.Transfer_Items)
                .HasForeignKey(ti => ti.TransferID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
