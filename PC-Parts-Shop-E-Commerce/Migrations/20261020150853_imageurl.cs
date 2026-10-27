using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PC_Parts_Shop_E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class imageurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://img-cdn.heureka.group/v1/3a01e256-9993-48bb-b658-79cc53f92cec/intel-core-i9-13900k-24-core-4-3ghz-lga1700-box-bx8071513900k.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.google.com/imgres?q=i9%2013900k&imgurl=https%3A%2F%2Fimg-cdn.heureka.group%2Fv1%2F3a01e256-9993-48bb-b658-79cc53f92cec%2Fintel-core-i9-13900k-24-core-4-3ghz-lga1700-box-bx8071513900k.jpg&imgrefurl=https%3A%2F%2Fwww.pazaruvaj.com%2Fprocesori-c3139%2Fintel%2Fcore-i9-13900k-24-core-4-3ghz-lga1700-box-bx8071513900k-p864868896%2F&docid=SEYzUwoGXjQuJM&tbnid=vAHqhT5QLiJH9M&vet=12ahUKEwjo1Zbn7MiXAxWkQvEDHUGEHY0QnPAOegQISBAA..i&w=591&h=572&hcb=2&ved=2ahUKEwjo1Zbn7MiXAxWkQvEDHUGEHY0QnPAOegQISBAA");
        }
    }
}
