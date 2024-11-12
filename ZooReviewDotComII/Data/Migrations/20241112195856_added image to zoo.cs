using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooReviewDotComII.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedimagetozoo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Zoos",
                type: "longblob",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Zoos");
        }
    }
}
