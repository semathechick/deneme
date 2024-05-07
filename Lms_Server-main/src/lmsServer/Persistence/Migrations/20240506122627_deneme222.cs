using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deneme222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 218, 148, 1, 18, 111, 195, 238, 133, 141, 7, 3, 94, 11, 217, 154, 46, 153, 216, 55, 213, 59, 237, 53, 69, 93, 15, 142, 115, 131, 211, 69, 59, 232, 98, 61, 17, 180, 84, 168, 60, 36, 60, 45, 169, 227, 50, 192, 63, 141, 162, 76, 151, 215, 155, 197, 145, 1, 111, 99, 114, 133, 243, 232, 199 }, new byte[] { 208, 220, 65, 180, 226, 21, 219, 185, 150, 56, 9, 37, 243, 108, 105, 210, 224, 33, 172, 98, 85, 97, 155, 85, 89, 209, 247, 73, 146, 210, 32, 34, 9, 100, 82, 40, 75, 109, 141, 59, 183, 122, 92, 217, 124, 91, 218, 2, 244, 112, 47, 205, 87, 162, 193, 157, 153, 185, 145, 107, 110, 19, 239, 32, 220, 27, 56, 10, 105, 97, 145, 121, 148, 132, 81, 28, 20, 175, 198, 89, 143, 226, 212, 252, 175, 41, 172, 199, 246, 105, 254, 78, 165, 180, 59, 214, 206, 55, 9, 95, 93, 165, 90, 23, 214, 17, 145, 96, 60, 249, 15, 46, 58, 32, 133, 147, 44, 251, 194, 28, 88, 138, 129, 37, 223, 204, 6, 151 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8fa0a4f2-5958-4a18-8eb7-47e9c59005d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8fa0a4f2-5958-4a18-8eb7-47e9c59005d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84211ca1-592c-44ca-a5bf-a86146a817e3"));

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
    }
}
