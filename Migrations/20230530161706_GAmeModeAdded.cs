using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADO.NET_PW_5.Migrations
{
    /// <inheritdoc />
    public partial class GAmeModeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameModeId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GameMode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMode", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameModeId",
                table: "Games",
                column: "GameModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameMode_GameModeId",
                table: "Games",
                column: "GameModeId",
                principalTable: "GameMode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameMode_GameModeId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "GameMode");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameModeId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CopiesSold",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameModeId",
                table: "Games");
        }
    }
}
