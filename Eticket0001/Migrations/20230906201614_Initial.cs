using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticket0001.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "producer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCategory = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movie_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movie_producer_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "producer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actor_movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actor_movie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_actor_movie_actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actor_movie_movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actor_movie_MovieId",
                table: "actor_movie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_movie_CinemaId",
                table: "movie",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_movie_ProducerId",
                table: "movie",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actor_movie");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "movie");

            migrationBuilder.DropTable(
                name: "Cinema");

            migrationBuilder.DropTable(
                name: "producer");
        }
    }
}
