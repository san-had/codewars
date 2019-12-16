namespace General
{
    internal class Program
    {
        private static void Main()
        {
            var input = new int[3] { 1, 2, 3 };

            var result = LostWoMap.Maps(input);

            Display(result);
        }

        private static void Display(int[] input)
        {
            foreach (var item in input)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}