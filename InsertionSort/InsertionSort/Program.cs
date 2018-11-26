using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an int array
            int[] numbers = { 7, 8, 4, 6, 2, 1};
            
            Console.WriteLine("Array before sort: 7, 8, 4, 6, 2, 1");
            //declaring int variable for store the next number
            int newValue;
            //loop interation. obs: no need to be lenght - 1(because we cant move the first element foward)
            for (int i = 1; i < numbers.Length; i++)
            {
                newValue = numbers[i];

                int j = i;
                //we use the same interator value to our inner loop, we compare if the previous number is bigger than the next number
                while (j > 0 && numbers[j - 1] > newValue)
                {
                    //if the number is bigger we change for the previous value
                    numbers[j] = numbers[j - 1];
                    j--;
                }
                //this is for the next interation to analyse if there is any run out of numbers in the array (j = 0) or there are no more values larger than
                // the current number (newValue) to it's left (preceding it).
                numbers[j] = newValue;
            }
            //Print our Result
            Console.WriteLine("Array after sort: ");
            foreach (int val in numbers)
            {
                Console.Write(val + ", ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
