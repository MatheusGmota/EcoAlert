using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoAlert.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_LIMIAR_CLIMATICO",
                columns: table => new
                {
                    ID_LIMIAR = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PARAMETRO_SENSOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    VALOR_MAX = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    VALOR_MIN = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    MSG_MAX = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MSG_MIN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RECOMENDACAO_ALERTA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LIMIAR_CLIMATICO", x => x.ID_LIMIAR);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LIMIAR_CLIMATICO");
        }
    }
}
