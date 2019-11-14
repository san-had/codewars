using System;
using System.IO;

namespace Dex
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class DisposableClass : IDisposable
    {
        private bool disposed = false;
        private StreamReader reader;

        public DisposableClass(string fileName)
        {
            reader = new StreamReader(fileName);
        }

        public string Read()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(DisposableClass));
            }
            return reader.ReadToEnd();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (reader != null)
                {
                    reader.Dispose();
                    reader = null;
                }
            }
            disposed = true;
        }
    }
}