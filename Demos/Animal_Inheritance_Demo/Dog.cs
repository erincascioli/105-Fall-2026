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
        // No unique fields for dog!

        /// <summary>
        /// Constructor for the Dog class
        /// </summary>
        /// <param name="name">Name of the dog</param>
        /// <param name="age">Age of the dog</param>
        /// <param name="favoriteTreat">Dog's favorite thing to eat</param>
        public Dog(string name, int age, string favoriteTreat)
            : base(name, age, favoriteTreat, 2, 15, ConsoleColor.Blue, "D")
        {
            // Parent class takes care of all field assignment
        }
    }
}
