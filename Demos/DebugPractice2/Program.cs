namespace DebugPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write pseudocode for the nested conditional

            // IF state is IL or MN THEN
            //     IF younger than 15
            //         Too young to drive
            //     ELSE IF age is 15 THEN
            //         Permit
            //     ELSE
            //         License
            // IF state is NJ THEN
            //     IF age is 17 THEN
            //         Permit
            //     IF age is 18 THEN
            //         License

            // TODO: write code for the conditional
            string state = "IL";
            int age = 14;

            if(state == "IL")
            {
                if(age < 15)
                {
                    Console.WriteLine("You are too young to drive!");
                }
                else if(age == 15)
                {
                    Console.WriteLine("Permit!");
                }
                else
                {
                    Console.WriteLine("License!");
                }
            }
            if(state == "NJ")
            {
                if (age < 16)
                {
                    Console.WriteLine("You are too young to drive!");
                }
                else if (age == 17)
                {
                    Console.WriteLine("Permit!");
                }
                else
                {
                    Console.WriteLine("License!");
                }
            }


            /*
            string choice1 = "sbxdjbxdj";
            string phrase = "";

            if( choice1 == "A" )
            {
                phrase = "Yay! A!";
            }
            else if(choice1 == "B")
            {
                phrase = "No! B!";
            }
            else
            {
                phrase = "Anything but A!";
            }

            //if (choice1 == "B")
            //{
            //    phrase = "No! B!";
            //}

            Console.WriteLine(phrase);
            */

            // WE WILL PICK UP WITH THIS PROGRAM IDEA ON WEDNESDAY!
            // OPTIONS: FRENCH FRIES OR CURDLED MILK

            // PSEUDOCODE:
            // Prompt the user for their choice of french fries or curdled milk
            // Gather user's response with C.RL
            // Save the user's response as a string variable called answer
            // IF answer is "french fries" THEN
            //     Display "Yum!"
            // ELSE IF answer is "curdled milk" THEN
            //     Display "Gross!"

            /*
            Console.WriteLine("Would you rather eat FRENCH FRIES or CURDLED MILK?");
            Console.Write("Enter \"french fries\" or \"curdled milk\" here: ");
            string answer = Console.ReadLine()!.Trim().ToUpper();

            if(answer == "FRENCH FRIES")
            {
                Console.WriteLine("Yum!");
            }
            else if(answer == "CURDLED MILK")
            {
                Console.WriteLine("Gross!");
            }
            else
            {
                Console.WriteLine(answer + " is not a recognized response.");
            }
            */

            /*
            // Declare 2 variables of whatever type with whatever value you want
            int number = 100;
            string word = "popcorn";

            // Beginning breakpoint statement (for demo)
            Console.WriteLine("Hello, World!");

            // Now add 5 more C.WL statements
            Console.WriteLine("srghfghxjfgx");
            Console.WriteLine(number);
            Console.WriteLine(word);
            Console.WriteLine("rgiuhskgbjgseuldbfjvzfbvzjd");
            Console.WriteLine("kbdjhrjhbsjhb");
            */
        }
    }
}
