using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaNiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int br;
            int[] niz = new int[10];
            for (int i = 0; i < 10; i++)
            {
                br = i + 1;
                niz[i] = br * br;
            }
            Console.WriteLine("Kvadrat prvih deset brojeva je:");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(niz[j]+" ");
            }
            Console.ReadKey();
        }
    }
}
