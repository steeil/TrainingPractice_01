using System;

namespace VDV_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++) array[i] = random.Next(-50, 50);

            Console.WriteLine("\nМассив до сортировки:");
            for (int i = 0; i < size; i++)
                Console.Write(array[i] + " ");
            Console.Write("\n");
            Console.WriteLine("\nМассив после сортировки:");
            Shuffle(array, size);
            for (int i = 0; i < size; i++)
                Console.Write(array[i] + " ");
            Console.Write("\n");
        }
        static void Shuffle(int[] array, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int j = random.Next(0, i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
