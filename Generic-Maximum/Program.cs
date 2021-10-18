using System;

namespace Generic_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12,4,36,11,23,41,25 };
            GenericMax<int> generic = new GenericMax<int>(array);
            generic.PrintMax();


           
        }
        
    }
}
