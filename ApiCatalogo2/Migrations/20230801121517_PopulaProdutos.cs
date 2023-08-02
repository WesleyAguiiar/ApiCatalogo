using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo2.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Coca-Cola Diet', 'Refrigerante de Cola 350ml', 5.45, 'cocacola.jpg',50,now(), 1)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Lanche de Atum', 'Lanche de Atum com maionese', 8.5, 'atum.jpg',10,now(), 2)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg',20,now(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}