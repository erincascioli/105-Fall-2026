namespace WhileLoop_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - 20 in C.W statements
            Console.Write(2);
            Console.Write(4);
            Console.Write(6);
            Console.Write(8);
            Console.Write(10);
            Console.Write(12);
            Console.Write(14);
            Console.Write(16);
            Console.Write(18);
            Console.Write(20);
            Console.WriteLine();

            // Provide user with a prompt
            // Read their input into a int variable by parsing the data
            // IF input within range 1 (inclusive) - 10 (inclusive)
            //    Display "Success!" in green
            // ELSE
            //    Display "Try again" in red

            // -------------------------------------------------------
            Console.Write("Enter a whole number between 1 and 10: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            short input = short.Parse(Console.ReadLine()!);
            // -------------------------------------------------------
            while (input < 1 || input > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Try again.");
                input = short.Parse(Console.ReadLine()!);
            }
            // -------------------------------------------------------
            if (input >= 1 && input <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success! ");
            }
            // -------------------------------------------------------


            // Reset the console color back to its original value
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ResetColor();

            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
            Console.WriteLine("efkghxdglkhzdjkgbzslkjxf");
        }
    }
}
