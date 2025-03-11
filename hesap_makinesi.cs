using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System .Threading.Tasks;





namespace kodlama
{
    
    class Program
    {

        static void Main(string[]args)
        {

        
           Console.WriteLine("Basit Hesap Makinesi");
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        double sonuc = 0;
        
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                    Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
                break;
            default:
                Console.WriteLine("Geçersiz işlem!");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}



    
    }
