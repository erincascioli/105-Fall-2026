using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    // Cat is a child class of Animal
    // Child classes receive all of the code from the shared parent class,
    //   including fields, properties, the parent constructor, and methods.
    // Child classes should not repeat any of the code from the parent class.
    // Children CAN define their own unique fields, properties, and methods
    //   if they have unique data or behaviors. 
    // Child class constructors will run AFTER the parent class's does.
    // Child class constructors must call the parent class's constructor 
    //   via the base keyword.

    class Cat : Animal
    {   
        // No unique data for cat!

        public Cat(string name, int age, string favoriteTreat)
            : base(name, age, favoriteTreat)
        {
            // Parent class assigns values for the name, age and treat fields!

            // Override parent class field values with cat-specific default data
            xPosition = 8;
            yPosition = 10;
            textColor = ConsoleColor.Green;
            characterToDraw = "C";
        }
        
        /// <summary>
        /// Moves this cat to a new position in the console window
        /// Cat moves "left" by 1 units
        /// If cat moves offscreen, wraps it to the left
        /// </summary>
        public void Walk()
        {
            // Increase cat's X position so it "walks" across the screen
            xPosition++;

            // If it walks offscreen, place the cat at the left of the window
            if (xPosition >= 40)
            {
                xPosition = 0;
            }
        }
    }
}
