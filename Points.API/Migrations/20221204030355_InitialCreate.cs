using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Points.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Wago 750-550", "PLC" });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Wago 750-450", "PLC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Module");
        }
    }
}
