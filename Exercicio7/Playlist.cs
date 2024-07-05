using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Playlist
    {
        private static Random _rng = new Random();
        private Repository<Musica> _repository;

        public Playlist()
        {
            _repository = new Repository<Musica>();
        }

        public void TocarMusica(int id)
        {
            var musica = _repository.GetById(id) ?? throw new ArgumentException("Musica nao encontrada");

            Console.WriteLine(musica + "\n");
        }

        public Musica AdcionarMusica(string nome, string autor, string gravadora)
        {
            var musica = new Musica()
            {
                Id = _repository.GetAll().Count + 1,
                Nome = nome,
                Autor = autor,
                Gravadora = gravadora
            };

            _repository.Add(musica);

            return musica;
        }

        public void TocarMusicaNoAleatorio()
        {
            var musicasAleatorias = _repository.GetAll().OrderBy(_ => _rng.Next());
            foreach(var musica in musicasAleatorias)
            {
                Console.WriteLine(musica + "\n");
            }
        }

        public void TocarMusicas()
        {
            foreach(var musica in _repository.GetAll())
            {
                Console.WriteLine(musica + "\n");
            }
        }
    }
}
