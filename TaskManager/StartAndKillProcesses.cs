using static TaskManager.runningProcesses;
using System.Diagnostics;

namespace TaskManager;

public class StartAndKillProcesses
{
    public static void getStartAndKillProcesses()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Enter the File Location of the process you want to start: \nEg. C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe  \n");
            var userInput3 = Console.ReadLine();
            if (int.TryParse(userInput3, out int selection3))
            {
                Console.WriteLine("Input should not be a numerical value!");
                Console.ReadKey();
                getStartAndKillProcesses();
            }
            else
            {

                Process process = null;

                process = Process.Start(userInput3);
                Console.WriteLine($"{process?.ProcessName} has Started!");

                Console.WriteLine($"Enter 1 to End {process?.ProcessName} process\nEnter 2 to list all current running process\nEnter 3 to Exit");
                var selection4 = Console.ReadLine();
                if (int.TryParse(selection4, out int userInput4))
                {
                    switch (userInput4)
                    {
                        case 1:
                            foreach(var p in Process.GetProcessesByName(process?.ProcessName))
                            {
                                p.Kill(true);
                            }
                            Console.WriteLine($"{process?.ProcessName} process has Ended!");
                            break;
                        case 2:
                            getRunningProcesses();
                            break;
                        case 3:
                            Console.WriteLine("Goodbye!");
                            break;
                        default: 
                            Console.WriteLine("Please Enter 1, 2 or 3!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Numerical Value!");
                }
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"File Location is Incorrect or Empty!....{ex.Message}");
            Console.ReadKey();
            getStartAndKillProcesses();
        }
    }

    public static void KillRunningProcesses()
    {
        try
        {
            Console.WriteLine("Enter the correct name of the process you want to end: \nEg. Calculator");
            var userInput5 = Console.ReadLine().Trim();
            if (int.TryParse(userInput5, out int selection5))
            {
                Console.WriteLine("Input should not be a numerical value!");
                Console.ReadKey();
                KillRunningProcesses();
            }
            else
            {
                foreach (var s in Process.GetProcessesByName(userInput5))
                {
                    s.Kill(true);
                }
                Console.WriteLine($"{userInput5} process has Ended!");
            }
        }
        catch(Exception ex) 
        { 
            Console.WriteLine(ex.Message); 
        }
    }

}
