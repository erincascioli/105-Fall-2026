using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo_2
{
    internal class ChildClass : ParentClass
    {

        // Data unique to this child class
        private int age;

        public ChildClass() : base()
        {
            // No work needs to be done here!
            // Parent class is already doing the work!

            // Overwrite any parent class assigned default data
            points = 45;

            // Assign values to unique fields
            age = 5;
        }

        public ChildClass(string weapon, string name, string food, int points, int age) : 
            base(weapon, name, food, points)
        {
            // Parent class is already doing the work!

            // Assign unique fields parameterized data
            this.age = age;
        }

        public void PrintChild()
        {
            Console.WriteLine("I am a CHILD object!");
            base.PrintParent();
            Console.WriteLine(age);
        }
    }
}
