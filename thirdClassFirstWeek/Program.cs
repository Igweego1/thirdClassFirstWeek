using System;

namespace thirdClassFirstWeek
{
    internal class Program
    {
        static void Main()

        {
            int[] numbers = new int[] { 9, 3, 88, 45 };

            numbers[3] = numbers[3] + 1;
            numbers[2] = numbers[0];

            Console.WriteLine(numbers[1]);

            bool[] boolarray = new bool[] { true, true, true };

          

        }
    }  
}
