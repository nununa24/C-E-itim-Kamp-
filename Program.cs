using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                         // 1. DERS
            
            Console.WriteLine("****** Yemek Kategorileri ******\n");
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Ara Sicaklar");
            Console.WriteLine("3- Corbalar\n");
            Console.WriteLine("****** Afiyet Olsun ******\n");

            string customer_name;    
            string customer_surname;
            string customer_phone;
            string customer_email;
            string district, city;   

            customer_name = "Nurefsan";
            customer_surname = "Akerik";
            customer_phone = "+90 500 400 30 20";
            customer_email = "denem@gmail.com";
            district = "Uzumlu";
            city = "Erzincan";

            Console.WriteLine("**** Rezervasyon Karti ****\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Musteri: " + customer_name + " " + customer_surname);
            Console.WriteLine("Iletisim: " + customer_phone);
            Console.WriteLine("E-Mail: " + customer_email);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------------\n");

            customer_name = "Aslan";
            customer_surname = "Yilmaz";
            customer_phone = "+90 500 400 30 20";
            customer_email = "deneme@gmail.com";
            district = "Buyuk Cekmece";
            city = "Istanbul";

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Musteri: " + customer_name + " " + customer_surname);
            Console.WriteLine("Iletisim: " + customer_phone);
            Console.WriteLine("E-Mail: " + customer_email);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------------\n\n");


            int hamburger_price = 300;
            int coke_price = 35;
            int water_price = 10;
            int fries_price = 50;
            int pizza_price = 250;
            int lemonade_price = 30;

            Console.WriteLine("**** Restoran Menu Fiyati ****\n");
            Console.WriteLine("--Hamburger: " + hamburger_price + " TL");
            Console.WriteLine("--Pizza: " + pizza_price + " TL");
            Console.WriteLine("--Kola: " + coke_price + " TL");
            Console.WriteLine("--Limonata: " + lemonade_price + " TL");
            Console.WriteLine("--Kizartma: " + fries_price + " TL");
            Console.WriteLine("--Su: " + water_price + " TL");
            Console.WriteLine();

            int hamburger_count = 3;
            int coke_count = 3;
            int water_count = 3;
            int fries_count = 1;
            int pizza_count = 0;
            int lemonade_count = 0;

            int total_hamburger_price = hamburger_count * hamburger_price;
            int total_coke_price = coke_count * coke_price;
            int total_water_price = water_count * water_price;
            int total_fries_price = fries_count * fries_price;
            int total_pizza_price = pizza_count * pizza_price;
            int total_lemonade_price = lemonade_count * lemonade_price;

            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Hamburger Tutari: " + total_hamburger_price + " TL");
            Console.WriteLine("Kola Tutari: " + total_coke_price + " TL");
            Console.WriteLine("Su Tutari: " + total_water_price + " TL");
            Console.WriteLine("Limonata Tutari: " + total_lemonade_price + " TL");
            Console.WriteLine("Kizartma Tutari: " + total_fries_price + " TL");
            Console.WriteLine("Pizza Tutari: " + total_pizza_price + " TL\n");

            int total_price = total_hamburger_price + total_coke_price + total_water_price + total_lemonade_price + total_fries_price + total_pizza_price;
            Console.WriteLine("Toplam Tutar: " + total_price);

                         // 2. DERS

             #region Double Değişkenler
             Console.WriteLine("***** Fiyat Listesi *****\n");
             double apple_price, orange_price, strawberry_price, potato_price, tomato_price;

             apple_price = 14.85;
             orange_price = 18.95;
             strawberry_price = 20.54;
            potato_price = 16.32;
            tomato_price = 22.68;
  
            Console.WriteLine("--Elma Birim Fiyati: " + apple_price + " TL");
            Console.WriteLine("--Portakal Birim Fiyati: " + orange_price + " TL");
            Console.WriteLine("--Cilek Birim Fiyati: " + strawberry_price + " TL");
            Console.WriteLine("--Patates Birim Fiyati: " + potato_price + " TL");
            Console.WriteLine("--Domates Birim Fiyati: " + tomato_price + " TL");

            double apple_gram, orange_gram, strawberry_gram, potato_gram, tomato_gram;

            apple_gram = 1.456;
            orange_gram = 3.6132;
            strawberry_gram = 8.9657;
            potato_gram = 5.7461;
            tomato_gram = 2.2561;

            double apple_total_price = apple_gram * apple_price;
            double orange_total_price = orange_gram * orange_price;
            double strawberry_total_price = strawberry_gram * strawberry_price;
            double potato_total_price = potato_gram * potato_price;
            double tomato_total_price = tomato_gram * tomato_price;

            Console.WriteLine("Alinan Urun: Elma\t" + "Birim Fiyatı: " + apple_price + " TL" + "\tGramaj: " + apple_gram + "\tToplam Tutar: " + apple_total_price + " TL");
            Console.WriteLine("Alinan Urun: Portakal\t" + "Birim Fiyatı: " + orange_price + " TL" + "\tGramaj: " + orange_gram + "\tToplam Tutar: " + orange_total_price + " TL");
            Console.WriteLine("Alinan Urun: Cilek\t" + "Birim Fiyatı: " + strawberry_price + " TL" + "\tGramaj: " + strawberry_gram + "\tToplam Tutar: " + strawberry_total_price + " TL");
            Console.WriteLine("Alinan Urun: Patates\t" + "Birim Fiyatı: " + potato_price + " TL" + "\tGramaj: " + potato_gram + "\tToplam Tutar: " + potato_total_price + " TL");
            Console.WriteLine("Alinan Urun: Domates\t" + "Birim Fiyatı: " + tomato_price + " TL" + "\tGramaj: " + tomato_gram + "\tToplam Tutar: " + tomato_total_price + " TL");

            double shopping_tottal_price = apple_total_price + orange_total_price + strawberry_total_price + potato_total_price + tomato_total_price;

            Console.WriteLine();
            Console.WriteLine("Alisveris Toplam Tutar: " + shopping_tottal_price + " TL");
            #endregion

                
            #region Char Değişkenler
            char symbol = 'a';
            // char sembol = "a";    HATA VERİR
            Console.WriteLine(symbol);
            #endregion

                
            #region Klavyeden Veri Girişleri (String) 
            Console.WriteLine("***** Yolcu Bilgisi *****\n");
            string passenger_name, passencer_surname, passenger_district, passencer_city, passencer_age, passencer_identity_no;

           Console.Write("Yolcu Adi: ");
           passenger_name = Console.ReadLine();

           Console.Write("Yolcu Soyadi: ");
           passencer_surname = Console.ReadLine();

           Console.Write("Ilce Bilgisi: ");
           passenger_district = Console.ReadLine();

           Console.Write("Il Bilgisi: ");
           passencer_city = Console.ReadLine();

           Console.Write("Yas Bilgisi: ");
           passencer_age = Console.ReadLine();

           Console.Write("Kimlik Numarasi:");
           passencer_identity_no = Console.ReadLine();
           Console.WriteLine();

           Console.WriteLine("-------------------------------------------");
           Console.WriteLine("Yolcu Kimlik No: " + passencer_identity_no + "\t" + "- Yolcu Adi Soyadi: " + passenger_name + " " +
           passencer_surname + " " + passenger_district + "/" + passencer_city + " " + passencer_age);
           #endregion


           #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
           int shoes_price, computer_price, chair_price, tv_price, shoes_count, computer_count, chair_count, tv_count;
           shoes_price = 1000;
           computer_price = 20000;
           chair_price = 5000;
           tv_price = 12000;

           Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
           shoes_count = int.Parse(Console.ReadLine());

           Console.Write("Lutfen aldiginiz bilgisayar sayiisni girizniz: ");
           computer_count = int.Parse(Console.ReadLine());

           Console.Write("Lutfen aldiginiz koltuk sayisini giriniz: ");
           chair_count = int.Parse(Console.ReadLine());

           Console.Write("Lutfen aldiginiz tv sayisini giriniz: ");
           tv_count = int.Parse(Console.ReadLine());

           int total_price = shoes_count * shoes_price + computer_count * computer_price + chair_count * chair_price + tv_count * tv_price;
           Console.WriteLine("\nToplam odemeniz gereken tutar: " + total_price);
           #endregion


           #region Klavyeden Ondalıklı Sayı İşlemleri
           double exam1, exam2, exam3, result;

           Console.Write("1. sinav notu: ");
           exam1 = double.Parse(Console.ReadLine());

           Console.Write("2. sinav notu: ");
           exam2 = double.Parse(Console.ReadLine());

           Console.Write("3. sinav notu: ");
           exam3 = double.Parse(Console.ReadLine());

           result = (exam1 + exam2 + exam3) / 3;
           Console.WriteLine("\nSinav ortalamasi: " + result);
           #endregion

           #region Klavyeden Karakter Girişleri
           char gender;
           Console.Write("Lutfen ciniyet seciniz: ");
           gender = char.Parse(Console.ReadLine());
           Console.WriteLine("Sectiginiz cinsiyet: " + gender);
           #endregion
            
            Console.ReadKey(); 
        }
    }
}
