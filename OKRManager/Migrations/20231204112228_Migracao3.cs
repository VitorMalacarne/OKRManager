using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class Migracao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                table: "KeyResults");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectiveId",
                table: "KeyResults",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults",
                column: "ObjectiveId",
                principalTable: "Objectives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectiveId",
                table: "KeyResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ObjectId",
                table: "KeyResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults",
                column: "ObjectiveId",
                principalTable: "Objectives",
                principalColumn: "Id");
        }
    }
}
