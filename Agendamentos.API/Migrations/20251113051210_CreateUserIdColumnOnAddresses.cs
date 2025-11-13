using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendamentos.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserIdColumnOnAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_AddressID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddressID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AddressID",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserID",
                table: "Addresses",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Clients_UserID",
                table: "Addresses",
                column: "UserID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Employees_UserID",
                table: "Addresses",
                column: "UserID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Clients_UserID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Employees_UserID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressID",
                table: "Employees",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressID",
                table: "Clients",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressID",
                table: "Clients",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_AddressID",
                table: "Employees",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "ID");
        }
    }
}
