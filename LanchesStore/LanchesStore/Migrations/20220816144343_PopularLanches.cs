using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesStore.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferio, EmEstoque) " +
                                 "VALUES(1, 'X-Tudo', 'Sanduiche feito com ingredientes naturais', 'Pão, hamburguer, Ovo, Maionese', 5.50, 'http://www.google.com.br/imagem1.jpg', 'http://www.google.com.br/imagem2.jpg', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferio, EmEstoque) " +
                                 "VALUES(1, 'X-Salada', 'Sanduiche feito com ingredientes naturais', 'Pão, hamburguer, Ovo, Alface, Tomate, Cebola', 7.50, 'http://www.google.com.br/imagem1.jpg', 'http://www.google.com.br/imagem2.jpg', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferio, EmEstoque) " +
                                 "VALUES(2, 'X-Egg', 'Sanduiche simples', 'Pão, hamburguer, Ovo', 3.50, 'http://www.google.com.br/imagem1.jpg', 'http://www.google.com.br/imagem2.jpg', 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
