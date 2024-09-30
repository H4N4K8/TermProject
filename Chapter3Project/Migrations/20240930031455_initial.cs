using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chapter3Project.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmiskiType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "sets",
                columns: new[] { "Id", "SetName", "SmiskiType" },
                values: new object[,]
                {
                    { "B", "Bath", "Shower Smiski" },
                    { "C", "Cheer", "Pom Pom Smiski" },
                    { "D", "Dressing", "Sweater Smiski" },
                    { "E", "Exercise", "Sit Ups Smiski" },
                    { "L", "Living", "Flute Smiski" },
                    { "M", "Moving", "Boxes Smiski" },
                    { "W", "Work", "Laptop Smiski" },
                    { "Y", "Yoga", "Grounded Smiski" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sets");
        }
    }
}
