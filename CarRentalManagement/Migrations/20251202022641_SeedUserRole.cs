using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "01644c38-3ed9-4c27-b96e-feb7f6fc37fd", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMXV1WzoYEpOcXD8GMeM8Dp5vb9D+LVWyqX6C2Ouljyi0tWiD6mOKAbhPReKXnEqmg==", null, false, "0c0eef1b-2899-48b7-8422-c06de1ff34e3", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(1811), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(1850), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2432), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2630), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2636), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2645), new DateTime(2025, 12, 2, 10, 26, 39, 276, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(6206), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(6247), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7101), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7110), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7299), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7305), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7310), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7315), new DateTime(2025, 12, 2, 10, 18, 46, 97, DateTimeKind.Local).AddTicks(7316) });
        }
    }
}
