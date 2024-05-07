using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c61ba14c-354b-49de-80e3-2dad7fc91b50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d"));

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "LoanTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnStatus = table.Column<bool>(type: "bit", nullable: false),
                    ReturnTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanTransactions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanTransactions_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Admin", null },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Read", null },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Write", null },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Create", null },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Update", null },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LoanTransactions.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 130, 72, 32, 237, 53, 187, 133, 117, 65, 115, 182, 150, 70, 147, 143, 112, 139, 151, 173, 240, 19, 255, 242, 151, 50, 21, 144, 99, 196, 82, 179, 195, 78, 97, 145, 232, 27, 240, 36, 43, 122, 39, 184, 40, 89, 238, 147, 5, 142, 121, 138, 83, 220, 99, 33, 101, 39, 76, 242, 73, 124, 82, 120 }, new byte[] { 33, 218, 70, 146, 221, 237, 140, 158, 36, 208, 241, 166, 241, 109, 244, 244, 255, 208, 90, 133, 169, 25, 223, 23, 144, 218, 16, 51, 213, 142, 139, 58, 38, 234, 187, 155, 147, 106, 159, 196, 59, 11, 184, 93, 21, 217, 245, 86, 204, 137, 35, 45, 94, 33, 12, 184, 46, 129, 224, 148, 34, 216, 10, 254, 118, 77, 209, 41, 234, 151, 104, 13, 230, 179, 0, 171, 168, 86, 254, 208, 219, 61, 99, 82, 168, 124, 0, 244, 88, 91, 228, 235, 241, 171, 222, 67, 243, 17, 96, 139, 214, 197, 85, 135, 91, 118, 236, 158, 195, 43, 126, 86, 242, 67, 244, 238, 189, 32, 113, 70, 148, 254, 106, 149, 142, 13, 6, 180 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("514f77e0-98b6-4806-b77e-cece2f402e81") });

            migrationBuilder.CreateIndex(
                name: "IX_LoanTransactions_BookId",
                table: "LoanTransactions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanTransactions_MemberId",
                table: "LoanTransactions",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanTransactions");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"));

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 203, 18, 42, 137, 150, 8, 94, 92, 1, 162, 193, 53, 95, 47, 99, 142, 182, 54, 32, 5, 113, 105, 98, 27, 251, 46, 10, 110, 31, 59, 162, 63, 161, 170, 173, 190, 169, 104, 187, 35, 84, 79, 110, 120, 22, 100, 23, 190, 114, 103, 77, 255, 36, 66, 245, 240, 84, 101, 233, 235, 128, 177, 92, 70 }, new byte[] { 67, 225, 80, 203, 3, 185, 84, 12, 244, 132, 116, 85, 203, 240, 251, 79, 103, 120, 218, 83, 250, 146, 196, 254, 227, 59, 37, 61, 21, 79, 123, 97, 189, 61, 206, 152, 252, 141, 85, 197, 155, 231, 200, 217, 246, 128, 205, 147, 192, 192, 44, 8, 64, 179, 10, 198, 120, 10, 41, 92, 76, 166, 253, 153, 207, 21, 206, 248, 3, 253, 92, 56, 123, 212, 136, 0, 121, 140, 86, 61, 180, 216, 215, 37, 199, 144, 79, 125, 155, 136, 201, 5, 132, 151, 176, 252, 92, 195, 246, 73, 106, 89, 67, 139, 36, 235, 117, 60, 206, 120, 142, 246, 128, 165, 6, 101, 126, 41, 90, 173, 206, 107, 201, 51, 10, 119, 170, 228 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c61ba14c-354b-49de-80e3-2dad7fc91b50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d") });
        }
    }
}
