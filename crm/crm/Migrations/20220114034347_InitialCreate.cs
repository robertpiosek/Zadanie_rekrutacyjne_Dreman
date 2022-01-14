using Microsoft.EntityFrameworkCore.Migrations;

namespace crm.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    symbol = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    rate = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    is_sync = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    updated_at = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ghosted = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}
