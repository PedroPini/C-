using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array of integers that will be used for searching
            int[] arrLinearSearch = { 2, 3, 4, 5, 8, 10 };
            int searchTerm = 8;
            int result = BinarySearch(arrLinearSearch, searchTerm, 0, arrLinearSearch.Length - 1);

            if (result != -1)
            {
                Console.WriteLine($"Search term found at index {result}.");
            }
            else
            {
                Console.WriteLine("Search term not found in the array.");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] arr, int key, int first, int last)

        {

            while (first <= last)

            {

                int mid = (first + last) / 2;


                if (key == arr[mid])

                {

                    return mid;

                }

                else if (key < arr[mid])

                {

                    last = mid - 1;

                }

                else

                {

                    first = mid + 1;

                }

            }

            return -1;

        }
    }
}
