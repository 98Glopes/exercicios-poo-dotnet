using System;
using System.Collections.Generic;
using System.Text;

namespace cursoFoop_Exercicio_SOLID1
{
    public interface IExportaClientes
    {
        string ExportaClientes(List<Cliente> clientes);
    }
}
