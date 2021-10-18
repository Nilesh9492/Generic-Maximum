using System;

namespace Generic_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12,4,36,11,23,41,25 };
            var maxVal = new GenericMax<int>(array).GetMaximumValue();
            Console.WriteLine("Maximum value = " + maxVal);

           
        }
        
    }
}
