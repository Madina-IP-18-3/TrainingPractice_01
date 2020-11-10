using System;

namespace JMM_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 10;
             Console.Write("Введите количество золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Не хотели бы приобрести кристаллы по цене " + price + " золотых\n");
             Console.WriteLine("Сколько кристаллов Вы хотите купить?");
            int cristal = Convert.ToInt32(Console.ReadLine());

            gold = gold - (cristal * price);

             Console.WriteLine();
             Console.WriteLine("Сделка успешно совершена!\nВы приобрели кристаллы в количестве: " + cristal);
             Console.WriteLine("Остаток вашего золота: " + gold);
            Console.ReadKey();
        }
    }
}
