namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float firstNr = float.Parse(Console.ReadLine());

            //siin valitakse switchi case
            Console.WriteLine("Vali tehe: *,/, +, -");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number");
            float secondNr = float.Parse(Console.ReadLine());

            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Liitmise tulemuse: {firstNr} + {secondNr} = {firstNr + secondNr}");
                    break;

                case "-":
                    Console.WriteLine($"Lahutamise tulemuse: {firstNr} - {secondNr} = {firstNr - secondNr}");
                    break;

                case "*":
                    Console.WriteLine($"Korrutamise tulemuse: {firstNr} * {secondNr} = {firstNr * secondNr}");
                    break;

                case "/":
                    if (secondNr == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        Console.WriteLine($"Jagamise tulemuse: {firstNr} / {secondNr} = {firstNr / secondNr}");
                    }
                    break;

                default:
                    Console.WriteLine("Valisid vale tingmärgi");
                    break;
            }
        }
    }
}
