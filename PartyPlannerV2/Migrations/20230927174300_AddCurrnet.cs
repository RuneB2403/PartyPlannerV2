using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartyPlannerV2.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentParticipants",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentParticipants",
                table: "Events");
        }
    }
}
