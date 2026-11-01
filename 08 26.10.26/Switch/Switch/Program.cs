namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: +");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number");
            float secondNr = float.Parse(Console.ReadLine());

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Liitmise tulemuse: {firstNr} + {secondNr} = {firstNr + secondNr}");
                    break;

                default:
                    Console.WriteLine("Valisid vale tingmärgi");
                    break;
            }

            Console.WriteLine("Sisesta oma vanus!");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case < 18:
                    Console.WriteLine("Oled alaealine");
                    break;

                case >= 18:
                    Console.WriteLine("Oled täisealine");
                    break;
            }

            Console.WriteLine("Sisesta oma nimi!");
            string name = Console.ReadLine();

            switch (name)
            {
                case "Steven":
                    Console.WriteLine("Tere, Steven!");
                    break;

                default:
                    Console.WriteLine($"Tere, {name}!");
                    break;
            }
        }
    }
}
