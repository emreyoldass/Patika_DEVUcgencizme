using System;

namespace Patika_DEVücgencizme
{
    class Program
    {
        static void Main(string[] args)
        {
            int say;
            Console.WriteLine("Üçgen Oluşturma Konsoluna Hoşgeldiniz");
            
            Console.WriteLine("1-) Dik Üçgen (90° - 45° - 45°)");
            Console.WriteLine("2-) Ters Dik Üçgen (90° - 45° - 45°)");
            Console.WriteLine("3-) Üçgen (60° - 60° - 60°)");
            Console.WriteLine("4-) Birleştirilmiş Üçgen (Baş kısmı bulunmayan)");
            ücgenler ücgen = new ücgenler();
            restart:
            Console.WriteLine("Seçmek istediğiniz Üçgen Çeşidi Nedir ?");
            int secim = int.Parse(Console.ReadLine());
            if (secim <= 4)
            {

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Oluşturmak için bir değer giriniz :");
                        say = int.Parse(Console.ReadLine());
                        ücgen.dikücgen(say);
                        break;
                    case 2:
                        Console.WriteLine("Oluşturmak için bir değer giriniz :");
                        say = int.Parse(Console.ReadLine());
                        ücgen.tersdikücgen(say);
                        break;
                    case 3:
                        Console.WriteLine("Oluşturmak için  bir değer giriniz :");
                        say = int.Parse(Console.ReadLine());
                        ücgen.ücgen(say);
                        break;
                    case 4:
                        Console.WriteLine("Oluşturmak için bir değer giriniz :");
                        say = int.Parse(Console.ReadLine());
                        ücgen.birlestirilmisücgen(say);
                        break;
                }
                Console.WriteLine();

            }
           
            else
            {
                Console.WriteLine("Var olmayan bir üçgen çeşidini seçtiniz. Lütfen tekrar seçim yapın.");
                goto restart;
            }
            Console.WriteLine("Başa dönmek istermisiniz E/Y");
            string tekrardeneme = Console.ReadLine();
            if (tekrardeneme.ToLower() == "e")
            {
                goto restart;
            }
        }
    }
}
