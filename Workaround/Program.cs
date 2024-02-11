using Business.Concrete;
using Entities.Concrete;
using System;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            List<string> yeniSehirler = new List<string> { "Ankara", "İstanbul", "Bursa" };
            yeniSehirler.Add("Adana");
            foreach(var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }
            Person person = new Person();
            person.FirstName = "Engin";

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(new Person());
            
            Console.ReadKey();
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
 
}
