using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zoo_management_practice.Migrations
{
    /// <inheritdoc />
    public partial class addMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Membership",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Membership",
                table: "Visitors");
        }
    }
}
