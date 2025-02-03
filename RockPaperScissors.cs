namespace CodeX
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;
            Random random = new Random();

            Console.WriteLine("\nWelcome To Rock Paper & Scissors!");

            while (playerScore != 3 && enemyScore != 3) 
            {
                Console.WriteLine("\nPlayer Score : " + playerScore +"\nEnemy Score : " + enemyScore);
                Console.WriteLine("\nPress 'r'for rock, 'p' for paper and anything else for scissors");
                string playerChoice = Console.ReadLine();

                int enemyCHoice = random.Next(0, 3);

                if (enemyCHoice == 0)
                {
                    Console.WriteLine("Enemy Chose ROCK");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;

                        case "p":
                            Console.WriteLine("Player Won This Round");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("Enemy Won This Round");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyCHoice == 1)
                {
                    Console.WriteLine("Enemy Chose PAPER");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy Won This Round");
                            enemyScore++;
                            break;

                        case "p":
                            Console.WriteLine("Tie!");
                            break;

                        default:
                            Console.WriteLine("Player Won This Round");
                            playerScore++;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enemy Chose SCISSORS");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player Won This Round");
                            playerScore++;
                            break;

                        case "p":
                            Console.WriteLine("Enemy Won This Round");
                            enemyScore++;
                            break;

                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }

            }
            if (playerScore == 3)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
        }
    }
}