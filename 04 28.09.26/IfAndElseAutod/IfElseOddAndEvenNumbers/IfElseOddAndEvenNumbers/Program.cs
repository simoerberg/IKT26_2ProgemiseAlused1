namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //konsool küsib numbrit
            Console.WriteLine("Sisesta number");
            string number = Console.ReadLine();
            //number tuleb ära parsida
            int numberInt = int.Parse(number);
            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu nr
            //mida % operaator tähendab
            //see leiab jäägi ja nii kaua kontrollib, kas on 0
            if (numberInt % 2 == 0)
            {
                Console.WriteLine("Number on paaris.");
            }
            else
            {
                Console.WriteLine("Number on paaritu.");
                //kutsuda paarisarvu ja paarituarvu tekst välja
                //läbi meetodi kutsumise

            }
        }
        static void EvenNumbers()
        {
            Console.WriteLine("Paarisarv" );
        }

        static void Oddnumbers()
        {
            Console.WriteLine("Paarituarv");
        }
    }
}