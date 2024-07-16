using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public class CalcularImpostoBrazil: ICalcularImposto
    {
        public decimal Calcular(decimal valor, decimal deducao)
        {
            Console.WriteLine("Regras Imposto do Brasil");
            return 0;
        }
    }
}
