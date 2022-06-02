using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StayHealthy.Data.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string[] AspNetUsersColumns = { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" };
            object[] AspNetUsersValues = { "3cfda5ca-9322-4a39-a490-6cb8932ef635", "admin", "ADMIN", "admin@admin.com", "ADMIN@ADMIN.COM", true, "AQAAAAEAACcQAAAAEE7L9go2ynBA3FL7jp+GX2T+J9nFNHNaydpEh3UG2sYkpX3EaReRo2KDI9yxmT5ijA==", "277LYSHXYMOJQXVHFBF3H3LFFDEHBURQ", "df521c2f-0ee7-49e5-b2a6-59c800a30271", null, false, false, null, false, 0 };
            migrationBuilder.InsertData("AspNetUsers", AspNetUsersColumns, AspNetUsersValues);

            string[] AspNetRolesColumns = { "Id", "Name", "NormalizedName", "ConcurrencyStamp" };
            object[] AspNetRolesValues = { "497b8d1e-689e-41bf-8166-29b5c19a6c2a", "Admin", "ADMIN", "df521c2f-0ee7-49e5-c3b9-59c800a30271" };
            migrationBuilder.InsertData("AspNetRoles", AspNetRolesColumns, AspNetRolesValues);

            string[] AspNetUserRolesColumns = { "UserId", "RoleId" };
            object[] AspNetUserRolesValues = { "3cfda5ca-9322-4a39-a490-6cb8932ef635", "497b8d1e-689e-41bf-8166-29b5c19a6c2a" };
            migrationBuilder.InsertData("AspNetUserRoles", AspNetUserRolesColumns, AspNetUserRolesValues);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
