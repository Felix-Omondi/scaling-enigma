using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace scaling_enigma.Migrations;

/// <inheritdoc />
public partial class _20261126054955_StoreEnumAsStrings : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "WorkShift",
            table: "Employees",
            type: "text",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "integer");

        migrationBuilder.AlterColumn<string>(
            name: "Team",
            table: "Employees",
            type: "text",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "integer");

        migrationBuilder.AlterColumn<string>(
            name: "Role",
            table: "Employees",
            type: "text",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "integer");

        migrationBuilder.AlterColumn<string>(
            name: "Designation",
            table: "Employees",
            type: "text",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "integer");

        migrationBuilder.AlterColumn<string>(
            name: "Department",
            table: "Employees",
            type: "text",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "integer");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<int>(
            name: "WorkShift",
            table: "Employees",
            type: "integer",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "text");

        migrationBuilder.AlterColumn<int>(
            name: "Team",
            table: "Employees",
            type: "integer",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "text");

        migrationBuilder.AlterColumn<int>(
            name: "Role",
            table: "Employees",
            type: "integer",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "text");

        migrationBuilder.AlterColumn<int>(
            name: "Designation",
            table: "Employees",
            type: "integer",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "text");

        migrationBuilder.AlterColumn<int>(
            name: "Department",
            table: "Employees",
            type: "integer",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "text");
    }
}
