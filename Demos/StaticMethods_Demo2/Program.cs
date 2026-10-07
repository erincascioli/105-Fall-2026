
// Erin Cascioli
// 10/7/26
// Demo Static methods

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
            PrintName();

            // ----------------------------------------------------------------
            // Calling methods with parameters
            // ----------------------------------------------------------------
            int product = MultiplyTwoValues(3, 4);          // 12
            Console.WriteLine(product);                     // Prints 12

            Console.WriteLine( MultiplyTwoValues(3, 4) );   // Prints 12



            // ----------------------------------------------------------------
            // Calling methods with parameters and return statement(s)
            // ----------------------------------------------------------------
            Console.WriteLine(MultipleOfFive(12));
            Console.WriteLine(MultipleOfFive(25));
        }
        // END OF MAIN
        // all static methods you write from here through week 10-ish will be HERE

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

        // I'm going to write some methods that have parameters and/or returns here. No need to follow along! 
        // 1) Write firstValue method that returns the product of 2 values. (product = multiplication)
        // 2) Write firstValue method that returns true when firstValue value is firstValue multiple of 5. 
        // 3) Return true if the given string begins with "mix", except the 'm' can be anything,
        //    so "pix", "9ix" all count.
        // 4) ?? 

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

        // TODO: Write firstValue method that returns true when firstValue value is firstValue multiple of 5. 
        
        /// <summary>
        /// Determine whether a whole number is a multiple of 5.
        /// </summary>
        /// <param name="value">Value that may be a multiple of 5</param>
        /// <returns>True when the value is a multiple of 5, false otherwise.</returns>
        public static bool MultipleOfFive(int value)
        {
            if(value % 5 == 0)
            {
                return true;
            }

            return false;
        }

        public static string Whatever(string s)
        {
            return "gethtrhrdrjcy";

            Console.WriteLine("efighzigzuxsg");
            int x = 5;
            if(x > 3)
                Console.WriteLine("Whatevryruvtgzrbeifpgsv");
        }

    } // END OF PROGRAM CLASS
}
