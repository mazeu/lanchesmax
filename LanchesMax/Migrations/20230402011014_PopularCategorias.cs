using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMax.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, CategoriaDescricao) " +
                "Values('Normal', 'Lanche feito com ingredientes normais.')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, CategoriaDescricao) " +
               "Values('Natural', 'Lanche feito com ingredientes naturais e integrais.')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
