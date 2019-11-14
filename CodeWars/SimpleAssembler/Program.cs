using System;
using System.Collections.Generic;

namespace SimpleAssembler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var instructions = new string[]
            {
                "mov a 5",
                "inc a",
                "dec a",
                "dec a",
                "jnz a -1",
                "inc a"
            };

            var instructionProcessor = new InstructionProcessor();

            var simpleAssembler = new SimpleAssembler(instructionProcessor);

            //var results = simpleAssembler.Simple_Assembler(instructions);

            //DisplayResult(results);

            var instructions2 = new string[]
             {
                "mov a -10",
                "mov b a",
                "inc a",
                "dec b",
                "jnz a -2"
             };

            //var results = simpleAssembler.Simple_Assembler(instructions2);

            var instructions3 = new string[]
                         {
                            "mov d 100",
                            "dec d",
                            "mov b d",
                            "jnz b -2",
                            "inc d",
                            "mov a d",
                            "jnz 5 10",
                            "mov c a"
                         };

            var results = simpleAssembler.Simple_Assembler(instructions3);

            DisplayResult(results);
        }

        private static void DisplayResult(Dictionary<string, int> results)
        {
            foreach (var item in results)
            {
                Console.WriteLine($"Register: {item.Key}  Value: {item.Value}");
            }
        }
    }
}