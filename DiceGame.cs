using System.ComponentModel.Design;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random r1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nPress any key to roll the dice.");
                Console.ReadKey();

                playerRandomNum = r1.Next(1, 7);
                Console.WriteLine("\n \nYou rolled a : " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = r1.Next(1, 7);
                Console.WriteLine("\nEnemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("\nPlayer wins this Round");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("\nEnemy AI wins this Round");

                }
                else 
                {
                    Console.WriteLine("\nDRAW!!");
                }
            
            }
            Console.WriteLine("Your Score Was :" + playerPoints);
            Console.WriteLine("Enemy Score Was :" + enemyPoints);
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You Won The Game !!");
            }
            else 
            {
                Console.WriteLine("Enemy AI Won The Game!!");
            }
        }
    }
}