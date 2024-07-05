using System.Net.Http.Headers;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tarefa1 = new Tarefa()
            {
                DataVencimento = DateTime.Parse("2024-07-10"),
                Descricao = "Aprender Java",
                Id = 1,
            };

            var tarefa2 = new Tarefa()
            {
                DataVencimento = DateTime.Parse("2024-07-05"),
                Descricao = "Aprender Python",
                Id = 2
            };

            var tarefa3 = new Tarefa()
            {
                DataVencimento = DateTime.Now.Date,
                Descricao = "Aprender .Net Core",
                Id = 3
            };

            var tarefasIniciais = new List<Tarefa>() { tarefa1, tarefa2};

            var gerenciadorDeTarefas = new GerenciadorDeTarefas(tarefasIniciais);

            gerenciadorDeTarefas.AddTarefa(tarefa3);

            gerenciadorDeTarefas.ListarTarefa();

            gerenciadorDeTarefas.ListarTarefasParaHoje();

            gerenciadorDeTarefas.RemoveTarefa(3);

            gerenciadorDeTarefas.ListarTarefasParaHoje();
        }
    }
}
