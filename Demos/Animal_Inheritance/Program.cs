using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erin Cascioli
// Demo: Polymorphism with Animals

namespace Animal_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 20);
            Console.ForegroundColor = ConsoleColor.White;

            // ----------------------------------------------------------------
            // Create animals and print their data
            // ----------------------------------------------------------------
            Rabbit roger = new Rabbit("Roger", 5, "alfalfa", 4);
            roger.Print();
            Console.WriteLine("The bunny can hop " + roger.NumberOfHops + " times");
            
            Cat dash = new Cat("Dash", 10, "crunchy treats");
            dash.Print();
            
            Dog bandit = new Dog("Bandit", 6, "coffee");
            bandit.Print();

            // ----------------------------------------------------------------
            // Provide instructions for player
            // ----------------------------------------------------------------
            Console.WriteLine("\nPress 'ENTER' key to move the animals!");


            // ----------------------------------------------------------------
            // Display them in the console
            // ----------------------------------------------------------------
            roger.Draw();
            dash.Draw();
            bandit.Draw();

            // Loop this for 10 iterations
            for (int i = 0; i < 15; i++)
            {
                // "Pause" the program
                // Move cursor to top left
                // And clear what was on the screen so we can see new positions of animals
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.ReadLine();
                Console.Clear();

                // Animals all move
                roger.Hop();
                dash.Walk();
                bandit.Jump();

                // Draw them at their new positions
                roger.Draw();
                dash.Draw();
                bandit.Draw();
            }
            
            // Window
            Console.ReadLine();
        }
    }
}
