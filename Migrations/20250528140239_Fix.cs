using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Warehouse_WarehouseID",
                table: "Transfer");

            migrationBuilder.DropIndex(
                name: "IX_Transfer_WarehouseID",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "Transfer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarehouseID",
                table: "Transfer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_WarehouseID",
                table: "Transfer",
                column: "WarehouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Warehouse_WarehouseID",
                table: "Transfer",
                column: "WarehouseID",
                principalTable: "Warehouse",
                principalColumn: "ID");
        }
    }
}
