using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(5404), "Industrial & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(5430), "Clothing, Grocery & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(5443), "Grocery, Shoes & Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 13, 15, 38, 12, 784, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 786, DateTimeKind.Local).AddTicks(9937), "Salladı suscipit enim ve dışarı.", "Corporis." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 786, DateTimeKind.Local).AddTicks(9989), "Dolorem kalemi sunt çıktılar blanditiis.", "Sed." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 787, DateTimeKind.Local).AddTicks(17), "Ki mi commodi enim dolor.", "Reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 789, DateTimeKind.Local).AddTicks(6539), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8.159359406090140m, 380.58m, "Practical Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 38, 12, 789, DateTimeKind.Local).AddTicks(6567), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8.112965976148560m, 964.05m, "Practical Cotton Salad" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 127, DateTimeKind.Local).AddTicks(9971), "Books, Toys & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 127, DateTimeKind.Local).AddTicks(9983), "Books, Health & Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 127, DateTimeKind.Local).AddTicks(9993), "Baby & Industrial" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 9, 13, 27, 47, 128, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 9, 13, 27, 47, 128, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 9, 13, 27, 47, 128, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 9, 13, 27, 47, 128, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 130, DateTimeKind.Local).AddTicks(169), "Ullam ipsum ex exercitationem masanın.", "Dışarı." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 130, DateTimeKind.Local).AddTicks(245), "Düşünüyor perferendis ötekinden sed voluptatem.", "Sunt." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 130, DateTimeKind.Local).AddTicks(272), "Voluptatem velit çünkü aut için.", "Öyle." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 131, DateTimeKind.Local).AddTicks(5145), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8.35402390712010m, 441.52m, "Ergonomic Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 9, 13, 27, 47, 131, DateTimeKind.Local).AddTicks(5167), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7.900073261316720m, 39.09m, "Intelligent Steel Mouse" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
