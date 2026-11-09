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

        // This constructor will run first!
        public Animal(string name, int age, string treat)
        {
            // Parameterized information
            this.name = name;
            this.age = age;
            this.favoriteTreat = treat;

            // Default information
            xPosition = 0;
            yPosition = 0;
            textColor = ConsoleColor.White;
            characterToDraw = "XX";
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
            // Move the cursor to the Rabbit's position
            // Set text color and "draw" the rabbit
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.ForegroundColor = textColor;
            Console.Write(characterToDraw);
        }

        /// <summary>
        /// Generates random value for this animal's X and Y positions
        /// </summary>
        public void RandomPosition()
        {
            xPosition = generator.Next(0, 40);
            yPosition = generator.Next(0, 20);
        }

    }
}
