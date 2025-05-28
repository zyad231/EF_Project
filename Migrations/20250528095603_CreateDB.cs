using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Item_Units",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    ProdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Delivery_Orders_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_Orders_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Item_UnitsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => new { x.WarehouseID, x.ID });
                    table.ForeignKey(
                        name: "FK_Item_Item_Units_Item_UnitsID",
                        column: x => x.Item_UnitsID,
                        principalTable: "Item_Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "selling_orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selling_orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_selling_orders_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selling_orders_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selling_orders_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseFromID = table.Column<int>(type: "int", nullable: false),
                    WarehouseToID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    ProdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transfer_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transfer_Warehouse_WarehouseFromID",
                        column: x => x.WarehouseFromID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfer_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Transfer_Warehouse_WarehouseToID",
                        column: x => x.WarehouseToID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Items",
                columns: table => new
                {
                    DeliveryOrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Items", x => new { x.DeliveryOrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_Delivery_Items_Delivery_Orders_DeliveryOrderID",
                        column: x => x.DeliveryOrderID,
                        principalTable: "Delivery_Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_Items_Item_WarehouseID_ItemID",
                        columns: x => new { x.WarehouseID, x.ItemID },
                        principalTable: "Item",
                        principalColumns: new[] { "WarehouseID", "ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "selling_items",
                columns: table => new
                {
                    SellingOrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selling_items", x => new { x.SellingOrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_selling_items_Item_WarehouseID_ItemID",
                        columns: x => new { x.WarehouseID, x.ItemID },
                        principalTable: "Item",
                        principalColumns: new[] { "WarehouseID", "ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selling_items_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_selling_items_selling_orders_SellingOrderID",
                        column: x => x.SellingOrderID,
                        principalTable: "selling_orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transfer_items",
                columns: table => new
                {
                    TransferID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfer_items", x => new { x.TransferID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_transfer_items_Item_WarehouseID_ItemID",
                        columns: x => new { x.WarehouseID, x.ItemID },
                        principalTable: "Item",
                        principalColumns: new[] { "WarehouseID", "ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transfer_items_Transfer_TransferID",
                        column: x => x.TransferID,
                        principalTable: "Transfer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Items_WarehouseID_ItemID",
                table: "Delivery_Items",
                columns: new[] { "WarehouseID", "ItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Orders_SupplierID",
                table: "Delivery_Orders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Orders_WarehouseID",
                table: "Delivery_Orders",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Item_UnitsID",
                table: "Item",
                column: "Item_UnitsID");

            migrationBuilder.CreateIndex(
                name: "IX_selling_items_SupplierID",
                table: "selling_items",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_selling_items_WarehouseID_ItemID",
                table: "selling_items",
                columns: new[] { "WarehouseID", "ItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_selling_orders_ClientID",
                table: "selling_orders",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_selling_orders_SupplierID",
                table: "selling_orders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_selling_orders_WarehouseID",
                table: "selling_orders",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_SupplierID",
                table: "Transfer",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_WarehouseFromID",
                table: "Transfer",
                column: "WarehouseFromID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_WarehouseID",
                table: "Transfer",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_WarehouseToID",
                table: "Transfer",
                column: "WarehouseToID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_items_WarehouseID_ItemID",
                table: "transfer_items",
                columns: new[] { "WarehouseID", "ItemID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery_Items");

            migrationBuilder.DropTable(
                name: "selling_items");

            migrationBuilder.DropTable(
                name: "transfer_items");

            migrationBuilder.DropTable(
                name: "Delivery_Orders");

            migrationBuilder.DropTable(
                name: "selling_orders");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Transfer");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Item_Units");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Warehouse");
        }
    }
}
