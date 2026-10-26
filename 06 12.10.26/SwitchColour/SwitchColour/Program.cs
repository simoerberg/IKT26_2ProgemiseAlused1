using System.Drawing;

namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värvi nimi!");
            //kasutada switchi
            //sisestab värvi nime
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "Värv puudub"
            string color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Red");
                    break;
                case "Green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Green");
                    break;
                case "Blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Blue");
                    break;
                case "White":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("White");
                    break;
                case "Orange":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Console.WriteLine("Orange");
                    break;
                default:
                    Console.WriteLine("Värv puudub");
                    break;
            }
        }
    }
}
