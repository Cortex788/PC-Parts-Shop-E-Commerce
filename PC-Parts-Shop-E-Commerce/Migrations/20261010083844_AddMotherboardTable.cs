using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PC_Parts_Shop_E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class AddMotherboardTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FormFactor = table.Column<int>(type: "int", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MemoryType = table.Column<int>(type: "int", nullable: false),
                    MemorySlots = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Motherboards_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motherboards");
        }
    }
}
