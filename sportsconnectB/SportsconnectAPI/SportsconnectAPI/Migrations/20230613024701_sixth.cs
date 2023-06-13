using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsconnectAPI.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9bb67e72-c57a-45ed-9b55-4249f76b5343"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a4cc67c5-0245-4775-ad07-dee03d1d1a4b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("dcf20863-d2aa-460a-ae3d-ab6146e7d525"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("6497a6c9-c717-4ac8-ab2b-563aef7aab8c"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7dcef371-d430-416c-8f3c-d8549ee2dc2e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("90ab3ef8-2f54-4374-bb83-b8b9dd8d43fd"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9d2e87eb-3ed2-4d6c-a1a9-a08a31f77bb7"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f3375793-e1a4-4d5c-b28f-30992e215f8d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("9bb67e72-c57a-45ed-9b55-4249f76b5343"), 2, "Port of Spain", "12970", 15774, "12971", null, new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6350), "SoccerMeet" },
                    { new Guid("a4cc67c5-0245-4775-ad07-dee03d1d1a4b"), 2, "Port of Spain", "12973", 15775, "12971", null, new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6356), "SoccerMeet2" },
                    { new Guid("dcf20863-d2aa-460a-ae3d-ab6146e7d525"), 2, "Port of Spain", "12971", 15773, "12970", null, new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6360), "SoccerMeet3" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "address", "age", "attending", "lastActive", "name", "pCode", "phone", "sport" },
                values: new object[,]
                {
                    { new Guid("6497a6c9-c717-4ac8-ab2b-563aef7aab8c"), "PortofSpain", 34, "15774", new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6066), "Cody", 12970, "186879874097", "Soccer" },
                    { new Guid("7dcef371-d430-416c-8f3c-d8549ee2dc2e"), "San Juan", 38, "15774, 1575, 15773", new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6073), "Gervais", 12971, "1868732274097", "Soccer" },
                    { new Guid("90ab3ef8-2f54-4374-bb83-b8b9dd8d43fd"), "Down Town", 34, "15775, 1573", new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6069), "Gervais", 12973, "1868732274097", "Soccer" },
                    { new Guid("9d2e87eb-3ed2-4d6c-a1a9-a08a31f77bb7"), "Woodbrook", 19, "No Events", new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6062), "Zaak", 12976, "18687964097", "Soccer" },
                    { new Guid("f3375793-e1a4-4d5c-b28f-30992e215f8d"), "Shakespeare Avenue", 17, "No Events", new DateTime(2023, 6, 12, 22, 20, 12, 196, DateTimeKind.Local).AddTicks(6017), "William", 12972, "8687375691", "Soccer" }
                });
        }
    }
}
