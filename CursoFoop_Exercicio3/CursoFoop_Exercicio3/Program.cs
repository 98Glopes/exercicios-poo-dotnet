using System;

namespace CursoFoop_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var impostoBrasil = new CalcularImpostoBrazil();
            var impostoEUA = new CalcularImpostoEUA();

            Console.WriteLine(impostoBrasil.Calcular(10, 1));
            Console.WriteLine(impostoEUA.Calcular(10, 1));
        }
    }
}
