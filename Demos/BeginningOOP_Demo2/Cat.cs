using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningOOP_Demo2
{
    /// <summary>
    /// Represents the possible breeds of cat. Used in the Cat class.
    /// </summary>
    public enum Breed
    {
        RussianBlue,
        Orange,
        Ragdoll,
        MaineCoon,
        Calico
    }
    
    /// <summary>
    /// Represents a Cat.
    /// </summary>
    internal class Cat
    {
        // --------------------------------------------------------------------
        // Fields of the class
        // --------------------------------------------------------------------
        // All classwide data is considered a "field"
        // These are called "attributes" or "class variables" in other languages.
        public string name;
        public Breed catBreed;
        public int age;
        public bool hasClaws;

        // --------------------------------------------------------------------
        // Constructor(s)
        // --------------------------------------------------------------------
        // Constructors are meant to ensure that all fields of the class have
        //   values by the end of the constructor.
        // 2 types: Default and Parameterized
        // Default: Assigns default data to all fields of the class
        // Parameterized: Allows customizable data for some or all fields.
        // These are considered "overloaded" because the constructor has the same
        //   name (the name of the class) but different parameter lists!
        
        /// <summary>
        /// Default constructor that instantiates a Cat object.
        /// </summary>
        public Cat()
        {
            name = "Charles";
            catBreed = Breed.Orange;
            age = 7;
            hasClaws = true;
        }

        /// <summary>
        /// Constructs a Cat object.
        /// </summary>
        /// <param name="name">Name of this cat</param>
        /// <param name="catBreed">Breed of this cat, out of 5 possible options</param>
        /// <param name="age">Current cat age</param>
        /// <param name="hasClaws">Whether the cat has its claws</param>
        public Cat(string name, Breed catBreed, int age, bool hasClaws)
        {
            this.name = name;
            this.catBreed = catBreed;
            this.age = age;
            this.hasClaws = hasClaws;
        }

        public Cat(string name, Breed catBreed, int age)
        {
            // Parameterize some data
            this.name = name;
            this.catBreed = catBreed;
            this.age = age;

            // Default data
            hasClaws = true;
        }

        /*
        public Cat(string catName, Breed breed, int catAge, bool claws)
        {
            name = catName;
            catBreed = breed;
            age = catAge;
            hasClaws = claws;
        }

        public Cat(string p_name, Breed p_breed, int p_age, bool p_claws)
        {
            name = p_name;
            catBreed = p_breed;
            age = p_age;
            hasClaws = p_claws;
        }
        */



    }
}
