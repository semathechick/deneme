using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deneme5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8fa0a4f2-5958-4a18-8eb7-47e9c59005d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3"));

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("22849b49-5083-44ae-a6db-d7cfc4c37043"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 54, 98, 250, 174, 51, 197, 173, 76, 14, 5, 248, 121, 161, 165, 163, 149, 247, 120, 38, 46, 87, 98, 235, 176, 57, 124, 222, 124, 231, 149, 167, 93, 92, 157, 39, 225, 71, 50, 237, 124, 44, 199, 247, 38, 157, 166, 13, 99, 31, 64, 23, 38, 255, 8, 223, 252, 126, 252, 17, 205, 40, 35, 244, 236 }, new byte[] { 36, 100, 137, 71, 235, 15, 75, 23, 135, 121, 127, 49, 112, 120, 64, 23, 126, 131, 1, 187, 145, 227, 249, 246, 182, 208, 169, 11, 32, 163, 183, 8, 251, 31, 37, 44, 123, 48, 29, 86, 53, 150, 28, 10, 65, 2, 206, 127, 66, 251, 28, 246, 171, 204, 214, 69, 56, 164, 237, 47, 87, 137, 19, 219, 218, 76, 191, 119, 23, 111, 149, 54, 248, 240, 120, 159, 231, 119, 205, 59, 0, 126, 169, 193, 253, 253, 40, 68, 60, 203, 65, 150, 88, 121, 219, 128, 36, 202, 143, 78, 25, 92, 214, 70, 186, 112, 114, 112, 111, 196, 135, 223, 118, 60, 139, 29, 106, 44, 29, 135, 214, 59, 40, 218, 99, 221, 189, 21 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7da32f44-fcc3-42b0-a7ef-b7395e4c0005"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("22849b49-5083-44ae-a6db-d7cfc4c37043") });

            migrationBuilder.CreateIndex(
                name: "IX_Images_BookId",
                table: "Images",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7da32f44-fcc3-42b0-a7ef-b7395e4c0005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22849b49-5083-44ae-a6db-d7cfc4c37043"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 218, 148, 1, 18, 111, 195, 238, 133, 141, 7, 3, 94, 11, 217, 154, 46, 153, 216, 55, 213, 59, 237, 53, 69, 93, 15, 142, 115, 131, 211, 69, 59, 232, 98, 61, 17, 180, 84, 168, 60, 36, 60, 45, 169, 227, 50, 192, 63, 141, 162, 76, 151, 215, 155, 197, 145, 1, 111, 99, 114, 133, 243, 232, 199 }, new byte[] { 208, 220, 65, 180, 226, 21, 219, 185, 150, 56, 9, 37, 243, 108, 105, 210, 224, 33, 172, 98, 85, 97, 155, 85, 89, 209, 247, 73, 146, 210, 32, 34, 9, 100, 82, 40, 75, 109, 141, 59, 183, 122, 92, 217, 124, 91, 218, 2, 244, 112, 47, 205, 87, 162, 193, 157, 153, 185, 145, 107, 110, 19, 239, 32, 220, 27, 56, 10, 105, 97, 145, 121, 148, 132, 81, 28, 20, 175, 198, 89, 143, 226, 212, 252, 175, 41, 172, 199, 246, 105, 254, 78, 165, 180, 59, 214, 206, 55, 9, 95, 93, 165, 90, 23, 214, 17, 145, 96, 60, 249, 15, 46, 58, 32, 133, 147, 44, 251, 194, 28, 88, 138, 129, 37, 223, 204, 6, 151 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8fa0a4f2-5958-4a18-8eb7-47e9c59005d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3") });
        }
    }
}
