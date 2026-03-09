using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aurix.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultStatusForCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE \"Courses\" SET \"Status\" = 'Draft' WHERE \"Status\" = ''");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE \"Courses\" SET \"Status\" = '' WHERE \"Status\" = 'Draft'");
        }
    }
}
