using System;
using System.Collections.Generic;

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
            // Initialization of Animal objects         


            // Create animals and print their data
            Rabbit roger = new Rabbit("Roger", 5, "alfalfa", 4);
            //roger.Print();
            Console.WriteLine("The bunny can hop " + roger.NumberOfHops + " times");
            
            Cat dash = new Cat("Dash", 10, "crunchy treats");
            //dash.Print();
            
            Dog bandit = new Dog("Bandit", 6, "coffee");
            //bandit.Print();


            // ----------------------------------------------------------------
            // List of Animal objects
            // ----------------------------------------------------------------

            // Data structure to hold Animals (all cats, dogs, rabbits)
            List<Animal> myAnimals = new List<Animal>();

            // Since all animals share a base type of Animal, they can be stored in the same
            //   data structure of type Animal
            myAnimals.Add(roger);
            myAnimals.Add(dash);
            myAnimals.Add(bandit);

            // Print out all animals
            // Only Rabbits can Thump
            for(int i = 0; i < myAnimals.Count; i++)
            {
                myAnimals[i].Print();

                // Check whether the object is of the appropriate child type
                // This is *really* important otherwise a runtime error will occur of type 
                //   InvalidCastException
                if (myAnimals[i] is Rabbit)
                {
                    // Downcast the child object to a child type in order to use anything
                    //   unique to that class.
                    Rabbit tempRabbit = (Rabbit)myAnimals[i];
                    tempRabbit.Thump();
                }
            }

            

            /*
            myAnimals[0].Print();

            // Downcast the animal to a Rabbit
            Rabbit tempRabbit = (Rabbit)myAnimals[0];
            tempRabbit.Thump();

            ((Rabbit)myAnimals[0]).Thump();
            */
            


            // ----------------------------------------------------------------
            // Using ToString()
            // ----------------------------------------------------------------

            
            // The ToString() method is called on every object reference that's passed
            //   into a C.WL method.
            // Our goal is to write a more meaningful version of the ToString method.
            //Console.WriteLine(roger.ToString());
            //Console.WriteLine(65.ToString());
            //Console.WriteLine(true.ToString());



            // These are here to have a "break" between the printed stuff and the animals
            //   moving in the window.
            Console.ReadLine();
            Console.Clear();
            


            // ----------------------------------------------------------------
            // Draw all Animal objects
            // ----------------------------------------------------------------

            /*
            // Display all animals in the console
            foreach (Animal animal in myAnimals)
            {
                // They can all be drawn to the console window.
                animal.Draw();

                // Only Rabbits need to thump:
                if (animal is Rabbit)
                {
                    // Do this by casting the Animal to a Rabbit in one of 2 ways:
                    
                    // Way #1:
                    Rabbit myRabbitObjectReference = (Rabbit)animal;
                    myRabbitObjectReference.Thump();

                    // Or Way #2:
                    ((Rabbit)animal).Thump();
                }
            }
            */


            // ----------------------------------------------------------------
            // Move each animal for 10 iterations
            // ----------------------------------------------------------------
            /*
            // Show the animals moving for 10 iterations:
            for (int i = 0; i < 10; i++)
            {
                // "Pause" the program
                // Move cursor to top left
                // And clear what was on the screen so we can see new positions of animals
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.ReadLine();
                Console.Clear();

                // Animals all move - regardless of the child type,
                //   I know that they all "move" with the same method name
                // Easier to remember than separately-named movement method
                //   for each child class.
                // Display them in the console and then
                // Draw them at their new positions
                // No need for overriding here. They are all drawn the same way.
                foreach (Animal animal in myAnimals)
                {
                    animal.Move();
                    animal.Draw();
                }
            }
            */


            // ----------------------------------------------------------------
            // Fin!  :)
            // ----------------------------------------------------------------
        }
    }
}
