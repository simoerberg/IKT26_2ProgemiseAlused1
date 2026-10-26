namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");

            //genereerib juhuslikke numbreid 1 kuni 6
            int cube = new Random().Next(1, 7);

            //kasutada switchi
            //peab kontrollima tulemust ja kuvama vastavat sõnumit
            switch (cube)
            {
                case 1:
                    Console.WriteLine("Tuli 1");
                    break;
                case 2:
                    Console.WriteLine("Tuli 2");
                    break;
                case 3:
                    Console.WriteLine("Tuli 3");
                    break;
                case 4:
                    Console.WriteLine("Tuli 4");
                    break;
                case 5:
                    Console.WriteLine("Tuli 5");
                    break;
                case 6:
                    Console.WriteLine("Tuli 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
