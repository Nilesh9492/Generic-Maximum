using System;

namespace Generic_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Float Value :");
            double FirstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Float Value :");
            double SecondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Float Value :");
            double ThirdValue = double.Parse(Console.ReadLine());

            int maxInteger = MaximumInt(13, 12, 48);
            Console.WriteLine("Maximum Integer : " + maxInteger);

            double maxDouble = MaximumFloat(FirstValue,SecondValue,ThirdValue);
            Console.WriteLine("Maximum Double  : " + maxDouble);


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
        public static double MaximumFloat(double FirstValue, double SecondValue, double ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                return FirstValue;
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
                return SecondValue;
            if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                return ThirdValue;
            return 0;
        }
    }
}
