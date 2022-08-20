using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " + 
                                 "VALUES('Normal','Lanches feito com Ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(Name, Description) " +
                                 "VALUES('Natural','Lanches feito com ingredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
