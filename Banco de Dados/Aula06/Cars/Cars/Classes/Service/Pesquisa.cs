using Microsoft.IdentityModel.Tokens;
using Cars.Classes.Contextos;
using static System.Net.Mime.MediaTypeNames;

namespace Cars.Classes.Service
{
    internal static class Pesquisa
    {
        //Campo
        static EstoqueContexto contexto = new EstoqueContexto();

        //Métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1)
        {
            if (moto.Equals(false) & carro.Equals(false))
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = contexto.Estoque.Select(e => new {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();

                }
                else
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Modelo.Contains(texto)).Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();
                }

            }
            else if (moto.Equals(true) & carro.Equals(false))
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 1).Select(e => new {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();
                }
                else
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 1 && e.Modelo.Contains(texto)).Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();
                }
            }
            else
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 2).Select(e => new {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();
                }
                else
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 2 && e.Modelo.Contains(texto)).Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        Valor = e.Valor.ToString("C"),
                        e.Quantidade
                    }).ToList();
                }
            }
        }
    }
}
