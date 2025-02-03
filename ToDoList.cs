namespace CodeX
{
    class RockPaperScissors
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome To The Program");
            List<String> taskList = new List<String>();
            string option = "";

            while (option != "e") 
            {
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("\n What would you like to do Next");

                System.Threading.Thread.Sleep(250);    

                Console.WriteLine("\n Enter '1' to add a task to the list");

                System.Threading.Thread.Sleep(250);

                Console.WriteLine("\n Enter '2'to remove a task from list");

                System.Threading.Thread.Sleep(250);

                Console.WriteLine("\n Enter '3' to view the list");

                System.Threading.Thread.Sleep(250);

                Console.WriteLine("\n Enter 'e' to Exit from program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("\nPlease enter the name of the task to add to the list");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("\nTask Added to list Succesfully");
                }
                else if (option == "2")
                {
                    for (global::System.Int32 i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                    Console.WriteLine("\nPlease Enter The Number of task You would like to remove");
                    int taskNum = Convert.ToInt32(Console.ReadLine());

                    taskList.RemoveAt(taskNum);
                }

                else if (option == "3")
                {
                    Console.WriteLine("\nCurrent Tasks in the list : ");
                    for (global::System.Int32 i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine("\n" + (i+1) + " : " + taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("\nExiting The Program");
                }
                else 
                {
                    Console.WriteLine("\nInvalid Option Please Try again");

                }
            }
            Console.WriteLine("\nThank You ! for Using our Program");
        
        
        }
        
    }
}