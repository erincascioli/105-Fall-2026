namespace BeginningOOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 2 instances of a Pumpkin object using the default constructor
            Pumpkin myPumpkin = new Pumpkin();
            Pumpkin myOtherPumpkin = new Pumpkin();
            Pumpkin myCarvedPumpkin = new Pumpkin("Jeremy", 10f, Color.Yellow, true, 17.5);
            Pumpkin myPatch = new Pumpkin("Whatever", 1f, 1);

            Console.WriteLine($"My pumpkin weighs {myPatch.weight}");
        }
    }
}
