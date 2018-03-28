using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo7
{
    class NumberList<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count;

        public void Add(T item)
        {
            if(count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
