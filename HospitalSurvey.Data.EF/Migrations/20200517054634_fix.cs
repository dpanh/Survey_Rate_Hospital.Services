using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalSurvey.Data.EF.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_HospitalDepartments_HospitalDepartmentId",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalDepartmentId",
                table: "Staffs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_HospitalDepartments_HospitalDepartmentId",
                table: "Staffs",
                column: "HospitalDepartmentId",
                principalTable: "HospitalDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_HospitalDepartments_HospitalDepartmentId",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalDepartmentId",
                table: "Staffs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_HospitalDepartments_HospitalDepartmentId",
                table: "Staffs",
                column: "HospitalDepartmentId",
                principalTable: "HospitalDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
