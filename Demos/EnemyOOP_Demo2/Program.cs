namespace EnemyOOP_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy bob = new Enemy("Bob", 75);
            Enemy gary = new Enemy("Gary", 20);
            bob.PrintEnemy();
            gary.PrintEnemy();
            Console.WriteLine("---------");

            bob.TakeDamage(150);
            bob.PrintEnemy();
            Console.WriteLine("---------");

            int damageDealt = bob.Attack();
            Console.WriteLine($"{bob.Name} deals {damageDealt} damage.");
            gary.TakeDamage(damageDealt);
            gary.PrintEnemy();
            Console.WriteLine("---------");

            Console.WriteLine(bob.EnemyWeapon);             // get block executes
            bob.EnemyWeapon = Weapon.Dagger;                // set block executes
            bob.PrintEnemy();

            Console.WriteLine(gary.EnemyWeapon);             // get block executes
            gary.EnemyWeapon = Weapon.Dagger;                // set block executes
            gary.PrintEnemy();
            Console.WriteLine("---------");

            // Testing the set block of the Name property
            bob.Name = "Ian";                               // Doesn't change the name
            Console.WriteLine(bob.Name);
            bob.Name = "Steven";                            // Changes the name!
            Console.WriteLine(bob.Name);
            bob.Name = "Michael";                           // Doesn't change the name
            Console.WriteLine(bob.Name);
            Console.WriteLine("---------");

            // Test the PercentHealth property
            Console.WriteLine(gary.PercentHealth);
            Console.WriteLine("---------");

            // Test the IsDead property
            if (bob.IsDead)
                Console.WriteLine("He's a goner");
        }
    }
}
