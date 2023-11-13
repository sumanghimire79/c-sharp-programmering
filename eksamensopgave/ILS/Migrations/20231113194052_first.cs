using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILS.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contactForms",
                columns: table => new
                {
                    CFID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactForms", x => x.CFID);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    IID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "lends",
                columns: table => new
                {
                    LID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IID = table.Column<int>(type: "int", nullable: false),
                    LendingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendingDays = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lends", x => x.LID);
                    table.ForeignKey(
                        name: "FK_lends_items_IID",
                        column: x => x.IID,
                        principalTable: "items",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "contactForms",
                columns: new[] { "CFID", "Email", "Message", "Name" },
                values: new object[,]
                {
                    { 1, "testContactEmail@seed.dk", "0.This is test seed message", "testName" },
                    { 2, "testContactEmail@seed1.dk", "1.This is test seed message", "testName2" },
                    { 3, "testContactEmail@seed2.dk", "2.This is test seed message", "testName3" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "IID", "Category", "Description", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 0, "all in one bore maskine", "Bose bore maskine", 300.0 },
                    { 2, 1, "reusable party plate", "plastic plate", 5.0 },
                    { 3, 2, "light tent for summer", "tent", 500.0 }
                });

            migrationBuilder.InsertData(
                table: "lends",
                columns: new[] { "LID", "IID", "LendingDate", "LendingDays", "Note", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3401), 1, " thank you for the support.", 100.0 },
                    { 2, 2, new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3433), 3, " thank you for the Lending.", 200.0 },
                    { 3, 3, new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3435), 2, " thank you for the great support.", 300.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_lends_IID",
                table: "lends",
                column: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactForms");

            migrationBuilder.DropTable(
                name: "lends");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
