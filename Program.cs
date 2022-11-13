using System;

namespace BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char PIRATE = '1';
            const char STONE_CHEWER = '2';
            const char GHOST_WARRIOR = '3';
            const char OUTWORLDER = '4';
            const char MONSTER_KNIGHT = '5';
            const char DARK_GOBLIN = '6';


            const int HEALTH_PIRATE = 20, SPEED_PIRATE = 3, ATTACK_PIRATE = 3, ARMOR_PIRATE = 3;
            const int HEALTH_STONE_CHEWER = 50, SPEED_STONE_CHEWER = 1, ATTACK_STONE_CHEWER = 8, AMORE_STONE_CHEWER = 10;
            const int HEALTH_GHOST_WARRIOR = 20, SPEED_GHOST_WARRIOR = 5, ATTACK_GHOST_WARRIOR = 2, ARMOR_GHOST_WARRIOR = 2;
            const int HEALTH_OUTWORLDER = 20, SPEED_OUTWORLDER = 10, ATTACK_OUTWORLDER = 1, ARMOR_OUTWORLDER = 2;
            const int HEALTH_MONSTER_KNIGHT = 15, SPEED_MONSTER_KNIGHT = 3, ATTACK_MONSTER_KNIGHT = 4, ARMOR_MONSTER_KNIGHT = 3;
            const int HEALTH_DARK_GOBLIN = 10, SPEED_DARK_GOBLIN = 3, ATTACK_DARK_GOBLIN = 3, AMORE_DARK_GOBLIN = 8;


            Console.WriteLine("   ROLE              ATTRIBUTE VALUES");
            Console.WriteLine("1) Pirate            Health: 20, attack: 3, armor: 3, speed: 3");
            Console.WriteLine("2) Stone Chewer      Health: 50, attack: 8, armor: 10, speed: 1");
            Console.WriteLine("3) Ghost Warrior     Health: 20, attack: 2, armor: 2, speed: 5");
            Console.WriteLine("4) Outworlder	    Health: 15, attack: 1, armor: 2, speed: 10");
            Console.WriteLine("5) Monster Knight    Health: 15, attack: 4, armor: 3, speed: 3");
            Console.WriteLine("6) Dark Goblin	    Health: 10, attack: 1, armor: 8, speed: 3");
            Console.WriteLine();
            Console.Write("Player 1,  choose your character (enter a number):  ");
            char character1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Player 2,  choose your character (enter a number):  ");
            char character2 = Convert.ToChar(Console.ReadLine());

            int health1 = 0;
            int health2 = 0;
            int speed1 = 0;
            int speed2 = 0;
            int attack1 = 0;
            int attack2 = 0;

            if (character1 == PIRATE)
            {
                health1 = HEALTH_PIRATE + ARMOR_PIRATE;
                speed1 = SPEED_PIRATE;
                attack1 = ATTACK_PIRATE;
            }
            else if (character1 == STONE_CHEWER)
            {
                health1 = HEALTH_STONE_CHEWER + AMORE_STONE_CHEWER;
                speed1 = SPEED_STONE_CHEWER;
                attack1 = ATTACK_STONE_CHEWER;
            }
            else if (character1 == GHOST_WARRIOR)
            {
                health1 = HEALTH_GHOST_WARRIOR + ARMOR_GHOST_WARRIOR;
                speed1 = SPEED_GHOST_WARRIOR;
                attack1 = ATTACK_GHOST_WARRIOR;
            }
            else if (character1 == OUTWORLDER)
            {
                health1 = HEALTH_OUTWORLDER + ARMOR_OUTWORLDER;
                speed1 = SPEED_OUTWORLDER;
                attack1 = ATTACK_OUTWORLDER;
            }
            else if (character1 == MONSTER_KNIGHT)
            {
                health1 = HEALTH_MONSTER_KNIGHT + ARMOR_MONSTER_KNIGHT;
                speed1 = SPEED_MONSTER_KNIGHT;
                attack1 = ATTACK_MONSTER_KNIGHT;
            }
            else if (character1 == DARK_GOBLIN)
            {
                health1 = HEALTH_DARK_GOBLIN + AMORE_DARK_GOBLIN;
                speed1 = SPEED_DARK_GOBLIN;
                attack1 = ATTACK_DARK_GOBLIN;
            }


            if (character2 == PIRATE)
            {
                health2 = HEALTH_PIRATE;
                speed2 = SPEED_PIRATE;
                attack2 = ATTACK_PIRATE;
            }
            else if (character2 == STONE_CHEWER)
            {
                health2 = HEALTH_STONE_CHEWER;
                speed2 = SPEED_STONE_CHEWER;
                attack2 = ATTACK_STONE_CHEWER;
            }
            else if (character2 == GHOST_WARRIOR)
            {
                health2 = HEALTH_GHOST_WARRIOR;
                speed2 = SPEED_GHOST_WARRIOR;
                attack2 = ATTACK_GHOST_WARRIOR;
            }
            else if (character1 == OUTWORLDER)
            {
                health2 = HEALTH_OUTWORLDER + ARMOR_OUTWORLDER;
                speed2 = SPEED_OUTWORLDER;
                attack2 = ATTACK_OUTWORLDER;
            }
            else if (character1 == MONSTER_KNIGHT)
            {
                health2 = HEALTH_MONSTER_KNIGHT + ARMOR_MONSTER_KNIGHT;
                speed2 = SPEED_MONSTER_KNIGHT;
                attack2 = ATTACK_MONSTER_KNIGHT;
            }
            else if (character1 == DARK_GOBLIN)
            {
                health2 = HEALTH_DARK_GOBLIN + AMORE_DARK_GOBLIN;
                speed2 = SPEED_DARK_GOBLIN;
                attack2 = ATTACK_DARK_GOBLIN;
            }

            int round = 0;

            while (health1 > 0 && health2 > 0)
            {
                health1 -= (speed1 * attack1);
                health2 -= (speed2 * attack2);
                round++;
            }

            if (health1 <= 0 && health2 > 0)
            {
                Console.WriteLine($"Player 2 has won after {round} rounds");
            }
            else if (health1 > 0 && health2 <= 0)
            {
                Console.WriteLine($"Player 1 has won after {round} rounds");
            }
            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Keiner hat gewonnen/verloren, unentschieden");
            }
        }
    }
}
