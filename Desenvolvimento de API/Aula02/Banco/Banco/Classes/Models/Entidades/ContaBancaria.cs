using System.ComponentModel.DataAnnotations;

namespace Banco.Classes.Models.Entidades
{
    public class ContaBancaria
    {    
        /// <summary>
        /// Cria o número da conta bancária no database
        /// </summary>
        [Key]
        public int NumeroConta { get; set; }

        /// <summary>
        /// Cria o titular da conta bancária no database
        /// </summary>
        [Required]
        public string TitularConta { get; set; }

        /// <summary>
        /// Cria o saldo da conta e pode ser negativo ou zero
        /// </summary>
        [Required]
        public decimal Saldo { get; set; }


        public ContaBancaria(string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }
    }
}
