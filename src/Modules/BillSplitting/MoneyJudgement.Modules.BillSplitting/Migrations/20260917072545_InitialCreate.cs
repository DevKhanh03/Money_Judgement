using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyJudgement.Modules.BillSplitting.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bill_splitting");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "bill_splitting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                schema: "bill_splitting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    PaidByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SplitType = table.Column<string>(type: "text", nullable: false),
                    BillDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AttachmentUrl = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "bill_splitting",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillSplitDetails",
                schema: "bill_splitting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BillId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupMemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    AmountOwed = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    SplitValue = table.Column<decimal>(type: "numeric(18,4)", precision: 18, scale: 4, nullable: true),
                    IsSettled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillSplitDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillSplitDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalSchema: "bill_splitting",
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CategoryId",
                schema: "bill_splitting",
                table: "Bills",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BillSplitDetails_BillId",
                schema: "bill_splitting",
                table: "BillSplitDetails",
                column: "BillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillSplitDetails",
                schema: "bill_splitting");

            migrationBuilder.DropTable(
                name: "Bills",
                schema: "bill_splitting");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "bill_splitting");
        }
    }
}
