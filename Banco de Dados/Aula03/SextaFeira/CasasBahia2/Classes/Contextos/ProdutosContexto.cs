using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class ProdutosContexto : DbContext
    {
        //Propriedades
        public DbSet<Produtos> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"server=ECFP507D1319382\SQLEXPRESS03;database=ProdutosCasasBahia;trusted_connection=true;trustServerCertificate=true;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produtos>(entidade => {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDoProduto);
                entidade.Property(e => e.ValorDoProduto);
            }
            );
        }
    }
}