using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    // Parent class to Cat, Dog and Rabbit
    // Should contain code that is shared among all children
    //   including fields, properties, a constructor, and methods.
    // Protested access modifier means that children can access those fields,
    //   but classes outside of the parent or child cannot. This is typically used for
    //   fields in the parent class when utilizing inheritance.
    // Child classes receive ALL of the code from this parent class

    class Animal
    {
        // Animal data
        protected string name;
        protected int age;
        protected string favoriteTreat;

        // Position and display attributes
        protected int xPosition;
        protected int yPosition;
        protected ConsoleColor textColor;
        protected string characterToDraw;
        protected Random generator;

        /// <summary>
        /// Default Animal constructor sets up default data
        /// </summary>
        public Animal()
        {
            name = "name";
            age = 0;
            favoriteTreat = "treat";
            xPosition = 0;
            yPosition = 0;
            textColor = ConsoleColor.White;
            characterToDraw = "XX";
            generator = new Random();
        }

        /// <summary>
        /// Parameterized Animal constructor allows custom information to be passed
        /// in for each parent and animal type.
        /// </summary>
        /// <param name="name">Name of the animal</param>
        /// <param name="age">Age of the animal</param>
        /// <param name="treat">Animal's favorite thing to eat</param>
        /// <param name="xPos">X position in the console</param>
        /// <param name="yPos">Y position in the console</param>
        /// <param name="textColor">Text color in the console</param>
        /// <param name="toDraw">Character to represent the animal</param>
        public Animal(string name, int age, string treat, 
            int xPos, int yPos, ConsoleColor textColor, string toDraw)
        {
            this.name = name;
            this.age = age;
            this.favoriteTreat = treat;

            xPosition = xPos;
            yPosition = yPos;
            this.textColor = textColor;
            characterToDraw = toDraw;

            // Just in case any child classes need Randomness
            generator = new Random();
        }

        /// <summary>
        /// Displays information about this animal to the console window
        /// </summary>
        public void Print()
        {
            Console.WriteLine("{0} is {1} years old. \n{0}'s favorite treat is {2}.",
                name,
                age,
                favoriteTreat);
        }

        /// <summary>
        /// Displays a character at this animal's position in the console window
        /// </summary>
        public void Draw()
        {
            // Move the cursor to the animal's position
            // Set text color and "draw" the animal
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.ForegroundColor = textColor;
            Console.Write(characterToDraw);
        }


        /// <summary>
        /// Virtual method alows child classes to override this.
        /// For now, method doesn't do much but needs to be there for polymorphism
        /// to run the correct "version" (i.e. either Parent or Child method) on each
        /// object.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("This animal moves.");

            // How do individual children move? No idea. 
        }

        /// <summary>
        /// Overridden method for returning a string representation of this class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string returnedString = $"{name} is {age} years old.";
            return returnedString;

            //return "This is a generic animal object.";

            // Must override, even in the parent class you write.
        }

    }
}
