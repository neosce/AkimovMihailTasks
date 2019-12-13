using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_3.Tasks.Dynamic_Array
{
    public class DynamicArrayEnumerator<T> : IEnumerator<T>, IDisposable
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
