namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //muutuja nimega y on double ehk komakohaga arv
            //ja väärtus on 9
            double y = 20.5;

            if (y == 9)
            {
                //kui panen if-i sisse teise if-i, siis nsee on nested ehk pesastatud if
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus on kõik peale 11");
                }
            }
            else if (y == 20.5)
            {
                Console.WriteLine("Vastus on 20.5");
            }
            else if (y == 30)
            {
                Console.WriteLine("Vastus on 30");
            }
            else
            {
                Console.WriteLine("Mingi kahtlane number");
            }
        }
    }
}
