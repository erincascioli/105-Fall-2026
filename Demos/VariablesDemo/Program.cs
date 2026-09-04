namespace VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine shortcut:  *cw tab tab*  or  *cw tab* (depends on your VS)
            // (No, there's not one for Console.Write or Console.Read or Console.ReadLine)

            // Common data types:
            // Short  --> 2 bytes/16 bits
            // Int    --> 4 bytes/32 bits
            // Float  --> 4 bytes/32 bits
            // Double --> 8 bytes/64 bits
            // Bool   --> 1 byte/8 bits
            // Char   --> 2 bytes/16 bits


            // Variable declaration only
            // Requires data type and identifier
            // "Variable block"
            string favoriteAnimal;                      // ""
            int numberFingersToes;                      // 0
            bool isRaining;                             // false
            char letter;                                // ''
            double money;                               // 0.0
            string userName;

            // Unassigned value in c#
            //Console.WriteLine(letter);

            // Variable initialization only
            // Requires identifier, assignment operator, and a value
            isRaining = false;
            letter = 'Q';
            money = 486.52;
            numberFingersToes = 20;
            favoriteAnimal = "crow";

            Console.WriteLine("Is it raining? " + isRaining);

            // Variable declare & init, same line
            // Data type identifier = value
            float weightOfFingersToes = 5.0f;

            Console.Write("Enter your name here: ");
            userName = Console.ReadLine();


            // Initialization with expression and other variable values
            // variable = value/expression/variable
            int a = 6;
            int b = a;
            int c = a + b;

            string favoriteAnimal2 = favoriteAnimal + " also";

            // Constants
            // const keyword comes first
            const int passingGrade = 70;
            //passingGrade = 65;        // ERROR!!!


            // Increment and decrement operators
            // ++ and --
            int myNumberA = 1;                   // 1
            myNumberA++;                         // 2
            Console.WriteLine(myNumberA);        // 2

            int myNumberB = 1;                   // 1
            myNumberB--;                         // 0
            Console.WriteLine(myNumberB);        // 0

            short myNumberC = 4;
            myNumberC++;

            int myNumberD = 5;
            myNumberD = myNumberD + 4;      // myNumberD += 4;


            // Common variable errors: Compatibility and redeclaration
            //int size = 4;
            //int size = 28;
            //char secondLetter = "A";
            //double largeNumber = 29348462;

        }
    }
}
