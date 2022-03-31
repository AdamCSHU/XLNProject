using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "errors",
                columns: table => new
                {
                    FaultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaultAgainst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivertRequired = table.Column<bool>(type: "bit", nullable: false),
                    DivertPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AffectingWhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncidentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncidentDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIntermittent = table.Column<bool>(type: "bit", nullable: false),
                    IntermittentDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosticsResults = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptsWarning = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_errors", x => x.FaultId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaultId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customers_errors_FaultId",
                        column: x => x.FaultId,
                        principalTable: "errors",
                        principalColumn: "FaultId");
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "Address", "CompanyName", "Email", "FaultId", "Name", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "Thone Drive S91QR", " Bakes ", "ismail@gmail.com", null, "Ismail", "1234", "0770128013", "IsmailBakes" },
                    { 2, "Highgate S43ASD", " Ahemds Foods ", "ahmed@gmail.com", null, "Ahmed", "1234", "072304713201", "AhmedFoods" },
                    { 3, "Hasfield Drive S32QR", " Sandwhich mani ", "john@gmail.com", null, "John KLSD", "1234", "07237030812", "JohnK" }
                });

            migrationBuilder.InsertData(
                table: "errors",
                columns: new[] { "FaultId", "AcceptsWarning", "AffectingWhat", "DiagnosticsResults", "DivertPhone", "DivertRequired", "FaultAgainst", "IncidentDetails", "IncidentType", "IntermittentDetails", "IsIntermittent", "Notes", "Status" },
                values: new object[,]
                {
                    { 1, false, "x", "x", "x", true, "Wifi", "x", "x", "x", false, "NA", "Done" },
                    { 2, false, "x", "x", "x", true, "Wifi", "x", "x", "x", false, "NA", "not Done" },
                    { 3, false, "x", "x", "x", true, "Wifi", "x", "x", "x", false, "NA", "not Done" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_FaultId",
                table: "customers",
                column: "FaultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "errors");
        }
    }
}
