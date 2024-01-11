using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    public partial class sargunan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillProperts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visited_Palce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Travel_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose_of_Visit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_Visit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_Return = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bill_File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bill_Number = table.Column<long>(type: "bigint", nullable: false),
                    Date_on_Bill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expense = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillProperts", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillProperts");
        }
    }
}
