using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionDeTareas.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskPriorities",
                columns: table => new
                {
                    id_tskPr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tskPr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskPriorities", x => x.id_tskPr);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatus",
                columns: table => new
                {
                    id_tskSt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tskSt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatus", x => x.id_tskSt);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    id_tskTy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tskTy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.id_tskTy);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    id_Tsk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_Tsk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_Tsk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate_Tsk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    endDate_Tsk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_TskPr_Tsk = table.Column<int>(type: "int", nullable: false),
                    id_TskTy_Tsk = table.Column<int>(type: "int", nullable: false),
                    id_TskSt_Tsk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.id_Tsk);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskPriorities_id_TskPr_Tsk",
                        column: x => x.id_TskPr_Tsk,
                        principalTable: "TaskPriorities",
                        principalColumn: "id_tskPr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskStatus_id_TskSt_Tsk",
                        column: x => x.id_TskSt_Tsk,
                        principalTable: "TaskStatus",
                        principalColumn: "id_tskSt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_id_TskTy_Tsk",
                        column: x => x.id_TskTy_Tsk,
                        principalTable: "TaskTypes",
                        principalColumn: "id_tskTy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TaskPriorities",
                columns: new[] { "id_tskPr", "name_tskPr" },
                values: new object[,]
                {
                    { 1, "Baja" },
                    { 2, "Media" },
                    { 3, "Alta" }
                });

            migrationBuilder.InsertData(
                table: "TaskStatus",
                columns: new[] { "id_tskSt", "name_tskSt" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "Pausado" },
                    { 3, "Finalizado" }
                });

            migrationBuilder.InsertData(
                table: "TaskTypes",
                columns: new[] { "id_tskTy", "name_tskTy" },
                values: new object[,]
                {
                    { 1, "Trabajo" },
                    { 2, "Personal" },
                    { 3, "Estudio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_id_TskPr_Tsk",
                table: "Tasks",
                column: "id_TskPr_Tsk");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_id_TskSt_Tsk",
                table: "Tasks",
                column: "id_TskSt_Tsk");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_id_TskTy_Tsk",
                table: "Tasks",
                column: "id_TskTy_Tsk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskPriorities");

            migrationBuilder.DropTable(
                name: "TaskStatus");

            migrationBuilder.DropTable(
                name: "TaskTypes");
        }
    }
}
