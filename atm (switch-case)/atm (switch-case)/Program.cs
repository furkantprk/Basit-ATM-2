using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm__switch_case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1-Bakiye Görüntüle:");
            Console.WriteLine("2-Para yatırma:");
            Console.WriteLine("3-Para çekme:");
            Console.WriteLine("4-Çıkış");
            double bakiye = 1233.55;
           
            
            int islem=Convert.ToInt32(Console.ReadLine());
            

            switch (islem)
            {
                case 1: Console.WriteLine("Bakiyeniz:"+ bakiye); break;
                case 2: 
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:"); 
                    int yatirilicak_tutar=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yatırılan para ile beraber bakiyeniz: " + (bakiye + yatirilicak_tutar));
                    break;

                case 3:
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Çekilen tutardan sonra bakiyeniz: " + (bakiye - cekilecek_tutar));
                    break;
                case 4: Console.WriteLine("ATM'DEN ÇIKIŞ YAPTINIZ. YİNE BEKLERİZ."); break;
                default: Console.WriteLine("Eksik ya da hatalı tuşlama yaptınız. Lütfen yeniden deneyiniz."); break;
            }

            Console.ReadKey();


        }
    }
}
