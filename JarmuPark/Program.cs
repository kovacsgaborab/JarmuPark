using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto a = new Auto();  priváttá tettük a valamiket

            Auto lada = new Auto("piros", "Lada 2112", 11);
            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);
            lada.Tankol(20);
            trabant.Tankol(20);


            Console.WriteLine("Mennyit megy a lada: ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            Console.WriteLine($"Maradt: {lada.UZEMANYAG} l - {lada.MEGTEHETO} km"); //propertyvel...

            Console.WriteLine("Mennyit megy a trabant: ");
            int kmm = int.Parse(Console.ReadLine());
            trabant.Megy(kmm);
            trabant.Allapot();
            //lada.fogyaszt = 11;
            //lada.km = 212342;

            //trabant.fogyaszt = 8;
            //trabant.km = 302999;

            Console.ReadKey();
        }
    }
}
