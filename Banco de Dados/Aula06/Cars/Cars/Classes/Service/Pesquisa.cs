using Microsoft.IdentityModel.Tokens;
using Cars.Classes.Contextos;
using Cars.Classes.Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace Cars.Classes.Service
{
    internal static class Pesquisa
    {
        //Campo
        static EstoqueContexto contexto = new EstoqueContexto();

        //Métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1, string filtro)
        {
            if (moto.Equals(false) & carro.Equals(false))
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque);

                }
                else
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
                }

            }
            else if (moto.Equals(true) & carro.Equals(false))
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 2));
                }
                else
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 2 && e.Modelo.Contains(texto)));
                }
            }
            else
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 1));
                }
                else
                {
                    dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 1 && e.Modelo.Contains(texto)));
                }
            }
        }
        private static void Filtro(string texto, DataGridView dataGridView1, string filtro)
        {
            if (texto.IsNullOrEmpty())
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque);
            }
            else if (filtro.Equals("Contém"))
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
            }
            else if (filtro.Equals("Inicia"))
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
            }
        }
        /// <summary>
        /// Métodos auxiliar responsável pela projeção em todas as pesquisas
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        private static object Projetar(IQueryable<Estoque> consulta){
            return consulta.Select(e => new {
                e.Tipo,
                e.Modelo,
                Valor = e.Valor.ToString("C"),
                e.Quantidade
            }).ToList();
        }
    }
}