
// Erin Cascioli
// 9/14/26
// Demo: Input, Parsing, String interpolation, Escape sequences


namespace InputParsingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // String interpolation with $
            // Place any variable inside {} within the confines of a string. Must
            //   place the $ symbol before the string. 
            // ----------------------------------------------------------------
            int currentYear = 2026;
            double moneyInAccount = 47.52;

            Console.WriteLine("The current year is " + currentYear + " and I have $" + 
                moneyInAccount + " in my bank account.");

            Console.WriteLine($"The current year is {currentYear} and I have ${moneyInAccount} " +
                $"in my bank account.");


            // ----------------------------------------------------------------
            // Spacing between the 2 program areas
            // ----------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();


            // ----------------------------------------------------------------
            // Get input from a user with Console.ReadLine()
            // ----------------------------------------------------------------
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine()!;

            // ----------------------------------------------------------------
            // Escape sequence for double-quote:  \"
            // ----------------------------------------------------------------
            Console.WriteLine($"Thanks \"{userName}\"!");


            // ----------------------------------------------------------------
            // Inputs are always read in as string
            // Must convert string to intended data type
            // Parsing = string to num, string to bool, string to primitive
            // ----------------------------------------------------------------
            Console.WriteLine($"{userName}, enter a whole number: ");
            string userNumber = Console.ReadLine()!;
            int userNumberAsInt = int.Parse(userNumber);
            Console.WriteLine($"Your number is {userNumberAsInt}");
            Console.WriteLine($"{userNumberAsInt * 5}");


            // ----------------------------------------------------------------
            // Errors upon parsing
            // ----------------------------------------------------------------
            // Must parse to a compatible data type
            // These will cause RUNTIME errors. NOT syntax errors.
            // ----------------------------------------------------------------
            //int.Parse("2.5");
            //bool.Parse("0");
            //double.Parse("lala");

        }
    }
}
