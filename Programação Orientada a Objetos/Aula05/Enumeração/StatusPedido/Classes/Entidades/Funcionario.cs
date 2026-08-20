namespace StatusPedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente
    internal class Funcionario
    {
        //1º - Campos
        private string nome;


        //2º - Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        //3º - Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }
    }
}
