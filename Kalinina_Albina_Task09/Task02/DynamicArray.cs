using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{

    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] data;

        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        public int Length
        {
            get; private set;
        }

        public void DisplayArray(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

                Console.WriteLine();
            }
        }

        public DynamicArray()
        {
            data = new T[8];
        }

        public DynamicArray(int length)
        {
            data = new T[length];
        }

        public DynamicArray(T[] array)
        {
            data = array;
        }

        public void Add(T elem)
        {
            Insert(elem, Length);
        }

        public void AddRange(T[] array)
        {
            if (Capacity < Length + array.Length)
            {
                Array.Resize(ref data, Length + array.Length);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        public bool Remove(T elem)
        {
            int elemToRemoveIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                if (data[i].Equals(elem))
                {
                    elemToRemoveIndex = i;
                }
            }

            if (elemToRemoveIndex > -1)
            {
                for (int i = elemToRemoveIndex; i < Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }

                Length--;
                return true;
            }

            return false;
        }

        public void Insert(T elem, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Length == Capacity)
            {
                Array.Resize(ref data, Capacity * 2);
            }

            for (int i = Length - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = elem;
            Length++;
        }

      
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                if (index > -1 && index < Length)
                {
                    return data[index];
                }

                throw new ArgumentOutOfRangeException();
            }

            set
            {
                if (index > -1 && index < Length)
                {
                    data[index] = value;
                }

                throw new ArgumentOutOfRangeException();
            }
        }


        public class MyEnumerator<T> : IEnumerator<T>
        {
            public T Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}



