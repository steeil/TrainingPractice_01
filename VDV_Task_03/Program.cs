using System;

namespace VDV_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifPassword;
            string password = "практика сишарп";
            string message = "'задание 3 заключается в том, что пользователь за 3 попытки должен угадать пароль'";
            Console.WriteLine("Данная программа содержит секретное послание. Чтобы его увидеть, Вам нужно угадать пароль. У вас есть 3 попытки.");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите пароль:");
                ifPassword = Convert.ToString(Console.ReadLine());
                if (ifPassword == password)
                {
                    Console.WriteLine("Пароль совпал.\nСекретное послание: " + message);
                    break;
                }
                Console.WriteLine("Пароль не совпал");
            }
        }
    }
}
