
// Erin Cascioli
// 10/2/26
// Demo: 1-dimensional arrays

namespace Arrays1D_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // 1-dimensional Arrays
            // ----------------------------------------------------------------
            // A data structure that holds multiple values of an identical data type
            //   using one variable identifier
            // ----------------------------------------------------------------
            int index = 2;
            int[] numbers = new int[4];
            numbers[0] = 32;
            numbers[1] = 27;
            numbers[2] = 32;
            numbers[3] = 67;
            numbers[index] = 28465;

            string[] words = new string[3];
            words[0] = "chocolate";
            words[1] = "movie";
            words[2] = "water";

            // ----------------------------------------------------------------
            // Array iteration
            // ----------------------------------------------------------------
            // For loops are commonly used to iterate through a 1D array.
            // Best practice: use the length of the array instead of a hard-coded literal
            //   length whenever possible. 
            // Exception: If you only need a range of the elements, like accessing only
            //   the first 3 values or so.
            // ----------------------------------------------------------------

            // Prints every element in the array to the console window
            Console.WriteLine("Numbers array: ------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Words array: ------------------");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            // This does NOT automatically print all elements like you might think it would:
            Console.WriteLine("Type of data in the array: ------------------");
            Console.WriteLine(words);       // Tells us it's a string array.


            // ----------------------------------------------------------------
            // Errors with indices
            // ----------------------------------------------------------------
            //numbers[4] = 3857;            // Error! Index must be less than 4
            //numbers[-1] = 3857;           // Error! Index must be > 0


            // ----------------------------------------------------------------
            // Literal array
            // ----------------------------------------------------------------
            // Declare and initialize in one line
            // Can be helpful if you have all the data ("literals")  right away. 
            // ----------------------------------------------------------------
            int[] numbers2 = {10, 20, 30, 40, 50};

            // ----------------------------------------------------------------
            // Individual indices of a string
            // ----------------------------------------------------------------
            Console.WriteLine("The first character of the first element is " +
                words[0][0]);
            Console.WriteLine("The last character of the first element is " +
                words[0][words[0].Length]);
        }
    }
}
