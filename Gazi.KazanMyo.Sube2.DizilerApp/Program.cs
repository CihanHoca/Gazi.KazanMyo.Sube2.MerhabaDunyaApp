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

            //int[] dizi = new int[3];




            //dizi[0] = 58;
            //dizi[1] = 7;
            //dizi[2] = 20;

            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);


            //Random rnd = new Random();
            //int sayi = rnd.Next();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //int[] dizi = new int[10];

            //Random rnd=new Random();  

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(100); 
            //}
            //Array.Sort(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //   Console.WriteLine(dizi[i]);
            //}


            //Console.WriteLine("Kaç adet isim?");
            //int adet = int.Parse(Console.ReadLine());

            //string[] isimler = new string[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine("İsim Giriniz:");
            //    isimler[i] = Console.ReadLine();
            //}

            //Array.Sort(isimler);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {

            //    }
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //*
            //**
            //***
            //****
            //*****


            int[,] dizi = new int[3, 2];
            Random rnd = new Random();

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = rnd.Next(100);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(dizi[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
