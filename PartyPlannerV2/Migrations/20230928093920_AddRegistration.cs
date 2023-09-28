using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartyPlannerV2.Migrations
{
    /// <inheritdoc />
    public partial class AddRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Participants",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Organizers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Organizers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Organizers");
        }
    }
}
