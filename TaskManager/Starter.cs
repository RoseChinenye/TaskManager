using static TaskManager.runningProcesses;

namespace TaskManager;

public class Starter
{
    public static void getStarted()
    {
        Console.WriteLine("1. List all running processes in your system\n2. Exit the program");
        var selection1 = Console.ReadLine();
        if(int.TryParse(selection1, out int userInput1))
        {
                switch (userInput1)
                {
                    case 1:
                        Console.WriteLine("Running processes in your system:\n");
                        getRunningProcesses();
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please Enter 1, 2 or 3");
                        getStarted();
                        break;

                }
            }
            
            else
            {
                Console.WriteLine("Please, Enter a numerical value!");
                getStarted();
            }
        
        Console.ReadKey();
    }
}
