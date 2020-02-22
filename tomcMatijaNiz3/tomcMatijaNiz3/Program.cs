using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaNiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite koliko brojeva želite u svakom nizu:");
            int brVelicineNiza = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[brVelicineNiza];
            int[] niz2 = new int[brVelicineNiza];
            int[] niz3 = new int[brVelicineNiza];
            int brojac = 0;
            int imali = 0;

            Console.WriteLine("Upisite elemente prvog niza:");
            for (int i = 0; i < brVelicineNiza; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Upisite elemente drugog niza:");
            for (int j = 0; j < brVelicineNiza; j++)
            {
                niz2[j] = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < brVelicineNiza; k++)
                {
                    if (niz[j] == niz2[k])
                    {
                        imali++;
                        break;
                    }
                }
                if(imali == 0)
                {
                    brojac++;
                    niz3[brojac] = niz[j];
                }
                imali = 0;
            }

            Console.WriteLine("Elementi koji se nalaze u prvom niz a ne u drugom su:");
            for(int l = 0; l < brojac; l++)
            {
                Console.Write(niz3[l]+" ");
            }
            Console.ReadKey();
        }
    }
}
