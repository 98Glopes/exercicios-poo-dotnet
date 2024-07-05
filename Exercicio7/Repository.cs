using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Repository<T> where T : IQueryItem
    {
        protected List<T> _list;

        public Repository() 
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public T? GetById(int id)
        {
            return _list.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _list;
        }
    }
}
