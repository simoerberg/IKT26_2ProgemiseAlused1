namespace IfAndElseMajad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha neli if-i ja else-i kontrolli, kus kontrollitakse majade ruutmeetrit.
            //esimene kontroll on 0.40 ruutmeetri juures, teine 41-90, kolmas 91-130
            //ja neljas on suuremad kui 131 ruutmeetrit
            //kui mingi suurus on tuvastatud siis konsool näitab teksti:
            //Sinu maja suurus on x ruutmeetrit
            Console.WriteLine("Sisesta oma maja ruutmeetrid");
            int ruutmeeter = int.Parse(Console.ReadLine());
            //esimene tingimus on alati if, teised on else if ja viimane on else
            if (ruutmeeter >= 0 && ruutmeeter <= 40)
            {
                Console.WriteLine($"Sinu maja suurus on {ruutmeeter} ruutmeetrit");
            }
            else if (ruutmeeter >= 41 && ruutmeeter <= 90)
            {
                Console.WriteLine($"Sinu maja suurus on {ruutmeeter} ruutmeetrit");
            }
            else if (ruutmeeter >= 91 && ruutmeeter <= 130)
            {
                Console.WriteLine($"Sinu maja suurus on {ruutmeeter} ruutmeetrit");
            }
            else if (ruutmeeter >= 131)
            {
                Console.WriteLine($"Sinu maja suurus on {ruutmeeter} ruutmeetrit");
            }
            else
            {
                Console.WriteLine("Vale arv");
            }
        }
    }
}
