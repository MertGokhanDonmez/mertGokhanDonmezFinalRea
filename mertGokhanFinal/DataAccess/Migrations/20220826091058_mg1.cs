using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    tagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.tagID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    createDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    categoriescategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productID);
                    table.ForeignKey(
                        name: "FK_products_categories_categoriescategoryID",
                        column: x => x.categoriescategoryID,
                        principalTable: "categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tag_products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagID = table.Column<int>(type: "int", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tag_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_tag_products_products_productID",
                        column: x => x.productID,
                        principalTable: "products",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tag_products_tags_tagID",
                        column: x => x.tagID,
                        principalTable: "tags",
                        principalColumn: "tagID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_categoriescategoryID",
                table: "products",
                column: "categoriescategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tag_products_productID",
                table: "tag_products",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_tag_products_tagID",
                table: "tag_products",
                column: "tagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tag_products");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
