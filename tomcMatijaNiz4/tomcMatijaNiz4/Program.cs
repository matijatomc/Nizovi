using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaNiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] niz = new int[11, 11];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    niz[i, j] = i * j;
                }
            }
            Console.WriteLine("Vrijednost upisana na poziciji 7*5 u tablici 11*11 je: " + niz[7, 5]);
            Console.ReadKey();
        }
    }
}
