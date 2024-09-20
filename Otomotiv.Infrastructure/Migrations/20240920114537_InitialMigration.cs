using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Otomotiv.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrandSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrandId = table.Column<int>(type: "integer", nullable: true),
                    PlatformId = table.Column<int>(type: "integer", nullable: true),
                    ChannelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandSettings_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BrandSettings_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BrandSettings_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "VW", "VolksWagenTicari" },
                    { 2, "VW", "VolksWagen" },
                    { 3, "VW", "Turkuaz" },
                    { 4, "VW", "Skoda" },
                    { 5, "VW", "Seat" },
                    { 6, "VW", "Porsche" },
                    { 7, "VW", "Audi" },
                    { 8, "VW", "Scania" },
                    { 9, "VW", "Cupra" },
                    { 10, "VW", "ScaniaNew" },
                    { 11, "VW", "DogusOtomotivDaily" },
                    { 12, "VW", "AutomotiveAccountOperationsUser" }
                });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web" },
                    { 2, "Mobil" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "VolksWagenTicari" },
                    { 2, "VolksWagen" },
                    { 3, "Turkuaz" },
                    { 4, "Skoda" },
                    { 5, "Seat" },
                    { 6, "Porsche" },
                    { 7, "Audi" },
                    { 8, "Scania" },
                    { 9, "Cupra" },
                    { 10, "ScaniaNew" },
                    { 11, "DogusOtomotivDaily" },
                    { 12, "AutomotiveAccountOperationsUser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandSettings_BrandId",
                table: "BrandSettings",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandSettings_ChannelId",
                table: "BrandSettings",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandSettings_PlatformId",
                table: "BrandSettings",
                column: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandSettings");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
