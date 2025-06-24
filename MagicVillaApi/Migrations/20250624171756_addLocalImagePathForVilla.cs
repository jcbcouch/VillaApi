using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaApi.Migrations
{
    /// <inheritdoc />
    public partial class addLocalImagePathForVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLocalPath",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 17, 56, 233, DateTimeKind.Local).AddTicks(9663), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 17, 56, 233, DateTimeKind.Local).AddTicks(9712), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 17, 56, 233, DateTimeKind.Local).AddTicks(9715), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 17, 56, 233, DateTimeKind.Local).AddTicks(9717), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 17, 56, 233, DateTimeKind.Local).AddTicks(9719), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocalPath",
                table: "Villas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 16, 19, 39, 926, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 16, 19, 39, 926, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 16, 19, 39, 926, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 16, 19, 39, 926, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 16, 19, 39, 926, DateTimeKind.Local).AddTicks(614));
        }
    }
}
