namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imovel1 = new Imovel()
            {
                Id = 1,
                Endereco = "Rua dotmet",
                Preco = 270,
                Tipo = TipoDeImovel.Casa
            };

            var imovel2 = new Imovel()
            {
                Id = 2,
                Endereco = "Rua Java",
                Preco = 50,
                Tipo = TipoDeImovel.Chacara
            };

            var imovel3 = new Imovel()
            {
                Id = 3,
                Endereco = "Rua Python",
                Preco = 300,
                Tipo = TipoDeImovel.Apartamento
            };

            var corretorDeImoveis = new CorretorDeImovel();

            corretorDeImoveis.AdcionarImovel(imovel1);
            corretorDeImoveis.AdcionarImovel(imovel3);
            corretorDeImoveis.AdcionarImovel(imovel2);

            corretorDeImoveis.VerImoveis();

            Console.WriteLine($"Media de Precos: {corretorDeImoveis.CalcularMediaDePrecos()}\n");

            // Altera preco imovel 2

            corretorDeImoveis.AlterarPrecoDoImovel(2, 20);

            corretorDeImoveis.VerImoveis();

            Console.WriteLine($"Media de Precos: {corretorDeImoveis.CalcularMediaDePrecos()}\n");
        }
    }
}
