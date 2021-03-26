using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationASPNetCore.Data.Migrations
{
    public partial class AttendeeEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsId",
                table: "AttendeeEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendeeEvent",
                table: "AttendeeEvent");

            migrationBuilder.DropIndex(
                name: "IX_AttendeeEvent_EventsId",
                table: "AttendeeEvent");

            migrationBuilder.DropColumn(
                name: "AttendeesId",
                table: "AttendeeEvent");

            migrationBuilder.RenameColumn(
                name: "EventsId",
                table: "AttendeeEvent",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AttendeeEvent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "AttendeeEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "AttendeeEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendeeEvent",
                table: "AttendeeEvent",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_AttendeeId",
                table: "AttendeeEvent",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventId",
                table: "AttendeeEvent",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeeId",
                table: "AttendeeEvent",
                column: "AttendeeId",
                principalTable: "Attendee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventId",
                table: "AttendeeEvent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventId",
                table: "AttendeeEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendeeEvent",
                table: "AttendeeEvent");

            migrationBuilder.DropIndex(
                name: "IX_AttendeeEvent_AttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropIndex(
                name: "IX_AttendeeEvent_EventId",
                table: "AttendeeEvent");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "AttendeeEvent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AttendeeEvent",
                newName: "EventsId");

            migrationBuilder.AlterColumn<int>(
                name: "EventsId",
                table: "AttendeeEvent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AttendeesId",
                table: "AttendeeEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendeeEvent",
                table: "AttendeeEvent",
                columns: new[] { "AttendeesId", "EventsId" });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventsId",
                table: "AttendeeEvent",
                column: "EventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesId",
                table: "AttendeeEvent",
                column: "AttendeesId",
                principalTable: "Attendee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsId",
                table: "AttendeeEvent",
                column: "EventsId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
