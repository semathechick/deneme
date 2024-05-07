using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class guncellemekitap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4e08f53c-8a4d-4dcb-a500-14dbc84c0f09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0bd54e1-80d0-455e-96b7-630a21db4981"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("617b4bcf-07a1-4d7c-8df2-f6fede278ffd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 48, 187, 48, 109, 197, 254, 231, 203, 71, 24, 92, 235, 251, 181, 50, 73, 196, 212, 76, 125, 217, 1, 58, 83, 249, 181, 49, 33, 223, 166, 233, 198, 26, 85, 182, 199, 251, 152, 226, 143, 31, 22, 200, 207, 0, 75, 91, 100, 126, 26, 254, 163, 195, 198, 197, 75, 36, 22, 252, 255, 181, 11, 229, 242 }, new byte[] { 59, 141, 155, 120, 216, 13, 67, 70, 161, 108, 32, 178, 229, 74, 132, 25, 111, 55, 138, 143, 250, 236, 162, 5, 77, 90, 230, 243, 108, 51, 1, 170, 89, 201, 214, 11, 196, 72, 5, 60, 173, 178, 141, 197, 25, 128, 166, 118, 76, 59, 222, 71, 122, 100, 108, 148, 181, 210, 228, 198, 125, 13, 82, 32, 203, 214, 219, 212, 245, 241, 12, 142, 100, 226, 2, 60, 203, 149, 154, 120, 24, 192, 31, 33, 91, 154, 218, 74, 238, 17, 116, 66, 115, 195, 223, 244, 18, 64, 63, 38, 142, 40, 64, 55, 121, 248, 168, 129, 5, 24, 146, 205, 154, 60, 127, 14, 102, 169, 41, 161, 241, 132, 50, 129, 58, 210, 9, 211 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("392085bd-469d-4666-a7fd-5b7d90828322"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("617b4bcf-07a1-4d7c-8df2-f6fede278ffd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("a0bd54e1-80d0-455e-96b7-630a21db4981"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 22, 33, 192, 17, 171, 224, 112, 158, 64, 108, 90, 154, 170, 91, 13, 150, 114, 35, 154, 204, 206, 149, 226, 181, 24, 240, 236, 170, 32, 28, 220, 45, 252, 236, 232, 84, 232, 71, 111, 249, 71, 220, 188, 93, 214, 254, 216, 50, 229, 15, 252, 51, 201, 126, 31, 216, 249, 156, 6, 232, 222, 233, 151, 172 }, new byte[] { 115, 173, 208, 166, 195, 242, 76, 213, 18, 128, 232, 70, 115, 44, 64, 144, 45, 220, 196, 188, 239, 131, 246, 228, 176, 132, 36, 81, 0, 114, 78, 26, 189, 0, 233, 60, 163, 131, 135, 213, 172, 232, 139, 145, 117, 1, 49, 93, 34, 81, 39, 207, 149, 235, 62, 215, 201, 242, 173, 110, 97, 69, 34, 49, 235, 121, 79, 233, 118, 97, 137, 125, 139, 216, 159, 198, 94, 32, 197, 141, 238, 210, 154, 157, 178, 187, 61, 72, 58, 239, 166, 179, 30, 79, 75, 137, 129, 186, 168, 26, 92, 97, 254, 230, 37, 171, 240, 223, 117, 251, 203, 238, 46, 119, 31, 72, 16, 208, 239, 79, 216, 6, 125, 39, 12, 240, 169, 241 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4e08f53c-8a4d-4dcb-a500-14dbc84c0f09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a0bd54e1-80d0-455e-96b7-630a21db4981") });
        }
    }
}
