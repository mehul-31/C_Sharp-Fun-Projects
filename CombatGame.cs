namespace CodeX
{
    class CombatGame
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int enemyHP = 100;

            Random r = new Random();

            while (playerHP > 0 && enemyHP > 0) 
            {
                int playerAttack = r.Next(1, 45);
                int enemyAttack = r.Next(1, 45);

                int playerHeal = r.Next(1, 30);
                int enemyHeal = r.Next(1, 30);

                System.Threading.Thread.Sleep(1000);

                //Player Turn
                Console.WriteLine("\n -- Player Turn -- ");
                Console.WriteLine("\nPlayer HP is : " + playerHP + " Enemy HP is : "+ enemyHP);
                Console.WriteLine("\nEnter 'a' to attack or 'h' to heal : ");
                string choice  = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("\nPlayer attacks enemy and deals " + playerAttack + "HP damage" );

                    if (playerAttack > 35)
                    {
                        Console.WriteLine("\n Ohh Critical Hit");
                    }
                }
                else if (choice == "h") 
                {
                    playerHP += playerHeal;
                    Console.WriteLine("\nPlayer healed himself with" + playerHeal + "HP");

                }
                System.Threading.Thread.Sleep(1000);
                //Enemy Turn

                if (enemyHP > 0)
                {
                    Console.WriteLine("\n-- Enemy Turn --");
                    Console.WriteLine("\nPlayer HP is : " + playerHP + " Enemy HP is : " + enemyHP);
                    int enemyChoice = r.Next(0, 2);
                    if (enemyChoice == 0)
                    {
                        Console.WriteLine("\nEnemy attacked the player and dealt " + enemyAttack + "HP damage");
                        playerHP -= enemyAttack;

                        if (enemyAttack > 35)
                        {
                            Console.WriteLine("\n Ohh Critical Hit");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("\nEnemy healed himself with" + enemyHeal + "HP");
                        enemyHP += enemyHeal;
                    }
                }

            }
            if (playerHP > 0)
            {
                Console.WriteLine("\nCongratulations, You Have Won This Game");
            }
            else 
            { 
                Console.WriteLine("\nOhh, You Lost"); 
            }


        }




    }
}