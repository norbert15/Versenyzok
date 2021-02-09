using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Versenyzok
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pilotak> pilotak = new List<Pilotak>();

            using (StreamReader sr = new StreamReader("../../pilotak.csv", Encoding.Default))
            {
                string sor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] pil = sr.ReadLine().Split(';');

                    Pilotak pilota = new Pilotak(pil[0], pil[1], pil[2], pil[3]);
                    pilotak.Add(pilota);
                }
            }

            Console.WriteLine("3.feladat: " + pilotak.Count);
            Console.WriteLine("4.feladat: " + pilotak[pilotak.Count-1].Nev);
            Console.WriteLine("5.feladat: ");
            for(int i = 0; i < pilotak.Count; i++)
            {
                string ev = pilotak[i].Szulet.Substring(0, 4);
                if(Convert.ToInt32(ev) < 1901)
                {
                    Console.WriteLine("\t"+pilotak[i].Nev + " (" + pilotak[i].Szulet + ")");
                }
            }

            string min_nemzetiseeg = null;
            int min = 1000;
            for (int i = 0; i < pilotak.Count; i++)
            {
                if (!pilotak[i].Rajtszam.Equals(""))
                {
                    int rajt = Convert.ToInt32(pilotak[i].Rajtszam);
                    if(rajt < min)
                    {
                        min = rajt;
                        min_nemzetiseeg = pilotak[i].Nemzetiseg;
                    }
                }
            } 

            Console.WriteLine("6.feladat: " + min_nemzetiseeg);

            List<String> rajtszamok = new List<string>();
            for (int i = 0; i < pilotak.Count; i++)
            {
                for (int j = 0; j < pilotak.Count; j++)
                {
                    if(i != j)
                    {
                        if (pilotak[i].Rajtszam.Equals(pilotak[j].Rajtszam) && !(rajtszamok.Contains(pilotak[i].Rajtszam)))
                        {
                            rajtszamok.Add(pilotak[i].Rajtszam);
                        }
                    }
                }
            }

            Console.Write("7.feladat:" );
            foreach (var item in rajtszamok)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
