namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else laused, et kontrollida,
            //kas kasutaja vanus on suurem kui 18 või väiksem kui 18

            //saab kasutada Converti ja Parse-t
            //int userAge= Convert.ToInt32(Console.Readline());
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge >= 18)
            {
                Console.WriteLine("Sa oled täisealine");
            }
            else
            {
                Console.WriteLine("Sa oled alaaline");
            }

          
        }
    }
}
