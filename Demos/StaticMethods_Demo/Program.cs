
// Erin Cascioli
// 10/7/26
// Demo: Static methods with parameter and returns.

namespace StaticMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Calling methods that we've written from here in Main!
            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            // Method with no parameters
            // ----------------------------------------------------------------
            PrintMyName();
            PrintMyName(ConsoleColor.DarkGreen);

            // ----------------------------------------------------------------
            // Methods with parameters
            // ----------------------------------------------------------------
            PrintMyPhrase("String to be printed.");
            SumDouble(10, 20);
            SumDouble(3, 3);

            // ----------------------------------------------------------------
            // Methods with parameters and return
            // ----------------------------------------------------------------
            int sum = SumDoubleReturn(10, 20);
            Console.WriteLine(sum);

            Console.WriteLine(SumDoubleReturn(3, 3));

            #region Minimized Code
            /*
            Console.WriteLine("Pretend this is part of a program");

            PrintDivider();

            Console.WriteLine("Pretend this is a different part of a program");

            PrintDivider();

            Console.WriteLine("Pretend this is a third different part of a program");
            */
            #endregion

        } // end of Main
          // ---------------------------------------------------

        // STATIC METHODS GO HERE BETWEEN THESE LINES (END OF MAIN AND END OF PROGRAM!!!)

        /// <summary>
        /// Prints a purple block of characters to visually divide the program's output
        /// </summary>
        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("**************************");
            Console.WriteLine("--------------------------");
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Prints my name to the console window.
        /// </summary>
        public static void PrintMyName()
        {
            Console.WriteLine("Erin Cascioli");
        }

        /// <summary>
        /// Overloaded method for PrintMyName that writes text in specified color
        /// </summary>
        /// <param name="textColor">Text color in the console window</param>
        public static void PrintMyName(ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine("Erin Cascioli");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Prints any phrase to the console window.
        /// </summary>
        /// <param name="phrase">Message to be printed to the console</param>
        public static void PrintMyPhrase(string phrase)
        {
            Console.WriteLine(phrase);
        }


        /// <summary>
        /// Print the sum of 2 whole numbers. If numbers are equal, print the sum doubled.
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        public static void SumDouble(int firstValue, int secondValue)
        {
            if(firstValue == secondValue)
                Console.WriteLine((firstValue + secondValue) * 2);
            else
                Console.WriteLine(firstValue + secondValue);
        }

        public static int SumDoubleReturn(int firstValue, int secondValue)
        {
            if (firstValue == secondValue)
                return (firstValue + secondValue) * 2;
            else
                return firstValue + secondValue;
        }

        /*
        public static string Whatever()
        {
            return "hey";

            Console.WriteLine("dgxdhxhcfjcfjvkgkkg");
            if(5 > 2)
                Console.WriteLine(true);
        }
        */

        // ---------------------------------------------------
    }   // end of Program
}
