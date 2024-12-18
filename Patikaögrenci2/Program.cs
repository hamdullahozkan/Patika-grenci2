using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Merhaba Dünya";

            Console.WriteLine(greeting);
            Console.WriteLine("Merhaba Dünya");

            int year = 2024;
            Console.WriteLine("Bu yıl " + year + " .");

            Console.WriteLine("Adınız: ");
            string name = Console.ReadLine();

            Console.WriteLine("Yaşınız: ");
            string strAge = Console.ReadLine();

            // Yaşı bir tam sayı olarak almak isterseniz:
            if (int.TryParse(strAge, out int age))
            {
                Console.WriteLine($"Merhaba {name}, {age} yaşındasınız.");
            }
            else
            {
                Console.WriteLine($"Merhaba {name}, yaşınızı doğru girmediniz: {strAge}");
            }

            // Programın sonlanmasını beklemek için (isteğe bağlı):
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
