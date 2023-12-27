using System.Runtime.ConstrainedExecution;

namespace Algoritma_calısmasi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region örnek-1



           // Bir mağazada alınan ürünün fiyatı 100 TL ve üzerinde
           // ise 5 TL olan kargo ücreti alınmamaktadır.Ürünün fiyatı
           // girildiğinde toplam ödenmesi gereken tutarı gösteren C# konsol uygulaması


   
            {

                Console.Write("ürünün fiyatını giriniz:");
                int ürün = int.Parse(Console.ReadLine());


                if (ürün >= 100)
                {
                    int satış = ürün;
                    Console.WriteLine("Ödenmesi gereken miktar:" + satış);

                }
                else
                {
                    int satış = ürün + 5;
                    Console.WriteLine("ödenmesi gereken miktar:" + satış);
                }


            }



            #endregion



            #region örnek-2


            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise,
            //2.üründen % 25 indirim yaparak ödenecek tutarı gösteren C# konsol uygulaması.


      
            {
                Console.Write("1.ürünün fiyatını giriniz:");
                double sayı1 = double.Parse(Console.ReadLine());
                Console.Write("2.ürün fiyatı:");
                double sayı2 = double.Parse(Console.ReadLine());

                double toplam = sayı1 + sayı2;


                if (toplam > 200)
                {
                    double tutar = sayı1 + (sayı2 * 75 / 100);
                    Console.Write("ödenecek tutar:" + tutar);
                }

                else
                {
                    Console.Write("ödenecek tutar:" + toplam);
                }


            }



            #endregion



            #region örnek-3


            //1’den 25’e kadar olan sayıların kareleri toplamını bulan C# konsol uygulaması.

   
            {
                int sayac = 0;

                do
                {

                    sayac = sayac + 1;
                }
                while (sayac <= 25);

                int toplam = 0;

                for (int i = 0; i <= 25; i = i + 1)
                {
                    int karesi = i * i;
                    toplam = toplam + karesi;
                }

            }






            #endregion



            #region örnek-4


           // Furkan, bir romanın her gün bir önceki gün okuduğu sayfadan 5 sayfa fazlasını okumaktadır.
           // İlk gün 10 sayfa okuyarak başlayan Furkan' ın 1.000 sayfalık bir romanı kaç günde bitireceğini
           // bulan program.


      
            {

                int sayfa = 1000;
                int gün = 1;
                int okunmuş = 10;
                do
                {
                    okunmuş = (okunmuş + okunmuş) + 5;
                    gün++;
                }
                while (okunmuş <= sayfa);

                Console.WriteLine("kitabın toplamda bittiği gün:" + gün);






            }

            #endregion





            #region örnek-5

            //1-100 arasındaki sayılardan, kullanıcının girdiği sayıya
            //tam olarak bölünenleri ekrana yazdıran kod

            Console.Write("sayı girin:");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("1-100 arasındaki sayılardan " + sayi + "değerine tam olarak bölünebilne sayılar");

            for (int i = 1; i < 100; i++)
            {
                if (i% sayi==0)
                {
                    Console.Write(i + " ");
                }


            }

            


            #endregion






        }
    }
}
