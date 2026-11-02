namespace EnemyOOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy myGuy1 = new Enemy("Bob", 75);
            Enemy myGuy2 = new Enemy("Gary", 100);
            myGuy1.PrintEnemy();
            myGuy2.PrintEnemy();
            Console.WriteLine("-----------------------------");

            myGuy1.TakeDamage(15);
            myGuy1.PrintEnemy();
            Console.WriteLine("-----------------------------");

            int myGuy2Attack = myGuy2.Attack();
            int myGuy1Attack = myGuy1.Attack();
            Console.WriteLine($"{myGuy1.GetName()} attacked for {myGuy1Attack}");
            Console.WriteLine($"{myGuy2.GetName()} attacked for {myGuy2Attack}");
            myGuy1.TakeDamage(myGuy2Attack);
            myGuy2.TakeDamage(myGuy1Attack);
            myGuy1.PrintEnemy();
            myGuy2.PrintEnemy();
            Console.WriteLine("-----------------------------");

            // TESTING THE METHOD
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine( myGuy2.Attack() );
            //}

        }
    }
}
