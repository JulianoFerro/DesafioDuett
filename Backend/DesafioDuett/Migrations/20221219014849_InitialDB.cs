using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioDuett.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ValueA = table.Column<int>(type: "int", nullable: false),
                    ValueB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Description", "ValueA", "ValueB" },
                values: new object[] { 1, "Banana", 10, 5 });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Description", "ValueA", "ValueB" },
                values: new object[] { 2, "Maça", 8, 4 });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Description", "ValueA", "ValueB" },
                values: new object[] { 3, "Laranja", 6, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
