using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Valorant.Dodle.Infra.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Arsenal",
                schema: "dbo",
                columns: table => new
                {
                    IdArma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ImagemArma = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arsenal", x => x.IdArma);
                });

            migrationBuilder.CreateTable(
                name: "Mapas",
                schema: "dbo",
                columns: table => new
                {
                    IdMapa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Região = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    ImagemMapa = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapas", x => x.IdMapa);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                schema: "dbo",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Regiao = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Funcao = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    ImagemPersonagem = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.IdPersonagem);
                });

            migrationBuilder.CreateTable(
                name: "Skin",
                schema: "dbo",
                columns: table => new
                {
                    IdSkin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArma = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Pacote = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    ImagemSkin = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Rara = table.Column<string>(type: "char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skin", x => x.IdSkin);
                    table.ForeignKey(
                        name: "FK_Skin_Arsenal_IdArma",
                        column: x => x.IdArma,
                        principalSchema: "dbo",
                        principalTable: "Arsenal",
                        principalColumn: "IdArma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                schema: "dbo",
                columns: table => new
                {
                    IdHabilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersonagem = table.Column<int>(type: "int", nullable: false),
                    PrimeiraHabilidade = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    DescricaoPrimeiraHabilidade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ImagemPrimeiraHabilidade = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    SegundaHabilidade = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    DescricaoSegundaHabilidade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ImagemSegundaHabilidade = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    TerceiraHabilidade = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    DescricaoTerceiraHabilidade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ImagemTerceiraHabilidade = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    UltimaHabildade = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    DescricaoUltimaHabildade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ImagemUltimaHabilidade = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.IdHabilidade);
                    table.ForeignKey(
                        name: "FK_Habilidades_Personagem_IdPersonagem",
                        column: x => x.IdPersonagem,
                        principalSchema: "dbo",
                        principalTable: "Personagem",
                        principalColumn: "IdPersonagem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_IdPersonagem",
                schema: "dbo",
                table: "Habilidades",
                column: "IdPersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Skin_IdArma",
                schema: "dbo",
                table: "Skin",
                column: "IdArma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Mapas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Skin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Personagem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Arsenal",
                schema: "dbo");
        }
    }
}
