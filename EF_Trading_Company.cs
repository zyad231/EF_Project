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

            // Warehouse primary key
            modelBuilder.Entity<Warehouse>()
                .HasKey(w => w.ID);

            // Item composite primary key
            modelBuilder.Entity<Item>()
                .HasKey(i => new { i.WarehouseID, i.ID });

            // Item -> Warehouse relationship (many to one)
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Warehouse)
                .WithMany(w => w.Items)
                .HasForeignKey(i => i.WarehouseID);

            // Item_Units composite primary key
            modelBuilder.Entity<Item_Units>()
                .HasKey(u => new { u.warehouseID, u.ItemID, u.Unit });

            // Item_Units -> Item relationship (many to one)
            modelBuilder.Entity<Item_Units>()
                .HasOne(u => u.Item)
                .WithMany(i => i.Item_Units)
                .HasForeignKey(u => new { u.warehouseID, u.ItemID });

            modelBuilder.Entity<Delivery_Items>()
                .HasKey(di => new { di.DeliveryOrderID, di.ItemID, di.WarehouseID ,});

            modelBuilder.Entity<Delivery_Items>()
                .HasOne(di => di.DeliveryOrder)
                .WithMany(DO => DO.Delivery_Items)
                .HasForeignKey(di => di.DeliveryOrderID);

            modelBuilder.Entity<Delivery_Items>()
                .HasOne(di => di.Item)
                .WithMany()
                .HasForeignKey(di => new { di.WarehouseID, di.ItemID });

            modelBuilder.Entity<Selling_Items>()
                .HasKey(si => new { si.SellingOrderID, si.ItemID ,si.WarehouseID});
            modelBuilder.Entity<Selling_Items>()
                .HasOne(si => si.SellingOrder)
                .WithMany(SO => SO.Selling_Items)
                .HasForeignKey(si => si.SellingOrderID);
            modelBuilder.Entity<Selling_Items>()
                .HasOne(si => si.Item)
                .WithMany()
                .HasForeignKey(si => new { si.WarehouseID, si.ItemID });

            modelBuilder.Entity<Transfer_Items>()
                .HasKey(ti => new { ti.TransferID, ti.ItemID ,ti.WarehouseID});
            modelBuilder.Entity<Transfer_Items>()
                .HasOne(ti => ti.Transfer)
                .WithMany(t => t.Transfer_Items)
                .HasForeignKey(ti => ti.TransferID);
            modelBuilder.Entity<Transfer_Items>()
                .HasOne(ti => ti.Item)
                .WithMany()
                .HasForeignKey(ti => new { ti.WarehouseID, ti.ItemID });
            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.WarehouseFrom)
                .WithMany()
                .HasForeignKey(t => t.WarehouseFromID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.WarehouseTo)
                .WithMany()
                .HasForeignKey(t => t.WarehouseToID)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
