using System;
using System.Threading;

namespace Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
            string user_answer;
            Console.WriteLine("Yarismaya Hosgeldiniz !");
            Thread.Sleep(2000);
            Console.WriteLine("Toplam 3 adet soru cevaplayacaksiniz. En az 2 adet soruyu dogru cevaplarsaniz buyuk odulun sahibi olacaksiniz.");
            Thread.Sleep(2000);
            Console.WriteLine("Sorulara baslamak icin bir tusa basiniz.");
            Console.ReadKey(true);
            Console.WriteLine("Soru 1 : Formula 1'de bir sezonda en fazla yaris kazanan pilot kimdir ? \n A:Lewis Hamilton \n B:Michael Schumacher ");

            bool validAnswer = false;
            while (!validAnswer)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        correct++;
                        validAnswer = true;
                        Console.WriteLine("Dogru cevap!");
                        break;
                    case "b":
                        validAnswer = true;
                        Console.WriteLine("Malesef Yanlis cevap!");
                        break;
                    default:
                        Console.WriteLine("Gecersiz bir secim yaptiniz. Lutfen A veya B seceneklerinden birini giriniz.");
                        break;
                }
            }

            // İkinci soru
            Console.WriteLine("İkinci Sorunuz Geliyor !");
            Thread.Sleep(2000);
            Console.WriteLine("Soru 2 : Cebir alanında önemli çalışmalar yapan Müslüman bilim insanı kimdir ? \n A: İbn Sina \n B: Harezmi ");

            validAnswer = false;
            while (!validAnswer)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "b":
                        correct++;
                        validAnswer = true;
                        Console.WriteLine("Dogru cevap!");
                        break;
                    case "a":
                        validAnswer = true;
                        Console.WriteLine("Malesef Yanlis cevap!");
                        break;
                    default:
                        Console.WriteLine("Gecersiz bir secim yaptiniz. Lutfen A veya B seceneklerinden birini giriniz.");
                        break;
                }
            }

            // En az bir doğru cevap varsa üçüncü soru
            if (correct > 0)
            {   
                Console.WriteLine("Üçüncü Sorunuz Geliyor !");
                Thread.Sleep(2000);
                Console.WriteLine("Soru 3 : Dünyanın en yüksek dağı hangisidir? \n A: Agri \n B: Everest");

                validAnswer = false;
                while (!validAnswer)
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "b":
                            correct++;
                            validAnswer = true;
                            Console.WriteLine("Dogru cevap!");
                            break;
                        case "a":
                            validAnswer = true;
                            Console.WriteLine("Malesef Yanlis cevap!");
                            break;
                        default:
                            Console.WriteLine("Gecersiz bir secim yaptiniz. Lutfen A veya B seceneklerinden birini giriniz.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Yarismayi kaybettiniz. Tekrar deneyin.");
            }

            // Yarışma sonucu
            if (correct >= 2)
            {
                Console.WriteLine("Tebrikler! Büyük ödülün sahibi oldunuz.");
            }
            else
            {
                Console.WriteLine("Malesef, yeterli doğru cevabı veremediniz.");
            }
        }
    }
}
