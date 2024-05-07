using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class member0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("392085bd-469d-4666-a7fd-5b7d90828322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("617b4bcf-07a1-4d7c-8df2-f6fede278ffd"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 203, 18, 42, 137, 150, 8, 94, 92, 1, 162, 193, 53, 95, 47, 99, 142, 182, 54, 32, 5, 113, 105, 98, 27, 251, 46, 10, 110, 31, 59, 162, 63, 161, 170, 173, 190, 169, 104, 187, 35, 84, 79, 110, 120, 22, 100, 23, 190, 114, 103, 77, 255, 36, 66, 245, 240, 84, 101, 233, 235, 128, 177, 92, 70 }, new byte[] { 67, 225, 80, 203, 3, 185, 84, 12, 244, 132, 116, 85, 203, 240, 251, 79, 103, 120, 218, 83, 250, 146, 196, 254, 227, 59, 37, 61, 21, 79, 123, 97, 189, 61, 206, 152, 252, 141, 85, 197, 155, 231, 200, 217, 246, 128, 205, 147, 192, 192, 44, 8, 64, 179, 10, 198, 120, 10, 41, 92, 76, 166, 253, 153, 207, 21, 206, 248, 3, 253, 92, 56, 123, 212, 136, 0, 121, 140, 86, 61, 180, 216, 215, 37, 199, 144, 79, 125, 155, 136, 201, 5, 132, 151, 176, 252, 92, 195, 246, 73, 106, 89, 67, 139, 36, 235, 117, 60, 206, 120, 142, 246, 128, 165, 6, 101, 126, 41, 90, 173, 206, 107, 201, 51, 10, 119, 170, 228 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c61ba14c-354b-49de-80e3-2dad7fc91b50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c61ba14c-354b-49de-80e3-2dad7fc91b50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("593bd4cd-ba4f-45d4-a22a-d11cb36a551d"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("617b4bcf-07a1-4d7c-8df2-f6fede278ffd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 48, 187, 48, 109, 197, 254, 231, 203, 71, 24, 92, 235, 251, 181, 50, 73, 196, 212, 76, 125, 217, 1, 58, 83, 249, 181, 49, 33, 223, 166, 233, 198, 26, 85, 182, 199, 251, 152, 226, 143, 31, 22, 200, 207, 0, 75, 91, 100, 126, 26, 254, 163, 195, 198, 197, 75, 36, 22, 252, 255, 181, 11, 229, 242 }, new byte[] { 59, 141, 155, 120, 216, 13, 67, 70, 161, 108, 32, 178, 229, 74, 132, 25, 111, 55, 138, 143, 250, 236, 162, 5, 77, 90, 230, 243, 108, 51, 1, 170, 89, 201, 214, 11, 196, 72, 5, 60, 173, 178, 141, 197, 25, 128, 166, 118, 76, 59, 222, 71, 122, 100, 108, 148, 181, 210, 228, 198, 125, 13, 82, 32, 203, 214, 219, 212, 245, 241, 12, 142, 100, 226, 2, 60, 203, 149, 154, 120, 24, 192, 31, 33, 91, 154, 218, 74, 238, 17, 116, 66, 115, 195, 223, 244, 18, 64, 63, 38, 142, 40, 64, 55, 121, 248, 168, 129, 5, 24, 146, 205, 154, 60, 127, 14, 102, 169, 41, 161, 241, 132, 50, 129, 58, 210, 9, 211 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("392085bd-469d-4666-a7fd-5b7d90828322"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("617b4bcf-07a1-4d7c-8df2-f6fede278ffd") });
        }
    }
}
