using System.Threading.Channels;

namespace IfAndElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikus on: red, blue, green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta eelpool sisestatud värvi");

            Console.Write("Sisesta värv: ");
            string varv = Console.ReadLine();

            if (varv == "red")
            {
                Console.WriteLine("Valisid punase värvi.");
            }
            else if (varv == "blue")
            {
                Console.WriteLine("Valisid sinise värvi.");
            }
            else if (varv == "green")
            {
                Console.WriteLine("Valisid rohelise värvi.");
            }
            else if (varv == "white")
            {
                Console.WriteLine("Valisid valge värvi.");
            }
            else
            {
                Console.WriteLine("Sisestatud vale värv");
            }
        }
    }
}
