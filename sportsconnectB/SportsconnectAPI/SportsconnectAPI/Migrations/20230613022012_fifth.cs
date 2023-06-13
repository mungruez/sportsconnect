using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsconnectAPI.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
