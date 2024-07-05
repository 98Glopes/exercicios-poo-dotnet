using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Musica: IQueryItem
    {
        public int Id { get; set; }
        public string Nome {  get; set; }
        public string Autor { get; set; }
        public string Gravadora {  get; set; }

        public override string ToString()
        {
            return $"#{Id} - {Nome}";
        }
    }
}
