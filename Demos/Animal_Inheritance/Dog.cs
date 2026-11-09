using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    // Dog is a child class of Animal
    // Child classes receive all of the code from the shared parent class,
    //   including fields, properties, the parent constructor, and methods.
    // Child classes should not repeat any of the code from the parent class.
    // Children CAN define their own unique fields, properties, and methods
    //   if they have unique data or behaviors. 
    // Child class constructors will run AFTER the parent class's does.
    // Child class constructors must call the parent class's constructor 
    //   via the base keyword.

    class Dog : Animal
    {
        // No unique data for dog!

        public Dog(string name, int age, string favoriteTreat)
            : base(name, age, favoriteTreat)
        {
            // Parent class assigns values for the name, age and treat fields!

            // Override parent class field values with dog-specific default data
            xPosition = 2;
            yPosition = 15;
            textColor = ConsoleColor.Blue;
            characterToDraw = "D";
        }

        
        /// <summary>
        /// Moves this dog to a new position in the console window
        /// Dog moves "up" by 2 units
        /// If dog moves offscreen, wraps it back to the bottom
        /// </summary>
        public void Jump()
        {
            // Decrease dog's y position so it "jumps" up the window
            yPosition -= 2;

            // If it jumps offscreen, place the dog at the bottom of window
            if (yPosition <= 0)
            {
                yPosition = 19;
            }
        }
        
    }
}
