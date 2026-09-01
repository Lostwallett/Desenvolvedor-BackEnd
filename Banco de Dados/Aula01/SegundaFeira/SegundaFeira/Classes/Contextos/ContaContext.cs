using Microsoft.EntityFrameworkCore;
using SegundaFeira.Classes.Entidades;

namespace SegundaFeira.Classes.Contextos
{
    internal class ContaContext : DbContext
    {
        //Propriedade = Representa as contas no BD
        public DbSet<Conta> contas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string config = @"Server=localhost\SQLEXPRESS03;Database=BancoDBContas;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);
            });
        }
    }
}
