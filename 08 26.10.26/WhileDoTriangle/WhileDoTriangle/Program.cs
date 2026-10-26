namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            //otsida internetist While koodiga kolmnurga
            //kujundeid e tegemise viise
            //kui kood on leitud, siis kirjutada see siia alla
            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }

                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
