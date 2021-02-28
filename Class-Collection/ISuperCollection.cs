using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Collection
{
    public interface ISuperCollection<T>
    {
        void AddElement(T element);
        void RemoveElement();
        void RemoveAll();
        T BinarySearch();
    }
}
