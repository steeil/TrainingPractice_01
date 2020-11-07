using System;

namespace VDV_Task_04
{
    public class Player
    {
        public int health;
        public int amount = 1;
        public int mana=0;
        public int PlayerDamage(string spell)
        {
            Random random = new Random();
            int damage;
            int playerDamage;
            switch (spell.ToLower())
            {
                case "attack":
                    damage = random.Next(25,41);
                    Console.WriteLine($"Вы нанесли {damage} урона противнику");
                    mana++;
                    return damage;
                case "fireball":
                    damage = random.Next(60, 81);
                    Console.WriteLine($"Вы нанесли {damage} урона противнику");
                    mana++;
                    return damage;
                case "mega attack":
                    if(mana>=3)
                    {
                        damage = 150;
                        playerDamage = 50;
                        health -= playerDamage;
                        Console.WriteLine($"Вы нанесли {damage} урона, но поранились и получили {playerDamage} урона");
                        mana = mana-3;
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно маны");
                        damage = 0;
                    }
                    return damage;

                case "bonus attack":
                    if (amount > 0 && mana>=5)
                    {
                        damage = 350;
                        playerDamage = 150;
                        health -= playerDamage;
                        Console.WriteLine($"Вы нанесли {damage} урона, но повредились и получили {playerDamage} урона");
                        amount--;
                        mana = mana - 5;
                    }
                    else 
                    {
                        Console.WriteLine("Вы не смогли использовать бонусную атаку");
                        damage = 0;
                    }
                    return damage;
                case "potion":
                    if (health <= 50)
                    {
                        health += 100;
                        Console.WriteLine("Вы выпили зелье восстановления");
                    }
                    else
                        Console.WriteLine("Вы можете выпить зелье только, когда у вас меньше 50 ХП.");
                    return 0;
            }
            Console.WriteLine("Увы, такого действия нет.");
            return 0;
        }
    }
    public class Boss
    {
        public int health;
        public int bossAttack;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Player player = new Player();
            Boss boss = new Boss();
            Console.WriteLine("Возможные действия: \n" +
                "attack       - наносит от 25 до 40 урона боссу, начисляет 1 ману\n" +
                "fireball     - наносит от 60 до 80  урона боссу, начисляет 1 ману\n" +
                "mega attack  - наносит 150 урона боссу, и 50 урона вам, необходимо маны: 3\n" +
                "bonus attack - наносит 350 урона боссу, и 150 урона вам, использовать можно только 1 раз, необходимо маны: 5\n" +
                "potion       - восстанавливает здоровье на 100 HP, но только если у вас меньше 50 HP\n");
            player.health = random.Next(600, 700);
            boss.health = random.Next(700, 800);
            for (int step = 1; (player.health > 0) && (boss.health > 0); step++)
            {
                Console.WriteLine($"{step} ход ");
                Console.WriteLine($"Кол-во жизней у вас: {player.health} HP. Кол-во жизней противника - {boss.health} HP");
                Console.WriteLine("Накоплено маны: " + player.mana);
                Console.WriteLine("\nВведите действие: ");
                string spell = Console.ReadLine();
                boss.health -= player.PlayerDamage(spell);
                if (spell.ToLower() != "potion")
                {
                    boss.bossAttack = random.Next(26, 100);
                    player.health -= boss.bossAttack;
                    Console.WriteLine($"Противник нанес вам {boss.bossAttack} урона");
                }
                Console.Write("\n-----\n");
            }
            Console.Clear(); 
            if (boss.health <= 0)
            {
                if (player.health > 0)
                    Console.WriteLine("Вы выиграли!");
                else
                    Console.WriteLine("Ничья!");
            }
            else
                Console.WriteLine("Вы проиграли!");
        }
    }
}
