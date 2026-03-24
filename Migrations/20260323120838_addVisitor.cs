using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zoo_management_practice.Migrations
{
    /// <inheritdoc />
    public partial class addVisitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Visitors",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Visitors");
        }
    }
}
