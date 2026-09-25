namespace CompoundConditionalsSwitch_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 66;

            switch(number)
            {
                case < 60:
                    Console.WriteLine("F");
                    break;
                case < 70:
                    Console.WriteLine("D");
                    break;
                case < 80:
                    Console.WriteLine("C");
                    break;
            }



            string food = "tacos";
            double cost = 0;

            switch(food)
            {
                case "tacos":
                    cost = 7.999;
                    break;
                case "burger":
                    cost = 9.00;
                    break;
                case "ramen":
                    cost = 13.00;
                    break;
                default:
                    cost = 0;
                    break;
            }

            Console.WriteLine($"I ate {food} today and it cost {cost:C2}");

            /*
            Console.Write("Give me a number between 5 and 8: ");
            int answer = int.Parse(Console.ReadLine()!);

            // Within range! 5 (inclusive) - 8 (inclusive)
            if( answer >= 5 && answer <= 8 )   // answer > 4 && answer < 9
            {
                Console.WriteLine("In range!");
            }

            // Out of range!
            if(answer < 5 || answer > 8)      // answer <= 4 || answer >= 9
            {
                Console.WriteLine("Out of range!");
            }
            if ( !(answer >= 5 && answer <= 8) )
            {
                Console.WriteLine("Out of range!");
            }
            */
        }
    }
}
