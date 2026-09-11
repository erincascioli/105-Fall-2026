namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String variables can be inputted into a C.WL statement
            int lastIndex = 0;
            string phrase = "Hello, World!";

            lastIndex = phrase.Length - 1;
            Console.WriteLine(phrase);

            // Length
            // Property --> c# construct, not a method, no ()
            Console.WriteLine("Number of characters: " + phrase.Length);
            Console.WriteLine("First character is " + phrase[0]);
            Console.WriteLine("Last character is " + phrase[12]);
            Console.WriteLine("Last character is " + phrase[lastIndex]);

            // Indices
            // Methods
            string upperPhrase = phrase.ToUpper();
            Console.WriteLine(phrase);
            Console.WriteLine(upperPhrase);

            // Portion of a phrase
            Console.WriteLine("Part of the phrase is " + phrase.Substring(2, 2));

        }
    }
}
