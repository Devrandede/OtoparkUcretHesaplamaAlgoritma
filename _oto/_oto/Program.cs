using System;

namespace _oto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double ticari = 6.5, taksi = 6, minibus = 5;
                double saat = 0, tutar = 0;
                double _saat = 0;
                _saat = saat;
                double TicariExstra = 0, TaksiEkstra = 0, MinibusEkstra = 0;
                TicariExstra = ticari * 21.5 / 100;
                TaksiEkstra = taksi * 20 / 100;
                MinibusEkstra = minibus * 25 / 100;
                Console.WriteLine("Lütfen Park Etmek İstediğiniz  araç tipini seçiniz..\n -1- Ticari Araç -2- Taksi -3-Minibüs");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim < 1 || secim > 3)
                {
                    Console.WriteLine("Lütfen Araç Seçiminizi Kontrol Ediniz. Hatalı Tuşlama Yaptınız..");
                }

                while (secim >= 1 && secim <= 3)
                {

                    if (secim == 1)
                    {
                        tutar = ticari;
                        Console.WriteLine("Park Edilecek Araç Ticari.Ticari Araç Park Ücreti saatlik 6 tl'dir.\n ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" \n    Saatlik Ücretler => \n      (Ticari Araç) = 6.5 TL  \n      (Taksi) = 6 TL   \n      (Minibüs) = 5 TL \n " +
                        "Lütfen Kaç Saat Park Etmek İstediğinizi Rakam Olarak Giriniz..");
                        saat = Convert.ToInt32(Console.ReadLine());
                        if (saat == 1)
                        {
                            Console.WriteLine("Ödenecek tutar :" + tutar + " TL");
                            break;
                        }

                        if (saat > 1 && saat < 24)
                        {

                            tutar = tutar * saat;
                            TicariExstra = TicariExstra * saat;
                            tutar = tutar + TicariExstra;
                            Console.WriteLine($" Araç : Ticari | Kalınan Süre : {_saat} (Saat) |Tutar {tutar} TL");
                            break;


                        }
                        else
                        {
                            if (saat > 24)
                            {
                                Console.WriteLine("Lütfen 24 Saati Aşmayacak Bir Rakam Giriniz. 24 Saatten fazla Otopark Hizmetimiz Yoktur..");

                                break;
                            }
                            else if (saat < 1)
                            {
                                Console.WriteLine("Karşılıksız bir saat değeri girdiniz. 1 Saatten Az Otopark Hizmetimiz Yoktur..");
                                break;
                            }

                        }
                    }
                    else if (secim == 2)
                    {
                        tutar = taksi;
                        Console.WriteLine("Seçmiş olduğunuz Araç Taksidir. Taksi Fiyatı saatlik 6 tl'dir.\n " +
                            "Hatırlatma ; (1 Saati Aşan Park Sürelerine Her Saat Başına %20 Ekstra Saatlik Ücrete Eklenicektir..)");
                        if (saat == 1)
                        {
                            Console.WriteLine("Ödenecek tutar :" + tutar + " TL");
                            break;
                        }
                        if (saat > 1 && saat < 24)
                        {
                            tutar = tutar * saat;
                            TaksiEkstra = TaksiEkstra * saat;
                            tutar = tutar + TaksiEkstra;
                            Console.WriteLine($" Araç : Taksi | Kalınan Süre : {_saat} (Saat) |Tutar {tutar} TL");
                            break;

                        }
                        else
                        {
                            if (saat > 24)
                            {
                                Console.WriteLine("Lütfen 24 Saati Aşmayacak Bir Rakam Giriniz. 24 Saatten fazla Otopark Hizmetimiz Yoktur..");

                                break;
                            }
                            else if (saat < 1)
                            {
                                Console.WriteLine("Karşılıksız bir saat değeri girdiniz. 1 Saatten Az Otopark Hizmetimiz Yoktur..");
                                break;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçmiş olduğunuz Araç Modeli Minibüs. Minibüs Park Ücreti saatlik 6 tl'dir.\n " +
                            "Hatırlatma ; (1 Saati Aşan Park Sürelerine Her Saat Başına %25 Ekstra Saatlik Ücrete Eklenicektir..)");
                        tutar = minibus;
                        if (saat == 1)
                        {
                            Console.WriteLine("Ödenecek tutar :" + tutar + " TL");
                            break;
                        }
                        if (saat > 1 && saat < 24)
                        {

                            tutar = tutar * saat;
                            MinibusEkstra = MinibusEkstra * saat;
                            tutar = tutar + MinibusEkstra;
                            Console.WriteLine($" Araç : Minibüs | Kalınan Süre : {_saat} (Saat) |Tutar {tutar} TL");
                            break;

                        }
                        else
                        {

                            if (saat > 24)
                            {
                                Console.WriteLine("Lütfen 24 Saati Aşmayacak Bir Rakam Giriniz. 24 Saatten fazla Otopark Hizmetimiz Yoktur..");
                                break;

                            }
                            else if (saat < 1)
                            {
                                Console.WriteLine("Karşılıksız bir saat değeri girdiniz. 1 Saatten Az Otopark Hizmetimiz Yoktur..");
                                break;
                            }

                            break;

                        }

                    }

                }
            }
            catch
            {
                Console.WriteLine("Lütfen Girdiğiniz Değerleri Kontrol Ediniz Ve Tekrar Deneyiniz . Hatalı Tuşlama Yaptınız..");

            }
        }
    }
}
