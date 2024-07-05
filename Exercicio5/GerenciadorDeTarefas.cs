using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class GerenciadorDeTarefas
    {
        private List<Tarefa> _tarefas;

        public GerenciadorDeTarefas()
        {
            _tarefas = new List<Tarefa>();
        }

        public GerenciadorDeTarefas(List<Tarefa> tarefas)
        {
            _tarefas = tarefas;
        }

        public void AddTarefa(Tarefa tarefa)
        {
            _tarefas.Add(tarefa);   
        }

        public Tarefa? GetTarefa(int id)
        {
            return _tarefas.Where(x => x.Id == id).FirstOrDefault();
        }

        public void RemoveTarefa(int id)
        {
            var tarefa = GetTarefa(id);
            if (tarefa == default(Tarefa)) return;

            _tarefas.Remove(tarefa);
        }

        public void ListarTarefa()
        {
            foreach(var tarefa in _tarefas)
            {
                Console.WriteLine(tarefa.ToString() + "\n");
            }
        }

        public void ListarTarefasParaHoje()
        {
            foreach (var item in _tarefas.Where(x => x.DataVencimento.Date == DateTime.Now.Date))
            {
                Console.WriteLine(item.ToString() + "\n");
            }
        }
    }
}
