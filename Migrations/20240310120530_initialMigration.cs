using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShopBrodova.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypesOfBoats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfBoats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TypesOfBoats",
                columns: new[] { "Id", "DisplayOrder", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "https://as1.ftcdn.net/v2/jpg/01/24/27/30/1000_F_124273079_ZHuBjV9p2Im0LZYcKH82C6bcaQrjRxtq.jpg", "Motor boats" },
                    { 2, 2, "https://www.bavariayachts.com/fileadmin/_processed_/2/7/csm_bavaria-sy-cruiserline-overview-cruiser37_8a9c47d54f.jpg", "Sailing boats" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypesOfBoats");
        }
    }
}
