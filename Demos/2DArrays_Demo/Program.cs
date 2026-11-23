namespace _2DArrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Declare and initialize multidimensional arrays

            // ------------------------------------------------------------------------------------
            // Problem 1:  Declare and initialize a 2D integer array named 'table', 3 rows, 3 columns
            //             Place default data 100 in each element
            //             - Print all data in a 3x3 grid
            // ------------------------------------------------------------------------------------

            int rows = 3;
            int columns = 3;

            // *** ADD CODE HERE *** //


            // Print all values in the array
            int initialValue = 100;

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < columns; col++)
            //    {
            //        table[row][col] = initialValue;
            //        count++;
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
            // ------------------------------------------------------------------------------------

            int rows = 2;
            int columns = 4;

            // *** ADD CODE HERE *** //


            // Print all partnerships
            //for (int row = 0; row <= rows; row++)
            //{
            //    Console.Write("Partners: ");

            //    for (int col = 0; col <= columns; col++)
            //    {
            //        Console.Write(studentPartners[row][col] + " ");
            //    }

            //    Console.WriteLine();
            //}


            // Access second group of partners (Jackson and Maria)

            // *** ADD CODE HERE *** //

            #endregion

            #region Declare and initialize jagged arrays

            // ------------------------------------------------------------------------------------
            // Problem 3:  Declare and initialize a jagged array of integers
            //             - Print the values 47, 51, and 92 by accessing them jagged array
            // ------------------------------------------------------------------------------------

            int[][] arr = { 
                { 47, 3,  12 }, 
                { 51, 74, 20, 27 }, 
                { 15, 92 } 
            };

            // *** ADD CODE HERE *** //




            // ------------------------------------------------------------------------------------
            // Problem 4:  Access individual characters of a string in an array of strings
            //             - Print all letters of the string 'stapler' on separate lines
            // ------------------------------------------------------------------------------------

            string[] myItems = new string[3];
            myItems[0] = "paper clip";
            myItems[1] = "stapler";
            myItems[2] = "book";

            // *** ADD CODE HERE *** //


            #endregion
        }
    }
}
