using Microsoft.EntityFrameworkCore.Migrations;

namespace amazonDataConnector.Data.Migrations
{
    public partial class initOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmzOrderId",
                table: "AcuOrder",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmzOrderId",
                table: "AcuOrder");
        }
    }
}
