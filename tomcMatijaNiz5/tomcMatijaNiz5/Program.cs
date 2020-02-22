using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaNiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[10];
            int[] niz2 = new int[10];
            int neparni = 0;
            int parni = 0;
            int br;
            bool istina = true;

            Console.WriteLine("Upisite 20 brojeva ili uspisite brojeve sve dok ne upisete 0:");
            while (neparni != 10 && parni != 10 && istina)
            {
                br = Convert.ToInt32(Console.ReadLine());
                if (br == 0)
                {
                    istina = false;
                }
                if (br % 2 != 0)
                {
                    niz[neparni] = br;
                    neparni++;
                }
                if (br % 2 == 0)
                {
                    niz2[parni] = br;
                   parni++;
                }
            }
            Console.WriteLine("Svi neparni brojevi koje ste upisali:");
            foreach (int g in niz) Console.Write(g + " ");
            Console.WriteLine("");
            Console.WriteLine("Svi psrni brojevi koje ste upisali:");
            foreach (int h in niz2) Console.Write(h + " ");
            Console.ReadKey();
        }
    }
}
