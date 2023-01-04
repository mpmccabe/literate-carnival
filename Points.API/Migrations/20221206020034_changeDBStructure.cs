using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Points.API.Migrations
{
    public partial class changeDBStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Module");

            migrationBuilder.AddColumn<int>(
                name: "Channels",
                table: "Module",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MaxCnts",
                table: "Module",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinCnts",
                table: "Module",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Signal",
                table: "Module",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Module",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Channels", "MaxCnts", "Name", "Signal", "Type" },
                values: new object[] { 2, 32764.0, "750-550", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Channels", "MaxCnts", "MinCnts", "Name", "Signal", "Type" },
                values: new object[] { 2, 32767.0, -32767.0, "750-556", 1, 1 });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "Channels", "MaxCnts", "MinCnts", "Name", "Signal", "Type" },
                values: new object[,]
                {
                    { 3, 2, 32767.0, 0.0, "750-552", 2, 1 },
                    { 4, 2, 0.0, 0.0, "750-400", 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Channels",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "MaxCnts",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "MinCnts",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "Signal",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Module");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Module",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Wago 750-550", "PLC" });

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Wago 750-450", "PLC" });
        }
    }
}
