using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class Dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "04744fd5-b0e0-43cb-981d-e65c87f6c250");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "1b53bad1-2aaa-4ba1-afb0-18be3e8dfc57");

            migrationBuilder.DeleteData(
                table: "EmailConfigs",
                keyColumn: "Id",
                keyValue: "832910d8-bc53-4466-b0c0-afc4a83b630e");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "ba2c9c4a-ffcd-4f55-af6f-418674bb4154", new DateTime(2024, 10, 18, 9, 30, 12, 127, DateTimeKind.Local).AddTicks(9452), "kieuminhduc02@gmail.com", false, false, new DateTime(2024, 10, 18, 9, 30, 12, 128, DateTimeKind.Local).AddTicks(6329), null, null, "$2a$11$g5uq788thwhwNuJ2VozldeEGTGJnyKf3jTkFJemQiIpzUmKE4kdjS", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "a258386b-12c0-468d-b3ba-0f538cab1c6a", new DateTime(2024, 10, 18, 9, 30, 12, 281, DateTimeKind.Local).AddTicks(5195), "", "", false, new DateTime(2024, 10, 18, 9, 30, 12, 281, DateTimeKind.Local).AddTicks(5210), "", "" });

            migrationBuilder.InsertData(
                table: "EmailConfigs",
                columns: new[] { "Id", "AppPassword", "Created", "Email", "IsDelete", "LastModified" },
                values: new object[] { "672802b0-4bb5-4aef-a2a9-2041ae513aeb", "ybri advf vvni efko", new DateTime(2024, 10, 18, 9, 30, 12, 281, DateTimeKind.Local).AddTicks(9052), "kieuminhduc02@gmail.com", false, new DateTime(2024, 10, 18, 9, 30, 12, 281, DateTimeKind.Local).AddTicks(9058) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ba2c9c4a-ffcd-4f55-af6f-418674bb4154");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "a258386b-12c0-468d-b3ba-0f538cab1c6a");

            migrationBuilder.DeleteData(
                table: "EmailConfigs",
                keyColumn: "Id",
                keyValue: "672802b0-4bb5-4aef-a2a9-2041ae513aeb");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "04744fd5-b0e0-43cb-981d-e65c87f6c250", new DateTime(2023, 6, 30, 13, 40, 7, 726, DateTimeKind.Local).AddTicks(3683), null, false, false, new DateTime(2023, 6, 30, 13, 40, 7, 727, DateTimeKind.Local).AddTicks(290), null, null, "$2a$11$MT9kkyBugM.nUGRo024PreR/on9ePyegj3tWHlsl2NDklRqB6oe8m", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "1b53bad1-2aaa-4ba1-afb0-18be3e8dfc57", new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(5941), "", "", false, new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(5959), "", "" });

            migrationBuilder.InsertData(
                table: "EmailConfigs",
                columns: new[] { "Id", "AppPassword", "Created", "Email", "IsDelete", "LastModified" },
                values: new object[] { "832910d8-bc53-4466-b0c0-afc4a83b630e", "", new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(9415), "", false, new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(9421) });
        }
    }
}
