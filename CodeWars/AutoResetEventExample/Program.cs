using System;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventExample
{
    internal class Program
    {
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        private static string dataFromServer = string.Empty;

        private static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                GetDataFromServer();
            });

            autoResetEvent.WaitOne();

            Console.WriteLine(dataFromServer);
        }

        private static void GetDataFromServer()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            dataFromServer = "Webservice data";
            autoResetEvent.Set();
        }
    }
}