using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tactsoft.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UpdateNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDelete", "ModifiedBy", "ModifiedDate", "Name", "StateId", "UpdateNo" },
                values: new object[,]
                {
                    { 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6261), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, 0, 0, 0, 0)), "Los Angeles", 1L, 0 },
                    { 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), "San Francisco", 1L, 0 },
                    { 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)), "San Diego", 1L, 0 },
                    { 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6294), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6295), new TimeSpan(0, 0, 0, 0, 0)), "Sacramento", 1L, 0 },
                    { 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6297), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 0, 0, 0, 0)), "San Jose", 1L, 0 },
                    { 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 0, 0, 0, 0)), "Houston", 2L, 0 },
                    { 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6304), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 0, 0, 0, 0)), "Dallas", 2L, 0 },
                    { 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 0, 0, 0, 0)), "Austin", 2L, 0 },
                    { 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 0, 0, 0, 0)), "San Antonio", 2L, 0 },
                    { 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 0, 0, 0, 0)), "Fort Worth", 2L, 0 },
                    { 11L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6322), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 0, 0, 0, 0)), "New York City", 3L, 0 },
                    { 12L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6326), new TimeSpan(0, 0, 0, 0, 0)), "Buffalo", 3L, 0 },
                    { 13L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 0, 0, 0, 0)), "Rochester", 3L, 0 },
                    { 14L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, 0, 0, 0, 0)), "Yonkers", 3L, 0 },
                    { 15L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), "Syracuse", 3L, 0 },
                    { 16L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6337), new TimeSpan(0, 0, 0, 0, 0)), "Miami", 4L, 0 },
                    { 17L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6339), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 0, 0, 0, 0)), "Orlando", 4L, 0 },
                    { 18L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6344), new TimeSpan(0, 0, 0, 0, 0)), "Tampa", 4L, 0 },
                    { 19L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 0, 0, 0, 0)), "Jacksonville", 4L, 0 },
                    { 20L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 0, 0, 0, 0)), "Fort Lauderdale", 4L, 0 },
                    { 21L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), "Chicago", 5L, 0 },
                    { 22L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 0, 0, 0, 0)), "Aurora", 5L, 0 },
                    { 23L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)), "Naperville", 5L, 0 },
                    { 24L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 0, 0, 0, 0)), "Rockford", 5L, 0 },
                    { 25L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6369), new TimeSpan(0, 0, 0, 0, 0)), "Joliet", 5L, 0 },
                    { 26L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6371), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6372), new TimeSpan(0, 0, 0, 0, 0)), "Toronto", 6L, 0 },
                    { 27L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6375), new TimeSpan(0, 0, 0, 0, 0)), "Ottawa", 6L, 0 },
                    { 28L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6378), new TimeSpan(0, 0, 0, 0, 0)), "Mississauga", 6L, 0 },
                    { 29L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6381), new TimeSpan(0, 0, 0, 0, 0)), "Brampton", 6L, 0 },
                    { 30L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6397), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 0, 0, 0, 0)), "Hamilton", 6L, 0 },
                    { 31L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), "Montreal", 7L, 0 },
                    { 32L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6404), new TimeSpan(0, 0, 0, 0, 0)), "Quebec City", 7L, 0 },
                    { 33L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 0, 0, 0, 0)), "Laval", 7L, 0 },
                    { 34L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 0, 0, 0, 0)), "Gatineau", 7L, 0 },
                    { 35L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)), "Longueuil", 7L, 0 },
                    { 36L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6495), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6496), new TimeSpan(0, 0, 0, 0, 0)), "Vancouver", 8L, 0 },
                    { 37L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 0, 0, 0, 0)), "Victoria", 8L, 0 },
                    { 38L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6616), new TimeSpan(0, 0, 0, 0, 0)), "Surrey", 8L, 0 },
                    { 39L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6618), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6619), new TimeSpan(0, 0, 0, 0, 0)), "Burnaby", 8L, 0 },
                    { 40L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6621), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6622), new TimeSpan(0, 0, 0, 0, 0)), "Richmond", 8L, 0 },
                    { 41L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)), "Calgary", 9L, 0 },
                    { 42L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6628), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, 0, 0, 0, 0)), "Edmonton", 9L, 0 },
                    { 43L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 0, 0, 0, 0)), "Red Deer", 9L, 0 },
                    { 44L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6637), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6637), new TimeSpan(0, 0, 0, 0, 0)), "Lethbridge", 9L, 0 },
                    { 45L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 0, 0, 0, 0)), "St. Albert", 9L, 0 },
                    { 46L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6643), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6643), new TimeSpan(0, 0, 0, 0, 0)), "Winnipeg", 10L, 0 },
                    { 47L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6646), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6647), new TimeSpan(0, 0, 0, 0, 0)), "Brandon", 10L, 0 },
                    { 48L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 0, 0, 0, 0)), "Steinbach", 10L, 0 },
                    { 49L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6653), new TimeSpan(0, 0, 0, 0, 0)), "Thompson", 10L, 0 },
                    { 50L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 0, 0, 0, 0)), "Portage la Prairie", 10L, 0 },
                    { 51L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), "London", 11L, 0 },
                    { 52L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), "Manchester", 11L, 0 },
                    { 53L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 0, 0, 0, 0)), "Birmingham", 11L, 0 },
                    { 54L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 0, 0, 0, 0)), "Liverpool", 11L, 0 },
                    { 55L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 0, 0, 0, 0)), "Leeds", 11L, 0 },
                    { 56L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 0, 0, 0, 0)), "Edinburgh", 12L, 0 },
                    { 57L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6692), new TimeSpan(0, 0, 0, 0, 0)), "Glasgow", 12L, 0 },
                    { 58L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 0, 0, 0, 0)), "Aberdeen", 12L, 0 },
                    { 59L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 0, 0, 0, 0)), "Dundee", 12L, 0 },
                    { 60L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 0, 0, 0, 0)), "Inverness", 12L, 0 },
                    { 61L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 0, 0, 0, 0)), "Cardiff", 13L, 0 },
                    { 62L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6708), new TimeSpan(0, 0, 0, 0, 0)), "Swansea", 13L, 0 },
                    { 63L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6711), new TimeSpan(0, 0, 0, 0, 0)), "Newport", 13L, 0 },
                    { 64L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6714), new TimeSpan(0, 0, 0, 0, 0)), "Wrexham", 13L, 0 },
                    { 65L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6716), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, 0, 0, 0, 0)), "Barry", 13L, 0 },
                    { 66L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, 0, 0, 0, 0)), "Belfast", 14L, 0 },
                    { 67L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 0, 0, 0, 0)), "Derry", 14L, 0 },
                    { 68L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 0, 0, 0, 0)), "Lisburn", 14L, 0 },
                    { 69L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 0, 0, 0, 0)), "Newry", 14L, 0 },
                    { 70L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 0, 0, 0, 0)), "Armagh", 14L, 0 },
                    { 71L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6735), new TimeSpan(0, 0, 0, 0, 0)), "Truro", 15L, 0 },
                    { 72L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 0, 0, 0, 0)), "Falmouth", 15L, 0 },
                    { 73L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 0, 0, 0, 0)), "Penzance", 15L, 0 },
                    { 74L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 0, 0, 0, 0)), "Newquay", 15L, 0 },
                    { 75L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 0, 0, 0, 0)), "St Ives", 15L, 0 },
                    { 76L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 0, 0, 0, 0)), "Sydney", 16L, 0 },
                    { 77L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6753), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 0, 0, 0, 0)), "Newcastle", 16L, 0 },
                    { 78L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, 0, 0, 0, 0)), "Wollongong", 16L, 0 },
                    { 79L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6760), new TimeSpan(0, 0, 0, 0, 0)), "Dubbo", 16L, 0 },
                    { 80L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 0, 0, 0, 0)), "Tamworth", 16L, 0 },
                    { 81L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6767), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6768), new TimeSpan(0, 0, 0, 0, 0)), "Melbourne", 17L, 0 },
                    { 82L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 0, 0, 0, 0)), "Geelong", 17L, 0 },
                    { 83L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 0, 0, 0, 0)), "Ballarat", 17L, 0 },
                    { 84L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 0, 0, 0, 0)), "Bendigo", 17L, 0 },
                    { 85L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6783), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 0, 0, 0, 0)), "Shepparton", 17L, 0 },
                    { 86L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6786), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6787), new TimeSpan(0, 0, 0, 0, 0)), "Brisbane", 18L, 0 },
                    { 87L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), "Gold Coast", 18L, 0 },
                    { 88L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6792), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 0, 0, 0, 0)), "Townsville", 18L, 0 },
                    { 89L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), "Cairns", 18L, 0 },
                    { 90L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6798), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 0, 0, 0, 0)), "Toowoomba", 18L, 0 },
                    { 91L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6801), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 0, 0, 0, 0)), "Perth", 19L, 0 },
                    { 92L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6805), new TimeSpan(0, 0, 0, 0, 0)), "Fremantle", 19L, 0 },
                    { 93L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 0, 0, 0, 0)), "Bunbury", 19L, 0 },
                    { 94L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 0, 0, 0, 0)), "Albany", 19L, 0 },
                    { 95L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 0, 0, 0, 0)), "Kalgoorlie", 19L, 0 },
                    { 96L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6816), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 0, 0, 0, 0)), "Adelaide", 20L, 0 },
                    { 97L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6821), new TimeSpan(0, 0, 0, 0, 0)), "Mount Gambier", 20L, 0 },
                    { 98L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 0, 0, 0, 0)), "Whyalla", 20L, 0 },
                    { 99L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 0, 0, 0, 0)), "Port Augusta", 20L, 0 },
                    { 100L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, 0, 0, 0, 0)), "Port Lincoln", 20L, 0 },
                    { 101L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6834), new TimeSpan(0, 0, 0, 0, 0)), "Sydney", 16L, 0 },
                    { 102L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6837), new TimeSpan(0, 0, 0, 0, 0)), "Newcastle", 16L, 0 },
                    { 103L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), "Wollongong", 16L, 0 },
                    { 104L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)), "Dubbo", 16L, 0 },
                    { 105L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6881), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 0, 0, 0, 0)), "Tamworth", 16L, 0 },
                    { 106L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6885), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 0, 0, 0, 0)), "Melbourne", 17L, 0 },
                    { 107L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6889), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), "Geelong", 17L, 0 },
                    { 108L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6892), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 0, 0, 0, 0)), "Ballarat", 17L, 0 },
                    { 109L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6895), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6896), new TimeSpan(0, 0, 0, 0, 0)), "Bendigo", 17L, 0 },
                    { 110L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 0, 0, 0, 0)), "Shepparton", 17L, 0 },
                    { 111L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 0, 0, 0, 0)), "Brisbane", 18L, 0 },
                    { 112L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)), "Gold Coast", 18L, 0 },
                    { 113L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)), "Townsville", 18L, 0 },
                    { 114L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 0, 0, 0, 0)), "Cairns", 18L, 0 },
                    { 115L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)), "Toowoomba", 18L, 0 },
                    { 116L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), "Perth", 19L, 0 },
                    { 117L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6922), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 0, 0, 0, 0)), "Fremantle", 19L, 0 },
                    { 118L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6925), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, 0, 0, 0, 0)), "Bunbury", 19L, 0 },
                    { 119L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6929), new TimeSpan(0, 0, 0, 0, 0)), "Albany", 19L, 0 },
                    { 120L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 0, 0, 0, 0)), "Kalgoorlie", 19L, 0 },
                    { 121L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6935), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6935), new TimeSpan(0, 0, 0, 0, 0)), "Adelaide", 20L, 0 },
                    { 122L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, 0, 0, 0, 0)), "Mount Gambier", 20L, 0 },
                    { 123L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, 0, 0, 0, 0)), "Whyalla", 20L, 0 },
                    { 124L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6945), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 0, 0, 0, 0)), "Port Augusta", 20L, 0 },
                    { 125L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 621, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 0, 0, 0, 0)), "Port Lincoln", 20L, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4739), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4757), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4761), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4765), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4826), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4829), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 622, DateTimeKind.Unspecified).AddTicks(4837), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7356), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7367), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7368), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7378), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7382), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7449), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7452), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7455), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7462), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7462), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7468), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7478), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7479), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7482), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7487), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7490), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7493), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7493), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7495), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7502), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7520), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7524), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7529), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7531), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7532), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7534), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7544), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7552), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 10, 15, 6, 624, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7217), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7222), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7225), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7228), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7229), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7235), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 139, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2891), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2896), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2897), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2907), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2951), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2951), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2953), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2956), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2957), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2958), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2962), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2967), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2973), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2975), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2997), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2998), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3024), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3041), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
