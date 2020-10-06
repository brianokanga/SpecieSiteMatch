using Microsoft.EntityFrameworkCore.Migrations;

namespace Species.Data.Migrations
{
    public partial class AddCountyIdToPlantRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlantRequests_Counties_CountyId",
                table: "PlantRequests");

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "PlantRequests",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantRequests_Counties_CountyId",
                table: "PlantRequests",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlantRequests_Counties_CountyId",
                table: "PlantRequests");

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "PlantRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PlantRequests_Counties_CountyId",
                table: "PlantRequests",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
