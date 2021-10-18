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
        public T GetMaximumValue(T[] array)
        {
            var sortedValues = SortValues(this.array);
            return sortedValues[0];
        }
        public void PrintMax()
        {
            var max = GetMaximumValue(this.array);
            Console.WriteLine("Maximum value is : " +max);
            
        }
    }
}
