namespace DowhileForLoop_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // For Loops - great when a specific number of iterations are needed
            // Typical to see single letter iterator variables.
            // Remember scope: iterator variables exist only in their loop!
            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            // Break and Continue statements
            // ----------------------------------------------------------------
            // break exits the current loop
            // continue skips the rest of the code in the current loop and 
            //    continues from the update statement.
            // ----------------------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");

                if(i == 5)
                    break;
            }

            Console.WriteLine("\n---------------------------------");
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                    continue;       // Skip any code after this!

                Console.Write(i + " ");
            }

            // Move to the next line
            Console.WriteLine();


            // ----------------------------------------------------------------
            // Nesting for loops
            // ----------------------------------------------------------------
            // A nested for loop
            // ----------------------------------------------------------------

            // Nested for loop allows for a "grid" of data
            for (int i = 0; i < 10; i++)             // 10 "rows"
            {
                for (int j = 0; j < 30; j++)         // 30 "columns"
                {
                    // For even rows, start with a star
                    if(i % 2 == 0)
                    {
                        // Even columns print a *, odd columns print a -
                        if (j % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write("-");
                    }
                    // Odd rows start with a dash
                    else
                    {
                        // Even columns print a -, odd columns print a *
                        if (j % 2 == 0)
                            Console.Write("-");
                        else
                            Console.Write("*");
                    }
                }

                // Move the curser to the next line
                Console.WriteLine();
            }

            /*
            // While loop for incrementing a value from 1 - 3
            int counter = 1;

            while (counter < 4)
            {
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine();

            // For loop for incrementing a value from 1 - 3
            for(int c = 1; c < 4; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // NOOOOO dawg
            string input = "";
            for (; input != "y" && input != "n"; input = Console.ReadLine()!)
            {
                Console.WriteLine("Enter 'y' or 'n'");
            }
            */



            /*
            // While loop for incrementing a value from 1 - 10
            int counter = 1;

            while(counter <= 10)
            {
                Console.Write(counter + " ");
                counter++;
            }


            // For loop for incrementing a value from 1 - 10
            for(int c = 1; c <= 10; c++)
            {
                Console.Write(c + " ");
            }
            */

            /*
            for()
            {
                for()
                {

                }
            }
            */

            /*
            // Break and continue keywords
            for(int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                    continue;

                Console.WriteLine(i);
            }
            */




            #region While Loop PE Answers
            /*
            // While Loop PE "answers"
            // Print 20 - 23 to console window. Separate lines.
            int printedValue = 20;
            while (printedValue < 24)
            {
                Console.WriteLine(printedValue);
                printedValue++;
            }

            // Visual divider
            Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            // Print 1 - 10 to console window. Same line.
            // Reset the LCV to 1 for use in this loop
            printedValue = 1;

            while (printedValue < 11)  // printedValue <= 10
            {
                Console.Write(printedValue + " ");
                printedValue++;
            }

            // Visual divider
            Console.WriteLine("\n*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            // Print 6 - 10 backwards to console window. Separate lines.

            // Reset LCV to 10
            printedValue = 10;

            while (printedValue >= 6)
            {
                Console.WriteLine(printedValue);
                printedValue--;
            }

            // Visual divider
            Console.WriteLine("\n*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            // Print 0 - 20 (evens only) to console window. Exclude 0, include 20. Same line with *
            printedValue = 2;

            while (printedValue < 20)
            {
                printedValue += 2;

                if (printedValue == 20)
                {
                    Console.Write(printedValue);                // ONLY 20
                }
                else {
                    Console.Write(printedValue + "*");          // everything else
                }
            }

            // Visual divider
            Console.WriteLine("\n*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            // Ask for input until user types "STOP"

            // Ask the user to enter a word "STOP"
            // WHILE the user has NOT given me the exact word
            //      Prompt user again
            //      User must enter the word again
            // Display "Okay!"

            // Need a new LCV
            string userInput = "";

            Console.WriteLine("Enter the word 'yes' or 'no' or 'y' or 'n'");
            //while(userInput != "STOP")
            while ( userInput != "YES" && 
                    userInput != "NO" && 
                    userInput != "Y" && 
                    userInput != "N")
            //while (userInput != "YES" || userInput != "NO" || userInput != "Y" || userInput != "N")   // Infinite loop!
            {
                Console.Write("Enter a word:");
                userInput = Console.ReadLine()!.Trim().ToUpper();     // No upper or lower
            }

           Console.WriteLine("Okay!");

            // Visual divider
            Console.WriteLine("\n*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
            */
            #endregion
        }
    }
}
