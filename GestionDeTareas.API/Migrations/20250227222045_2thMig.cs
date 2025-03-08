using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeTareas.API.Migrations
{
    /// <inheritdoc />
    public partial class _2thMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskTypes_typesId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "typesId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskTypes_typesId",
                table: "Tasks",
                column: "typesId",
                principalTable: "TaskTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskTypes_typesId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "typesId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskTypes_typesId",
                table: "Tasks",
                column: "typesId",
                principalTable: "TaskTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
