using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inputs;

namespace Class_Collection
{
    public class SuperCollection<T> : IEnumerator, IEnumerable, ISuperCollection<T>
    {
        private T[] array;
        int index = 0;

        public SuperCollection()
        {
            array = new T[10];
        }

        public object Current
        {
            get
            {
                return array[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            if (index < array.Length)
            {
                index++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            index = 0;
        }

        public void AddElement(T element)
        {
            if (index == array.Length)
            {
                Array.Resize<T>(ref array, array.Length * 2);
            }
            array[index] = element;
            index++;
        }

        public void RemoveElement()
        {
            int id = 0;
            index = GetElementIndex(ref id);

            if(index > Count() - 1)
            {
                Console.WriteLine("Wrong id!");
                return;
            }

            for (int i = index; i <= Count(); i++)
            {
                array[i] = array[i + 1];
            }
        }
        int GetElementIndex(ref int index)
        {
            Console.WriteLine("Input element id");
            index = NumbersInput.Integer("Index: ");
            return index;
        }

        public void RemoveAll()
        {
            array = null;
        }

        public T BinarySearch()
        {
            int id = 0;
            index = GetElementIndex(ref id);

            int leftRange = 0;
            int rightRange = array.Length - 1;
            if (id < leftRange || id > rightRange)
            {
                Console.WriteLine("Wrong id!");
                return default;
            }

            int middle = 0;
            while (true)
            {
                middle = (leftRange + rightRange) / 2;

                if (id == middle) return array[id];

                if (id < middle)
                {
                    rightRange = middle;
                }

                if (id > middle)
                {
                    leftRange = middle;
                }
            }
        }

        public ref T[] GetArray()
        {
            return ref array;
        }

        //retun number of elements != null
        public int Count()
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) break;
                count++;
            }

            return count;
        }

        public bool IsEmoty()
        {
            return (array[0] == null);
        }
    }
}
