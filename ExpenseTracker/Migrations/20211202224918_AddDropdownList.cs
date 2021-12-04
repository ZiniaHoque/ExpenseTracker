using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeProject.Migrations
{
    public partial class AddDropdownList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ExpenseCategories_ExpenseCategoryCategoryId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ExpenseCategoryCategoryId",
                table: "Users",
                newName: "ExpenseCategoriesCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ExpenseCategoryCategoryId",
                table: "Users",
                newName: "IX_Users_ExpenseCategoriesCategoryId");

            migrationBuilder.RenameColumn(
                name: "ExpenseId",
                table: "Expenses",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ExpenseCategories_ExpenseCategoriesCategoryId",
                table: "Users",
                column: "ExpenseCategoriesCategoryId",
                principalTable: "ExpenseCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ExpenseCategories_ExpenseCategoriesCategoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "ExpenseCategoriesCategoryId",
                table: "Users",
                newName: "ExpenseCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ExpenseCategoriesCategoryId",
                table: "Users",
                newName: "IX_Users_ExpenseCategoryCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Expenses",
                newName: "ExpenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ExpenseCategories_ExpenseCategoryCategoryId",
                table: "Users",
                column: "ExpenseCategoryCategoryId",
                principalTable: "ExpenseCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
