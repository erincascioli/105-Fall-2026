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
        // No unique fields for cat!

        /// <summary>
        /// Constructor for a Cat
        /// </summary>
        /// <param name="name">Name of the cat</param>
        /// <param name="age">Age of the cat</param>
        /// <param name="favoriteTreat">Cat's favorite thing to eat</param>
        public Cat(string name, int age, string favoriteTreat)
            : base(name, age, favoriteTreat, 8, 10, ConsoleColor.Green, "C")
        {
            // Parent class takes care of all field assignment
        }
        
    }
}
