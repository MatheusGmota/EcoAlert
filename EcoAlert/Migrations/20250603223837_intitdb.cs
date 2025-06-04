using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoAlert.Migrations
{
    /// <inheritdoc />
    public partial class intitdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_limiar_climatico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ParametroSensor = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ValorMax = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    ValorMin = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    MsgMax = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MsgMin = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RecomendacaoAlerta = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_limiar_climatico", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_limiar_climatico");
        }
    }
}
