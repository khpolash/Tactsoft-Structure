using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tactsoft.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialStateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UpdateNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "CreatedBy", "CreatedDate", "IsDelete", "ModifiedBy", "ModifiedDate", "Name", "UpdateNo" },
                values: new object[,]
                {
                    { 1L, 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 0, 0, 0, 0)), "California", 0 },
                    { 2L, 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 0, 0, 0, 0)), "Texas", 0 },
                    { 3L, 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)), "New York", 0 },
                    { 4L, 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2891), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2891), new TimeSpan(0, 0, 0, 0, 0)), "Florida", 0 },
                    { 5L, 1L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 0, 0, 0, 0)), "Illinois", 0 },
                    { 6L, 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2896), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2897), new TimeSpan(0, 0, 0, 0, 0)), "Ontario", 0 },
                    { 7L, 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 0, 0, 0, 0)), "Quebec", 0 },
                    { 8L, 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 0, 0, 0, 0)), "British Columbia", 0 },
                    { 9L, 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 0, 0, 0, 0)), "Alberta", 0 },
                    { 10L, 2L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2907), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), "Manitoba", 0 },
                    { 11L, 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2910), new TimeSpan(0, 0, 0, 0, 0)), "England", 0 },
                    { 12L, 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), "Scotland", 0 },
                    { 13L, 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)), "Wales", 0 },
                    { 14L, 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)), "Northern Ireland", 0 },
                    { 15L, 3L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2951), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2951), new TimeSpan(0, 0, 0, 0, 0)), "Cornwall", 0 },
                    { 16L, 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2953), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2954), new TimeSpan(0, 0, 0, 0, 0)), "New South Wales", 0 },
                    { 17L, 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2956), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2957), new TimeSpan(0, 0, 0, 0, 0)), "Victoria", 0 },
                    { 18L, 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2958), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 0, 0, 0, 0)), "Queensland", 0 },
                    { 19L, 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2961), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2962), new TimeSpan(0, 0, 0, 0, 0)), "Western Australia", 0 },
                    { 20L, 4L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2964), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 0, 0, 0, 0)), "South Australia", 0 },
                    { 21L, 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2967), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 0, 0, 0, 0)), "Bavaria", 0 },
                    { 22L, 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 0, 0, 0, 0)), "Baden-Württemberg", 0 },
                    { 23L, 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2973), new TimeSpan(0, 0, 0, 0, 0)), "North Rhine-Westphalia", 0 },
                    { 24L, 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2975), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), "Hesse", 0 },
                    { 25L, 5L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)), "Saxony", 0 },
                    { 26L, 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)), "Île-de-France", 0 },
                    { 27L, 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, 0, 0, 0, 0)), "Provence-Alpes-Côte d'Azur", 0 },
                    { 28L, 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 0, 0, 0, 0)), "Auvergne-Rhône-Alpes", 0 },
                    { 29L, 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), "Nouvelle-Aquitaine", 0 },
                    { 30L, 6L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 0, 0, 0, 0)), "Occitanie", 0 },
                    { 31L, 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0)), "Tokyo", 0 },
                    { 32L, 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2997), new TimeSpan(0, 0, 0, 0, 0)), "Osaka", 0 },
                    { 33L, 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2998), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 0, 0, 0, 0)), "Hokkaido", 0 },
                    { 34L, 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), "Fukuoka", 0 },
                    { 35L, 7L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, 0, 0, 0, 0)), "Aichi", 0 },
                    { 36L, 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)), "Beijing", 0 },
                    { 37L, 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 0, 0, 0, 0)), "Shanghai", 0 },
                    { 38L, 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 0, 0, 0, 0)), "Guangdong", 0 },
                    { 39L, 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 0, 0, 0, 0)), "Sichuan", 0 },
                    { 40L, 8L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 0, 0, 0, 0)), "Zhejiang", 0 },
                    { 41L, 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)), "Maharashtra", 0 },
                    { 42L, 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0)), "Karnataka", 0 },
                    { 43L, 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3024), new TimeSpan(0, 0, 0, 0, 0)), "Tamil Nadu", 0 },
                    { 44L, 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), "Uttar Pradesh", 0 },
                    { 45L, 9L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3028), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 0, 0, 0, 0)), "Gujarat", 0 },
                    { 46L, 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 0, 0, 0, 0)), "São Paulo", 0 },
                    { 47L, 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 0, 0, 0, 0)), "Rio de Janeiro", 0 },
                    { 48L, 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 0, 0, 0, 0)), "Minas Gerais", 0 },
                    { 49L, 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), "Bahia", 0 },
                    { 50L, 10L, 0L, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(2024, 8, 6, 9, 57, 3, 141, DateTimeKind.Unspecified).AddTicks(3041), new TimeSpan(0, 0, 0, 0, 0)), "Paraná", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4384), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4386), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4391), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4400), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 6, 9, 8, 10, 178, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
