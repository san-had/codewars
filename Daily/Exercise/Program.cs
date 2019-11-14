using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        private static int DoComplexCalculation(int input)
        {
            Thread.Sleep(3000);

            System.Console.WriteLine("DoComplexCalculation");

            return input * 1000;
        }

        private static async Task<int> Main(string[] args)
        {
            var backgroundTask = Task.Run(() => DoComplexCalculation(42));

            var result = await backgroundTask;

            System.Console.WriteLine(result.ToString());

            return result;
        }
    }
}