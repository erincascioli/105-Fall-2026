using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    // Rabbit is a child class of Animal
    // Child classes receive all of the code from the shared parent class,
    //   including fields, properties, the parent constructor, and methods.
    // Child classes should not repeat any of the code from the parent class.
    // Children CAN define their own unique fields, properties, and methods
    //   if they have unique data or behaviors. 
    // Child class constructors will run AFTER the parent class's does.
    // Child class constructors must call the parent class's constructor 
    //   via the base keyword.

    class Rabbit : Animal
    {
        // Unique Rabbit data
        private int numberOfHops;

        // Unique Rabbit property
        public int NumberOfHops
        {
            get { return numberOfHops; }
        }

        public Rabbit(string name, int age, string favoriteTreat, int numberOfHops)
            : base(name, age, favoriteTreat)
        {
            // Parent class assigns values for the name, age and treat fields!

            // Assign value to unique rabbit field
            this.numberOfHops = numberOfHops;

            // Override parent class field values with rabbit-specific default data
            xPosition = 3;
            yPosition = 11;
            textColor = ConsoleColor.DarkYellow;
            characterToDraw = "R";
        }               

        /// <summary>
        /// Moves this rabbit to a new position in the console window
        /// X and Y positions are randomly generated and will remain
        /// in the bounds of the console window
        /// </summary>
        public void Hop()
        {
            // Choose a new spot on the console window
            RandomPosition();
        }        
    }
}
