using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class CorretorDeImovel
    {
        private List<Imovel> _imoveis;

        public CorretorDeImovel()
        {
            _imoveis = new List<Imovel>();
        }

        public void AdcionarImovel(Imovel imovel) 
        {
            _imoveis.Add(imovel);
        }

        public decimal CalcularMediaDePrecos()
        {
            if (_imoveis.Count == 0) return 0;
            return _imoveis.Select(x => x.Preco).Sum() / _imoveis.Count;
        }

        public void AlterarPrecoDoImovel(int codigo, decimal novoPreco)
        {
            var imovel = _imoveis.Where(x => x.Id == codigo).FirstOrDefault();
            if (imovel == default(Imovel)) return;

            imovel.Preco = novoPreco;
        }

        public void VerImoveis()
        {
            foreach(var imovel in _imoveis)
            {
                Console.WriteLine(imovel.ToString());
                Console.WriteLine();
            }
        }
    }
}
