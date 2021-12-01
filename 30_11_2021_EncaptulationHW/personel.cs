using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_11_2021_EncaptulationHW
{
    public class personel
    {
        private string _TcNo;
        public string TcNo
        {
            get
            {
                return _TcNo.ToString().Substring(0, 5);
            }
            set
            {
                try
                {
                    int sayac = 0;
                    bool control = false;
                    if (value.ToString().Length == 11)
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            control = char.IsNumber(value[i]);
                            if (control)
                            {
                                sayac++;
                            }

                        }
                        if (sayac == 11)
                        {
                            _TcNo = value;
                            Console.WriteLine("Başarılı bir şekilde kayıt oluşturuldu");
                        }
                        else
                        {
                            Console.WriteLine("HATA! TC kimlik no sadece rakamlardan oluşturulmalıdır");
                        }
                    }
                    else
                    {
                        Console.WriteLine("HATA! TC kimlik numarası 11 haneli olmalıdır");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("HATA! : " + ex);
                }
            }
        }
    }
}
