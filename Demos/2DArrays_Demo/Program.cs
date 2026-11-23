namespace _2DArrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multidimensional (square/rectangular) arrays

            // ------------------------------------------------------------------------------------
            // Problem 1:  Declare and initialize a 2D integer array named 'table', 4 rows, 5 columns
            //             - Place default data 100 in each element
            //             - Print all data in a 3x3 grid
            // ------------------------------------------------------------------------------------

            // 1. Declare and initialize 4x5 array
            // *** ADD CODE HERE *** //


            // 2. Use default value of 100 for each element
            int initialValue = 100;

            // 3. Place default value in each element
            // 4.Print every element
            //for (int row = 0; row < 4; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        table[row][col] = initialValue;
            //        Console.Write(table[row][col] + " ");
            //    }

            //    Console.WriteLine();
            //}



            // ------------------------------------------------------------------------------------
            // Problem 2:  Declare and initialize a 2D array named 'studentPartners'
            //             Data row 1: Brice, Jackson, Anna,   Noah
            //             Data row 2: Kamal, Maria,   Elissa, Kevin
            //             - Print all partners
            //             - Access just the second group of partners (Jackson and Maria)
            //             - Change loops to find the dimensions of the array
            // ------------------------------------------------------------------------------------

            int rows = 2;
            int columns = 4;

            // 1. Declare and initialize 'studentPartners' array 4x2 array with data specified from above
            // *** ADD CODE HERE *** //


            // 2. Print all partnerships
            // 4. Change loops to find the dimensions of the array
            //for (int row = 0; row < rows; row++)
            //{
            //    Console.Write("Partners: ");

            //    for (int col = 0; col < columns; col++)
            //    {
            //        Console.Write(studentPartners[row][col] + " ");
            //    }

            //    Console.WriteLine();
            //}


            // 3. Access second group of partners (Jackson and Maria)
            // *** ADD CODE HERE *** //


            #endregion

            #region Jagged arrays

            // ------------------------------------------------------------------------------------
            // Problem 3:  Declare and initialize a jagged array of integers
            //             - Print the values 47, 51, and 92 by accessing them jagged array
            // ------------------------------------------------------------------------------------

            // 1. Declare and initialize jagged array of integers:
            //    47  3   12
            //    51  74  20  27
            //    15  92 

            //int[][] numbers = 
            //[ 
            //    [ 47, 3,  12 ], 
            //    [ 51, 74, 20, 27 ], 
            //    [ 15, 92 ] 
            //];

            // OR:
            //int[][] numbers =
            //{
            //    new[] { 47, 3,  12 },
            //    new[] { 51, 74, 20, 27 },
            //    new[] { 15, 92 }
            //};

            // OR:
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 47, 3, 12 };
            numbers[1] = new int[] { 51, 74, 20, 27 };
            numbers[2] = new int[] { 15, 92 };

            // 2. Print the values 47, 51, and 92 by accessing them jagged array
            // *** ADD CODE HERE *** //




            // ------------------------------------------------------------------------------------
            // Problem 4:  Access individual characters of a string in an array of strings
            //             - Print all letters of the string 'book' on separate lines
            // ------------------------------------------------------------------------------------

            // 1. Add 3 strings to an array of strings
            string[] myItems = new string[3];
            myItems[0] = "paper clip";
            myItems[1] = "stapler";
            myItems[2] = "book";

            // Print all letters of the string 'book' on separate lines in separate C.WL statements
            // *** ADD CODE HERE *** //


            #endregion

            // Examples derived from here:
            // https://runestone.academy/ns/books/published/apcsareview/Array2dBasics/Exercises.html
        }
    }
}
