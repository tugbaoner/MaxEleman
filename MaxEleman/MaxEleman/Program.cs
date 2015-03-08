using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxEleman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç elemanlı dizi olsun istersin?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];
            Console.WriteLine("dizi elemanını giriniz:");   // dizinin elemanlarını kullanıcı klavyeden giriyor.

            for (int i = 0; i < sayi; i++)
                int.TryParse(Console.ReadLine(), out dizi[i]);  // girilen değerler ekrana yazdırılıyor
            
            Console.WriteLine("Girilen Değerler:");
            for (int i = 0; i < sayi; i++)
                Console.Write(dizi[i] + " - ");
            int max = dizi[0];
            for (int i = 1; i < sayi; i++)
            {
                if (dizi[i] > max) max = dizi[i];
                
            }
            Console.Write(" Max:" + max);
            
            Console.ReadLine();
        }
    }
}
