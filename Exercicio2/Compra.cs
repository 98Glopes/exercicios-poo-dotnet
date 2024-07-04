using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Compra
    {
        public string Codigo { get; set; }
        public DateTime DataDeCompra { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Compra(string codigo, List<Produto> produtos) 
        {
            DataDeCompra = DateTime.Now;
            Produtos = produtos;
            Codigo = codigo;
        }

        public void ListarCompra()
        {
            Console.WriteLine($"Data da compra #{Codigo} - {DataDeCompra}");
            foreach ( Produto produto in Produtos )
            {
                Console.WriteLine($"#{produto.Codigo} {produto.Nome} - R$ {produto.Preco} - {produto.Quantidade}");
            }
        }
    }
}
