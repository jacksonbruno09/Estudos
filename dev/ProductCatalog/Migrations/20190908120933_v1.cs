using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryid",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Product",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Product",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryid",
                table: "Product",
                newName: "IX_Product_categoryid");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Product",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                type: "varchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "varchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Category",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_categoryid",
                table: "Product",
                column: "categoryid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_categoryid",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_categoryid",
                table: "Products",
                newName: "IX_Products_categoryid");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryid",
                table: "Products",
                column: "categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
