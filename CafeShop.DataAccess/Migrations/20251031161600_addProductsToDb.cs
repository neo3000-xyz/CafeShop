using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CafeShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Name", "Price", "Price100", "Price50", "ProductCode", "Size" },
                values: new object[,]
                {
                    { 1, "Cà phê pha phin truyền thống với sữa đặc, vị đậm đà và béo ngậy.", 45000.0, "Cà phê sữa đá", 42000.0, 38000.0, 40000.0, "CF001", "M" },
                    { 2, "Trà đào tươi kết hợp cam vàng và sả, vị ngọt thanh mát.", 55000.0, "Trà đào cam sả", 52000.0, 47000.0, 50000.0, "TD001", "L" },
                    { 3, "Bánh ngọt kiểu Ý với lớp kem mascarpone mềm mịn và cacao thơm lừng.", 65000.0, "Bánh tiramisu", 62000.0, 57000.0, 60000.0, "BK001", "M" },
                    { 4, "Sự kết hợp tinh tế giữa vị ngọt của vải tươi và hương thơm quyến rũ của hoa hồng.", 59000.0, "Trà vải hoa hồng", 56000.0, 51000.0, 54000.0, "TC001", "L" },
                    { 5, "Trà trái cây tươi mát với ổi hồng chín mọng, mang đến hương vị ngọt dịu tự nhiên.", 57000.0, "Trà ổi hồng", 54000.0, 49000.0, 52000.0, "TC002", "L" },
                    { 6, "Trà nhài kết hợp vị ngọt thanh của đào và ổi, mang hương thơm dịu nhẹ và sảng khoái.", 60000.0, "Trà nhài đào ổi", 57000.0, 52000.0, 55000.0, "TC003", "L" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
