
// Erin Cascioli
// 9/14/26
// Demo: Input and parsing, string interpolation, Trim()

namespace InputParsingDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // String interpolation demo
            // ----------------------------------------------------------------
            int currentYear = 2026;
            int bankAccountBalance = 0;

            Console.WriteLine("It is the year " + currentYear + " and I have $" + 
                bankAccountBalance + " in my bank account");
            Console.WriteLine($"It is the year {currentYear} and I have " +
                $"${bankAccountBalance} in my bank account");
            Console.WriteLine("It is the year {0} and I have " +
                "${1} in my bank account", currentYear, bankAccountBalance);

            // ----------------------------------------------------------------
            // Getting user input with Console.ReadLine()
            // and String "Sanitization" (cleaning up leading/trailing spaces)
            // ----------------------------------------------------------------
            // 1. Prompt the user anytime you need their input!
            Console.Write("Enter your name: ");

            // 2 Grab the user's input
            string userName = Console.ReadLine()!;      // ! = ignore the warning

            // 2a. Trim/sanitize the input
            userName = userName.Trim();

            // 3. Use their input somehow!
            Console.WriteLine($"Thanks, {userName}!");

            // ----------------------------------------------------------------
            // Parsing
            // Data types must match what you're attempting to parse to.
            // Non-matching data types = runtime error/crash!
            // ----------------------------------------------------------------
            
            // Parse to an integer
            Console.Write("Enter an integer: ");
            string userNumber = Console.ReadLine()!;
            int userNumberAsInt = int.Parse(userNumber);
            Console.WriteLine(userNumberAsInt * 5);

            // Parse to a boolean (not case sensitive)
            Console.Write("Enter TRUE or FALSE: ");
            string userBool = Console.ReadLine()!;
            bool userBoolAsBool = bool.Parse(userBool);
            Console.WriteLine(userBoolAsBool);


            // ----------------------------------------------------------------
            // Ceiling and Floor testing
            // ----------------------------------------------------------------
            
            // Testing with a whole number (entered as a double)
            Console.WriteLine(Math.Ceiling(1.0));
            Console.WriteLine(Math.Floor(1.0));

            // Testing with a fractional component
            Console.WriteLine(Math.Ceiling(8.794));
            Console.WriteLine(Math.Floor(8.794));
        }
    }
}
