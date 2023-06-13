using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsconnectAPI.Migrations
{
    /// <inheritdoc />
    public partial class seventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("14ee902d-5c0b-4b48-bdfc-c20beaa552b7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("506e5933-2197-4be5-a25e-356a93a1bbad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e9d02596-c0bc-4e71-8a14-2cb6d9d8564e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2e4cbc95-74ac-4db4-b6f0-21bb2deb44e2"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2fd6d0c6-46f9-4b10-90af-d4491f32a869"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("339cf9d4-6dec-42af-b67b-b184de53f4d7"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ad0d5e01-d838-4c88-bec3-2380108c6728"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e52f6997-fc74-4380-9f9d-6bf20c0d3b33"));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "duration", "location", "owner", "pCode", "playersAttending", "sport", "startDate", "title" },
                values: new object[,]
                {
                    { new Guid("4ea555fc-de84-43ad-b006-2522e80a3d9b"), 2, "Port of Spain", "12970", 15774, "12971", "Soccer", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5890), "Soccer Meet" },
                    { new Guid("6440efa8-d9fd-4bde-afb6-88a8bf821405"), 2, "Port of Spain", "12971", 15773, "12970", "Soccer", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5898), "SoccerMeet Game" },
                    { new Guid("de7f893d-f00b-4b04-be1b-9b7b94d0dcd1"), 2, "Port of Spain", "12973", 15775, "12971", "Soccer", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5895), "Soccer Match" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "address", "age", "attending", "lastActive", "name", "pCode", "phone", "sport" },
                values: new object[,]
                {
                    { new Guid("534fe14d-c20f-4665-84b6-5056331c399c"), "Down Town", 34, "15775, 1573", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5691), "Micheal", 12973, "1868732274097", "All" },
                    { new Guid("912f0ec4-27d5-4b44-8eaf-7067fcd609fa"), "Woodbrook", 19, "No Events", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5662), "Zaak", 12976, "18687964097", "Soccer" },
                    { new Guid("c007e7ea-4932-4387-80c6-71085fdeca74"), "Shakespeare Avenue", 17, "No Events", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5642), "William", 12972, "8687375691", "Soccer" },
                    { new Guid("c3ddd429-0c20-4ad9-8ce2-042b72856c49"), "PortofSpain", 34, "15773", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5665), "Cody", 12970, "186879874097", "Soccer" },
                    { new Guid("e82a2f1a-b321-44a4-8308-206a3e4e6b8e"), "San Juan", 38, "15774, 1575, 15773", new DateTime(2023, 6, 12, 23, 18, 28, 994, DateTimeKind.Local).AddTicks(5695), "Gervais", 12971, "1868732274097", "Soccer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4ea555fc-de84-43ad-b006-2522e80a3d9b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6440efa8-d9fd-4bde-afb6-88a8bf821405"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("de7f893d-f00b-4b04-be1b-9b7b94d0dcd1"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("534fe14d-c20f-4665-84b6-5056331c399c"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("912f0ec4-27d5-4b44-8eaf-7067fcd609fa"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c007e7ea-4932-4387-80c6-71085fdeca74"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c3ddd429-0c20-4ad9-8ce2-042b72856c49"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e82a2f1a-b321-44a4-8308-206a3e4e6b8e"));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "duration", "location", "owner", "pCode", "playersAttending", "sport", "startDate", "title" },
                values: new object[,]
                {
                    { new Guid("14ee902d-5c0b-4b48-bdfc-c20beaa552b7"), 2, "Port of Spain", "12973", 15775, "12971", "Soccer", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(3118), "SoccerMeet2" },
                    { new Guid("506e5933-2197-4be5-a25e-356a93a1bbad"), 2, "Port of Spain", "12970", 15774, "12971", "Soccer", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(3113), "SoccerMeet" },
                    { new Guid("e9d02596-c0bc-4e71-8a14-2cb6d9d8564e"), 2, "Port of Spain", "12971", 15773, "12970", "Soccer", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(3121), "SoccerMeet3" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "address", "age", "attending", "lastActive", "name", "pCode", "phone", "sport" },
                values: new object[,]
                {
                    { new Guid("2e4cbc95-74ac-4db4-b6f0-21bb2deb44e2"), "Woodbrook", 19, "No Events", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(2877), "Zaak", 12976, "18687964097", "Soccer" },
                    { new Guid("2fd6d0c6-46f9-4b10-90af-d4491f32a869"), "Down Town", 34, "15775, 1573", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(2884), "Gervais", 12973, "1868732274097", "Soccer" },
                    { new Guid("339cf9d4-6dec-42af-b67b-b184de53f4d7"), "PortofSpain", 34, "15774", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(2881), "Cody", 12970, "186879874097", "Soccer" },
                    { new Guid("ad0d5e01-d838-4c88-bec3-2380108c6728"), "San Juan", 38, "15774, 1575, 15773", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(2909), "Gervais", 12971, "1868732274097", "Soccer" },
                    { new Guid("e52f6997-fc74-4380-9f9d-6bf20c0d3b33"), "Shakespeare Avenue", 17, "No Events", new DateTime(2023, 6, 12, 22, 47, 1, 186, DateTimeKind.Local).AddTicks(2837), "William", 12972, "8687375691", "Soccer" }
                });
        }
    }
}
