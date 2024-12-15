using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metohds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metodlar

            //() 
            // Geriye Değer Döndürmeyen metotşar
            //customer--> Lİstele, ekle, sil, güncelle
            // Void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region Geriye döndürmeyen paramtetrel metodlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("GÖkay kutluk");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: "+ name+""+surname);    
            //}
            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye döndürmeyen İNT paramtetrel metodlar

            //void Sum(int number1, int number2,int number3) 
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);



            #endregion

            #region Geriye değer döndüren Methodlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string SURNAME = "KAYA";

            //    return name + " " + SURNAME;

            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region GEriye Değer Döndüren String Paramatreli Metotlar

            //string CountryCard(string CountryName, string capital,string flagColor)
            //{
            //    string cardInfo="Ülke: "+CountryName+"- Başkent:  "+capital+"- BAyrak:  "+flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("BAşkenti giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("BAyrak rengini giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye Değer Döndüren INT PAramtreli metodlar

            //int ExamResult(string student int exam1, int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result => 50)
            //    {
            //        return "öğrenci sınavı geçti";
            //    }
            //    else
            //    {
            //        {
            //            return "Öğrenci başarısız oldu";
            //        }
            //    }
            //    Console.WriteLine(ExamResult("Ali",25,41,85))
            //    Console.WriteLine(ExamResult("Ayşe",23,51,35))

            //}
            #endregion
            Console.Read();
        }
    }
}
