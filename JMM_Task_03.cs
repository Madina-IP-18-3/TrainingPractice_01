using System;

namespace JMM_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "aVd_12";
              Console.WriteLine("Введите пароль ");
            for (int i = 1; i <= 3; i++)
            {                
               string kod = Console.ReadLine();
                if (password == kod)
                   {
                      Console.WriteLine("P.S. Скоро новый год!");
                      break;
                   }
                else
                   {
                      Console.WriteLine(" Пароль неверный. Попытка {0}/3", i );
                   }
                                
            };
            
            Console.ReadKey();

        }
    }
}
