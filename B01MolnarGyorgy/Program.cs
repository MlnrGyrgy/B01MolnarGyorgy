using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01MolnarGyorgy
{
    class Program
    {
        static int[] adatok = new int[3000];
        static void Beolvasas()
        {
            StreamReader olvas = new StreamReader("adatok.dat");
            int i = 0;
            while (!olvas.EndOfStream)
            {
                adatok[i] = int.Parse(olvas.ReadLine());
                //Console.WriteLine(adatok[i]);
                i++;
            }
            olvas.Close();
        }
        static void Minimumertek()
        {
            int min = 10000;
            for (int i = 1; i < adatok.Length; i++)
            {
                if (min > adatok[i] && adatok[i] != 0)
                {
                    min = adatok[i];
                }
            }
            Console.WriteLine("{0} a legkisebb szám", min);
        }
        static void Egyediek()
        {
            
            int csakottel = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] % 5 == 0 && adatok[i] % 4 != 0)
                {
                    csakottel++;
                }
            }
            Console.WriteLine("Öttel osztható, de néggyel nem osztható számok: {0}", csakottel);;
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek();
            Egyediek();
            Console.ReadKey();

        }
    }
}
