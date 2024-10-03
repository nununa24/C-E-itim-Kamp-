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

            customer_name = "Suheda";
            customer_surname = "Akerik";
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

            
            
            Console.ReadKey(); 
        }
    }
}
