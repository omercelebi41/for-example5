using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi doldurcak, dizi sınırını adam belirlicek, elemanlar random olucak, küçükten büyüğe sıralıcaz

            int a = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[a];
            Random r = new Random();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(100);
                Console.WriteLine(d[i]);
            }
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length ; j++)
                {
                    if (d[i] < d[j])
                    {
                        int gd = d[i];
                        d[i] = d[j];
                        d[j] = gd;
                    }
                }
            }
            Console.WriteLine("---------------");
            for (int i = 0; i < d.Length; i++)
                Console.WriteLine(d[i]);

        }
    }
}
