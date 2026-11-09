namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent1 = new Parent();
            Parent parent2 = new Parent(20, "Fjord");

            Child child1 = new Child();
            child1.PrintParent();

            Child child2 = new Child(500, "Tim", "Joe");
            child2.PrintParent();
            child2.PrintChild();

            Console.WriteLine();
        }
    }
}
