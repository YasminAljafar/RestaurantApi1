using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApi1.Migrations
{
    /// <inheritdoc />
    public partial class UndoResTypTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Restaurants_RestaurantId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants");

            migrationBuilder.RenameTable(
                name: "UserTypes",
                newName: "UserType");

            migrationBuilder.RenameTable(
                name: "Restaurants",
                newName: "Restaurant");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserType",
                table: "UserType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Restaurant_RestaurantId",
                table: "Users",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserType_UserTypeId",
                table: "Users",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Restaurant_RestaurantId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserType_UserTypeId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserType",
                table: "UserType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant");

            migrationBuilder.RenameTable(
                name: "UserType",
                newName: "UserTypes");

            migrationBuilder.RenameTable(
                name: "Restaurant",
                newName: "Restaurants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Restaurants_RestaurantId",
                table: "Users",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
