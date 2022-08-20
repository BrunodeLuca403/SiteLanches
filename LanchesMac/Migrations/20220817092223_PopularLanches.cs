using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId ,Name, DescriptionSmall, DescriptionLong, Price, ImageBig, ImageSmall, IsFavorite, InStrock) VALUES (1, 'XTradiconal' ,'Pão, Hamburguer, Ovo, Presunto, Queijo e batata', 'Lanche delicioso preparado na hora muito saboroso com ingredientes selecionados', 22.00,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 1, 1 )");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId ,Name, DescriptionSmall, DescriptionLong, Price, ImageBig, ImageSmall, IsFavorite, InStrock) VALUES (2, 'XNatural' ,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte', 'Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.', 30.00,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 1 )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
