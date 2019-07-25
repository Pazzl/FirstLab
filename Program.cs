using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int MIN_ARRAY_VALUE = 2;
            bool isStringOk = false;
            int[] intArray = { };
            do
            {
                Console.Write("Enter numbers separate by the sapce: ");
                string stringArray = Console.ReadLine();
                try
                {
                    intArray = Array.ConvertAll<string, int>(stringArray.Split(' '), int.Parse);
                    if (intArray.Length < MIN_ARRAY_VALUE)
                    {
                        Console.WriteLine("You should enter minimum 2 numbers! Please try again.");
                    }
                    else
                    {
                        isStringOk = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Input is not correct! Please try again.");
                    isStringOk = false;
                }

            } while (!isStringOk);


            FindMinMaxWithForLoop(intArray);
            FindMinMaxWithDoWhileLoop(intArray);
            FindMinMaxWithWhileLoop(intArray);


            Console.ReadKey();
        }

        private static void FindMinMaxWithForLoop(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;
            int minValue = arr[0];
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                int tValue = arr[i];
                if (minValue > tValue)
                {
                    minValue = tValue;
                    minIndex = i;
                }

                if (maxValue < tValue)
                {
                    maxValue = tValue;
                    maxIndex = i;
                }
            }
            Console.WriteLine("For loop:");
            Console.WriteLine("Minimum value is {0}, and index of minimum value is {1}", minValue, minIndex);
            Console.WriteLine("Maximum value is {0}, and index of maximum value is {1}", maxValue, maxIndex);
            Console.WriteLine();
        }

        private static void FindMinMaxWithDoWhileLoop(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;
            int minValue = arr[0];
            int maxValue = arr[0];
            int i = 1;

            do
            {
                int tValue = arr[i];
                if (minValue > tValue)
                {
                    minValue = tValue;
                    minIndex = i;
                }

                if (maxValue < tValue)
                {
                    maxValue = tValue;
                    maxIndex = i;
                }

                i++;
            } while (i < arr.Length);

            Console.WriteLine("Do-While loop:");
            Console.WriteLine("Minimum value is {0}, and index of minimum value is {1}", minValue, minIndex);
            Console.WriteLine("Maximum value is {0}, and index of maximum value is {1}", maxValue, maxIndex);
            Console.WriteLine();

        }

        private static void FindMinMaxWithWhileLoop(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;
            int minValue = arr[0];
            int maxValue = arr[0];
            int i = 1;

            while (i < arr.Length)
            {
                int tValue = arr[i];
                if (minValue > tValue)
                {
                    minValue = tValue;
                    minIndex = i;
                }

                if (maxValue < tValue)
                {
                    maxValue = tValue;
                    maxIndex = i;
                }

                i++;
            }

            Console.WriteLine("While loop:");
            Console.WriteLine("Minimum value is {0}, and index of minimum value is {1}", minValue, minIndex);
            Console.WriteLine("Maximum value is {0}, and index of maximum value is {1}", maxValue, maxIndex);
            Console.WriteLine();
        }
    }
}
