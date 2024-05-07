using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class denemeimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8819c95f-3b8b-4f65-b175-85c1a6b66bc4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 120, 116, 184, 243, 143, 208, 66, 122, 146, 80, 226, 222, 74, 207, 186, 47, 24, 10, 196, 238, 81, 119, 119, 137, 116, 117, 153, 48, 220, 44, 222, 214, 61, 197, 54, 9, 184, 74, 185, 223, 214, 146, 212, 42, 62, 84, 96, 161, 92, 232, 125, 135, 159, 127, 57, 248, 252, 57, 185, 198, 206, 178, 68, 239 }, new byte[] { 246, 75, 1, 87, 143, 32, 144, 236, 165, 75, 99, 215, 178, 22, 136, 225, 202, 105, 184, 218, 114, 201, 199, 88, 8, 240, 37, 29, 39, 48, 206, 88, 142, 197, 9, 142, 121, 9, 212, 231, 191, 9, 165, 242, 114, 125, 236, 182, 62, 34, 155, 79, 23, 26, 113, 191, 31, 196, 90, 195, 145, 209, 148, 136, 146, 75, 115, 18, 122, 76, 237, 24, 95, 7, 18, 109, 211, 10, 236, 171, 192, 65, 24, 87, 24, 49, 213, 37, 73, 68, 32, 100, 31, 238, 27, 189, 42, 81, 255, 216, 208, 240, 224, 13, 26, 198, 197, 3, 50, 252, 255, 155, 160, 160, 207, 152, 187, 116, 29, 225, 172, 186, 202, 181, 94, 253, 166, 192 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5526db57-97d3-4c59-984e-3106638ca221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8819c95f-3b8b-4f65-b175-85c1a6b66bc4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5526db57-97d3-4c59-984e-3106638ca221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8819c95f-3b8b-4f65-b175-85c1a6b66bc4"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 130, 72, 32, 237, 53, 187, 133, 117, 65, 115, 182, 150, 70, 147, 143, 112, 139, 151, 173, 240, 19, 255, 242, 151, 50, 21, 144, 99, 196, 82, 179, 195, 78, 97, 145, 232, 27, 240, 36, 43, 122, 39, 184, 40, 89, 238, 147, 5, 142, 121, 138, 83, 220, 99, 33, 101, 39, 76, 242, 73, 124, 82, 120 }, new byte[] { 33, 218, 70, 146, 221, 237, 140, 158, 36, 208, 241, 166, 241, 109, 244, 244, 255, 208, 90, 133, 169, 25, 223, 23, 144, 218, 16, 51, 213, 142, 139, 58, 38, 234, 187, 155, 147, 106, 159, 196, 59, 11, 184, 93, 21, 217, 245, 86, 204, 137, 35, 45, 94, 33, 12, 184, 46, 129, 224, 148, 34, 216, 10, 254, 118, 77, 209, 41, 234, 151, 104, 13, 230, 179, 0, 171, 168, 86, 254, 208, 219, 61, 99, 82, 168, 124, 0, 244, 88, 91, 228, 235, 241, 171, 222, 67, 243, 17, 96, 139, 214, 197, 85, 135, 91, 118, 236, 158, 195, 43, 126, 86, 242, 67, 244, 238, 189, 32, 113, 70, 148, 254, 106, 149, 142, 13, 6, 180 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("514f77e0-98b6-4806-b77e-cece2f402e81") });
        }
    }
}
