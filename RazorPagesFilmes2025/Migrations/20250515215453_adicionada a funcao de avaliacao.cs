using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilmes2025.Migrations
{
    /// <inheritdoc />
    public partial class adicionadaafuncaodeavaliacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Avaliacao",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliacao",
                table: "Filme");
        }
    }
}
