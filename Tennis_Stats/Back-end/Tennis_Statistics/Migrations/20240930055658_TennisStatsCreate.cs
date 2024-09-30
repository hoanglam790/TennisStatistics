using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tennis_Statistics.Migrations
{
    /// <inheritdoc />
    public partial class TennisStatsCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelStars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "MatchesDetailOther",
                columns: table => new
                {
                    MatchDetailOtherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcesPlayer1 = table.Column<int>(type: "int", nullable: false),
                    AcesPlayer2 = table.Column<int>(type: "int", nullable: false),
                    DoubleFaultsPlayer1 = table.Column<int>(type: "int", nullable: false),
                    DoubleFaultsPlayer2 = table.Column<int>(type: "int", nullable: false),
                    FirstServePlayer1 = table.Column<float>(type: "real", nullable: false),
                    FirstServePlayer2 = table.Column<float>(type: "real", nullable: false),
                    FirstServeWonPlayer1 = table.Column<float>(type: "real", nullable: false),
                    FirstServeWonPlayer2 = table.Column<float>(type: "real", nullable: false),
                    SecondServeWonPlayer1 = table.Column<float>(type: "real", nullable: false),
                    SecondServeWonPlayer2 = table.Column<float>(type: "real", nullable: false),
                    WinnersPlayer1 = table.Column<int>(type: "int", nullable: false),
                    WinnersPlayer2 = table.Column<int>(type: "int", nullable: false),
                    UnforcedErrorsPlayer1 = table.Column<int>(type: "int", nullable: false),
                    UnforcedErrorsPlayer2 = table.Column<int>(type: "int", nullable: false),
                    BreakPointsWonPlayer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreakPointsWonPlayer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FastestServePlayer1 = table.Column<float>(type: "real", nullable: false),
                    FastestServePlayer2 = table.Column<float>(type: "real", nullable: false),
                    AvgFirstServeSpeedPlayer1 = table.Column<int>(type: "int", nullable: false),
                    AvgFirstServeSpeedPlayer2 = table.Column<int>(type: "int", nullable: false),
                    AvgSecondServeSpeedPlayer1 = table.Column<int>(type: "int", nullable: false),
                    AvgSecondServeSpeedPlayer2 = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesDetailOther", x => x.MatchDetailOtherID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ResultID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ResultID);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonID);
                });

            migrationBuilder.CreateTable(
                name: "Surfaces",
                columns: table => new
                {
                    SurfaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurfaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surfaces", x => x.SurfaceID);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    WeekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.WeekID);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rounds = table.Column<int>(type: "int", nullable: false),
                    SurfaceID = table.Column<int>(type: "int", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentID);
                    table.ForeignKey(
                        name: "FK_Tournaments_Levels_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levels",
                        principalColumn: "LevelID");
                    table.ForeignKey(
                        name: "FK_Tournaments_Surfaces_SurfaceID",
                        column: x => x.SurfaceID,
                        principalTable: "Surfaces",
                        principalColumn: "SurfaceID");
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Player2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScorePlayer1 = table.Column<int>(type: "int", nullable: false),
                    ScorePlayer2 = table.Column<int>(type: "int", nullable: false),
                    TournamentID = table.Column<int>(type: "int", nullable: true),
                    SeasonID = table.Column<int>(type: "int", nullable: true),
                    WeekID = table.Column<int>(type: "int", nullable: true),
                    MatchTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    ResultID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_Results_ResultID",
                        column: x => x.ResultID,
                        principalTable: "Results",
                        principalColumn: "ResultID");
                    table.ForeignKey(
                        name: "FK_Matches_Seasons_SeasonID",
                        column: x => x.SeasonID,
                        principalTable: "Seasons",
                        principalColumn: "SeasonID");
                    table.ForeignKey(
                        name: "FK_Matches_Weeks_WeekID",
                        column: x => x.WeekID,
                        principalTable: "Weeks",
                        principalColumn: "WeekID");
                });

            migrationBuilder.CreateTable(
                name: "MatchesDetail",
                columns: table => new
                {
                    MatchDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchID = table.Column<int>(type: "int", nullable: true),
                    ScoreSet1Player1 = table.Column<int>(type: "int", nullable: false),
                    ScoreSet1Player2 = table.Column<int>(type: "int", nullable: false),
                    ScoreSet2Player1 = table.Column<int>(type: "int", nullable: false),
                    ScoreSet2Player2 = table.Column<int>(type: "int", nullable: false),
                    ScoreSet3Player1 = table.Column<int>(type: "int", nullable: true),
                    ScoreSet3Player2 = table.Column<int>(type: "int", nullable: true),
                    ScoreSet4Player1 = table.Column<int>(type: "int", nullable: true),
                    ScoreSet4Player2 = table.Column<int>(type: "int", nullable: true),
                    ScoreSet5Player1 = table.Column<int>(type: "int", nullable: true),
                    ScoreSet5Player2 = table.Column<int>(type: "int", nullable: true),
                    MatchDetailOtherID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesDetail", x => x.MatchDetailID);
                    table.ForeignKey(
                        name: "FK_MatchesDetail_MatchesDetailOther_MatchDetailOtherID",
                        column: x => x.MatchDetailOtherID,
                        principalTable: "MatchesDetailOther",
                        principalColumn: "MatchDetailOtherID");
                    table.ForeignKey(
                        name: "FK_MatchesDetail_Matches_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ResultID",
                table: "Matches",
                column: "ResultID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SeasonID",
                table: "Matches",
                column: "SeasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WeekID",
                table: "Matches",
                column: "WeekID");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesDetail_MatchDetailOtherID",
                table: "MatchesDetail",
                column: "MatchDetailOtherID");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesDetail_MatchID",
                table: "MatchesDetail",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_LevelID",
                table: "Tournaments",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_SurfaceID",
                table: "Tournaments",
                column: "SurfaceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchesDetail");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "MatchesDetailOther");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Surfaces");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Weeks");
        }
    }
}
