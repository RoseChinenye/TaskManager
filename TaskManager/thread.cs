

namespace TaskManager
{
    public class thread
    {
        public static void StartThread() 
        {
            Console.WriteLine("We have a program that print numbers from 0 - 9.");
            Console.WriteLine("1. Run program on a single thread\n2. Run program on multithread\n3. Thread Characteristics\n4. Exit the program");
            var selection6 = Console.ReadLine();
            if (int.TryParse(selection6, out int userInput6))
            {
                switch (userInput6)
                {
                    case 1:
                        PrintNumbers();
                        break;
                    case 2:
                        getMultithread();
                        break;
                    case 3:
                        getThreadCharacteristics();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please Enter 1, 2, or 3");
                        StartThread();
                        break;

                }
            }

            else
            {
                Console.WriteLine("Please, Enter a numerical value!");
                StartThread();
            }
        }

        public static void PrintNumbers()
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            Console.Clear();
            Console.WriteLine($"{primaryThread.Name} is executing a program that print numbers from 0 - 9.");

            
            Console.Write("The numbers are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\n{i}");
                Thread.Sleep(2000);
            }
            Console.WriteLine("\nCompleted!");
           
        }

        public static void getMultithread()
        {
            ThreadStart thread = new ThreadStart(PrintNumbers);
            Thread backgroundThread = new Thread(thread);
            backgroundThread.Start();
            
        }

        public static void getThreadCharacteristics()
        {
            Thread backgroundThread = Thread.CurrentThread;
            backgroundThread.Name = "TheSecondaryThread";

            backgroundThread.IsBackground = true;

            Console.WriteLine($"Thread Name: {backgroundThread.Name}");
            Console.WriteLine($"Thread IsAlive?: {backgroundThread.IsAlive}");
            Console.WriteLine($"Thread IsBackground?:{backgroundThread.IsBackground}");

        }
    }
}
