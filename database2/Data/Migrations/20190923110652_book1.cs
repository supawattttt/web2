using Microsoft.EntityFrameworkCore.Migrations;

namespace database2.Data.Migrations
{
    public partial class book1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
