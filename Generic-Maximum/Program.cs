using System;

namespace Generic_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value :");
            int FirstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Value :");
            int SecondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Value :");
            int ThirdValue = int.Parse(Console.ReadLine());
            int maxInteger = MaximumInt(FirstValue,SecondValue,ThirdValue);
            Console.WriteLine("Maximum Integer : " + maxInteger);
        }
        public static int MaximumInt(int FirstValue,int SecondValue,int ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                return FirstValue;
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
                return SecondValue;
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                return ThirdValue;
            return 0;
        }
    }
}
