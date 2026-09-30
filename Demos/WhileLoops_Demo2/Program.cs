namespace WhileLoops_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A loop that prints all even numbers from 2 - 20
            int counter = 2;
            while(counter <= 20)     // STOP when I reach beyond 20!
            {
                Console.Write(counter + " ");
                counter += 2;
            }

            // X Provide user with a prompt to enter 1 - 10
            // X Read their input into a string variable
            // X Parse the user's input into an integer
            // X IF input within range 1 (inclusive) - 10 (inclusive)
            //    Display "Success!" in green
            // X ELSE (out of range)
            //    Display "Try again" in red
            // Let's code it!  

            Console.Write("Enter a number between 1 and 10: ");
            // Either this:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.BackgroundColor = ConsoleColor.Green;
            string number = Console.ReadLine()!.Trim();
            int numberInt = int.Parse(number);
            Console.ForegroundColor = ConsoleColor.Gray;
            // Or this:
            //int number = int.Parse(Console.ReadLine()!);
                        
            while( numberInt < 1 || numberInt > 10 )
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Try again!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                number = Console.ReadLine()!.Trim();
                numberInt = int.Parse(number);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Check if value is within range 1 (inclusive) - 10 (inclusive)
            if (numberInt >= 1 && numberInt <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Success!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Gibberish just to show that there would be output after the if statement
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ResetColor();
            Console.WriteLine("ELFvbszjhbzjhbgzjsh");
            Console.WriteLine("ELFvbszjhbzjhbgzjsh");
            Console.WriteLine("ELFvbszjhbzjhbgzjsh");
            Console.WriteLine("ELFvbszjhbzjhbgzjsh");
        }
    }
}
