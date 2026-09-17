using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyJudgement.Modules.Reporting.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "reporting");

            migrationBuilder.CreateTable(
                name: "DebtSnapshots",
                schema: "reporting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtSnapshots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DebtSnapshots_GroupId_FromUserId_ToUserId",
                schema: "reporting",
                table: "DebtSnapshots",
                columns: new[] { "GroupId", "FromUserId", "ToUserId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DebtSnapshots",
                schema: "reporting");
        }
    }
}
