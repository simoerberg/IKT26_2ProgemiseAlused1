//namespace on projekti nimi
namespace Intro
{
    //see on class, mis sisaldab programmi sisenemispunkti
    internal class Program
    {
        //sisenemispunkt. Meetod nimega Main on see,
        //kust programm algab. See on staatiline meetod,
        //mis tähendab, et seda saab kutsuda ilma,
        //et oleks vaja luua klassi eksemplari.
        static void Main(string[] args)
        {
            // See on lihtne väljund, mis prindib teksti konsooli
            //kommentaari saab lisada endale vajaliku infot
            //seda ei loeta kompileerimisel, vaid on
            //mõeldud arendajale
            Console.WriteLine("Hello, World!");
        }
    }
}
