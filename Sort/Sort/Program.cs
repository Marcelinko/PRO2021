using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Izbiranje(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int min = tab[i];
                int minIndeks = i;
                for(int j = i; j<tab.Length; j++)
                {
                    if(tab[j] < min)
                    {
                        min = tab[j];
                        minIndeks = j;
                    }
                }
                int temp = tab[i];
                tab[i] = tab[minIndeks];
                tab[minIndeks] = temp;
            }
        }
        static void Vstavljanje(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                int j = i;
                int temp = tab[i];
                while (j > 0 && tab[j-1]>temp)
                {
                    tab[j] = tab[j - 1];
                    j--;
                }
                tab[j] = temp;
            }
        }
        static void Izpis(int[] tab)
        {
            for(int i = 0; i<tab.Length; i++)
            {
                Console.Write(tab[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = 100000;
            int[] tab = new int[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                tab[i] = r.Next(n);
            }
            DateTime d = DateTime.Now;
            Vstavljanje(tab);
            DateTime d1 = DateTime.Now;
            TimeSpan ts =d1 - d;
            Console.WriteLine("Cas vstavljanja je "+ts.TotalMilliseconds+"ms");
            Console.ReadKey();
        }
    }
}
