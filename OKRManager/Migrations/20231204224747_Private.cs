using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class Private : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubTasks_RelatedKeyResult",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_Objectives_RelatedUser",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_KeyResults_RelatedObjective",
                table: "KeyResults");

            migrationBuilder.DropColumn(
                name: "RelatedKeyResult",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "RelatedUser",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "RelatedObjective",
                table: "KeyResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelatedKeyResult",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RelatedUser",
                table: "Objectives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RelatedObjective",
                table: "KeyResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_RelatedKeyResult",
                table: "SubTasks",
                column: "RelatedKeyResult");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_RelatedUser",
                table: "Objectives",
                column: "RelatedUser");

            migrationBuilder.CreateIndex(
                name: "IX_KeyResults_RelatedObjective",
                table: "KeyResults",
                column: "RelatedObjective");
        }
    }
}
