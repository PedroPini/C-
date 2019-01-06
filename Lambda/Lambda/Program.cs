using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
       delegate void operacao(int x, int y);
        static void Main(string[] args)
        {
            operacao divi = (x, y) =>
            {
                Console.WriteLine("DIVISAO");
                Console.WriteLine(x / y);
            };
            divi(6, 3);
            divi(8, 2);

            divi = (x, y) =>
            {
                Console.WriteLine("Multiplicacao");
                Console.WriteLine(x * y);
            };
            divi(6, 3);

            //acha o indice do elemento impar na lista
            List<int> elements = new List<int>() { 10, 20, 40, 31 };
            int oddIndex = elements.FindIndex(elementos => elementos % 2 != 0);
            Console.WriteLine("\nLISTA");
            Console.WriteLine(oddIndex);
            //Console.ReadLine();
        }
    }
}
