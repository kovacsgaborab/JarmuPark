using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemanyag;
        public double UZEMANYAG { get { return uzemanyag; } }

        private double fogyaszt;
        public double FOGYASZT { get { return fogyaszt; } }

        private double km;
        public double KM { get { return km; } }

        private double megteheto;
        public double MEGTEHETO { get { return megteheto; } }



        





        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemanyag = 0;
            this.km = 0;
            this.megteheto = 0;
        }

        public void Tankol(double mennyit)
        {
            uzemanyag += mennyit;
            Megteheto();
        }

        public void Megy(double km)
        {
            this.km += km;
            uzemanyag -= (km * fogyaszt / 100);
            Megteheto();
        }

        private void Megteheto()
        {
            megteheto = uzemanyag / fogyaszt * 100;
        }
        public void Allapot()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"km óra: {km} km");
            Console.WriteLine($"üzemanyag: {uzemanyag}l");
            Console.WriteLine($"megtehető km: {megteheto} km");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
