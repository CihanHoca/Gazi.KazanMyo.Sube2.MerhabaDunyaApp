using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Sube2.DizilerApp
{
    class Program
    {
        static void Main(string[] args)
        {//Dizi-Array

            //int[] dizi = { 5,8,7,9 };

            int[] dizi = new int[3];

            dizi[0] = 58;
            dizi[1] = 7;
            dizi[2] = 20;

            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);
            
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey();

        }
    }
}
