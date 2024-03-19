using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbContextLibrary.Migrations
{
    /// <inheritdoc />
    public partial class New_Architecture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsList_CartId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductsList");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "text", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Title");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductsList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ammount = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsList", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                table: "Products",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsList_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "ProductsList",
                principalColumn: "Id");
        }
    }
}
