using System;

namespace Opposite_number_kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Opposite(number);



        }
        public static int Opposite(int number)
        {
            
            int oppositeResult = (number * -1);
            return oppositeResult;
        }
    }
}
