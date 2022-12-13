using System.Diagnostics;

namespace TaskManager;

public class runningProcesses
{
    public static void EnumeratingProcesses()
    {
        var runningProcesses = from proc in Process.GetProcesses()
                               orderby proc.Id
                               select proc;

        foreach (var s in runningProcesses)
        {
            string info = $"-> PID: {s.Id}\tName: {s.ProcessName}";
            Console.WriteLine(info);
        }
       
    }


}
