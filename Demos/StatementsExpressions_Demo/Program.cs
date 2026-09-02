
// Erin Cascioli
// 9/2
// Demo: Statements and Expressions with concatenation

namespace StatementsExpressions_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An expression by itself won't compile
            // All three of these cause syntax errors and have red squiggles underneath:
            //"Hello everyone";
            //4 + 274;
            //12345;

            // An expression must be in the greater context of a statement
            //   in order to compile and execute. 
            Console.WriteLine("Hello everyone");
            Console.WriteLine(4 + 274);
            Console.WriteLine(12345);

            // Watch for integer vs. floating point division!   // Console shows:
            Console.WriteLine("9/4 is " + (9/4));               // 2
            Console.WriteLine("9.0/4 is " + (9.0/4));           // 2.25
            Console.WriteLine("9.0/4.0 is " + (9.0/4.0));       // 2.25
            Console.WriteLine("9/4.0 is " + (9/4.0));           // 2.25

            // Mod gives us the remainder
            Console.WriteLine("9%4 is " + (9%4));
            
            // Escape characters for quotations
            Console.WriteLine("Then he said, \"Howdy!\"");
            Console.WriteLine("Then he said, 'Howdy!'");
            Console.WriteLine("Then he said, \'Howdy!\'");
            Console.WriteLine("\\\"");

            Console.WriteLine("5 plus 5 is " + (5 + 5));        // 10
            Console.WriteLine("5 plus 5 is " + 5 + 5);          // 55
            Console.WriteLine("5 times 5 is " + 5 + 5*2);       // 510

        }
    }
}
