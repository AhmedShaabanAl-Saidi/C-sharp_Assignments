using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class FixedSizeList<T>
    {
        public T[] Items { get; set; }
        public int Count { get; set; }

        public FixedSizeList(int capacity)
        {
            Items = new T[capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count < Items.Length)
            {
                Items[Count] = item;
                Count++;
            }
            else
                throw new InvalidOperationException("Cannot add more items. The list is full.");
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("Index is out of range.");
            return Items[index];
        }
    }
}
