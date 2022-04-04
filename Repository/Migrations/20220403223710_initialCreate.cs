using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "ProductModel");

            migrationBuilder.AlterColumn<int>(
                name: "camFeatures",
                table: "Specificatiion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "simType",
                table: "Specificatiion",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "simType",
                table: "Specificatiion");

            migrationBuilder.AlterColumn<int>(
                name: "camFeatures",
                table: "Specificatiion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ProductModel",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
