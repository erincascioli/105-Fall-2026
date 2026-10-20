using System.Drawing;

namespace EnumerationDemo_StarterWithClass2
{
    internal class Program
    {

        /// <summary>
        /// These 4 enemies are used in my game
        /// </summary>
        public enum EnemyType
        {
            Thief,
            Giant,
            StickySlime,
            Knight
        }

        static void Main(string[] args)
        {
            // ************************************************
            // Initialize the myMonster variable with an EnemyType member
            // ************************************************
            EnemyType myMonster = EnemyType.StickySlime;


            // ************************************************
            // Write unique output for each enum member
            // ************************************************
            if(myMonster == EnemyType.StickySlime)
            {
                Console.WriteLine("Eww, sticky!");
            }
            else if(myMonster == EnemyType.Giant)
            {
                Console.WriteLine("Sooo big!");
            }

            switch(myMonster)
            {
                case EnemyType.StickySlime:
                    Console.WriteLine("Eww, sticky!");
                    break;
            }

            // ************************************************
            // Cast myMonster to memberInteger
            // ************************************************
            int memberInteger = (int)myMonster;                     // value is 2


            // ************************************************
            // Cast memberInteger to an EnemyType
            // ************************************************
            EnemyType castedMonster = (EnemyType)3;                 // EnemyType.Knight

            /*
            // Generate a random monster!
            Random rng = new Random();
            for(int i = 0; i < 10; i++)
            {
                int randomValue = rng.Next(0, 4);
                EnemyType randomMonster = (EnemyType)randomValue;
                Console.WriteLine("The monster is a " + randomMonster);
            }
            */

            /*
            // Math on enums. Be careful! Unless you wrap the value and reset back to 0, 
            //    the math will continue and there are no enum members associated with 
            //    the resulting integer values.
            EnemyType startingBadGuy = EnemyType.Thief;
            for(int i = 0; i < 10; i++)
            {
                // Print the enum member
                Console.WriteLine(startingBadGuy);

                // Increase it by 1
                startingBadGuy++;
            }

            // How many members?
            //int enumMemberSize = Enum.GetValues(typeof(EnemyType)).Length;
            */

            // ************************************************
            // Parse enemString to parsedEnemy
            // ************************************************
            string enemyString = "Knight";
            EnemyType parsedEnemy = (EnemyType)Enum.Parse(typeof(EnemyType), enemyString);


            // ************************************************
            // Complete the loop to parse user input to an enum member. Print its integer value
            // ************************************************
            string playerChoice = "";

            // Loop user input and parsing with integer values
            while (playerChoice.ToLower() != "done")
            {
                // Ask player for an enemy type
                Console.WriteLine("\nEnter one of the four possible types...");

                // ************************************************
                // Add your 4 enum members to the statement below
                // ************************************************
                Console.Write("Choose Thief, Giant, StickySlime, or Knight or 'DONE' >> ");
                playerChoice = Console.ReadLine()!.Trim();

                // Exit the loop early if the player wants to quit
                if (playerChoice.ToLower() == "done")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }

                // ************************************************
                // TODO: Parse user input to an Enemy type. Print integer value of that type.
                // ************************************************
                // 1. Get users input and parse to Enum
                // 2. Cast the enum to an integer
                // 3. Print the integer
                EnemyType userChoiceAsEnum = (EnemyType)Enum.Parse(typeof(EnemyType), playerChoice);
                int userChoiceAsInt = (int)userChoiceAsEnum;
                Console.WriteLine(userChoiceAsInt);

                // All-in-one-ugly-ass-line! I don't recommend this.
                //Console.WriteLine((int)(EnemyType)Enum.Parse(typeof(EnemyType), playerChoice));
            }
        }

    }
}
