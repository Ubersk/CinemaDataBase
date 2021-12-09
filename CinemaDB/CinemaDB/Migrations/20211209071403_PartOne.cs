using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaDB.Migrations
{
    public partial class PartOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDuration = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersUserId = table.Column<int>(type: "int", nullable: true),
                    DateSession = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionID);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Composers",
                columns: table => new
                {
                    ComposerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComposerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComposerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComposerMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoviesMovieId = table.Column<int>(type: "int", nullable: true),
                    SessionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composers", x => x.ComposerId);
                    table.ForeignKey(
                        name: "FK_Composers_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Composers_Sessions_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Sessions",
                        principalColumn: "SessionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoviesMovieId = table.Column<int>(type: "int", nullable: true),
                    SessionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorId);
                    table.ForeignKey(
                        name: "FK_Directors_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Directors_Sessions_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Sessions",
                        principalColumn: "SessionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieSession",
                columns: table => new
                {
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false),
                    SongsSessionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSession", x => new { x.MoviesMovieId, x.SongsSessionID });
                    table.ForeignKey(
                        name: "FK_MovieSession_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSession_Sessions_SongsSessionID",
                        column: x => x.SongsSessionID,
                        principalTable: "Sessions",
                        principalColumn: "SessionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Composers_MoviesMovieId",
                table: "Composers",
                column: "MoviesMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Composers_SessionID",
                table: "Composers",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_MoviesMovieId",
                table: "Directors",
                column: "MoviesMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_SessionID",
                table: "Directors",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSession_SongsSessionID",
                table: "MovieSession",
                column: "SongsSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UsersUserId",
                table: "Sessions",
                column: "UsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Composers");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "MovieSession");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
