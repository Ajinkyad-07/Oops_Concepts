namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The main thread starts and prints "Main thread continues..."
            // Meanwhile, the new thread begins executing PrintNumbers, printing Number: 1, then waits 1 second, then prints Number: 2, and so on.
            // The main thread doesn't wait for the new thread to complete; it just continues executing independently.
            Thread thread = new Thread(PrintNumbers); 
            thread.Start(); // thread.Start() call starts the new thread, and it begins executing the PrintNumbers method.
            Console.WriteLine("Main thread is running contineously");

            Thread messageThread = new Thread(() => PrintMessage("Hii thread with Lambda Expressions"));
            messageThread.Start();
            Console.WriteLine("Main Lambda Expressions thread is running contineously again");

            Thread messageThread1 = new Thread(PrintMessage1);
            messageThread1.Start("Hiii ParameterizedThreadStart");
            Console.WriteLine("Main ParameterizedThreadStart thread is running contineously again");


            Thread threadState = new Thread(() => Thread.Sleep(2000)); // Simulates work
            threadState.Start();
            Console.WriteLine($"Is thread alive? {threadState.IsAlive}");
            threadState.Join(); // Waits for the thread to finish
            Console.WriteLine($"Is thread alive after join? {threadState.IsAlive}");
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                //Thread.Sleep(1000); // This method introduces a pause of 1 second in the new thread’s execution,
            }
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void PrintMessage1(object message)
        {
            Console.WriteLine(message);
        }
    }
}
