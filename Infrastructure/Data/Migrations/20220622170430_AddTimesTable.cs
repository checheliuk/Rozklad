using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddTimesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cites_CityId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Intervals");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Intervals");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Intervals");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Routes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "Intervals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Start = table.Column<TimeSpan>(type: "interval", nullable: true),
                    End = table.Column<TimeSpan>(type: "interval", nullable: true),
                    Value = table.Column<TimeSpan>(type: "interval", nullable: false),
                    IntervalId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Times_Intervals_IntervalId",
                        column: x => x.IntervalId,
                        principalTable: "Intervals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Times_IntervalId",
                table: "Times",
                column: "IntervalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cites_CityId",
                table: "Routes",
                column: "CityId",
                principalTable: "Cites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cites_CityId",
                table: "Routes");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "Intervals");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Routes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "End",
                table: "Intervals",
                type: "interval",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Start",
                table: "Intervals",
                type: "interval",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Intervals",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cites_CityId",
                table: "Routes",
                column: "CityId",
                principalTable: "Cites",
                principalColumn: "Id");
        }
    }
}
