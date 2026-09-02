
// Erin Cascioli
// 9/2
// Demo: Statements and Expressions with concatenation

namespace StatementsExpressions_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo statements and expressions
            Console.WriteLine("Hello, World!");
            Console.WriteLine("hey");

            // Simple math outputted to the console
            Console.WriteLine(365 * 24);
         
            // Math concatenated with a string
            Console.WriteLine("The answer is {0}" + 10/5);

            // Using the special placeholder with an argument list (advanced)
            Console.WriteLine("I want to insert a value {0}", "here");
        }
    }
}
