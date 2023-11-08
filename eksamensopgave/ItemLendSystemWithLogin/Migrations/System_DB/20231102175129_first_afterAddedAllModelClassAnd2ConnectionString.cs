using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemLendSystemWithLogin.Migrations.System_DB
{
    public partial class first_afterAddedAllModelClassAnd2ConnectionString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    BID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.BID);
                });

            migrationBuilder.CreateTable(
                name: "contactForm",
                columns: table => new
                {
                    CFID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactForm", x => x.CFID);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Items_Owners_OID",
                        column: x => x.OID,
                        principalTable: "Owners",
                        principalColumn: "OID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lends",
                columns: table => new
                {
                    LID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IID = table.Column<int>(type: "int", nullable: false),
                    BID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LendingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendingDays = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lends", x => x.LID);
                    table.ForeignKey(
                        name: "FK_Lends_Borrowers_BID",
                        column: x => x.BID,
                        principalTable: "Borrowers",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lends_Items_IID",
                        column: x => x.IID,
                        principalTable: "Items",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Borrowers",
                columns: new[] { "BID", "Email", "Mobile", "Name" },
                values: new object[,]
                {
                    { 1, "jiwan@test.dk", "3333333", "sher" },
                    { 2, "lovely@test.dk", "44444444", "jiwan" },
                    { 3, "lost@test.dk", "66666666", "Lasse" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OID", "Email", "Mobile", "Name" },
                values: new object[,]
                {
                    { 1, "testexam@test.dk", "27859433", "Lasse" },
                    { 2, "suman@test.dk", "42308933", "Suman" },
                    { 3, "ram@test.dk", "12345678", "Ram" }
                });

            migrationBuilder.InsertData(
                table: "contactForm",
                columns: new[] { "CFID", "Email", "Message", "Name" },
                values: new object[,]
                {
                    { 1, "testContactEmail@seed.dk", "0.This is test seed message", "testName" },
                    { 2, "testContactEmail@seed1.dk", "1.This is test seed message", "testName2" },
                    { 3, "testContactEmail@seed2.dk", "2.This is test seed message", "testName3" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "IID", "Category", "Description", "Name", "OID", "UnitPrice" },
                values: new object[] { 1, 0, "all in one bore maskine", "Bose bore maskine", 1, 300.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "IID", "Category", "Description", "Name", "OID", "UnitPrice" },
                values: new object[] { 2, 1, "reusable party plate", "plastic plate", 2, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "IID", "Category", "Description", "Name", "OID", "UnitPrice" },
                values: new object[] { 3, 2, "light tent for summer", "tent", 3, 500.0 });

            migrationBuilder.InsertData(
                table: "Lends",
                columns: new[] { "LID", "BID", "IID", "LendingDate", "LendingDays", "Note", "Quantity" },
                values: new object[] { 1, 1, 1, new DateTime(2023, 11, 2, 18, 51, 29, 232, DateTimeKind.Local).AddTicks(3858), 1, " thank you for the support.", 10 });

            migrationBuilder.InsertData(
                table: "Lends",
                columns: new[] { "LID", "BID", "IID", "LendingDate", "LendingDays", "Note", "Quantity" },
                values: new object[] { 2, 2, 2, new DateTime(2023, 11, 2, 18, 51, 29, 232, DateTimeKind.Local).AddTicks(3902), 3, " thank you for the Lending.", 20 });

            migrationBuilder.InsertData(
                table: "Lends",
                columns: new[] { "LID", "BID", "IID", "LendingDate", "LendingDays", "Note", "Quantity" },
                values: new object[] { 3, 1, 3, new DateTime(2023, 11, 2, 18, 51, 29, 232, DateTimeKind.Local).AddTicks(3906), 2, " thank you for the great support.", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Items_OID",
                table: "Items",
                column: "OID");

            migrationBuilder.CreateIndex(
                name: "IX_Lends_BID",
                table: "Lends",
                column: "BID");

            migrationBuilder.CreateIndex(
                name: "IX_Lends_IID",
                table: "Lends",
                column: "IID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactForm");

            migrationBuilder.DropTable(
                name: "Lends");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
