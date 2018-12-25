using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array of integers that will be used for searching
            int[] searchArray = { 5, 10, 3, 2, 4 };
            int term = 4;
            int index = LinearSearch(searchArray, term);

            if (index != -1)
            {
                Console.WriteLine($"Your search term was found at position {index}");
            }
            else
            {
                Console.WriteLine("Your search term was not found.");
            }
            Console.ReadLine();

        }
        public static int LinearSearch(int[] arr, int term)
        {
            // set up a loop to iterate over the elements in the array
            // because this is a linear search, we start at the beginning
            // of the array and work through the elements looking for the term
            for (int i = 0; i < arr.Length; i++)
            {
                // if we found a match, we can return the index in the array where the term is
                if (arr[i] == term)
                {
                    return i;
                }
            }

            // if the term is not found, we reach the end of the array
            // and as a result, we return -1 indicating that the term wasn't found
            // at a valid index in the array.
            return -1;
        }
    }
}
