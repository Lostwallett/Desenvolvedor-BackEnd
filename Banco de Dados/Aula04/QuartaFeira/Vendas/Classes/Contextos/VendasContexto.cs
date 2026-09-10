using Microsoft.EntityFrameworkCore;
using VendasSENAI.Classes.Entidades;

namespace VendasSENAI.Classes.Contextos
{
    internal class VendasSENAIContexto : DbContext
    {
        //Propriedades
        public DbSet<Vendas1> vendas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"server=ECFP507D1319382\SQLEXPRESS03;database=CamisasSENAI;trusted_connection=true;trustServerCertificate=true;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Vendas1>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.DataCompra);
                entidade.Property(e => e.Tipo);
                entidade.Property(e => e.Marca);
                entidade.Property(e => e.Faturamento);
                entidade.Property(e => e.Lucro);
            });
        }
    }
}