namespace EnemyOOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial instantiation of Enemy objects
            Enemy myGuy1 = new Enemy("Bob", 20);
            Enemy myGuy2 = new Enemy("Gary", 100);
            myGuy1.PrintEnemy();
            myGuy2.PrintEnemy();
            Console.WriteLine("-----------------------------");

            // Test the TakeDamage method
            //myGuy1.TakeDamage(15);
            myGuy1.PrintEnemy();
            Console.WriteLine("-----------------------------");

            // Test Attack method and Name property
            int myGuy2Attack = myGuy2.Attack();
            int myGuy1Attack = myGuy1.Attack();
            Console.WriteLine($"{myGuy1.Name} attacked for {myGuy1Attack}");
            Console.WriteLine($"{myGuy2.Name} attacked for {myGuy2Attack}");
            myGuy1.TakeDamage(myGuy2Attack);
            myGuy2.TakeDamage(myGuy1Attack);
            myGuy1.PrintEnemy();
            myGuy2.PrintEnemy();
            Console.WriteLine("-----------------------------");

            // Test changing a weapon
            myGuy1.EnemyWeapon = Weapon.Dagger;
            Console.WriteLine(myGuy1.EnemyWeapon);
            myGuy1.PrintEnemy(); 
            Console.WriteLine("-----------------------------");

            Console.WriteLine(myGuy2.PercentHealth);
        }
    }
}
