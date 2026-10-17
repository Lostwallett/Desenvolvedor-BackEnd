using System.ComponentModel.DataAnnotations;

namespace APIPessoas.Models.Entidades
{
    public class Produtos
    {
        //Propriedades
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Length(2, 15, ErrorMessage = "O campo nome deve ter entre 2 e 15 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo preço é obrigatório.")]
        [Range(0, 50000, ErrorMessage = "O preço deve estar entre 0 e 50.000.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo quantidade é obrigatório.")]
        [Range(0, 1000, ErrorMessage = "A quantidade deve estar entre 0 e 1000.")]
        public int Quantidade { get; set; }

    //Construtores
        public Produtos(string nome, decimal preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}