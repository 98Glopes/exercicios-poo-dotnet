namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produto()
            {
                Codigo = "K1",
                Preco = 10,
                Nome = "Kodak Portra",
                Quantidade = 1
            };

            var produto2 = new Produto()
            {
                Codigo = "K2",
                Preco = 10,
                Nome = "Kodak Vision",
                Quantidade = 1
            };

            var produto3 = new Produto()
            {
                Codigo = "F1",
                Preco = 10,
                Nome = "Fuji Superia",
                Quantidade = 1
            };

            var compra1 = new Compra("123", new List<Produto>() { produto1, produto2, produto3 });
            var compra2 = new Compra("124", new List<Produto>() { produto3 });
            var compra3 = new Compra("125", new List<Produto>() { produto3, produto2 });

            var registroDeCompras = new RegistroDeCompras();

            registroDeCompras.AdcionarCompras(compra1);
            registroDeCompras.AdcionarCompras(compra2);
            registroDeCompras.AdcionarCompras(compra3);

            registroDeCompras.ListarCompras();
        }
    }
}
