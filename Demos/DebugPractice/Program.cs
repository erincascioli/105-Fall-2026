
// Erin Cascioli
// 9/21/26
// Demo: Debugging with breakpoints, stepping over, and continue
//       Debugger with runtime errors
//       If statements (conditionals)


namespace DebugPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Apples are good
            // Live cockroaches are bad

            // IN SMALL GROUPS, WRITE PSEUDOCODE FOR THIS SMALL PROGRAM!
            // SAMPLE OUTPUT:
            // WOULD YOU RATHER EAT AN APPLE OR A LIVE COCKROACH?
            // THEN GIVE THEM SOME KIND OF RESPONSE

            // PSEUDOCODE:
            // Display choice: Would you rather eat apples or cockroach?
            // Prompt user for their choice (C.RL)
            // Save answer in string variable answer
            // IF answer is apples THEN
            //    Display ""
            // ELSE
            //    Display ""

            // ** WE WILL PICK BACK UP FROM HERE ON WEDNESDAY'S CLASS! **


            #region Commented code
            // ----------------------------------------------------------------
            // Debugging with breakpoints, stepping over (F10) and continue
            // Step over --> Execute line by line, staying within the local scope
            // Continue --> Jump to the next breakpoint and execute from there
            // ----------------------------------------------------------------
            /*
            // Variable block
            int number = 5;
            string word = "chocolate";

            // Display output in the window
            Console.WriteLine("Hello, World!");
            Console.WriteLine(number);
            Console.WriteLine(word);
            //Console.WriteLine(word[200]);               // Error! No index 200.
            Console.WriteLine("rghrfsgfdgsfgbgv");
            Console.WriteLine("rshsstaytesf");
            Console.WriteLine("sthagarhsrasgbdxdggrdhhgs");

            // Change the value of the 2 variables
            number = 100;
            //word = "popcorn";
            */

            // ----------------------------------------------------------------
            // Debugger with if statements
            // ----------------------------------------------------------------

            // IF word is popcorn
            //      Display "Pop!" in the console window

            /*
            if (word == "popcorn")
            {
                Console.WriteLine("Pop!");
            }
            */


            /*
            if (number == 5)
            {
                Console.WriteLine("Value is still 5!");
            }
            else
            {
                if (number == 100)
                {
                    Console.WriteLine("Value changed - it's exactly 100!");
                }
                else
                {
                    Console.WriteLine("Value has changed - it's something else!");
                }
            }
            */
            #endregion

        }
    }
}
