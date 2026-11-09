namespace InheritanceDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate 2 Parent objects, one of each constructor
            ParentClass parent1 = new ParentClass();
            ParentClass parent2 = new ParentClass("sword",
                "Bob", "mushrooms", 8);
            parent1.PrintParent();
            Console.WriteLine();
            parent2.PrintParent();
            Console.WriteLine();

            // Instantiate a child object of this parent
            ChildClass child1 = new ChildClass();
            child1.PrintParent();

            ChildClass child2 = new ChildClass(
                "axe", "John", "chicken potato", 1150, 4746);
            child2.PrintParent();
            child2.PrintChild();

            Console.WriteLine();
        }
    }
}
