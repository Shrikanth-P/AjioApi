using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AjioApi.Migrations
{
    public partial class initdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    useremail = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    password = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    mobile = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registration");
        }
    }
}
