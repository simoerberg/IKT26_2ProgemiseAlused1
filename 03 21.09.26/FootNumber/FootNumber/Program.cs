namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30-33 (siin on tekst roheline),
            //teine jalanumbri 34-38 (siin on tagataust valge),
            //kolmas jalanumbri 39-44 (siin on tekst sinine ja tagataust kollane
            //neljas jalanumbri 45-48 (siin teeb arvuti häält beep)
            //kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit
            Console.WriteLine("Sisesta jalanumber");
            int jalanumber = int.Parse(Console.ReadLine());

            if (jalanumber >= 30 && jalanumber <= 33)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("jalanumber on 30-33 vahel");
            }
            else if (jalanumber >= 34 && jalanumber <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Jalanumber on 34-38 vahel");
            }
            else if (jalanumber >= 39 && jalanumber <= 44)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jalanumber on 39-44 vahel");
            }
            else if (jalanumber >= 45 && jalanumber <= 48)
            {
                Console.Beep();
                Console.WriteLine("Jalanumber on 45-48 vahel");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR, vali number 30-48 vahel");
            }

        }
    }
}
