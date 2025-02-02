namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;

            Console.WriteLine("Hello & Welcome To My Calculator Program!");

            Console.WriteLine("Please Enter Your First Number :");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now Enter Your Second Number :");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Type Of Operation Would You Like To Do");
            Console.WriteLine("Please Enter Appropriate Choice \n 1.'a' for Addition \n 2.'s'for Subtraction \n 3.'m' for Multiplication \n 4.'d' for Division");

            string ans = Console.ReadLine();

            if (ans == "a")
            {
                res = num1 + num2;
            }
            else if (ans == "s")
            {
                res = num1 - num2;
            }
            else if (ans == "m")
            {
                res = num1 * num2;
            }
            else if (ans == "d")
            {
                res = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
            Console.WriteLine("Your Result Is : " + res);
            Console.ReadKey();
        }



    }





}