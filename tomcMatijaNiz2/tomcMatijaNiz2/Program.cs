using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaNiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] niz2 = { 5, 3, 22, 31, 13, 0, 67, 88, 7, 4};
            bool imali = false;
            int brojac = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (niz[i] == niz2[j])
                    {
                        imali = true; 
                        brojac++; 
                        break;
                    }
                }
            }
            if (imali)
            {
                Console.WriteLine("Nizevi imaju " + brojac + " zajednička broja");
            }
            else
            {
                Console.WriteLine("Nizevi nemaju zajedničke brojeve");
            }

            Console.ReadKey();
        }
    }
}
