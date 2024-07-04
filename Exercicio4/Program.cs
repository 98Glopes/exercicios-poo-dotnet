namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contato1 = new Contato()
            {
                Nome = "Feliz",
                Email = "feliz@alegria.com",
                Telefone = "1234-4567"
            };

            var contato2 = new Contato()
            {
                Nome = "Leite",
                Email = "leite@laticionios.com",
                Telefone = "7070-7070"
            };

            var agenda = new AgendaTelefonica();

            agenda.AdicionarContato(contato1);
            agenda.AdicionarContato(contato2);

            agenda.ListarContatos();

            agenda.RemoverContato("Feliz");

            agenda.ListarContatos();
        }
    }
}
