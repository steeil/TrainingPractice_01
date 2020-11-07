using System;

namespace VDS_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите кол-во золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            while (gold <= 0)
            {
                Console.WriteLine("Кол-во золота не может быть меньше 0");
                Console.WriteLine("\nВведите кол-во золота: ");
                gold = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите все кол-во кристаллов: ");
            int crystal = Convert.ToInt32(Console.ReadLine());
            while (crystal <= 0)
            {
                Console.WriteLine("Кол-во кристаллов не может быть меньше 0");
                Console.WriteLine("Введите все кол-во кристаллов: ");
                crystal = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите цену одного кристалла: ");
            int price = Convert.ToInt32(Console.ReadLine());
            while (price <= 0)
            {
                Console.WriteLine("Цена одного кристалла не может быть меньше 0");
                Console.WriteLine("Введите цену одного кристалла: ");
                price = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nВведите кол-во кристаллов для покупки: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (amount > crystal)
            {
                Console.WriteLine("\nВы ввели кол-во кристаллов, которое превышает кол-во всех кристаллов");
                Console.WriteLine("\nВведите кол-во кристаллов для покупки: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            int maxAmount = gold / price;
            while (maxAmount >= amount)
            {
                Console.WriteLine($"\nПокупка совершена успешно! Вы купили {amount} кристаллов и у вас осталось {gold - amount * price} золота");
                Environment.Exit(0);
            }
            Console.WriteLine($"\nУ вас недостаточно средств для покупки {amount} кристаллов. Вы можете купить {maxAmount} кристаллов.");
        }
    }
}
