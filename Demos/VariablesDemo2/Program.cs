namespace VariablesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Shortcut:  cw tab (or cw tab tab)
            // NO for Console.Write
            Console.WriteLine();

            // Variable declaration and initialization
            // Declare --> reserving space in memory
            // Initialize --> assign a value to a variable
            // datatype identifier = value;
            // = means assignment operator, assigns a value. NOT equals.
            int numberOfStudents = 30;
            float currentTemperature = 74.6f;
            string phrase = "Hi yall!";
            bool isRaining = false;
            char favoriteLetter = 'X';
            double gradePointAverage = 3.99;

            Console.WriteLine("The current temperature is " + currentTemperature);

            // Variable declaration only
            string userName;

            Console.Write("Please enter your name here: ");

            // Variable initialization only
            userName = Console.ReadLine();

            // Errors: compatibility and redeclaration
            //int catAge = 15.4;          // Double/float in an int
            //string myName = 'Erin';     // Double quotes for a string
            int cat1Age = 15;
            int cat2Age = 12;
            cat2Age = 11;
            //double money = true;        // Can't hold a bool in a double

            // Constant variables:
            // Value cannot be changed after declaration and initialization
            const double pi = 3.1415;

            int a = 4;      // 4
            int b = a;      // 4
            int c = a + b;  // 8
            int d = b + 1;  // 5
            a = a + 1;
            a += 1;
            a++;        // increment operator ONLY 1

            a = a - 1;
            a -= 1;
            a--;        // decrement operator ONLY 1

            a = a * 3;
            a *= 3;

            string one = "a";
            string two = one + "b";

            Console.WriteLine();
        }
    }
}
