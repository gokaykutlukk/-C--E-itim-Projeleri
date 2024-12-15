using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_mainCstringint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            //double number;
            //number = 4.86;

            //Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi***");

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;
            //Console.WriteLine("-----Elma Birim Fiyatı: " + applePrice+"TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı: " + orangePrice+"TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("-----Patates Birim Fiyatı: " + potato+"TL");
            //Console.WriteLine("-----Domates Birim Fiyatı: " + tomato+"TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potato;



            //Console.WriteLine("Elmanın TOPLAM FİYATI: " + appleTotalPrice);
            //Console.WriteLine("Portakal TOPLAM FİYATI: " + orangeTotalPrice);
            //Console.WriteLine("Çilek TOPLAM FİYATI: " + strawTotalPrice);
            //Console.WriteLine("Patates TOPLAM FİYATI: " + potatoTotalPrice);







            #endregion

            #region char değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            //" ' TEK TIRNAKLA TANIMLANIR

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);






            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**CSharp Hava Yolları Yolcu Bilgisi***");
            //Console.WriteLine();
            ////ctrl f  ile toplu isim değişikliği yapabilirim

            //string passengersName, passengersSurname, passengersDistrict, passengersCity, passengersAge, passengersIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengersName= Console.ReadLine();

            //Console.Write("yolcu soyadı: ");
            //passengersSurname= Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("***********");
            //Console.WriteLine("yolcu:" + passengersName + "" + passengersSurname);


            #endregion

            #region Klavyeden VERİ GİRİŞLERİ İNT DEĞİŞKENLER

            //ABDC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye fiyatını giriniz: ");
            //chairCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv fiyatını giriniz: ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice ;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result =(exam1+exam2+ exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region  klavyeden karakter girişleri

            //char gender;
            //Console.Write("lütfen cinsiyet seçiniz: ");

            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);


            #endregion

            #region örnek çalışmalarım
            //string

            //string adı, soyAdı;
            //Console.Write("çalışanın adı nedir?: ");
            //adı = Console.ReadLine();
            //Console.WriteLine(adı);

            //int

            //int kediMaması, kediTuvaleti, kediKasesi;
            //kediMaması = 300;
            //kediTuvaleti = 470;
            //kediKasesi = 157;

            //int kediMamaAdeti, kediTuvaletiAdeti, kediKasesiAdeti;

            //Console.Write("Lütfen kaç mama adet aldığınızı giriniz: ");
            //kediMamaAdeti=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç tuvalet adet aldığınızı giriniz: ");
            //kediTuvaletiAdeti = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç kase adet aldığınızı giriniz: ");
            //kediKasesiAdeti = int.Parse(Console.ReadLine());

            //int totalPrice = kediMaması * kediMamaAdeti + kediKasesi * kediKasesiAdeti + kediTuvaleti * kediTuvaletiAdeti;
            //Console.WriteLine();
            //Console.WriteLine("TOPLAM ÖDENEN TUTAR: " + totalPrice);
            #endregion

            Console.ReadKey();













        }
    }
}
