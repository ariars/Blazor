using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Between.Server.App.Migrations
{
    /// <inheritdoc />
    public partial class CandidateColumnAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Candidate",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AliasNames",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCity",
                table: "Candidate",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCountry",
                table: "Candidate",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCounty",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthState",
                table: "Candidate",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessStructure",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessStructureOther",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Candidate",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DOB",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DriverLicenseExpiration",
                table: "Candidate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverLicenseNumber",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverLicenseState",
                table: "Candidate",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidate",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EyeColor",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HairColor",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightFeet",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightInches",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePhone",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseNumber",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameSuffix",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeAddress",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeCity",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeState",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalMarks",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhone",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SSN",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryPhone",
                table: "Candidate",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Candidate",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsCitizen",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkFax",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkPhone",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "AliasNames",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BirthCity",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BirthCountry",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BirthCounty",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BirthState",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BusinessStructure",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "BusinessStructureOther",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "County",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "DriverLicenseExpiration",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "DriverLicenseNumber",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "DriverLicenseState",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "EyeColor",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "HairColor",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "HeightFeet",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "HeightInches",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "HomePhone",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "NameSuffix",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "OfficeAddress",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "OfficeCity",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "OfficeState",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "PhysicalMarks",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "PrimaryPhone",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "SSN",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "SecondaryPhone",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "UsCitizen",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "WorkFax",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "WorkPhone",
                table: "Candidate");
        }
    }
}
