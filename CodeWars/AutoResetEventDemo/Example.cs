using System;
using System.Threading;

namespace AutoResetEventDemo
{
    internal class Example
    {
        private static AutoResetEvent autoResetEvent_1 = new AutoResetEvent(true);
        private static AutoResetEvent autoResetEvent_2 = new AutoResetEvent(false);

        private static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to create three threads and start them.\r\n" +
                                  "The threads wait on AutoResetEvent #1, which was created\r\n" +
                                  "in the signaled state, so the first thread is released.\r\n" +
                                  "This puts AutoResetEvent #1 into the unsignaled state.");
            Console.ReadLine();

            for (int i = 1; i < 4; i++)
            {
                Thread t = new Thread(ThreadProc);
                t.Name = "Thread_" + i;
                t.Start();
            }
            Thread.Sleep(250);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Press Enter to release another thread.");
                Console.ReadLine();
                autoResetEvent_1.Set();
                Thread.Sleep(250);
            }

            Console.WriteLine("\r\nAll threads are now waiting on AutoResetEvent #2.");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Press Enter to release a thread.");
                Console.ReadLine();
                autoResetEvent_2.Set();
                Thread.Sleep(250);
            }

            // Visual Studio: Uncomment the following line.
            //Console.Readline();
        }

        private static void ThreadProc()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine("{0} waits on AutoResetEvent #1.", name);
            autoResetEvent_1.WaitOne();
            Console.WriteLine("{0} is released from AutoResetEvent #1.", name);

            Console.WriteLine("{0} waits on AutoResetEvent #2.", name);
            autoResetEvent_2.WaitOne();
            Console.WriteLine("{0} is released from AutoResetEvent #2.", name);

            Console.WriteLine("{0} ends.", name);
        }
    }
}