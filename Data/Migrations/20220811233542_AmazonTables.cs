using Microsoft.EntityFrameworkCore.Migrations;

namespace amazonDataConnector.Data.Migrations
{
    public partial class AmazonTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmzOrderId",
                table: "AcuOrder");

            migrationBuilder.DropColumn(
                name: "FullAcuOrderId",
                table: "AcuOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmzOrderId",
                table: "AcuOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullAcuOrderId",
                table: "AcuOrder",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
