﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenleri

            //double Number; 
            //Number = 20.25;  
            //Console.WriteLine(Number);  

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");


            #endregion

            #region char değişkenleri

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("***** Hava Yolcuları Bilgisi *****");

            //string passengerName, passengerSurname;
            //passengerDistrict, passengerCity,
            //passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoPrice, computerPrice, chairPrice, tvPrice;

            //shoPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoCaount, computerCaount, chairCaount, tvCaount;

            //Console.Write("Lütfen kaç ayakkabı aldıysanız sayısını giriniz: ");
            //shoCaount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç bigisayar aldıysanız sayısını giriniz: ");
            //computerCaount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç sandalye aldıysanız sayısını giriniz: ");
            //chairCaount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç Tv aldıysanız sayısını giriniz: ");
            //tvCaount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("Toplam ayakkabı ücreti: " + shoPrice + " * " + shoCaount + " =" + shoPrice * shoCaount);
            //Console.WriteLine("Toplam bigisayar ücreti: " + computerPrice + " * " + computerCaount + " =" + computerPrice * computerCaount);
            //Console.WriteLine("Toplam sandalye ücreti: " + chairPrice + " * " + chairCaount + " =" + chairPrice * chairCaount);
            //Console.WriteLine("Toplam tv ücreti: " + tvPrice + " * " + tvCaount + " =" + tvPrice * tvCaount);

            //int totalPrice = shoPrice * shoCaount + computerPrice * computerCaount + chairPrice * chairCaount + tvPrice * tvCaount;

            //Console.WriteLine("----------------------------");

            //Console.WriteLine("Toplam Ücret: " + shoPrice * shoCaount + " + " + computerPrice * computerCaount + "  + " + chairPrice * chairCaount + " + " + tvPrice * tvCaount
            // + " =" + totalPrice);


            #endregion                                           

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion





            Console.Read();
        }
    }
}
