using System;
using System.Collections.Generic;
using System.Text;

namespace cursoFoop_Exercicio_SOLID1
{
    public class ExportaClientesCsv: IExportaClientes
    {

        public ExportaClientesCsv()
        {
        }

        public string ExportaClientes(List<Cliente> clientes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in clientes)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
