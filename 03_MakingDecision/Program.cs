using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MİM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.Write("Lütfn şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password=="abcd")
            //    {
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}


            //string

            //string capital, country;
            //Console.Write("başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz");
            //country = Console.ReadLine();

            //if(capital=="ankara"& country== "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");

            //}
            //veya ||||||
            //string city;
            //Console.Write("lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "sivas" | city == "eskisehir") 
            //{
            //    Console.WriteLine("doğru bildiniz");
            //}
            //else {

            //    Console.WriteLine("bilemediniz");

            //}

            //Console.Write("lütfen kullanıcı adını giriniz: ");
            //string username =Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}
            #endregion

            #region mod işlemleri

            //int number;
            //number =25;
            //int result = number % 5;
            //Console.WriteLine(result);  

            //Console.Write("lütfen bir sayı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz:");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. saynın 2. sayıya bölümünden kalan:" + result);

            //Console.Write("lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());   

            //if(number%2==0)
            //{
            //    Console.Write("sayı çiftir");

            //}
            //else
            //{
            //    {
            //        Console.Write("sayı tektir");
            //    }
            //}


            //örnekkkkk
            //Console.Write("lütfen 3 ün katı bir sayı giriniz: ");
            //int rakam=int.Parse(Console.ReadLine());

            //if (rakam % 3 == 0)
            //{
            //    Console.Write("sayı 3 ün katıdır");
            //}
            //else
            //{
            //    Console.Write("sayı 3 ün katı deildir");
            //}









            #endregion

            #region char değişkenler
            //char team;
            //Console.Write("lütfen takım sembolünü giriniz:");
            //team=char.Parse(Console.ReadLine());

            //if (team =='G'|team=='g')
            //{
            //    Console.Write("galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.Write("fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.Write("beşiktaş");
            //}
            #endregion

            #region örnekler
            //Console.WriteLine("***** C eğitim kampı ***");
            //Console.WriteLine();
            //Console.WriteLine("1- ana yemekler");
            //Console.WriteLine("2- çorbalar");
            //Console.WriteLine("3- pizzalar");
            //Console.WriteLine("4- içecekler");
            //Console.WriteLine("5- tatlılar");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("detayını görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana yemekler---");
            //    Console.WriteLine();
            //    Console.WriteLine("1-köri soslu tavuk");
            //    Console.WriteLine("2-kızartma soslu tavuk");
            //    Console.WriteLine("3-fasulye soslu tavuk");
            //    Console.WriteLine("4-fırında somon soslu tavuk");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar---");
            //    Console.WriteLine();
            //    Console.WriteLine("1-mercimek");
            //    Console.WriteLine("2-ezogelin");
            //    Console.WriteLine("3-tavuk");
            //    Console.WriteLine("4-merci");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------pizza---");
            //    Console.WriteLine();
            //    Console.WriteLine("1-margar");
            //    Console.WriteLine("2-mantar");
            //    Console.WriteLine("3-falafe");
            //    Console.WriteLine("4-tavuk");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------içecekler---");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-fanta");
            //    Console.WriteLine("3-ayran");
            //    Console.WriteLine("4-fens");
            //}




            #endregion

            #region switch case



            //Console.Write("lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("ocak");break;
            //    case 2: Console.Write("şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("b"); break;
            //    case 10: Console.Write("besiktas"); break;
            //    default: Console.Write("hatalı giriş"); break;


            //}

            #endregion

            #region hesap makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak için sembol:");
            //symbol = char.Parse(Console.ReadLine());
            //switch(symbol)
            //{
            //    case '+':
            //        result = number2+ number1;
            //        Console.WriteLine("toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;
            //}

            #endregion
            #region myself to works

            //float number1, number2,result;
            //char symbol;
            //Console.Write("bir sayı girin: ");
            //number1 =float.Parse(Console.ReadLine());
            //Console.Write("ikinci sayı girin:");
            //number2 =float.Parse(Console.ReadLine());
            //Console.Write("lütfen bir sembol seçiniz:");
            //symbol=char.Parse(Console.ReadLine());
            //switch (symbol)
            //{ case '+':
            //    result=number1 + number2;
            //        Console.WriteLine("toplam:"+result); break;
            //    case '/':
            //    result = number1 / number2;
            //        Console.WriteLine("bölüm:" + result); break;
            //    case '*':
            //    result = number1 * number2;
            //        Console.WriteLine("çarpım:" + result); 

            //     break;


            #endregion

            Console.Read();
            
        }
    }
}
