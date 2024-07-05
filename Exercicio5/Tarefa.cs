using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public override string ToString()
        {
            return $"#{DataVencimento} - {Descricao}";
        }
    }
}
