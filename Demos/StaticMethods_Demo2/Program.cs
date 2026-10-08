
// Erin Cascioli
// 10/7/26
// Demo Static methods for section 6

namespace StaticMethods_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling methods that we've defined

            // ----------------------------------------------------------------
            // Calling methods with no parameters
            // ----------------------------------------------------------------
            PrintVisualDivider();
            PrintName();


            // ----------------------------------------------------------------
            // Calling methods with parameters
            // ----------------------------------------------------------------
            PrintVisualDivider();
            SumDouble(10, 20);
            SumDouble(12836, 273);


            // ----------------------------------------------------------------
            // Calling methods with parameters and return statement(s)
            // ----------------------------------------------------------------
            PrintVisualDivider();

            // When methods return values, you will typically want to do one of two
            //   things with those returned values:
            // 1. Save the returned value in a variable for future use.
            int product = MultiplyTwoValues(3, 4);          // 12
            Console.WriteLine(product);                     // Prints 12

            // 2. Use the returned variable as part of a statement or expression.
            Console.WriteLine(MultiplyTwoValues(3, 4));   // Prints 12

            Console.WriteLine(MultipleOfFive(12));
            Console.WriteLine(MultipleOfFive(25));
        }
        // END OF MAIN
        // Important: All static methods you write from here through week 10-ish will be HERE
        // All methods you write require XML comments!

        /// <summary>
        /// Prints a visually striking separator in the console window
        /// </summary>
        public static void PrintVisualDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("******************************");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Prints my name to the console window.
        /// </summary>
        public static void PrintName()
        {
            // TODO: You all "jazz" it up!
            // Change the colors, add characters, make it cooler! Take about 90 seconds.
            Console.WriteLine("Erin Cascioli");
            Console.WriteLine(" |----  |-   |   |\\    |");
            Console.WriteLine(" |      |  } |   | \\   |");
            Console.WriteLine(" |----  |/   |   |  \\  |");
            Console.WriteLine(" |      |\\   |   |   \\ |");
            Console.WriteLine(" |----  | \\  |   |    \\|");
        }

        /// <summary>
        /// Prints the sum of 2 values.
        /// </summary>
        /// <param name="firstValue">First value to be summed</param>
        /// <param name="secondValue">Second value to be summed</param>
        public static void SumDouble(int firstValue, int secondValue)
        {
            // Are the values the same? Print their sum, doubled.
            // Otherwise print their sum.
            if (firstValue == secondValue)
                Console.WriteLine((firstValue + secondValue) * 2);
            else
                Console.WriteLine(firstValue + secondValue);
        }

        /// <summary>
        /// Multiplies two whole numbers and returns the product.
        /// </summary>
        /// <param name="firstValue">First value</param>
        /// <param name="secondValue">Second value</param>
        /// <returns>Product of the two values</returns>
        public static int MultiplyTwoValues(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }
        
        /// <summary>
        /// Determine whether a whole number is a multiple of 5.
        /// </summary>
        /// <param name="value">Value that may be a multiple of 5</param>
        /// <returns>True when the value is a multiple of 5, false otherwise.</returns>
        public static bool MultipleOfFive(int value)
        {
            // Returns true when the value is a multiple of 5
            if(value % 5 == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// This method has no real purpose, but is here to show what unreachable code looks like.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Whatever(string s)
        {
            // Watch for methods that have returns before other statements
            // You will receive a warning about "unreachable code"
            return "gethtrhrdrjcy";

            // Warning is here, on the "Console" part of this method call:
            Console.WriteLine("efighzigzuxsg");
            int x = 5;
            if(x > 3)
                Console.WriteLine("Whatevryruvtgzrbeifpgsv");
        }

    } // END OF PROGRAM CLASS - Write static methods BEFORE this curly brace!
}
