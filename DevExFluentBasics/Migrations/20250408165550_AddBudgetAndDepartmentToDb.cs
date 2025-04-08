using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevExFluentBasics.Migrations
{
    /// <inheritdoc />
    public partial class AddBudgetAndDepartmentToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnualBudget",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualBudget", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Expense = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualBudgetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_AnnualBudget_AnnualBudgetId",
                        column: x => x.AnnualBudgetId,
                        principalTable: "AnnualBudget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_AnnualBudgetId",
                table: "Department",
                column: "AnnualBudgetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "AnnualBudget");
        }
    }
}
