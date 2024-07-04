using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class RegistroDeCompras
    {
        private List<Compra> _compras = new List<Compra>();

        public void AdcionarCompras(Compra compra)
        {
            _compras.Add(compra);
        }

        public void ListarCompras()
        {
            foreach (Compra compra in _compras)
            {
                compra.ListarCompra();
                Console.WriteLine("");
            }
        }
    }
}
