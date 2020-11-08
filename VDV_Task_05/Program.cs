using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace exp5
{
    class Program
    {
        static int pos1 = 0;
        static int pos2 = 0;
        static int coin = 0;
        static int step = 0;
        static int allCoin=0;

        static public char[,] ReadMap()
        {
            string[] file = File.ReadAllLines("..\\..\\..\\map.txt");
            char[,] map = new char[file.Length, file[0].Length];


            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    map[i, j] = file[j][i];

                    if (map[i, j] == '■')
                    {
                        pos1 = i;
                        pos2 = j;
                    }
                    if (map[i, j] == '.')
                        allCoin++;
                }
            }

            return map;
        }

        static public void DrawMap(char[,] map)
        {
            Console.Clear();
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static public bool CheckStep(char[,] map, int pos1, int pos2)
        {
            switch (map[pos1, pos2])
            {
                case ' ':
                    step++;
                    Console.SetCursorPosition(31, 7);
                    Console.WriteLine($"Сделано {step} шагов");
                    return true;
                case '.':
                    coin++;
                    step++;
                    Console.SetCursorPosition(31, 7);
                    Console.WriteLine($"Сделано {step} шагов");
                    Console.SetCursorPosition(31, 8);
                    if (coin > 0)
                        Console.WriteLine($"Вы собрали {coin} монет");
                    Console.SetCursorPosition(pos1, pos2);
                    map[pos1, pos2] = ' ';
                    Console.Write(map[pos1, pos2]);
                    return true;
                case '■':
                    step++;
                    Console.SetCursorPosition(31, 7);
                    Console.WriteLine($"Сделано {step} шагов");
                    return true;
                case 'E':
                    if (coin==allCoin)
                    {
                        Console.SetCursorPosition(pos1, pos2);
                        map[pos1, pos2] = ' ';
                        Console.Write(map[pos1, pos2]);
                        Console.SetCursorPosition(31, 10);
                        Console.WriteLine($"Лабиринт пройден! Вы сделали {step} шагов и собрали {coin} монет");
                        Console.SetCursorPosition(31, 30);
                        System.Environment.Exit(1);
                    }
                    return false;
                default:
                    return false;
            }
        }

        static public void MoveMap(char[,] map, int pos1, int pos2)
        {
            int newPos;
            Console.SetCursorPosition(31, 1);
            Console.WriteLine("Правила игры: Соберите все монеты на карте за минимальное кол-во шагов");
            Console.SetCursorPosition(31, 2);
            Console.WriteLine($"Всего монет на карте: {allCoin}");
            Console.SetCursorPosition(31, 4);
            Console.WriteLine($"Для выхода нажмите Esc");
            Console.SetCursorPosition(pos1, pos2);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    newPos = pos1 - 1;
                    if (CheckStep(map, newPos, pos2))
                        pos1 = newPos;
                    break;
                case ConsoleKey.RightArrow:
                    newPos = pos1 + 1;
                    if (CheckStep(map, newPos, pos2))
                        pos1 = newPos;
                    break;
                case ConsoleKey.UpArrow:
                    newPos = pos2 - 1;
                    if (CheckStep(map, pos1, newPos))
                        pos2 = newPos;
                    break;
                case ConsoleKey.DownArrow:
                    newPos = pos2 + 1;
                    if (CheckStep(map, pos1, newPos))
                        pos2 = newPos;
                    break;
                case ConsoleKey.Escape:
                    Console.SetCursorPosition(31, 10);
                    Console.WriteLine($"ВВы вышли из игры");
                    Console.SetCursorPosition(31, 30);
                    System.Environment.Exit(1);
                    break;
            }
            
            Console.SetCursorPosition(pos1, pos2);
            MoveMap(map, pos1, pos2);
        }

        static void Main(string[] args)
        {
            char[,] map = ReadMap();
            DrawMap(map);
            Console.SetCursorPosition(pos1, pos2);
            MoveMap(map, pos1, pos2);

            Console.ReadKey();
        }
    }
}
