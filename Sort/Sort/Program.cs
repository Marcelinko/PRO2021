using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Izpis(String[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int n = 100000;
            //int[] tab = new int[n];
            //Random r = new Random();
            //for(int i = 0; i < n; i++)
            //{
            //    tab[i] = r.Next(n);
            //}
            String[] tab = {"Jagoda", "Banana", "Burek", "Polenta", "Ječmen", "Jota" };
            QuickSort(0, tab.Length-1, tab);
            Console.ReadKey();
        }
        static int Pivot(int zacetek, int konec, String[] tab)
        {
            String p = tab[zacetek];
            int m = zacetek;
            int n = konec + 1;
            //poisci z m prvega, ki je vecji od p
            do
            {
                m = m + 1;
            }
            while (tab[m].CompareTo(p) < 0 && m < konec);
            do
            {
                n = n - 1;
            }
            while (tab[n].CompareTo(p) > 0);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih
            while (m < n)
            {
                String temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                }
                while (tab[m].CompareTo(p) < 0);
                do
                {
                    n = n - 1;
                }
                while (tab[n].CompareTo(p) > 0);
            }
            //zamenjaj pivotni element
            String temp2 = tab[n];
            tab[n] = tab[zacetek];
            tab[zacetek] = temp2;
            Izpis(tab);
            return n;
        }
        static void QuickSort(int zacetek, int konec, String[] tab)
        {
            if (zacetek >= konec)
                return;
            int a = Pivot(zacetek, konec, tab);
            QuickSort(zacetek, a - 1, tab);//levi del
            QuickSort(a + 1, konec, tab);//desni del

        }
    }
}
