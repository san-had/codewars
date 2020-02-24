using System;
using System.Linq;

namespace PipelineExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PipelineUsage();
        }

        private static void PipelineUsage()
        {
            var builder = new CastingPipelineBuilder();

            builder.AddStep(input => FindMostCommon(input as string));
            builder.AddStep(input => (input as string).Length);
            builder.AddStep(input => ((int)input) % 2 == 1);

            var pipeline = builder.GetPipeline();

            pipeline.Finished += result =>
            {
                Console.Write("Result: ");
                Console.WriteLine(result);
            };
            pipeline.Execute("The pipeline pattern is the best pattern");
        }

        private static string FindMostCommon(string input)
        {
            var commonWord = input.Split(' ')
                .GroupBy(word => word)
                .OrderBy(group => group.Count())
                .Last()
                .Key;
            return commonWord;
        }
    }
}