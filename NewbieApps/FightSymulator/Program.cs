using System;

namespace FightSymulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerSoldierHealth = 100;
            int enemySoldierHealth = 100;
            int hitCounter =1;

            while (playerSoldierHealth > 0 && enemySoldierHealth > 0)
            {
                int playerSoldierPower = rnd.Next(0, 20);
                int playerSoldierDefense = rnd.Next(0, 8);
                int playerSoldierSpeed = rnd.Next(0, 10);
                int enemySoldierPower = rnd.Next(0, 20);
                int enemySoldierDefense = rnd.Next(0, 8);
                int enemySoldierSpeed = rnd.Next(0, 10);

            if (playerSoldierSpeed > enemySoldierSpeed)
                {
                    playerSoldierHealth = playerSoldierHealth;
                    enemySoldierHealth = enemySoldierHealth + enemySoldierDefense - playerSoldierPower;
                }
            else
                {
                    playerSoldierHealth = playerSoldierHealth + playerSoldierDefense - enemySoldierPower;
                    enemySoldierHealth = enemySoldierHealth;
                }
            if (enemySoldierHealth<0)
                {
                    enemySoldierHealth = 0;
                }
            else if (playerSoldierHealth < 0)
                {
                    playerSoldierHealth = 0;
                }
                    Console.WriteLine("After " + hitCounter + " hit you have " + playerSoldierHealth + " hit points and your enemy have " + enemySoldierHealth +" hit points");
                    hitCounter += 1;

            }
            if (enemySoldierHealth == 0 )
            {
                Console.WriteLine("You win!!");
            }
            else
            {
                Console.WriteLine("You lose!!");
            }

        }
    }
}
