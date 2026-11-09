using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    internal class Parent
    {
        // Parent fields
        protected int number;
        protected string name;

        public Parent()
        {
            number = 419;
            name = "Gerald";
        }

        public Parent(int number, string name)
        {
            this.number = number;
            this.name = name;
        }

        public void PrintParent()
        {
            Console.WriteLine(number);
            Console.WriteLine(name);
        }
    }
}
