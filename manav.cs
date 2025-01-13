using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace kodlama



{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Manav uygulamasına hoşgeldiniz");
            
            string[] ürünler = new string[] { "kavun", "karpuz", "kıvırcık", "lahana", "ananas", "hindistan cevizi", "kabak", "avokado" };
            int[] stok = new int[] { 100, 200, 40, 80, 50, 80, 50, 59 };
            double[] fiyat = new double[] { 15.5, 17.50, 20, 40, 19, 25.5, 21.45, 22 };
            int[] satilanmiktar = new int[ürünler.Length];
           
            for (int i = 0; i < ürünler.Length; i++)
            {
                Console.WriteLine($"{ürünler[i]} - {stok[i]} adet stokta");
            }

            double toplamtutar = 0;

            while (true)
            {
                Console.WriteLine("Lütfen almak istediğiniz ürünleri seçin (kavun, karpuz, kıvırcık, lahana, ananas, hindistan cevizi, kabak, avokado): ");
                string secilenUrun = Console.ReadLine();
// z raporu
                if (secilenUrun == "çıkış")
                {
                    System.Console.WriteLine("Aldığınız ürünlerin toplam fiyatı :" + toplamtutar);

                    Console.WriteLine("   Z Raporu   ");
                    Console.WriteLine("Satılan Ürünler ve Miktarları:");
                    for (int i = 0; i < ürünler.Length; i++)
                    {
                        if (satilanmiktar[i] > 0)
                        {
                            Console.WriteLine($"{ürünler[i]}: {satilanmiktar[i]} adet - Toplam: {satilanmiktar[i] * fiyat[i]} TL");
                        }
                    }
                    Console.WriteLine($"Toplam Kazanç: {toplamtutar} TL");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz!");
                    break;
                }
    // satış bölümü
                int index = Array.IndexOf(ürünler, secilenUrun);

                if (index >= 0)
                {
                    Console.WriteLine($"{secilenUrun} ürünü şu an {stok[index]} adet stokta bulunuyor.");
                    Console.WriteLine("Kaç adet satılacak?: ");
                    int satilanAdet;
                    bool gecerli = int.TryParse(Console.ReadLine(), out satilanAdet);
                    

                    if (!gecerli || satilanAdet <= 0)
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen geçerli bir adet girin.");
                    }
                    else
                    {
                        if (satilanAdet <= stok[index])
                        {
                            stok[index] -= satilanAdet;
                            satilanmiktar[index] += satilanAdet; 
                            double tutar = fiyat[index] * satilanAdet;
                            toplamtutar += tutar;
                            Console.WriteLine($"{secilenUrun} ürününden {satilanAdet} adet satıldı. Yeni stok miktarı: {stok[index]}");
                            Console.WriteLine($"Toplam Tutar: {tutar} TL");
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz stok! Satılacak adet, mevcut stok miktarını aşamaz.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz ürün geçerli değil.");
                }
            }
        }
    }
}
