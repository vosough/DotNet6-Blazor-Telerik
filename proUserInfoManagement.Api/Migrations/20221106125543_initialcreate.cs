using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proUserInfoManagement.Api.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDateTime", "ExpireDateTime", "FName", "LName", "NationalCode", "PassWord", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 6, 16, 25, 43, 251, DateTimeKind.Local).AddTicks(9665), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vahid", "Vosoughi", "123456789", "123", "vahid" },
                    { 2, new DateTime(2022, 11, 6, 16, 25, 43, 251, DateTimeKind.Local).AddTicks(9933), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayoob", "Khani", "123456789", "123", "Ayoob" },
                    { 3, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(18), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehdi", "Hassani", "123456789", "123", "Mehdi" },
                    { 4, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(91), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vahid", "Fazeli", "123456789", "123", "vahid1" },
                    { 5, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(164), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeed", "Roshani", "123456789", "123", "Saeed" },
                    { 6, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(250), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazem", "Rahimi", "123456789", "123", "Kazem" },
                    { 7, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(322), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahad", "Mohammadi", "123456789", "123", "Ahad" },
                    { 8, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(390), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shahin", "Ahmadi", "123456789", "123", "Shahin" },
                    { 9, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hassan", "Ahmadian", "123456789", "123", "Hassan" },
                    { 10, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(547), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehdi", "Khataei", "123456789", "123", "Mehdi" },
                    { 11, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(621), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehri", "Soltani", "123456789", "123", "Mehri" },
                    { 12, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(692), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahar", "Fakhim", "123456789", "123", "Bahar" },
                    { 13, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(762), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laya", "Mostahkam", "123456789", "123", "Laya" },
                    { 14, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(832), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sajjad", "Vosoughi", "123456789", "123", "Sajjad" },
                    { 15, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(878), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "Vosoughi", "123456789", "123", "Ali" },
                    { 16, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(947), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vida", "Soltani", "123456789", "123", "Vida" },
                    { 17, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1017), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yunes", "MohamadZadeh", "123456789", "123", "Yunes" },
                    { 18, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1096), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sahand", "Asghari", "123456789", "123", "Sahand" },
                    { 19, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1369), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Firuz", "Kazemi", "123456789", "123", "Firuz" },
                    { 20, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1468), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohammad", "Shakeri", "123456789", "123", "Mohammad" },
                    { 21, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1535), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akram", "Jahanbakhsh", "123456789", "123", "Akram" },
                    { 22, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1596), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zahra", "Dadashzadeh", "123456789", "123", "Zahra" },
                    { 23, new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1662), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davood", "Soltani", "123456789", "123", "Davood" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
