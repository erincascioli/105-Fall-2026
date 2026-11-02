using System.ComponentModel.DataAnnotations;

namespace BeginningOOP_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();       // Instantiates a new Cat in memory!
            Cat secondCat = new Cat();
            Cat thirdCat = new Cat("Milky Way", Breed.Calico, 3, true);
            Cat fourthCat = new Cat("Dash", Breed.MaineCoon, 13, true);
            Cat fifthCat = new Cat("Anna", Breed.Ragdoll, 11);

            Console.WriteLine("First cat name: " + firstCat.name);
            Console.WriteLine("Second cat age: " + secondCat.age);
        }   

    }
}
