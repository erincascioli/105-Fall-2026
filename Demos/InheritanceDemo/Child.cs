using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    internal class Child : Parent
    {
        private double[] numberArray;
        private string something;


        // All child classes MUST call a parent class contstructor!!!
        // If there is no constructor in the child class, the Parent default is called.
        // If there is no parent default, trouble.

        public Child() : 
            base()     // <-- Calls default in the parent class
        {
            // All default data is set in the Parent class.

            // Set default data HERE in the child class
            numberArray = new double[10];
            for(int i = 0; i < 10; i++)
            {
                numberArray[i] = i * 10;
            }

            something = "gubernatorial";
        }

        public Child(int number, string name, string something) : 
            base(number, name)     // <-- Calls default in the parent class
        {
            // We DON'T NEED THIS WORK because the parent already does it.
            //this.name = name;
            //this.number = number;

            // Any unique data is set HERE in this class
            this.something = something;

            numberArray = new double[10];
            for (int i = 0; i < 10; i++)
            {
                numberArray[i] = i * 10;
            }
        }

        public void PrintChild()
        {
            Console.WriteLine("Child class instance:");
            base.PrintParent();
            Console.WriteLine(something);

            foreach(double d in numberArray)
            {
                Console.WriteLine(d);
            }
        }
    }
}
