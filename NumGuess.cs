namespace CodeX
{
    class NumGuess
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random r = new Random();

            int randomNum = r.Next(1, 111);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 100 will be generated.");
            Console.WriteLine("If you guess the correct number you win!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess :");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < randomNum)
                {
                    Console.WriteLine("Your Guess Is Too Low");
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Your Guess Is Too High");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("Congratulations ,You Have won the Game, The Number Was" + randomNum);



        }




    }
}