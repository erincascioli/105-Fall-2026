namespace EnumerationsDemo_StarterWithClass
{
    internal class Program
    {
        // ************************************************
        // Define EnemyType enumeration:
        // ************************************************

        /// <summary>
        /// The 6 types of enemies my game contains.
        /// </summary>
        public enum EnemyType
        {
            Goblin,
            Wolf,
            Skeleton,
            Lynel,
            Owlbear,
            Dragon
        }

        static void Main(string[] args)
        {

            // ************************************************
            // Initialize the myMonster variable with an EnemyType member
            // ************************************************
            EnemyType myMonster = EnemyType.Goblin;


            // ************************************************
            // Write unique output for each enum member
            // ************************************************
            
            // Can be used in regular conditionals
            if(myMonster == EnemyType.Goblin)
            {
                Console.WriteLine("Goblin!!!!");
            }
            else if(myMonster == EnemyType.Dragon)
            {
                Console.WriteLine("Dragon!!");
            }

            // Also plays nicely with a switch statement!
            switch(myMonster)
            {
                case EnemyType.Goblin:
                    Console.WriteLine("Goblin!");
                    break;
                //case EnemyType.GelatinousCube                     // Error!
            }

            // ************************************************
            // Cast myMonster to memberInteger
            // ************************************************
            
            // Converts the enumeration into its associated integer value
            int memberInteger = (int)myMonster;



            // ************************************************
            // Cast memberInteger to an EnemyType
            // ************************************************
            
            // Converts an integer into its associated Enum member
            int desiredMonster = 2;
            EnemyType castedMonster = (EnemyType)desiredMonster;


            // ************************************************
            // Parse enemyString to parsedEnemy
            // ************************************************
            
            // Converts a string into an enum member
            string enemyString = "Wolf";
            EnemyType parsedEnemy = (EnemyType)Enum.Parse(typeof(EnemyType), enemyString);


            // ************************************************
            // Complete the loop to parse user input to an enum member. Print its integer value
            // ************************************************
            string playerChoice = "";

            // Loop user input and parsing with integer values
            while (playerChoice.ToLower() != "done")
            {
                // Ask player for an enemy type
                Console.WriteLine("\nEnter one of the six possible types...");

                // ************************************************
                // Add your 6 enum members to the statement below
                // ************************************************
                Console.Write("Choose Goblin, Wolf, Skeleton, Lynel, Owlbear or Dragon or 'DONE' >> ");
                playerChoice = Console.ReadLine()!.Trim();

                // Exit the loop early if the player wants to quit
                if (playerChoice.ToLower() == "done")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }

                // ************************************************
                // Parse user input to an Enemy type. Print integer value of that type.
                // ************************************************
                EnemyType userChoiceAsEnum = (EnemyType)Enum.Parse(typeof(EnemyType), playerChoice);
                int userChoiceAsInt = (int)userChoiceAsEnum;

                Console.WriteLine(userChoiceAsEnum);
                Console.WriteLine(userChoiceAsInt);
            }
        }
    }
}
