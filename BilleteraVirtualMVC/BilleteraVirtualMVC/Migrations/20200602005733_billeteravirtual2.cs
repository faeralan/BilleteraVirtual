using Microsoft.EntityFrameworkCore.Migrations;

namespace BilleteraVirtualMVC.Migrations
{
    public partial class billeteravirtual2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cuentas_CuentaId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "CuentaId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cuentas_CuentaId",
                table: "Usuarios",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cuentas_CuentaId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "CuentaId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cuentas_CuentaId",
                table: "Usuarios",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
