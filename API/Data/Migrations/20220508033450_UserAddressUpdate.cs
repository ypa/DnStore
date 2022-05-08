using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class UserAddressUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fa80ae8c-b1ee-4e66-89f7-9c0d38e2ccc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "77824a81-7ac9-4565-9cd0-c0af85969fdb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "UserAddress");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6e8d3a86-3eb3-45f8-9854-3396ebaea7e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "774b962e-486c-41fa-bf91-688c4e052b0d");
        }
    }
}
