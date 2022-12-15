using System;

namespace Colosseum
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior blackWarrior = new Warrior {name="Black Warrior", power = 15, defense = 4, health = 100 };
            Warrior yellowWarrior = new Warrior {name = "Yellow Warrior",  power = 14, defense = 3, health = 100 };
            Contest.startFight(blackWarrior, yellowWarrior);
        }
        class Warrior
        {
            public string name; 
            public int power;
            public int defense;
            public int health;

        }
        class Contest
        {
            public static void startFight(Warrior warrior1, Warrior warrior2)
            {
                while (warrior1.health>0 && warrior2.health>0)
                {

                    warrior1.health = warrior1.health + warrior1.defense - warrior2.power;
                    warrior2.health = warrior2.health + warrior2.defense - warrior1.power;

                    Console.WriteLine(warrior1.name + " have " + warrior1.health + " hp. Opponent " + warrior2.name + " have " + warrior2.health+"hp");
                    if (warrior1.health < 0)
                    {
                        warrior1.health = 0;
                    }
                    else if (warrior2.health < 0)
                    {
                        warrior2.health = 0;

                    }
                  
                }
                if (warrior1.health == 0)
                {
                    Console.WriteLine(warrior2.name + "is winner!");
                }
                else
                {
                    Console.WriteLine(warrior1.name + "is winner!");
                }
            }

            }
        }
    }


