using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGII_CNTR.Migrations
{
    public partial class DGII_CNTR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuyente",
                columns: table => new
                {
                    IdContribuyente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rncCedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuyente", x => x.IdContribuyente);
                });

            migrationBuilder.CreateTable(
                name: "comprobantesF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContribuyente = table.Column<int>(type: "int", nullable: false),
                    rncCedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    itbis18 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContribuyentesIdContribuyente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprobantesF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comprobantesF_Contribuyente_ContribuyentesIdContribuyente",
                        column: x => x.ContribuyentesIdContribuyente,
                        principalTable: "Contribuyente",
                        principalColumn: "IdContribuyente");
                });

            migrationBuilder.CreateIndex(
                name: "IX_comprobantesF_ContribuyentesIdContribuyente",
                table: "comprobantesF",
                column: "ContribuyentesIdContribuyente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comprobantesF");

            migrationBuilder.DropTable(
                name: "Contribuyente");
        }
    }
}
