using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKRManager.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResult_Objective_ObjectiveId",
                table: "KeyResult");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTask_KeyResult_KeyResultId",
                table: "SubTask");

            migrationBuilder.DropIndex(
                name: "IX_SubTask_KeyResultId",
                table: "SubTask");

            migrationBuilder.DropIndex(
                name: "IX_KeyResult_ObjectiveId",
                table: "KeyResult");

            migrationBuilder.DropColumn(
                name: "KeyResultId",
                table: "SubTask");

            migrationBuilder.DropColumn(
                name: "ObjectiveId",
                table: "KeyResult");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SubTask",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "KeyResult",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResult_Objective_Id",
                table: "KeyResult",
                column: "Id",
                principalTable: "Objective",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTask_KeyResult_Id",
                table: "SubTask",
                column: "Id",
                principalTable: "KeyResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyResult_Objective_Id",
                table: "KeyResult");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTask_KeyResult_Id",
                table: "SubTask");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SubTask",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "KeyResultId",
                table: "SubTask",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "KeyResult",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ObjectiveId",
                table: "KeyResult",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTask_KeyResultId",
                table: "SubTask",
                column: "KeyResultId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyResult_ObjectiveId",
                table: "KeyResult",
                column: "ObjectiveId");

            migrationBuilder.AddForeignKey(
                name: "FK_KeyResult_Objective_ObjectiveId",
                table: "KeyResult",
                column: "ObjectiveId",
                principalTable: "Objective",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTask_KeyResult_KeyResultId",
                table: "SubTask",
                column: "KeyResultId",
                principalTable: "KeyResult",
                principalColumn: "Id");
        }
    }
}
