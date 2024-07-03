// See https://aka.ms/new-console-template for more information
using Exercicio1;

Console.WriteLine("Hello, World!");


var KodakPortra = new Produto("Kodak Portra", 109, 10);

KodakPortra.AdicionarItemAoEstoque(2);

Console.WriteLine($"{KodakPortra.Nome} - Quantidade em estoque: {KodakPortra.Estoque}");

KodakPortra.RemoverItensDoEstoque(1);

Console.WriteLine($"{KodakPortra.Nome} - Quantidade em estoque: {KodakPortra.Estoque}");


try
{
    KodakPortra.AdicionarItemAoEstoque(-1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

