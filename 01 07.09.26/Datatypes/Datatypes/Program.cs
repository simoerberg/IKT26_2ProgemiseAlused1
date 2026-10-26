namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datatypes!");

            //string e tähemärkide jada, mis on defineeritud andmetüübiga string
            //name on muutuja, mis on defineeritud andmetüübiga string
            //saab sisestada kõike, mis on klaviatuuril
            string name = "John Doe";
            Console.WriteLine(name);
            string one = "1";
            string two = "2";
            //see on stringide liitmine, mis tähendab,
            //et need kaks stringi liidetakse kokku
            //NB! Ei toimu matemaatilist liitmist,
            //vaid lihtsalt stringide ühendamine
            Console.WriteLine(one + two);

            Console.WriteLine("----Täisarvud----");
            //int on andmetüüp, mis toetab täisarve
            //age on muutuja, mis on defineeritud andmetüübiga int
            int age = 25;
            Console.WriteLine(age);
            //lisada teine täisarv muutuja ja saada konsoolis 
            //kahe liitmise tulemuseks 30
            int age2 = 5;
            Console.WriteLine(age + age2);

            Console.WriteLine("----Byte----");
            //byte on andmetüüp, mis toetab täisarve
            //vahemikus 0 kuni 255
            //see on kasulik, kui on vaja salvestada väikseid täisarve
            //8-bitine täisarv
            byte myByte = 255;
            Console.WriteLine(myByte);

            Console.WriteLine("----Short----");
            //short on andmetüüp, mis toetab täisarve
            //vahemikus -32,768 kuni 32,767
            //see on kasulik, kui on vaja salvestada
            //keskmise suurusega täisarve
            //16-bitine täisarv
            short myShort = 32767;
            Console.WriteLine(myShort);

            Console.WriteLine("----Long----");
            //long on andmetüüp, mis toetab täisarve
            //vahemikus -9,223,372,036,854,775,808
            //kuni 9,223,372,036,854,775,807
            //see on kasulik, kui on vaja salvestada suuri täisarve
            //64-bitine täisarv
            //NB! Kui kirjutad arvu, mis on suurem kui int.MaxValue,
            //siis tuleb lisada lõppu L
            long myLong = 9223372036854775807L;
            Console.WriteLine(myLong);

            Console.WriteLine("----Float----");
            //float on andmetüüp, mis toetab ujukomaarve
            //see on kasulik, kui on vaja salvestada arve,
            //mis sisaldavad komakohta
            //32-bitine ujukomaarv
            //NB! Kui kirjutad arvu, mis on suurem kui
            //float.MaxValue,, siis tuleb lisada lõppu f
            float myFloat = 3.14f;
            Console.WriteLine(myFloat);


            Console.WriteLine("----Double----");
            //double on andmetüüp, mis toetab ujukomaarve
            //see on kasulik, kui on vaja salvestada arve,
            //mis sisaldavad komakohta
            //64-bitine ujukomaarv
            double myDouble = 3.141592653589793;
            Console.WriteLine(myDouble);

            Console.WriteLine("----Decimal----");
            //decimal on andmetüüp, mis toetab täpseid ujukomaarve
            //see on kasulik, kui on vaja salvestada arve,
            //mis nõuavad täpsust
            //128-bitine ujukomaarv
            //decimal myDecimal = 3.141

            Console.WriteLine("----Boolean----");
            //bool on andmetüüp, mis toetab tõeväärtusi
            //see on kasulik, kui on vaja salvestada tõeväärtused
            bool isTrue = true;
            Console.WriteLine(isTrue);
            bool isFalse = false;
            Console.WriteLine(isFalse);
        }
    }
}
