namespace CompoundConditionalsSwitch_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch statements

            int grade = 89;

            switch(grade)
            {
                case 80:
                case 81:
                case 82:
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                    Console.WriteLine("B");
                    break;     
            }

            switch (grade)
            {
                case <= 59:
                    Console.WriteLine("F");
                    break;
                case <= 69:
                    Console.WriteLine("D");
                    break;
                case <= 79:
                    Console.WriteLine("C");
                    break;
                case <= 89:
                    Console.WriteLine("B");
                    break;
                case <= 100:
                    Console.WriteLine("A");
                    break;
            }







            // Small snippet that sets the cost of an item based upon the type of food.
            string food = "chicken tenders";
            double cost = 0;

            switch(food)
            {
                case "clam chowder":
                    cost = 5.46;
                    break;
                case "M&Ms":
                    cost = 3.50;
                    break;
                case "D'Mangu":
                    cost = 13.59;
                    break;
                case "chicken tenders":
                    cost = 7.99;
                    break;
                default:
                    cost = 0;
                    break;
            }

            Console.WriteLine($"I ate {food} today and it costs {cost:C0}");




            // ----------------------------------------------------------------
            // In and out of ranges with AND and OR
            // ----------------------------------------------------------------
            // TO check if a value is within a numerical range, AND is typically used.
            // Checking for a value out of the desired range? OR is usually used. 
            // ----------------------------------------------------------------

            Console.Write("Enter a number between 1 and 10: ");
            int userNumber = int.Parse(Console.ReadLine()!);
            
            // In range (1 inclusive - 10 inclusive)
            if( userNumber >= 1 && userNumber <= 10)  // userNumber > 0 && userNumber < 11
            {
                Console.WriteLine("Number is in range!");
            }
            // Out of range ...1     10...
            if ( userNumber < 1 || userNumber > 10)    // userNumber <= 0 || userNumber >= 11
            {
                Console.WriteLine("Number is out of range!");
            }
            // Out of range
            if ( !(userNumber >= 1 && userNumber <= 10) ) 
            {
                Console.WriteLine("Number is out of range!");
            }


            // ----------------------------------------------------------------
            // Compound conditionals are evaluated left to right. 
            // Can use parentheses to notate importance or order of evaluation. 
            // ----------------------------------------------------------------
            
            // If I'm bored and have no plans on Saturday, go to the Roc Game Dev Fest.
            // If I'm bored but I do have plans, I can't go.
            // If I'm not bored at all, I won't go. 
            bool bored = true;
            bool havePlans = true;
            bool goToFest = false;      // This may change depending on the conditional below!

            if ( (bored && havePlans) ||       // If I'm bored but I do have plans, I can't go.
                !bored)                        // If I'm not bored at all, I won't go. 
            {
                goToFest = false;
            }
            // If I'm bored and have no plans on Saturday, go to the Roc Game Dev Fest.
            if ( bored && !havePlans )
            {
                goToFest = true;
            }
            



        }
    }
}
