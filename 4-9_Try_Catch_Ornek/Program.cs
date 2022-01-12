using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_Try_Catch_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Console.ReadLine();
        }

        private static void Ornek1()
        {
            //Sınav notunu isteyelim.
            //0-50 arası "Daha çok çalışmalısın"
            //50-70 arası "Daha iyi olabilir"
            //70-100 arası "Başarılı"
            Console.WriteLine("Lutfen sınav notunu giriniz");

            try
            {
                int not = Convert.ToInt32(Console.ReadLine());

                if (not >= 0 && not <= 50)
                {
                    Console.WriteLine("Daha çok çalışmalaısın");
                }
                else if (not >= 51 && not <= 69)
                {
                    Console.WriteLine("Daha iyi olabilir");
                }
                else if (not >= 70 && not <= 100)
                {
                    Console.WriteLine("Başarılı");
                }
            }
            catch
            {

                Console.WriteLine("Sayı girmediniz.İşleme devam edilmiyor");
            }

        }
    }
}
