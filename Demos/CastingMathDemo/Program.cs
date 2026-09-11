namespace CastingMathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Casting
            // ----------------------------------------------------------------

            // Implicit casting --> Less to more precise
            double firstValue = 5;              // Cast, contains 5 as double
            short smallValue = 3;
            int secondValue = smallValue;       // Cast, contains 3 as int

            // Explicit casting --> More precise to less
            secondValue = (int)firstValue;      // Cast, contains 5 as int

            // Characters to numbers and back
            char letterA = (char)65;            // 'A'
            int letterAInt = (int)'A';          // 65

            // (We won't know this or use it yet - a quick peek ahead)
            Random generator = new Random();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write((char)generator.Next(65, 69));
                }
                Console.WriteLine();
            }

            // Invalid casts
            //int thirdValue = 200.857;           // Must be an EXPLICIT cast
            //string fourthValue = (string)6;     // Parse process, NOT casting


            // ----------------------------------------------------------------
            // Using Documentation
            // ----------------------------------------------------------------
            // Press F1 and highlight to open documentation!
            Math.Pow



            // ----------------------------------------------------------------
            // Math class methods
            // ----------------------------------------------------------------
            // Press F1 and highlight to open documentation!
            double pi = 3.1415;
            double roundedValueAsDouble = Math.Round(pi);
            int roundedValue = (int)Math.Round(pi);
            Console.WriteLine(roundedValueAsDouble);
            Console.WriteLine(roundedValue);
        }
    }
}
