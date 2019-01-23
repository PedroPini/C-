using System;

namespace RecursiveFunction
{
    class Program
    {
        public static int CalculateSumRecursively(int number1, int m)
        {
            int sum = number1;

            if (number1 < m)
            {
                number1++;
                return sum += CalculateSumRecursively(number1, m);
            }

            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumRecursively(number1, m);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
