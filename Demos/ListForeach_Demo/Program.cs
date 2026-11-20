// Erin Cascioli
// 11/20/26
// Demo: List class and foreach loops


namespace ListForeach_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declare and initialize a list
            // ----------------------------------------------------------------
            List<string> monstersList = new List<string>();

            // Initial count and capacity:
            Console.WriteLine("Initial count: " + monstersList.Count);
            Console.WriteLine("Initial capacity: " + monstersList.Capacity);


            // ----------------------------------------------------------------
            // Add data
            // ----------------------------------------------------------------
            
            // Cannot ADD data with index notation. Must use Add method.
            //monstersList[0] = "first monster";
            
            monstersList.Add("Godzilla");
            Console.WriteLine("\nFirst addition count: " + monstersList.Count);
            Console.WriteLine("First addition capacity: " + monstersList.Capacity);

            monstersList.Add("King Kong");
            Console.WriteLine("\nSecond addition count: " + monstersList.Count);
            Console.WriteLine("Second addition capacity: " + monstersList.Capacity);

            monstersList.Add("Mewtwo");
            monstersList.Add("dragon");
            monstersList.Add("King Ghidorah");
            Console.WriteLine("\nAfter adding 5 count: " + monstersList.Count);
            Console.WriteLine("After adding 5 capacity: " + monstersList.Capacity);

            monstersList.Add("witch");
            monstersList.Add("dragon");
            monstersList.Add("owlbear");
            monstersList.Add("slime cube");
            Console.WriteLine("\nAfter adding 9 count: " + monstersList.Count);
            Console.WriteLine("After adding 9 capacity: " + monstersList.Capacity);


            // ----------------------------------------------------------------
            // Access and change list data
            // ----------------------------------------------------------------
            string fourthMonster = monstersList[3];
            monstersList[2] = "whatever";


            // ----------------------------------------------------------------
            // Foreach loops
            // ----------------------------------------------------------------

            // A for loop can iterate through all of a data structures's data
            //   if the loop is written as such.
            Console.WriteLine("\nHere are all the monsters in the list FOR LOOP: ");
            for (int i = 0; i < monstersList.Count; i++)
            {
                Console.WriteLine(monstersList[i]);
            }

            // A foreach loop will iterate through EVERY item in the data structure
            //   by design!
            Console.WriteLine("\nHere are all the monsters in the list FOREACH LOOP: ");
            foreach (string item in monstersList)
            {
                Console.WriteLine(item);
            }

            // ----------------------------------------------------------------
            // Limitation: Cannot modify the data structure inside of a foreach loop. 
            // Use this kind of loop only when you want to access all data
            //   in a methodical forward manner.
            // ----------------------------------------------------------------
            //foreach (string item in monstersList)
            //{
                // ERROR! This is attempting to modify the list of monsters.
                // Causes an exception. 
                //monstersList.Add("new monster");
            //}
        }
    }
}
