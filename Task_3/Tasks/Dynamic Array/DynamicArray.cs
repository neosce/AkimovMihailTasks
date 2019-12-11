using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_3.Tasks.Dynamic_Array
{
    public class DynamicArray<T>: IEnumerable<T>, IEnumerable, ICloneable
    {

        const int defaultCapacity = 8;
        private T[] items = default;

        /// <summary>
        /// The number of stored items in the array (default 0)
        /// </summary>
        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                return index < 0 ? items[Count + index] : items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        /// <summary>
        /// The size of the array (the number of elements that are initially created in it) (default 8)
        /// </summary>
        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }

        public DynamicArray()
        {
            items = new T[defaultCapacity];
        }

        public DynamicArray(int capacity)
        {
            items = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> items)
        {
            if (items == null)
            {
                throw new InvalidOperationException();
            }
            this.items = new T[items.Count()];
            Array.Copy((T[])items, this.items, items.Count());
        }

        public void Add(T item)
        {
            if (items.Length == Count)
            {
                T[] largerArray = new T[items.Length * 2];
                Array.Copy(items, largerArray, Count);

                items = largerArray;
            }
            else if (item == null)
            {
                throw new InvalidOperationException();
            }
            items[Count++] = item;
        }

        public void Clear()
        {
            items = new T[0];
        }

        public bool Remove(int index)
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    items[i] = default;
                    return true;
                }
            }
            return false;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    items[i] = default;
                    return true;
                }
            }
            return false;
        }

        public void Insert(int index, T item)
        {
            if ((Count + 1 <= items.Length) && (index < Count) && (index >= 0))
            {
                Count++;

                for (int i = Count - 1; i > index; i--)
                {
                    items[i] = items[i - 1];
                }
                items[index] = item;
            }
        }

        public object Clone()
        {
            return (DynamicArray<T>)MemberwiseClone();
        }

        public object ToArray()
        {
            if (items == null)
            {
                throw new ArgumentNullException("source is null");
            }

            T[] newItems = new T[items.Length];
            Array.Copy(items, newItems, Count);

            newItems = items;

            return newItems;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

    }

    public class DynamicArrayEnumerator<T>: IEnumerator<T>, IDisposable
    {

        private T[] array;
        private int position = -1;
        public DynamicArrayEnumerator(T[] array)
        {
            this.array = array;
        }

        public T Current 
        {
            get
            {
                try
                {
                    return array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        //object IEnumerator.Current => throw new NotImplementedException();
        object IEnumerator.Current
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }

            return false; 
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }

    }
}
