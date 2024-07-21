using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsvReader.Repo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoneyProduction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoneyProduction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    smoker = table.Column<bool>(type: "bit", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_bill = table.Column<float>(type: "real", nullable: false),
                    tip = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.order_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoneyProduction");

            migrationBuilder.DropTable(
                name: "Tips");
        }
    }
}
