using System;
using System.Collections.Generic;
using System.Text;

namespace EnemyOOP_Demo
{

    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }


    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS of the class
        // --------------------------------------------------------------------
        // Today, we use private fields! Typically, a class wants to keep its data
        //   private, and only allow access whenever and wherever needed.
        private string name;
        private int currentHealth;
        private int maxHealth;
        private Weapon enemyWeapon;
        private string[] heldItems;
        private Random generator;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------

        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;

            // All Enemies can be maxed to 100 HP
            maxHealth = 100;

            // Weapon type is dependent on the name length
            int nameLength = name.Length;

            if (nameLength <= 3)                 // 0-3 chars
            {
                enemyWeapon = Weapon.Sword;
            }
            else if (nameLength <= 7)            // 4-7 chars
            {
                enemyWeapon = Weapon.Axe;
            }
            else                                // 8+ chars
            {
                enemyWeapon = Weapon.Dagger;
            }

            // All enemies start with the same 4 items
            heldItems = new string[3] 
            { "rations", "trinket", "trap" };

            // Get an instance of Random ready for any necessary value randomization
            generator = new Random();

            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // TODO: Write the answer to these 2 questions here, as comments:
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // What type is it – default or parameterized?
            //
            // What does this constructor do?
            //
        }


        // --------------------------------------------------------------------
        // METHODS of the class
        // --------------------------------------------------------------------

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // TODO: We will write some methods today!
        // TODO: When class is over, add an XML comment to each method.
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // 1. DONE Print data about the enemy
        // 2. DONE Harm this enemy (takes damage and reduces currentHealth)
        // 3. Attack another enemy (randomly attack based on weapon type)
        // 4. Heal to no more than full health
        // 5. Get the name of this Enemy

        /// <summary>
        /// Prints details about this Enemy instance.
        /// </summary>
        public void PrintEnemy()
        {
            Console.WriteLine($"{name} has a {enemyWeapon}.");
            Console.WriteLine($"{name} has {currentHealth}/{maxHealth} health");
            Console.WriteLine($"{name} has these items:");
            for (int i = 0; i < heldItems.Length; i++)
            {
                Console.WriteLine($" - {heldItems[i]}");
            }
        }

        /// <summary>
        /// Reduces this Enemy instance's current health by a spcified amount
        /// </summary>
        /// <param name="damage">Amount of damage the Enemy receives. 
        /// When value is negative, no damage is applied.</param>
        public void TakeDamage(int damage)
        {
            // Only positive damage can harm the player
            if(damage >= 0)
                currentHealth -= damage;

            // Dropped below 0? Cap it at 0.
            if (currentHealth < 0)
                currentHealth = 0;
        }


        public int Attack()
        { 
            int lowDamage = 0;
            int highDamage = 0;

            switch(enemyWeapon)
            {
                case Weapon.Axe:
                    lowDamage = 5;
                    highDamage = 9;
                    break;
                case Weapon.Dagger:
                    lowDamage = 2;
                    highDamage = 6;
                    break;
                case Weapon.Sword:
                    lowDamage = 6;
                    highDamage = 12;
                    break;
            }

            return generator.Next(lowDamage, highDamage + 1);
        }

        public string GetName()
        {
            return name;
        }



        /*
        public void PrintEnemy()
        {
            Console.WriteLine($"{name} carries a {enemyWeapon}.");
            Console.WriteLine($"{currentHealth}/{maxHealth} health");
            Console.WriteLine($"There are {heldItems.Length} items:");
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.WriteLine($" - {heldItems[i]}");
            }
        }

        public void TakeDamage(int damage)
        {
            // What if damage is negative? Don't want to heal.
            currentHealth -= Math.Abs(damage);

            // What if health drops below 0?
            if (currentHealth < 0) 
                currentHealth = 0;
        }

        public int Attack()
        {
            int lowDamage = 0;
            int highDamage = 0;

            switch(enemyWeapon)
            {
                case Weapon.Axe:
                    lowDamage = 5;
                    highDamage = 9;
                    break;
                case Weapon.Dagger:
                    lowDamage = 2;
                    highDamage = 6;
                    break;
                case Weapon.Sword:
                    lowDamage = 6;
                    highDamage = 12;
                    break;
            }

            return generator.Next(lowDamage, highDamage + 1);
        }

        public bool Heal()
        {
            // Heal if the enemy has a healing potion
            // Search through the items to find one!
            bool hasPotion = false;
            for(int i = 0; i < heldItems.Length; i++)
            {
                if (heldItems[i] == "healing potion")
                    hasPotion = true;
            }

            if(hasPotion)
            {
                currentHealth = maxHealth;
                return true;
            }

            return false;
        }

        public string GetName()
        {
            return name;
        }
        */
    }
}
