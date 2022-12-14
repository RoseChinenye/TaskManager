using System.Diagnostics;
using static TaskManager.StartAndKillProcesses;

namespace TaskManager;

public class runningProcesses
{
    public static void getRunningProcesses()
    {
        try
        {
            var runningProcesses = Process.GetProcesses().OrderBy(proc => proc.Id);

            foreach (var s in runningProcesses)
            {
                var info = $"Process ID: {s.Id}     Name: {s.ProcessName}";
                Console.WriteLine(info);

            }
            getProcesses();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void getProcesses()
    {
        try
        {
            Console.WriteLine("\n1. Start a Process\n2. End a running Process\n3. Exit the program");
            var selection2 = Console.ReadLine();
            if (int.TryParse(selection2, out int userInput2))
            {
                switch (userInput2)
                {
                    case 1:
                        getStartAndKillProcesses();
                        break;
                    case 2:
                        KillRunningProcesses();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please Enter 1, 2 or 3");
                        getProcesses();
                        break;

                }
            }

            else
            {
                Console.WriteLine("Please, Enter a numerical value!");
                getProcesses();
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}






