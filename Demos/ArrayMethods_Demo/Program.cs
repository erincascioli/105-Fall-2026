using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = {3, 25, 27, 42, 13, 87, 777};
            int[] numbers2 = {3, 25, 27, 42, 13, 87, 777 };
            int[] numbers3 = {3, 25, 27, 42};
            string[] fruits = {"banana", "starfruit", "apple", "tomato"};

            Console.WriteLine("Array 1:");
            PrintArray(numbers1);

            Console.WriteLine("Array 2:");
            PrintArray(numbers2);

            Console.WriteLine("Array 3:");
            PrintArray(numbers3);

            Console.WriteLine("Fruits Array:");
            PrintArray(fruits);

            /*
            //Console.WriteLine(numbers); // NOOOOOO

            //Console.WriteLine("These are the values in my numbers array: ");
            //PrintArray(numbers);
            //Console.WriteLine("These are the values in my numbers2 array: ");
            //PrintArray(numbers2);
            //Console.WriteLine("These are the values in my numbers3 array: ");
            //PrintArray(numbers3);

            //Console.WriteLine("These are my fruits:");
            //PrintArray(fruits);
            */
        }

        /// <summary>
        /// Print all array values to the console window, where data is tabbed from the left.
        /// </summary>
        /// <param name="intArray">Any sized array of integers</param>
        public static void PrintArray(int[] intArray)
        {
            // Iterate through all elements in the array
            for (int i = 0; i < intArray.Length; i++)
            {
                // Print each element, aligned 8 spaces from the left, like so:
                // "        #"
                Console.WriteLine("\t" + intArray[i]);
            }
        }

        /// <summary>
        /// Overload of the PrintArray method, prints any sized string array.
        /// </summary>
        /// <param name="stringArray">Array of strings</param>
        public static void PrintArray(string[] stringArray)
        {
            // Iterate through all elements in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                // Print each element, aligned 8 spaces from the left, like so:
                // "        #"
                Console.WriteLine("\t" + stringArray[i]);
            }
        }

        // {64, 12, 19, 76, 4, 29}

        /// <summary>
        /// Description
        /// </summary>
        /// <param name="array">Description</param>
        /// <returns>Description</returns>
        public static int FindMinimumValue(int[] array)
        {
            int smallest = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                    smallest = array[i];
            }

            return smallest;
        }

        /*
        /// <summary>
        /// Print the values of any length integer array. Data is indented by tab.
        /// </summary>
        /// <param name="intArray">Array of integers</param>
        public static void PrintArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("\t" + intArray[i]);
            }
        }

        /// <summary>
        /// Print the values of any length string array. Data is indented by tab.
        /// </summary>
        /// <param name="stringArray">Array of strings</param>
        public static void PrintArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("\t" + stringArray[i]);
            }
        }

        public static int FindMinimumValue(int[] intArray)
        {
            int minValue = intArray[0];

            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < minValue)
                    minValue = intArray[i];
            }

            return minValue;
        }
        */

        /*
        public static int FindMaximumValue(int[] intArray)
        {
            // WHAT IS THE PROCESS TO FIND THE MINIMUM VALUE?
            return _____;
        }
        */

    }
}
