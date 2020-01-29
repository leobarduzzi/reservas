using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace reservas.Migrations
{
    public partial class anuncios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    Quartos = table.Column<int>(nullable: false),
                    Banheiros = table.Column<int>(nullable: false),
                    CamaCasal = table.Column<int>(nullable: false),
                    CamaSolteiro = table.Column<int>(nullable: false),
                    Berco = table.Column<int>(nullable: false),
                    Beliche = table.Column<int>(nullable: false),
                    Colchoes = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    EstadiaMin = table.Column<int>(nullable: false),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disponibilidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnuncioId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Reservados = table.Column<int>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disponibilidade_Anuncio_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ValorAnuncio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnuncioId = table.Column<int>(nullable: false),
                    FormaPagamentoId = table.Column<int>(nullable: false),
                    Acrescimo = table.Column<decimal>(nullable: false),
                    ParcelaMin = table.Column<int>(nullable: false),
                    ParcelaMax = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValorAnuncio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValorAnuncio_Anuncio_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValorAnuncio_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidade_AnuncioId",
                table: "Disponibilidade",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_ValorAnuncio_AnuncioId",
                table: "ValorAnuncio",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_ValorAnuncio_FormaPagamentoId",
                table: "ValorAnuncio",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disponibilidade");

            migrationBuilder.DropTable(
                name: "ValorAnuncio");

            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "FormaPagamento");
        }
    }
}
