using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Imovel
    {
        public int Id;
        public string Endereco {  get; set; }
        public decimal Preco {  get; set; }
        public TipoDeImovel Tipo { get; set; }
        
        override public string ToString()
        {
            return $"#{Id} - {Endereco} - R$ {Preco}";
        }
    }


     
    public enum TipoDeImovel
    {
        Apartamento,
        Casa,
        Chacara

    }
}
