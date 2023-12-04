using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoPrivate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_UserId",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "SubTasks",
                newName: "RelatedKeyResult");

            migrationBuilder.AlterColumn<int>(
                name: "KeyResultId",
                table: "SubTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Objectives",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RelatedUser",
                table: "Objectives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ObjectiveId",
                table: "KeyResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults",
                column: "ObjectiveId",
                principalTable: "Objectives",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_UserId",
                table: "Objectives",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks",
                column: "KeyResultId",
                principalTable: "KeyResults",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResults_Objectives_ObjectiveId",
                table: "KeyResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_UserId",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks");

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
                name: "RelatedUser",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "RelatedObjective",
                table: "KeyResults");

            migrationBuilder.RenameColumn(
                name: "RelatedKeyResult",
                table: "SubTasks",
                newName: "Priority");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KeyResultId",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Objectives",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_UserId",
                table: "Objectives",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks",
                column: "KeyResultId",
                principalTable: "KeyResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
