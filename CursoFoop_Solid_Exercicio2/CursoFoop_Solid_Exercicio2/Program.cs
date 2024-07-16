using System;

namespace CursoFoop_Solid_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger();

            var pedidos = new Pedido(consoleLogger);

            pedidos.AdicionarPedido();

            pedidos = new Pedido(fileLogger);

            pedidos.AdicionarPedido();
        }
    }
}
