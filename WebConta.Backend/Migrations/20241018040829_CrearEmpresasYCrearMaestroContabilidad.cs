using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebConta.Backend.Migrations
{
    /// <inheritdoc />
    public partial class CrearEmpresasYCrearMaestroContabilidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    Patrono = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    DirecionPatrono = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    NuimeroPatronal = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Produce = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DebeHaber = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel3 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel4 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel5 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nivel6 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Pasivo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Ventas = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Costos = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Gastos = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    OtrosIngresos = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    OtrosGastos = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Produccion = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PorcentajeIva = table.Column<double>(type: "float", nullable: false),
                    ActMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    BanMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ComMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ConMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CxcMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CxpMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IvaMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PlaMesAct = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    DebeHaber = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    Cargos = table.Column<int>(type: "int", nullable: false),
                    Abonos = table.Column<int>(type: "int", nullable: false),
                    SaldoMes = table.Column<int>(type: "int", nullable: false),
                    CargosMes = table.Column<int>(type: "int", nullable: false),
                    AbonosMes = table.Column<int>(type: "int", nullable: false),
                    SaldoCierre = table.Column<int>(type: "int", nullable: false),
                    CodigoMayor = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CodigoPres = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IngresoCash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EgresoCash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuentas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_EmpresaId_Codigo",
                table: "Cuentas",
                columns: new[] { "EmpresaId", "Codigo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Nit",
                table: "Empresas",
                column: "Nit",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
