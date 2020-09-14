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
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.ReadKey();
        }
    }
}
