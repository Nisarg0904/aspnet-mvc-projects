using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP2139_Labs.Migrations
{
    /// <inheritdoc />
    public partial class ProjectModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tasks_ProjectId",
                table: "tasks");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_ProjectId",
                table: "tasks",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tasks_ProjectId",
                table: "tasks");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_ProjectId",
                table: "tasks",
                column: "ProjectId",
                unique: true);
        }
    }
}
