using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Repository<T> where T : IEntity
    {
        private readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            items.Add(item);
        }

        public bool Remove(string id)
        {
            var item = FindById(id);
            if (item == null) return false;
            return items.Remove(item);
        }

        public T FindById(string id)
        {
            return items.FirstOrDefault(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }

        public List<T> GetAll()
        {
            return items.ToList();
        }
    }
}
