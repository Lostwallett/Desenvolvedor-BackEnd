using Biblioteca.Interfaces;

namespace Biblioteca.Classes.Entidades;

internal class Item : IMovimentacao, IInformacoes
{
    //Campos
    private string titulo;
    private DateTime anopublicacao;
    private int quantidade;

    //Propriedades
    protected string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
    protected DateTime AnoPublicacao
    {
        get { return anopublicacao; }
        set { anopublicacao = value; }
    }
    protected int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }

    //Construtores
    public Item(string titulo, DateTime anoPublicacao)
    {
        Titulo = titulo;
        AnoPublicacao = anoPublicacao;
        Quantidade = 0;
    }
    public Item(string titulo, DateTime anoPublicacao, int quantidade) : this(titulo, anoPublicacao)
    {
        Quantidade = quantidade;
    }

    //Métodos
    void IMovimentacao.Devolver(int quantia)
    {
        Quantidade += quantia;
    }

    void IMovimentacao.Emprestar(int quantia)
    {
        Quantidade -= quantia;
    }
    public virtual string Exibir()
    {
         return ($"Dados do item:\n" +
            $"\tTítulo: {Titulo}.\n" +
            $"\tAno de Publicação: {AnoPublicacao}.\n" +
            $"\tQuantidade Disponível: {Quantidade}");
    }
}