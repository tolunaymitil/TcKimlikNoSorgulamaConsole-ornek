using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeÖrnekTcSorgusu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.TCKİMLİKNO = "12345678910";
            Console.WriteLine("Tc Kimlik Numaranız" + P1.TCKİMLİKNO);
            Console.ReadLine();
        }
    }

    public class Personel
    {
        private string tckimlikno;
        public string TCKİMLİKNO
        {
            get
            {
                return tckimlikno.Substring(0, 4)+"******";
            }

            set
            {
                bool kontrol = false; 
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                       bool sayiMi= char.IsNumber(value[i]); //123456789
                        if (sayiMi)
                        {
                            //yapmam gereken birşey yok 
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Tc Kimlik Numaranızda Geçersiz karakter bulundu");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Tc Kimlik no 11 karakter değildir");
                }
            }
        }
    }
}
