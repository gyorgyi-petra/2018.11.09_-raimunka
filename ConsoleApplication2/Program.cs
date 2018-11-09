using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        int szam = 1;
        bool logikai;
        int[] tomb;
        string str;

        static void Main(string[] args)
        {

            //     int[] t1 = null;
            //   int[] t2 = new int [0];
            int[] t2 = {1,0,-1,9,11 };
            int[] t3 = new int[ t2.Length];

            //int[] t3 = (int[])t2.Clone();

            for (int i = 0; i < t2.Length;i++) {
                t3[i] = t2[i];
            }

            //var p = new Program();
       //     Console.WriteLine(p.szam);
         //   Console.WriteLine(p.logikai);
           // Console.WriteLine(p.tomb);
            //Console.WriteLine(p.str);

            t2[1] = 999;

            //Console.WriteLine(t2.Length);
            foreach (var elem in t2) {
                // Console.WriteLine("Lefutott");
                Console.WriteLine(elem);

            }
            foreach(var elem in t3)
            {
                Console.WriteLine(elem);

            }

            //  Console.WriteLine(t1.Length);

            var p1 = new Program();
            var p2 = p1;
            p1.szam = 5;
            p2.szam = -8;
            Console.WriteLine("{0} {1} ", p1.szam, p2.szam);


            Console.ReadLine();



        }
    }
}
