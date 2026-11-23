namespace ListForeachDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // grocery list, chores, to do
            List<string> feast = new List<string>();
            //Console.WriteLine(feast.Capacity);
            //Console.WriteLine(feast.Count);

            // cranberry sauce, pasta, mashed potatoes, pie, hawaiian bread
            // mac & cheese, corn, stuffing, deviled eggs, green beans
            feast.Add("turkey");
            feast.Add("cranberry sauce");
            feast.Add("pasta");
            feast.Add("mashed potatoes");
            feast.Add("pie");
            feast.Add("hawaiian bread");
            feast.Add("mac and cheese");
            feast.Add("corn");
            feast.Add("stuffing");
            Console.WriteLine(feast.Capacity);
            Console.WriteLine(feast.Count);

            feast[5] = "green beans";
            Console.WriteLine(feast[6]);

            foreach(string food in feast)
            {
                Console.WriteLine(food);
                //feast.Add("rgefhjrstegzh");
            }
        }
    }
}
