using System.Security.AccessControl;

namespace IfAndElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kirjutada automärk
            //valikus on BMW, Audi, Porche ja skoda
            //kui valitakse Škoda, siis seal sees  on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus Kodiaq ja Octavia
            Console.WriteLine("Sisesta automärk");
            string automark = Console.ReadLine().ToLower() ;
            if (automark == "bmw")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid BMW");
            }
            else if (automark == "audi")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid Audi");
            }
            else if (automark == "porsche")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid Porsche");
            }
            else if (automark == "škoda")
            {
                Console.WriteLine("Mis škoda mudel?");
                    string mudel = Console.ReadLine().ToLower();
                if (mudel == "kodiaq")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valisid škoda Kodiaq");
                }
                else if (mudel == "octavia")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valisid škoda Octavia" );
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Tundmatu automärk");
            }
        }
    }
}
