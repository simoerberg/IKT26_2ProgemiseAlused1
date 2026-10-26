namespace IfElseAskName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda nimi");
            string name = Console.ReadLine();
            if (name == "Mati")
            {
                Console.WriteLine("sinu nimi on Mati" );
            }
            else
            {
                Console.WriteLine("sinu nimi ei ole Mati");
            }
        }
    }
}
