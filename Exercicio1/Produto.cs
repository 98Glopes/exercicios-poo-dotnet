using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Produto
    {
        private int _estoque;
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get { return _estoque; } }

        public Produto(string nome, decimal preco, int estoque)
        {
            Preco = preco;
            Nome = nome;
            _estoque = estoque;
        }

        public void AdicionarItemAoEstoque(int quantidadeParaAdicionar)
        {
            ValidarQuaatidadeDeItens(quantidadeParaAdicionar);

            _estoque += quantidadeParaAdicionar;
        }

        public void RemoverItensDoEstoque(int quantidadeParaRemover)
        {
            ValidarQuaatidadeDeItens(quantidadeParaRemover);

            _estoque -= quantidadeParaRemover;

        }

        private void ValidarQuaatidadeDeItens(int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new ArgumentException("Quantidade Invalida " + quantidade);
            }
        }
    }
}
