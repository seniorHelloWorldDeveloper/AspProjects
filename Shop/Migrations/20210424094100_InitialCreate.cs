using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meat = table.Column<bool>(type: "bit", nullable: false),
                    Onion = table.Column<bool>(type: "bit", nullable: false),
                    Tomatoes = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllPizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnMainPage = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllPizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllPizzas_AllCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AllCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllPizzas_CategoryId",
                table: "AllPizzas",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllOrders");

            migrationBuilder.DropTable(
                name: "AllPizzas");

            migrationBuilder.DropTable(
                name: "AllCategories");
        }
    }
}
