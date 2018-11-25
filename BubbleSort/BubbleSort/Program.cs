using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array of intenger
            int[] numbers = {5, 10, 3, 2, 4};

            //Printing array on preview order
            Console.WriteLine("Before: 5, 10, 3 , 2, 4 ");

            //declare auxiliary variable for swapp positions
            bool swapped;

            do
            {
                //to ensure at least one time the array was passad
                swapped = false;

                //this loop is responsible for iterating the array, we use minus 1 to stay on the correct order of array index 0 to 4 and not 1 to 5
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    //this conditional validate if the number value on interation is bigger than the next index position number value
                    if (numbers[i] > numbers[i + 1]) 
                    {
                        //if is bigger we create a temporary variable storing the smaller number
                        int temp = numbers[i + 1];
                        //we change the next variable with the preview biggest number
                        numbers[i + 1] = numbers[i];
                        //we change the current variable with the next smaller number
                        numbers[i] = temp;
                        //we changed swapp to true, because occured a change on our array
                        swapped = true;
                    }
                }
            } while (swapped == true); // verified if swapp variable is true, if it is false we go to next step

            //here we will list or changed array to  the corret Ascending Sort
            Console.WriteLine("After: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
            }

            Console.ReadLine();
        }              
    }
}
