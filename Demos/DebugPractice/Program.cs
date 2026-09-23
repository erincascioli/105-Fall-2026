
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
            // TODO: Write pseudocode for driving ages of license and permit for NC and WY

            // Nested if statement
            // Driving age NC
            // 15 --> Permit
            // 16 --> Full license
            // Driving age WY
            // 12 --> Permit
            // 15 --> License

            // IF Live in NC THEN
            //    IF 15 THEN
            //        Permit
            //    IF 16 THEN
            //        License
            // ELSE IF live in WY THEN
            //    IF 12 THEN
            //        Permit
            //    IF 15 THEN
            //        License
            // ELSE
            //    I don't know

            string state = "NC";
            int age = -4;

            // TODO: Write a nested conditional for driving ages
            if(state == "NC")
            { 
                if(age < 15)
                {
                    Console.WriteLine("You're too young to drive.");
                }
                else if(age == 15)
                {
                    Console.WriteLine("Permit");
                }
                else if(age == 16)
                {
                    Console.WriteLine("License");
                }
                else
                {
                    Console.WriteLine("You're older than 16 - You probably have a license?");
                }
            }
            else if(state == "WY")
            {
                if (age == 12)
                {
                    Console.WriteLine("Permit");
                }
                else if (age == 15)
                {
                    Console.WriteLine("License");
                }
            }
            else
            {
                Console.WriteLine("I don't know that state's laws");
            }

            /*
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
            //    Display "Yummy"
            // ELSE IF answer is cockroach THEN
            //    Display "Gross"
            // ELSE
            //    Display "Don't recognize"

            // ** WE WILL PICK BACK UP FROM HERE ON WEDNESDAY'S CLASS! **

            Console.WriteLine("Would you rather eat an APPLE or a LIVE COCKROACH?");
            Console.Write("Enter either the word \"APPLE\" or the word \"COCKROACH\": ");
            string answer = Console.ReadLine()!.Trim().ToUpper();

            if(answer == "APPLE")
            {
                Console.WriteLine("Yummy!");
            }
            else if(answer == "COCKROACH")
            {
                Console.WriteLine("Gross!");
            }
            else
            {
                Console.WriteLine("I don't recognize that input.");
            }
            */

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
