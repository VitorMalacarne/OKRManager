using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class @fixed : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubTasks",
                table: "SubTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KeyResults",
                table: "KeyResults");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "SubTasks",
                newName: "SubTask");

            migrationBuilder.RenameTable(
                name: "Objectives",
                newName: "Objective");

            migrationBuilder.RenameTable(
                name: "KeyResults",
                newName: "KeyResult");

            migrationBuilder.RenameIndex(
                name: "IX_SubTasks_KeyResultId",
                table: "SubTask",
                newName: "IX_SubTask_KeyResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Objectives_UserId",
                table: "Objective",
                newName: "IX_Objective_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_KeyResults_ObjectiveId",
                table: "KeyResult",
                newName: "IX_KeyResult_ObjectiveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubTask",
                table: "SubTask",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objective",
                table: "Objective",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KeyResult",
                table: "KeyResult",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResult_Objective_ObjectiveId",
                table: "KeyResult",
                column: "ObjectiveId",
                principalTable: "Objective",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_User_UserId",
                table: "Objective",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTask_KeyResult_KeyResultId",
                table: "SubTask",
                column: "KeyResultId",
                principalTable: "KeyResult",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResult_Objective_ObjectiveId",
                table: "KeyResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Objective_User_UserId",
                table: "Objective");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTask_KeyResult_KeyResultId",
                table: "SubTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubTask",
                table: "SubTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Objective",
                table: "Objective");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KeyResult",
                table: "KeyResult");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "SubTask",
                newName: "SubTasks");

            migrationBuilder.RenameTable(
                name: "Objective",
                newName: "Objectives");

            migrationBuilder.RenameTable(
                name: "KeyResult",
                newName: "KeyResults");

            migrationBuilder.RenameIndex(
                name: "IX_SubTask_KeyResultId",
                table: "SubTasks",
                newName: "IX_SubTasks_KeyResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Objective_UserId",
                table: "Objectives",
                newName: "IX_Objectives_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_KeyResult_ObjectiveId",
                table: "KeyResults",
                newName: "IX_KeyResults_ObjectiveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubTasks",
                table: "SubTasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KeyResults",
                table: "KeyResults",
                column: "Id");

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
    }
}
