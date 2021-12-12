using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Uygulama
            int n=0;
            
            Console.WriteLine("Bir sayi girin");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[n];
            Console.WriteLine("{0} adet sayi giriniz: ",n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr.EkranaCiftYaz();
            
            // 2.Uygulama
            int n1 = 0;
            int m = 0;
            Console.WriteLine("2 adet sayi girin");
            n1 = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if(x%m==0)
                    Console.WriteLine(x);
            }
            
            // 3.Uygulama
            int n2 = 0;
            Console.WriteLine("Sayi girin ");
            List<string> strArr = new List<string>();
            n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                strArr.Add(Console.ReadLine());
            }
            strArr.Reverse();
            Console.WriteLine("\n");
            strArr.EkranaYaz();
            
            // 4.Uygulama
            Console.WriteLine("Cumle Yazin");
            string str = Console.ReadLine();
            int cumleSayisi = str.Split(" ").Length;
            Console.WriteLine(cumleSayisi);
            int harfSayisi = str.Replace(" ", "").Length;
            Console.WriteLine(harfSayisi);
        }
    }

    public static class Extension
    {
        public static void EkranaCiftYaz(this int[] veri)
        {
            foreach (int item in veri)
                if(item%2==0)
                    Console.WriteLine(item);   
        }
        
        public static void EkranaYaz(this List<string> veri)
        {
            foreach (string item in veri)
                Console.WriteLine(item);   
        }
    }
}