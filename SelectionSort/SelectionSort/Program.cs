using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare an array of integer
            int[] array = { 7, 8, 4, 6, 2, 1};

            //Output the value before sorting
            Console.WriteLine("Array before Sort:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            //create variable to keep the track of minimum value
            int minPos;

            //aux is used to swapp the values for the sort
            int aux;

            //outer loop will ensure we iterated the entire array
            for (int i =0; i < array.Length - 1; i++)
            {
                //set the minPos to the counter value for traversing the array
                minPos = i;

                //inner loop will perform the comparisons between the min and the other values
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPos])
                    {
                        //minPos change his value with j position, because the value found is smaller
                        minPos = j;
                    }
                }

                //if minPos no longer equals i, it indicates a smaller value existed so a swap must take place to sort the values
                if (minPos != i)
                {
                    aux = array[i];
                    array[i] = array[minPos];
                    array[minPos] = aux;
                }
            }

            Console.WriteLine("\n\nArray after Sort: ");

            foreach (int val in array)
            {
                Console.Write(val + ",");
            }
            Console.ReadLine();
            
        }
    }
}
