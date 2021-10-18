using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Maximum
{
    class GenericMax<T> where T : IComparable
    {
        public T[] array;
        public GenericMax(T[] array)
        {
            this.array = array;
        }

        public T[] SortValues(T[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
        public T GetMaximumValue()
        {
            var sortedValues = SortValues(this.array);
            return sortedValues[0];
        }
    }
}
