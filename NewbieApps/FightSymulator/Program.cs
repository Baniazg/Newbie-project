using System;

namespace FightSymulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerSoldierHealth = 100;
            int playerSoldierPower = 20;
            int playerSoldierDefense = 5;
            int enemySoldierHealth = 100;
            int enemySoldierPower = 18;
            int enemySoldierDefense = 3;
            int hitCounter =1;

            while (playerSoldierHealth > 0 && enemySoldierHealth > 0)
            {
                playerSoldierHealth = playerSoldierHealth + playerSoldierDefense - enemySoldierPower;
                enemySoldierHealth = enemySoldierHealth + enemySoldierDefense - playerSoldierPower;
            if (enemySoldierHealth<0)
                {
                    enemySoldierHealth = 0;
                }
            else if (playerSoldierHealth < 0)
                {
                    playerSoldierHealth = 0;
                }
                Console.WriteLine("After " +hitCounter + " hit you have " + playerSoldierHealth + " and your enemy have " + enemySoldierHealth);
                hitCounter += 1;
            
            }

            if (playerSoldierHealth < 0)
                {
                    Console.WriteLine("You lose!!");
                }
            else
                {
                    Console.WriteLine("You win!!");
                }







        }
    }
}
