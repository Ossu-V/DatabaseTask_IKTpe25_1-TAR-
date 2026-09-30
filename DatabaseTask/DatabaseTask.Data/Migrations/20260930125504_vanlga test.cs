using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class vanlgatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrisonId",
                table: "Blocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_PrisonId",
                table: "Blocks",
                column: "PrisonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blocks_Prisons_PrisonId",
                table: "Blocks",
                column: "PrisonId",
                principalTable: "Prisons",
                principalColumn: "PrisonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blocks_Prisons_PrisonId",
                table: "Blocks");

            migrationBuilder.DropIndex(
                name: "IX_Blocks_PrisonId",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "PrisonId",
                table: "Blocks");
        }
    }
}
