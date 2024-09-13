using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCodeSnippets.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CodeSnippets",
                columns: new[] { "Id", "Description", "ProgrammingLanguage", "Snippet", "Status", "Tag", "Title" },
                values: new object[] { 1, "Simple sum function snippet", "TypeScript", "const sum = (x, y) => {return x + y;}", "Active", "Functions", "Sum function" });

            migrationBuilder.InsertData(
                table: "CodeSnippets",
                columns: new[] { "Id", "Description", "ProgrammingLanguage", "Snippet", "Status", "Tag", "Title" },
                values: new object[] { 2, "Simple multiply function snippet", "TypeScript", "const multiply = (x, y) => {return x * y;}", "Active", "Functions", "Multiply function" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSnippets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CodeSnippets",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
