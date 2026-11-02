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

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // TODO: Add an XML comment for this constructor
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
            heldItems = new string[4] { "rations", "trinket", "trap", "healing potion" };

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

        // 1. Print data about the enemy
        // 2. Harm this enemy (takes damage and reduces currentHealth)
        // 3. Attack another enemy (randomly attack based on weapon type)
        // 4. Heal to no more than full health
        // 5. Get the name of this Enemy

    }
}
