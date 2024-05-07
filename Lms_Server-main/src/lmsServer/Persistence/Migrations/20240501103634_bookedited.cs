using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class bookedited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("205152bd-dbf7-49ee-b6f2-cf22f02e1e19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0c94fc5-84ce-4b57-b0cf-ea6a4269e9c7"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a0bd54e1-80d0-455e-96b7-630a21db4981"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 22, 33, 192, 17, 171, 224, 112, 158, 64, 108, 90, 154, 170, 91, 13, 150, 114, 35, 154, 204, 206, 149, 226, 181, 24, 240, 236, 170, 32, 28, 220, 45, 252, 236, 232, 84, 232, 71, 111, 249, 71, 220, 188, 93, 214, 254, 216, 50, 229, 15, 252, 51, 201, 126, 31, 216, 249, 156, 6, 232, 222, 233, 151, 172 }, new byte[] { 115, 173, 208, 166, 195, 242, 76, 213, 18, 128, 232, 70, 115, 44, 64, 144, 45, 220, 196, 188, 239, 131, 246, 228, 176, 132, 36, 81, 0, 114, 78, 26, 189, 0, 233, 60, 163, 131, 135, 213, 172, 232, 139, 145, 117, 1, 49, 93, 34, 81, 39, 207, 149, 235, 62, 215, 201, 242, 173, 110, 97, 69, 34, 49, 235, 121, 79, 233, 118, 97, 137, 125, 139, 216, 159, 198, 94, 32, 197, 141, 238, 210, 154, 157, 178, 187, 61, 72, 58, 239, 166, 179, 30, 79, 75, 137, 129, 186, 168, 26, 92, 97, 254, 230, 37, 171, 240, 223, 117, 251, 203, 238, 46, 119, 31, 72, 16, 208, 239, 79, 216, 6, 125, 39, 12, 240, 169, 241 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4e08f53c-8a4d-4dcb-a500-14dbc84c0f09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a0bd54e1-80d0-455e-96b7-630a21db4981") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("d0c94fc5-84ce-4b57-b0cf-ea6a4269e9c7"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 176, 82, 137, 88, 97, 137, 134, 229, 178, 62, 138, 100, 48, 52, 86, 233, 136, 81, 77, 241, 63, 26, 232, 210, 100, 161, 248, 146, 117, 231, 61, 93, 153, 203, 219, 112, 18, 114, 212, 123, 180, 73, 174, 185, 190, 93, 7, 118, 26, 75, 221, 59, 57, 103, 44, 176, 60, 226, 229, 226, 91, 218, 32, 93 }, new byte[] { 158, 187, 150, 83, 245, 161, 242, 159, 77, 178, 47, 118, 28, 239, 218, 100, 164, 160, 107, 214, 53, 231, 122, 8, 6, 79, 117, 159, 216, 209, 75, 120, 63, 127, 162, 24, 151, 80, 115, 250, 75, 70, 125, 148, 149, 176, 127, 17, 188, 0, 190, 45, 83, 43, 15, 195, 115, 210, 41, 164, 92, 2, 115, 147, 233, 128, 195, 27, 1, 203, 87, 17, 122, 72, 247, 150, 204, 214, 107, 0, 128, 133, 250, 5, 71, 163, 101, 46, 137, 194, 45, 240, 202, 127, 209, 34, 103, 110, 127, 12, 99, 79, 239, 85, 100, 202, 116, 173, 2, 30, 39, 14, 151, 189, 39, 243, 173, 221, 50, 185, 28, 55, 52, 196, 35, 155, 176, 72 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("205152bd-dbf7-49ee-b6f2-cf22f02e1e19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d0c94fc5-84ce-4b57-b0cf-ea6a4269e9c7") });
        }
    }
}
