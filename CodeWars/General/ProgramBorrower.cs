namespace General
{
    internal class ProgramBorrower
    {
        private static void MainBorrower()
        {
            var input = "WhAt! FiCK! DaMn CAke?";

            var input2 = "THE big PeOpLE Here!!";

            var input3 = "i AM a TINY BoY!!G;H,-";

            var result = BorrowerSpeak.Borrow(input3);

            System.Console.WriteLine(result);
        }
    }
}