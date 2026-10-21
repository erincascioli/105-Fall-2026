// Erin Cascioli
// 10/21/2026
// Demo: Random number generation and TryParse method


namespace TryParse_Random_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ----------------------------------------------------------------
            // Variables for using TryParse:
            // ----------------------------------------------------------------
            int result = 1000;
            bool success = true;
            string parseValue = "whehdz";

            // ----------------------------------------------------------------
            // Attempt a parse of "bad" data with TryParse
            // ----------------------------------------------------------------
            // The returned boolean can be used in conditionals or loops!
            success = int.TryParse(parseValue, out result);
            if (success)
            {
                Console.WriteLine("Value was parseable!");
            }
            else
            {
                Console.WriteLine("Not parseable but NO CRASH");
            }

            // ----------------------------------------------------------------
            // Re-prompt a user for "good" data
            // ----------------------------------------------------------------
            while (!success)
            {
                Console.Write("Enter any integer: ");
                parseValue = Console.ReadLine()!;
                success = int.TryParse(parseValue, out result);
            }
            
            
                        
            // ----------------------------------------------------------------
            // Using Random numbers
            // ----------------------------------------------------------------
            Random generator = new Random();
            int singleRandomInteger = generator.Next(1, 101);
            double singleRandomDouble = generator.NextDouble();

            // Generate 15 numbers between 1 (incusive) and 10 (inclusive)
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(generator.Next(1, 11));
            }


            // Generate 100,000,000 random values between 0 and 9
            // Use an array to plot their frequency
            int[] numbers = new int[10];
            int numberValues = 100_000_000;

            for(int i = 0; i < numberValues; i++)
            {
                int randomValue = generator.Next(0, 10);
                numbers[randomValue]++;
            }

            // Visualize the results as tallies and also percentages
            for (int i = 0; i < numbers.Length; i++)
            {
                // Get the tally count
                int frequency = numbers[i];

                // Calculate percentage of total values generated
                double percentage = (frequency / (double)numberValues) * 100;
                percentage = Math.Round(percentage, 3);

                // Display results
                Console.WriteLine($"{i}: {frequency} tallies. {percentage}%");
            }
            
        }
    }
}
