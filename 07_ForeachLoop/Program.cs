﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Forecah(1;2;3;;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:IN
            //4:Liste,KOleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeişte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //foreach (int number in numbers) 
            //{
            //    if (number % 2 == 0)    
            //    {
            //        Console.WriteLine(number);
            //    }           
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6,
            //};
            //foreach (int number in numbers) {
            //Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulamsası

            //Console.Write("**** c# Eğitim Kampı Sınav Uygulaması ****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //// sınıftaki öğrenci sayısını alma
            //Console.WriteLine("-----------------------------");
            //Console.Write("sınıfınızda kaç öğrenci var : ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");
            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames=new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i = 0; i < studentCount; i++) 
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;
            //    //Her öğrenci için 3 sınav girişi

            //    for (int j = 0; j < 3; j++) 
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value; // notları topluyıruz
            //    }
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            ////öğrencilerin ortalaması ve geçip kalma durumları
            //for (int i = 0; i < studentCount; i++) 
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:  {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }

                
                
            //}
            
            #endregion
            //Console.Read();
        }
    }
}
