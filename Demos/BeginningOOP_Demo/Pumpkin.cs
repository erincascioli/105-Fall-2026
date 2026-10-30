using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningOOP_Demo
{
    /// <summary>
    /// All of the possible colors of pumpkins
    /// </summary>
    public enum Color
    {
        Orange,
        White,
        Red,
        Yellow,
        Green,
        Black
    }

    /// <summary>
    /// This class represents a pumpkin.  
    /// </summary>
    internal class Pumpkin
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------
        // Fields are the data that make up a class
        // Every object of this Pumpkin type has its own set of these 5 variables
        // For today, we declare them "public"
        // In future classes, we'll change this
        public string name;
        public float weight;
        public Color color;
        public bool isCarved;
        public double radius;


        /// <summary>
        /// Default constructor initializes all fields with default data.
        /// </summary>
        public Pumpkin()
        {
            // Assign each field a value
            // Every Pumpkin created with this constructor has this exact data!
            name = "Spookley";
            weight = 5f;
            color = Color.Orange;
            isCarved = false;
            radius = 10.5;
        }

        /// <summary>
        /// Creates a new Pumpkin with parameterized data
        /// </summary>
        /// <param name="name">Name of this pumpkin</param>
        /// <param name="weight">Weight (in pounds)</param>
        /// <param name="color">Color of the pumpkin</param>
        /// <param name="isCarved">Whether the pumpkin is a Jack O'Lantern yet</param>
        /// <param name="radius">Radius (in inches)</param>
        public Pumpkin(string name, float weight, Color color, bool isCarved, double radius)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
            this.isCarved = isCarved;
            this.radius = radius;
        }

        /// <summary>
        /// Partially parameterized Pumpkin object
        /// </summary>
        /// <param name="name">Name of this pumpkin</param>
        /// <param name="weight">Weight (in pounds)</param>
        /// <param name="radius">Radius (in inches)</param>
        public Pumpkin(string name, float weight, double radius)
        {
            // Parameterized
            this.name = name;
            this.weight = weight;
            this.radius = radius;

            // Default
            this.color = Color.Orange;
            this.isCarved = false;
        }
    }
}
