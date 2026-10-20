namespace TryParse_Random_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            // Generate 1,000 random values between 0 and 9
            // Use an array to plot their frequency
            int[] numbers = new int[10];
            int numberValues = 100;

            for(int i = 0; i < numberValues; i++)
            {
                int randomValue = generator.Next(0, 10);
                numbers[randomValue]++;
            }

            // Visualize the results as tallies and also percentages
            for(int i = 0; i < numbers.Length; i++)
            {
                // Get the tally count
                int frequency = numbers[i];

                // Calculate percentage of total values generated
                double percentage = (frequency/(double)numberValues) * 100;
                percentage = Math.Round(percentage, 3);

                // Display results
                Console.WriteLine($"{i}: {frequency} tallies. {percentage}%");
            }
        }
    }
}
