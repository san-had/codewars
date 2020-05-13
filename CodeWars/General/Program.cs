namespace General
{
    public class Program
    {
        private static void Main()
        {
            var objectArray = new object[] { 't', 'e', 's', 't' };

            System.Console.WriteLine(Kata.Check(objectArray, 'e'));
        }
    }
}