using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2.4.6.8
            //sari,kirmizi,mavi,siyah
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            string[] colors = new string[4];
            colors[0] = "Sarı";
            colors[1] = "Kırmızı";
            colors[2] = "Mavi";
            colors[3] = "Siyah";

            Console.WriteLine(colors[0]);

            string[] cities = new string[5];

            cities[0] = "İstanbul";
            cities[1] = "Ankara";
            cities[2] = "İzmir";
            cities[3] = "Bursa";
            cities[4] = "Adana";

            Console.WriteLine(cities[4]);

            int[] numbers = new int[10];
            numbers[0] = 23;
            numbers[1] = 4;
            numbers[2] = 59;
            numbers[3] = 86;
            numbers[4] = 317;
            Console.WriteLine(numbers[3]);

            string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };

            Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            string[] colors = { "Sarı", "Kırmızı", "Mavi", "Siyah", "Yeşil", "Turuncu", "Mor" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int[] numbers = { 1120, 23, 4, 597, 86, 317, 12, 45, 78, 2356 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            int maxNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            #endregion

            #region Dizi Metotları

            string[] customers = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali" };
            int index = Array.IndexOf(customers, "Ayşe");
            Console.WriteLine(index);

            int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write("Lütfen {0}. Şehir Adını Giriniz: ", i + 1);
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------------");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
