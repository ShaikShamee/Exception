using System;

namespace Task
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // Display values of array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {

                // Try to access invalid index of array
                Console.WriteLine(arr[7]);
                // An exception is thrown upon executing
                // the above line
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

           //different type of exception
            int[] arr1 = { 19, 0, 75, 52 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i] / arr1[i + 1]);
                }
            }

            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(" {0}", arr1[i]);
                }
            }


            Console.ReadLine();

        }
    }
}
