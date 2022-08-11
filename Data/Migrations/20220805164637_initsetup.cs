using Microsoft.EntityFrameworkCore.Migrations;

namespace amazonDataConnector.Data.Migrations {
    public partial class initsetup :Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "AcuOrder",
                columns: table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullAcuOrderId = table.Column<string>(nullable: true),
                    AmzOrderList = table.Column<string>(nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_AcuOrder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "AcuOrder");
        }
    }
}