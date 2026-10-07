
// Erin Cascioli
// 10/2/26
// Demo: 1-dimensional arrays

namespace _1DArrays_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declare an array:
            // ----------------------------------------------------------------
            // Declare an array of strings
            // Declare an array of doubles
            // ----------------------------------------------------------------
            string[] racers;          // names of racers
            double[] times;           // finishing times of racers

            // ----------------------------------------------------------------
            // Initialize the arrays with a size
            // ----------------------------------------------------------------
            // Helpful to be done when you don't know the starting size
            // Once the array is initialized with a size, the size is immutable
            // ----------------------------------------------------------------
            racers = new string[3];
            times = new double[3];

            // ----------------------------------------------------------------
            // Data Assignment
            // ----------------------------------------------------------------
            // Put data into the array
            // Assign data invididually into each element
            racers[0] = "Lightning McQueen";
            racers[1] = "Turbo";
            racers[2] = "Marty McFly";

            times[0] = 2;
            times[1] = 3.3;
            times[2] = 34;

            // ----------------------------------------------------------------
            // Literal array
            // ----------------------------------------------------------------
            // Only helpful when you know all data at the moment of init
            string[] coaches = {"Hudson", "Coach B", "Doc"};


            // ----------------------------------------------------------------
            // Accessing indices
            // ----------------------------------------------------------------
            Console.WriteLine("First racer is " + racers[0]);
            Console.WriteLine("Last racer is " + racers[racers.Length - 1]);

            int chosenIndex = 2;
            Console.WriteLine("Chosen racer is " + racers[chosenIndex]);

            // Out of range indices:
            //Console.WriteLine(racers[racers.Length]);
            //Console.WriteLine(racers[-1]);                  // Warning about negative!

            // ----------------------------------------------------------------
            // Printing array values
            // ----------------------------------------------------------------
            Console.WriteLine("The racers array holds: " + racers);
            Console.WriteLine("The times array holds: " + times);
            Console.WriteLine("The coaches array holds: " + coaches);


            // YOU DO:  DECLARE A LITERAL ARRAY OF THREE INTEGERS AND WRITE A LOOP 
            //          TO ITERATE THROUGH AND PRINT EACH VALUE.
            int[] numbers = {10, 20, 30};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Access first character of first racer
            int lastRacerIndex = racers.Length - 1;
            int lastIndexOfMarty = racers[2].Length - 1;
            Console.WriteLine("First letter of first racer: " + racers[0][0]);
            Console.WriteLine("Last letter of first racer: " + racers[0][racers[0].Length-1]);
            Console.WriteLine("Last letter of last racer: " + racers[racers.Length-1][racers[2].Length-1]);
            Console.WriteLine("Last letter of last racer: " + 
                racers[lastRacerIndex][lastIndexOfMarty]);

            // racers --> the entire array
            // racers[0] --> the string "Lightning McQueen"
            // racers[0][0] --> access a single character in that string

            /*
            // Warmup:
            // 1) Write a for loop that prints 1 (inc) - 10 (inc) 
            //    Can be separate or same line

            for(int i = 1; i <= 10; i++)        // i < 11
            {
                Console.WriteLine(i);
            }

            // 2) Write a for loop that prints each character of a string
            //    Can be separate or same line
            string word = "mousepad";
            for(int i = 0; i < word.Length - 1; i++)
            {
                Console.WriteLine(word[i]);
            }
            */

        }
    }
}
