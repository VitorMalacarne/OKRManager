using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class Migracao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_UserID",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "SubTasks",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "SubTasks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "SubTasks",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "SubTasks",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "SubTasks",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Objectives",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Objectives",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Objectives",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Objectives",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Objectives",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Objectives",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Objectives_UserID",
                table: "Objectives",
                newName: "IX_Objectives_UserId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "KeyResults",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "KeyResults",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "KeyResults",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "KeyResults",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "KeyResults",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "KeyResultId",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Objectives",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObjectId",
                table: "KeyResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_UserId",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                table: "KeyResults");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SubTasks",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SubTasks",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "SubTasks",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "SubTasks",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SubTasks",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Objectives",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Objectives",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Objectives",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Objectives",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Objectives",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Objectives",
                newName: "description");

            migrationBuilder.RenameIndex(
                name: "IX_Objectives_UserId",
                table: "Objectives",
                newName: "IX_Objectives_UserID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "KeyResults",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "KeyResults",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "KeyResults",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "KeyResults",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "KeyResults",
                newName: "description");

            migrationBuilder.AlterColumn<int>(
                name: "KeyResultId",
                table: "SubTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Objectives",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_UserID",
                table: "Objectives",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_KeyResults_KeyResultId",
                table: "SubTasks",
                column: "KeyResultId",
                principalTable: "KeyResults",
                principalColumn: "Id");
        }
    }
}
