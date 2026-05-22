using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KR22.Program;

namespace KR22
{
    public class Storage<T>
    {
        public delegate void ItemEventHadler<T>(T item);

        public List<T> items = new List<T>();

        public event ItemEventHadler<T> ItemAdded;
        public event ItemEventHadler<T> ItemSelected;

        public void Add(T item)
        {
            items.Add(item);
            ItemAdded?.Invoke(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public IEnumerable<T> Filter(IFilter<T> filter)
        {
            foreach (var item in items)
            {
                if (filter.Match(item))
                {
                    ItemSelected?.Invoke(item);
                    yield return item;
                }
            }
        }

    }
}
