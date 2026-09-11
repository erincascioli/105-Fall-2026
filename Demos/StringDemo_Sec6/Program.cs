namespace StringDemo_Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Strings are a variable type with no fixed size
            // More characters --> Longer length --> More bytes
            string phrase = "Hello, World!";
            int lastIndex = phrase.Length - 1;
            int middleIndex = lastIndex / 2;

            Console.WriteLine(phrase);
            
            phrase = phrase.ToUpper();
            Console.WriteLine(phrase);

            string partOfPhrase1 = phrase.Substring(2);
            Console.WriteLine(partOfPhrase1);

            string partOfPhrase2 = phrase.Substring(3, 5);
            Console.WriteLine(partOfPhrase2);

            phrase.Substring(3, 20);

            /*
            // Print the string to the console window
            Console.WriteLine(phrase);

            // Print the length of the phrase with the Length property
            // (Not a method, does not have parentheses)
            Console.WriteLine(phrase.Length);

            // Concatenate description text with the Length property
            Console.WriteLine("The length of this string is " + phrase.Length);

            Console.WriteLine("The first character is " + phrase[0]);
            Console.WriteLine("The last character is " + phrase[12]);
            Console.WriteLine("The last character is " + phrase[phrase.Length - 1]);
            Console.WriteLine("The last character is " + phrase[lastIndex]);
            Console.WriteLine("The middle character is " + phrase[middleIndex]);
            */
        }
    }
}
