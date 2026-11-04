using System;
using System.Collections.Generic;
using System.Text;

namespace EnemyOOP_Demo2
{
    /// <summary>
    /// Weapon types that Enemy objects can wield.
    /// </summary>
    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }

    /// <summary>
    /// Class that represents an Enemy in a game.
    /// </summary>
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
        // Properties go here, between fields and constructors!!!
        // --------------------------------------------------------------------

        /// <summary>
        /// Property for the name field that allows for retrieving the name and also
        /// limited changing of the name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // Only change the name if the attempted change is twice the size
                //   or more
                if (value.Length >= name.Length * 2)
                    name = value;
            }
        }

        /// <summary>
        /// Read-only property for the currentHealth field
        /// </summary>
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
        }

        /// <summary>
        /// Read and write access to the Weapon field. 
        /// </summary>
        public Weapon EnemyWeapon
        {
            get
            {
                return enemyWeapon;
            }
            set
            {
                // Only swap weapons when the enemy reaches < 20% health and not dead
                // This is a limitation on the setting of data!
                if(currentHealth <= maxHealth * 0.2 && currentHealth > 0)
                    enemyWeapon = value;
            }
        }

        /// <summary>
        /// Property without a backing field.  Calculates the percent of health.
        /// </summary>
        public double PercentHealth
        {
            get 
            { 
                return ((double)currentHealth / maxHealth) * 100; 
            }
        }

        /// <summary>
        /// Property without a backing field. Determines whether Enemy is dead. 
        /// </summary>
        public bool IsDead
        {
            get 
            { 
                return currentHealth <= 0; 
            }
        }      
               

        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------

        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;

            // All Enemies can be maxed to 100 HP
            maxHealth = 200;

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

            // All enemies start with the same 3 items
            heldItems = new string[3] { "rations", "trinket", "trap" };

            // Get an instance of Random ready for any necessary value randomization
            generator = new Random();
        }


        // --------------------------------------------------------------------
        // METHODS of the class
        // --------------------------------------------------------------------

        public void PrintEnemy()
        {
            Console.WriteLine($"{name} has a {enemyWeapon}.");
            Console.WriteLine($"{name} has {currentHealth}/{maxHealth} health.");
            Console.WriteLine($"{name} is holding:");
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.WriteLine($"  - {heldItems[i]}");
            }
        }

        public void TakeDamage(int damage)
        {
            // Choice 1:  Take positive value of a negative damage
            currentHealth = currentHealth - Math.Abs(damage);

            // Choice 2: Only take damage when its positive
            //if(damage > 0)
            //    currentHealth = currentHealth - damage;

            // Cap the health at the lowest value of 0
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
                    lowDamage = 10;
                    highDamage = 14;
                    break;
            }

            return generator.Next(lowDamage, highDamage + 1);
        }

    }
}
