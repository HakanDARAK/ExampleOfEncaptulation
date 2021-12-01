using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_11_2021_EncaptulationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string karar = string.Empty;
            string karar1 = string.Empty;
            string karar3 = string.Empty;
            personel personel = new personel();
            do
            {
                Console.WriteLine("Lütfen TC kimlik numaranızı Giriniz");
                string tcNo = Console.ReadLine();
                personel.TcNo = tcNo;
                Console.WriteLine("En son başarılı olarak girdiginiz TC kimlik numarasının ilk beş hanesini görmek istiyor musunuz? Evetse E Hayırsa H yazınız.");
                karar1 = Console.ReadLine();
                string karar2= karar1.ToUpper();
                if (karar2 == "E")
                {
                    Console.WriteLine(personel.TcNo);
                }
                Console.WriteLine("Ekleme yapmak istiyor musunuz? Evetse E Hayırsa H yazınız.");
                karar = Console.ReadLine();
               karar3= karar.ToUpper();
            } while (karar3 != "H");
            Console.ReadLine();
        }
    }
}
