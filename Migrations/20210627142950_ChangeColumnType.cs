using Microsoft.EntityFrameworkCore.Migrations;

namespace LongtextIssue.Migrations
{
    public partial class ChangeColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LongString",
                table: "Entities",
                type: "varchar(5000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldMaxLength: 5000,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LongString",
                table: "Entities",
                type: "longtext",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5000)",
                oldNullable: true);
        }
    }
}
