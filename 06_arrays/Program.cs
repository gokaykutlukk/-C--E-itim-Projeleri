using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Temel Dizi Örnekleri
            //2.4.6.8
            //adana.ankara.istanbul.bursa

            //değişken türü [] diziadı=new değişkentürü[eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "mavi";
            //colors[3] = "beyaz";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budağeşte";
            //cities[2] = "lyon";
            //cities[3] = "Kahire";
            //cities[4] = "istanbul";

            //Console.WriteLine(cities[3]);

            //int[] numbers= new int[10];
            //numbers[0] = 50;
            //numbers[1] = 300;
            //numbers[2] = 40;
            //numbers[3] = 60;
            //numbers[4] = 70;
            //numbers[5] = 800;
            //numbers[6] = 4500;
            //numbers[7] = 8900;
            //Console.WriteLine(numbers[7]);

            #endregion

            #region dizideki tüm elemanları sıralama

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turunucu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'A', 'B', 'C' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 1, 2, 3, 4, 5 };

            //int maxNumber = myArray[0];
            //for (int i = 1; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "mehmet", "ahmet", "metin" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 54, 56, 78, 98 };  //küçükten büyüğe sıralar sort metodu
            //Array.Sort(numbers); ;
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 54, 56, 78, 98 };
            //Array.Reverse(numbers);                   // diziyi sondan başa sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region dizi metodları
            //IndexOf metodu istenilendizinin kaçıncı sırada olduğunu gösterir.
            //string[] persons = { "ali", "buse", "çınar", "kals" };
            //int index = Array.IndexOf(persons, "buse");
            //Console.WriteLine(index);


            //int[] numbers = { 1, 2, 93, 45, 12, 90 };
            //Console.WriteLine("dizinin en büyük elemanı : " + numbers.Max() + "dizinin en küçük eleemanı: " + numbers.Min());




            #endregion

            #region kullanıcıdan değer alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"lütfen {i + 1}.Şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 12,2344,323,4123,523,642 };

            Console.WriteLine("çift sayılar");
            for (int i = 0; i < numbers.Length; i++) 
            {
                if[numbers[i]]
            }

            #endregion


            Console.Read();
        }
    }
}
