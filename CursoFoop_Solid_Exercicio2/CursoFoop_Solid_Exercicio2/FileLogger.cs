using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class FileLogger: ILogger
    {
        public FileLogger() { }

        public void Registrar(string mensagem)
        {
            Console.WriteLine("Registrado em arquivo" + mensagem);
        }
    }
}
