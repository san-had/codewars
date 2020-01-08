namespace General
{
    public class DeafRats
    {
        public static int CountDeafRats(string town)
        {
            int deafRatsCount = 0;

            string sequenceAll = town.Replace(" ", string.Empty)
                                  .Replace("~O", "L")
                                  .Replace("O~", "R");

            return deafRatsCount;
        }
    }
}