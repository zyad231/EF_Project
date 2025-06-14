﻿// <auto-generated />
using System;
using EF_Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Project.Migrations
{
    [DbContext(typeof(EF_Trading_Company))]
    [Migration("20250529142725_AddMissingDate")]
    partial class AddMissingDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Project.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("EF_Project.DeliveryOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProdDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Delivery_Orders");
                });

            modelBuilder.Entity("EF_Project.Delivery_Items", b =>
                {
                    b.Property<int>("DeliveryOrderID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DeliveryOrderID", "ItemID", "WarehouseID");

                    b.HasIndex("WarehouseID", "ItemID");

                    b.ToTable("Delivery_Items");
                });

            modelBuilder.Entity("EF_Project.Item", b =>
                {
                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WarehouseID", "ID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("EF_Project.Item_Units", b =>
                {
                    b.Property<int>("warehouseID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("warehouseID", "ItemID", "Unit");

                    b.ToTable("Item_Units");
                });

            modelBuilder.Entity("EF_Project.SellingOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("selling_orders");
                });

            modelBuilder.Entity("EF_Project.Selling_Items", b =>
                {
                    b.Property<int>("SellingOrderID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("SellingOrderID", "ItemID", "WarehouseID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseID", "ItemID");

                    b.ToTable("selling_items");
                });

            modelBuilder.Entity("EF_Project.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("EF_Project.Transfer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProdDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseFromID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseToID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseFromID");

                    b.HasIndex("WarehouseToID");

                    b.ToTable("Transfer");
                });

            modelBuilder.Entity("EF_Project.Transfer_Items", b =>
                {
                    b.Property<int>("TransferID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("TransferID", "ItemID", "WarehouseID");

                    b.HasIndex("WarehouseID", "ItemID");

                    b.ToTable("transfer_items");
                });

            modelBuilder.Entity("EF_Project.Warehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("EF_Project.DeliveryOrder", b =>
                {
                    b.HasOne("EF_Project.Supplier", "Supplier")
                        .WithMany("DeliveryOrders")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Warehouse", "Warehouse")
                        .WithMany("DeliveryOrders")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("EF_Project.Delivery_Items", b =>
                {
                    b.HasOne("EF_Project.DeliveryOrder", "DeliveryOrder")
                        .WithMany("Delivery_Items")
                        .HasForeignKey("DeliveryOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Item", "Item")
                        .WithMany()
                        .HasForeignKey("WarehouseID", "ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DeliveryOrder");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("EF_Project.Item", b =>
                {
                    b.HasOne("EF_Project.Warehouse", "Warehouse")
                        .WithMany("Items")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("EF_Project.Item_Units", b =>
                {
                    b.HasOne("EF_Project.Item", "Item")
                        .WithMany("Item_Units")
                        .HasForeignKey("warehouseID", "ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("EF_Project.SellingOrder", b =>
                {
                    b.HasOne("EF_Project.Client", "Client")
                        .WithMany("SellingOrders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Supplier", "Supplier")
                        .WithMany("SellingOrders")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Warehouse", "Warehouse")
                        .WithMany("SellingOrders")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("EF_Project.Selling_Items", b =>
                {
                    b.HasOne("EF_Project.SellingOrder", "SellingOrder")
                        .WithMany("Selling_Items")
                        .HasForeignKey("SellingOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Supplier", null)
                        .WithMany("Selling_Items")
                        .HasForeignKey("SupplierID");

                    b.HasOne("EF_Project.Item", "Item")
                        .WithMany()
                        .HasForeignKey("WarehouseID", "ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("SellingOrder");
                });

            modelBuilder.Entity("EF_Project.Transfer", b =>
                {
                    b.HasOne("EF_Project.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Warehouse", "WarehouseFrom")
                        .WithMany("FromTransfer")
                        .HasForeignKey("WarehouseFromID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EF_Project.Warehouse", "WarehouseTo")
                        .WithMany("ToTransfer")
                        .HasForeignKey("WarehouseToID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("WarehouseFrom");

                    b.Navigation("WarehouseTo");
                });

            modelBuilder.Entity("EF_Project.Transfer_Items", b =>
                {
                    b.HasOne("EF_Project.Transfer", "Transfer")
                        .WithMany("Transfer_Items")
                        .HasForeignKey("TransferID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Project.Item", "Item")
                        .WithMany()
                        .HasForeignKey("WarehouseID", "ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Transfer");
                });

            modelBuilder.Entity("EF_Project.Client", b =>
                {
                    b.Navigation("SellingOrders");
                });

            modelBuilder.Entity("EF_Project.DeliveryOrder", b =>
                {
                    b.Navigation("Delivery_Items");
                });

            modelBuilder.Entity("EF_Project.Item", b =>
                {
                    b.Navigation("Item_Units");
                });

            modelBuilder.Entity("EF_Project.SellingOrder", b =>
                {
                    b.Navigation("Selling_Items");
                });

            modelBuilder.Entity("EF_Project.Supplier", b =>
                {
                    b.Navigation("DeliveryOrders");

                    b.Navigation("SellingOrders");

                    b.Navigation("Selling_Items");
                });

            modelBuilder.Entity("EF_Project.Transfer", b =>
                {
                    b.Navigation("Transfer_Items");
                });

            modelBuilder.Entity("EF_Project.Warehouse", b =>
                {
                    b.Navigation("DeliveryOrders");

                    b.Navigation("FromTransfer");

                    b.Navigation("Items");

                    b.Navigation("SellingOrders");

                    b.Navigation("ToTransfer");
                });
#pragma warning restore 612, 618
        }
    }
}
