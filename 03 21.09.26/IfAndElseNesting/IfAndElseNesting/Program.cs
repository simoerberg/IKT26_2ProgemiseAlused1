namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else");
            double y = 15.5;

            string number = Console.ReadLine();
            int nr = int.Parse(number);

            if (nr == 12)
            {
                Console.WriteLine("Number 12");
            }
            else if (nr > 20)
            {
                //nestimine e pesastamine
                if (nr == 25)
                {
                    Console.WriteLine("Number 25");
                }
                else
                {
                    Console.WriteLine("kõik numbrid peale 25-te");
                }
            }
            else
            {
                Console.WriteLine("Kahtlane number");
            }
        }
    }
}
