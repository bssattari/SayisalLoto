using System;

namespace SayisalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            // VS 2022 kurulu arkadaşlar buradan yazmaya başlasın!
            int[] sayilar = new int[6];
            int[] randomSayilar = new int[6];
            int girilenSayi;
            int tahminEdilenAdet=0;
            Random rnd = new Random();
            Console.WriteLine("HOŞGELDİNİZ!\n");
            Console.WriteLine("Lütfen 1-59 Arasında 6 Adet Sayı Giriniz: ");
            Console.WriteLine("****************************\n");
            for (int i = 0; i < 6; i++)
            {
                randomSayilar[i]=rnd.Next(1,59);
                sayiGir:
                Console.Write("Lütfen {0}. Sayıyı Giriniz: ", (i + 1));
                girilenSayi = Convert.ToInt16(Console.ReadLine());

                if (girilenSayi > 0 && girilenSayi < 60)
                {                   
                    sayilar[i] = girilenSayi;
                    Console
                        .WriteLine("{0}. sayı olarak {1} sayısını girdiniz",
                        (i + 1),
                        sayilar[i]);
                        continue;
                }
                else
                {
                    Console.WriteLine("Lütfen 1-59 Arasında 6 Adet Sayı Giriniz!");
                    goto sayiGir;
                }
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = 0; j < randomSayilar.Length; j++)
                {
                    if (sayilar[i]==randomSayilar[j])
                    {
                        Console.WriteLine("{0} Sayısını Doğru Tutturdunuz", randomSayilar[j]);
                        tahminEdilenAdet++;
                    }
                }
            }

            Console.WriteLine("Random Tutulan Aşağıdaki Sayılar İçerisinde");

            foreach (var randomSayi in randomSayilar)
            {
                Console.Write("{0} ", randomSayi);
            }

            Console.WriteLine("\n {0} Adet Doğru Tahminde Bulundunuz!", tahminEdilenAdet);





            // VS 2022 kuruya kadar yazsın!
        }
    }
}
