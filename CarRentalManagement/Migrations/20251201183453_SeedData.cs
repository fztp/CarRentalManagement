using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Vehicle",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Model",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Make",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Customer",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Colour",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Booking",
                newName: "DateCreated");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8179), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8212), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8218), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8219), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8659), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8661), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8665), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8666), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8821), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8823), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8828), "x5", "System" },
                    { 3, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8831), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8833), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8836), new DateTime(2025, 12, 2, 2, 34, 51, 880, DateTimeKind.Local).AddTicks(8837), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicle",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Model",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Make",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customer",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colour",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Booking",
                newName: "Created");
        }
    }
}
