using System;

namespace JMM_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = " ";
            int sum = 0;

                do
                {

                    word = Console.ReadLine();
                    sum++;

                }
                while (word!= ("exit"));
            Console.WriteLine("Количество введенных  слов " + sum);
            Console.ReadKey();
            }
    }
}
