using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propriedades
        public DbSet<Entidades.Produto> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319382\SQLEXPRESS03;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            opcaoDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Entidades.Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDoProduto);
                entidade.Property(e => e.ValorDoProduto);
            }
            );
        }
    }
}
