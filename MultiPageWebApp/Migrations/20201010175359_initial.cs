using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageWebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.PhoneId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PhoneNumber" },
                values: new object[] { 1, "123 The Rock Ave", "Dwayne Johnson", "If you smell, what the rock is cook'n", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PhoneNumber" },
                values: new object[] { 2, "1 Yankee Stadium St", "Derek Jeter", "Greatest shortstop of all time", "222-222-2222" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PhoneNumber" },
                values: new object[] { 3, "18 Indianapolis Ln", "Peyton Manning", "Omaha!", "181-181-1818" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
