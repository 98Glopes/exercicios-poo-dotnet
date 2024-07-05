namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playlist = new Playlist();
            var stop = true;

            do
            {
                Console.WriteLine("\n\nMonte sua Playlist - Digite sua Instrução:");
                Console.WriteLine("1 - Adicionar musica a playlist");
                Console.WriteLine("2 - Tocar Playlist");
                Console.WriteLine("3 - Tocar Playlist no aleatório");
                Console.WriteLine("4 - Sair\n");

                Console.Write("Digite sua opção: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("\nDigite o Nome: ");
                        var nome = Console.ReadLine();

                        Console.Write("\nDigite o Autor: ");
                        var autor = Console.ReadLine();

                        Console.Write("\nDigite Gravadora: ");
                        var gravadora = Console.ReadLine();

                        var musica = playlist.AdcionarMusica(nome, autor, gravadora);

                        Console.WriteLine($"Adcionado {musica} a playlist");
                        break;

                    case "2":
                        playlist.TocarMusicas();
                        break;

                    case "3":
                        playlist.TocarMusicaNoAleatorio();
                        break;

                    case "4":
                        stop = false;
                        break;

                    default:
                        break;
                }

            } while (stop);


        }
    }
}
