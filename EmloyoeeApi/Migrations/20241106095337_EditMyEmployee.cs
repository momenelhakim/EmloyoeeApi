using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmloyoeeApi.Migrations
{
    /// <inheritdoc />
    public partial class EditMyEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departements",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departements",
                table: "Employees");
        }
    }
}
