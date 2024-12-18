using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class v01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_albums_artists_album_id",
                table: "albums");

            migrationBuilder.AlterColumn<long>(
                name: "album_id",
                table: "albums",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_tracks_genre_id",
                table: "tracks",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "IX_albums_artist_id",
                table: "albums",
                column: "artist_id");

            migrationBuilder.CreateIndex(
                name: "IX_albums_media_id",
                table: "albums",
                column: "media_id");

            migrationBuilder.AddForeignKey(
                name: "FK_albums_artists_artist_id",
                table: "albums",
                column: "artist_id",
                principalTable: "artists",
                principalColumn: "artists_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_albums_media_media_id",
                table: "albums",
                column: "media_id",
                principalTable: "media",
                principalColumn: "media_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tracks_genres_genre_id",
                table: "tracks",
                column: "genre_id",
                principalTable: "genres",
                principalColumn: "genre_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_albums_artists_artist_id",
                table: "albums");

            migrationBuilder.DropForeignKey(
                name: "FK_albums_media_media_id",
                table: "albums");

            migrationBuilder.DropForeignKey(
                name: "FK_tracks_genres_genre_id",
                table: "tracks");

            migrationBuilder.DropIndex(
                name: "IX_tracks_genre_id",
                table: "tracks");

            migrationBuilder.DropIndex(
                name: "IX_albums_artist_id",
                table: "albums");

            migrationBuilder.DropIndex(
                name: "IX_albums_media_id",
                table: "albums");

            migrationBuilder.AlterColumn<long>(
                name: "album_id",
                table: "albums",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_albums_artists_album_id",
                table: "albums",
                column: "album_id",
                principalTable: "artists",
                principalColumn: "artists_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
