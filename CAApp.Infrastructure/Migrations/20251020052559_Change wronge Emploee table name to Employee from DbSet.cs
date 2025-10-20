using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangewrongeEmploeetablenametoEmployeefromDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emploees",
                table: "Emploees");

            migrationBuilder.RenameTable(
                name: "Emploees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emploees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emploees",
                table: "Emploees",
                column: "Id");
        }
    }
}
