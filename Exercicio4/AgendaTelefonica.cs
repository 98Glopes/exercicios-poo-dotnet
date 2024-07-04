using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class AgendaTelefonica
    {
        public List<Contato> _contatos {  get; set; }

        public AgendaTelefonica()
        {
            _contatos = new List<Contato>();  
        }

        public void AdicionarContato(Contato contato)
        {
            _contatos.Add(contato);
        }

        public void RemoverContato(string nome)
        {
            var contatoParaRemover = BuscaContato(nome);

            if (contatoParaRemover == default(Contato)) return;

            _contatos.Remove(contatoParaRemover);
        }

        public Contato BuscaContato(string nome)
        {
            return _contatos.Where(x => x.Nome == nome).FirstOrDefault() ?? throw new NullReferenceException("Contato nao encontrado");
        }

        public void ListarContatos()
        {
            foreach(var contato in _contatos)
            {
                Console.WriteLine(contato.ToString() + "\n");
            }
        }
    }
}
