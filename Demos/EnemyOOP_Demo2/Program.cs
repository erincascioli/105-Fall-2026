namespace EnemyOOP_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy bob = new Enemy("Bob", 75);
            Enemy gary = new Enemy("Gary", 100);
            bob.PrintEnemy();
            gary.PrintEnemy();
            Console.WriteLine("---------");

            bob.TakeDamage(150);
            bob.PrintEnemy();
            Console.WriteLine("---------");

            int damageDealt = bob.Attack();
            Console.WriteLine($"{bob.GetName()} deals {damageDealt} damage.");
            gary.TakeDamage(damageDealt);
            gary.PrintEnemy();
        }
    }
}
