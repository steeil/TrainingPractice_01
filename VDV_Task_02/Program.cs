using System;

namespace VDV_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для выхода введите 'exit'");
            string exit = " ";
            while (exit != "exit")
            {
                exit = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
