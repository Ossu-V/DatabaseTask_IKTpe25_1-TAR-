using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class VanglaERDspellfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitingHr",
                table: "VisitingHr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shift",
                table: "Shift");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punishment",
                table: "Punishment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prisoner",
                table: "Prisoner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prison",
                table: "Prison");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crime",
                table: "Crime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chamber",
                table: "Chamber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Block",
                table: "Block");

            migrationBuilder.RenameTable(
                name: "VisitingHr",
                newName: "VisitingHrs");

            migrationBuilder.RenameTable(
                name: "Shift",
                newName: "Shifts");

            migrationBuilder.RenameTable(
                name: "Punishment",
                newName: "Punishments");

            migrationBuilder.RenameTable(
                name: "Prisoner",
                newName: "Prisoners");

            migrationBuilder.RenameTable(
                name: "Prison",
                newName: "Prisons");

            migrationBuilder.RenameTable(
                name: "Crime",
                newName: "Crimes");

            migrationBuilder.RenameTable(
                name: "Chamber",
                newName: "Chambers");

            migrationBuilder.RenameTable(
                name: "Block",
                newName: "Blocks");

            migrationBuilder.RenameColumn(
                name: "GuestsId",
                table: "Guests",
                newName: "GuestId");

            migrationBuilder.RenameColumn(
                name: "GuardsId",
                table: "Guards",
                newName: "GuardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitingHrs",
                table: "VisitingHrs",
                column: "VisitingHrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts",
                column: "ShiftId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punishments",
                table: "Punishments",
                column: "PunishmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prisoners",
                table: "Prisoners",
                column: "PrisonerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prisons",
                table: "Prisons",
                column: "PrisonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crimes",
                table: "Crimes",
                column: "CrimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chambers",
                table: "Chambers",
                column: "ChamberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blocks",
                table: "Blocks",
                column: "BlockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitingHrs",
                table: "VisitingHrs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punishments",
                table: "Punishments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prisons",
                table: "Prisons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prisoners",
                table: "Prisoners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crimes",
                table: "Crimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chambers",
                table: "Chambers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blocks",
                table: "Blocks");

            migrationBuilder.RenameTable(
                name: "VisitingHrs",
                newName: "VisitingHr");

            migrationBuilder.RenameTable(
                name: "Shifts",
                newName: "Shift");

            migrationBuilder.RenameTable(
                name: "Punishments",
                newName: "Punishment");

            migrationBuilder.RenameTable(
                name: "Prisons",
                newName: "Prison");

            migrationBuilder.RenameTable(
                name: "Prisoners",
                newName: "Prisoner");

            migrationBuilder.RenameTable(
                name: "Crimes",
                newName: "Crime");

            migrationBuilder.RenameTable(
                name: "Chambers",
                newName: "Chamber");

            migrationBuilder.RenameTable(
                name: "Blocks",
                newName: "Block");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Guests",
                newName: "GuestsId");

            migrationBuilder.RenameColumn(
                name: "GuardId",
                table: "Guards",
                newName: "GuardsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitingHr",
                table: "VisitingHr",
                column: "VisitingHrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shift",
                table: "Shift",
                column: "ShiftId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punishment",
                table: "Punishment",
                column: "PunishmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prison",
                table: "Prison",
                column: "PrisonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prisoner",
                table: "Prisoner",
                column: "PrisonerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crime",
                table: "Crime",
                column: "CrimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chamber",
                table: "Chamber",
                column: "ChamberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Block",
                table: "Block",
                column: "BlockId");
        }
    }
}
