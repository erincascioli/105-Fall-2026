using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo_2
{
    /// <summary>
    /// Parent of ChildClass
    /// </summary>
    internal class ParentClass
    {
        // All of these fields are given to all child classes
        protected string weapon;
        protected string name;
        protected string food;
        protected int points;

        // The ChildClass default constructor calls this one
        public ParentClass()
        {
            // This parent is handling the work of assigning values for the weapon,
            //   name, food, and points.
            // Child classes using this constructor don;t have to replicate that work
            //   internally in their constructor.
            // They, however, can choose to overwrite any of these defaukt values if they want!
            weapon = "blaster";
            name = "Luigi";
            food = "pasta";
            points = 30;
        }

        public ParentClass(string weapon, string name, string food, int points)
        {
            this.weapon = weapon;
            this.name = name;
            this.food = food;
            this.points = points;
        }

        public void PrintParent()
        {
            Console.WriteLine(weapon);
            Console.WriteLine(name);
            Console.WriteLine(food);
            Console.WriteLine(points);
        }
    }
}
