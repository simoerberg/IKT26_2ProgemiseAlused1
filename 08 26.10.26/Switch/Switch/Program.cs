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
        }
    }
}
