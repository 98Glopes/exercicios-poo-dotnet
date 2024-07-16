using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public class CalcularImpostoEUA: ICalcularImposto
    {
        public decimal Calcular(decimal valor, decimal deducao)
        {
            Console.WriteLine("Regras Imposto do EUA");
            return 0;
        }
    }
}
