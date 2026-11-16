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
        // Rabbit data
        private int numberOfHops;

        // Rabbit properties
        public int NumberOfHops
        {
            get { return numberOfHops; }
        }

        /// <summary>
        /// Constructor for the Rabbit class
        /// </summary>
        /// <param name="name">Name of the rabit</param>
        /// <param name="age">Age of the rabbit</param>
        /// <param name="favoriteTreat">Rabbit's favorite thing to eat</param>
        /// <param name="numberOfHops">How many hops a rabbit takes</param>
        public Rabbit(string name, int age, string favoriteTreat, int numberOfHops)
            : base(name, age, favoriteTreat, 3, 11, ConsoleColor.White, "R")
        {
            this.numberOfHops = numberOfHops;
        }               


        /// <summary>
        /// Unique method to the Rabbit class
        /// </summary>
        public void Thump()
        {
            Console.WriteLine("I am thumping my foot because I'm mad.");
        }

        public override string ToString()
        {
            string rogerInfo = base.ToString();
            rogerInfo +=
                "This is the returned string from the ToString method in the Animal class: ";
            return rogerInfo;
        }

    }
}
