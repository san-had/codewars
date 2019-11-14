using System.Collections.Generic;
using System.Linq;

namespace SimpleAssembler
{
    public class SimpleAssembler
    {
        private InstructionProcessor instructionProcessor;

        public SimpleAssembler(InstructionProcessor instructionProcessor)
        {
            this.instructionProcessor = instructionProcessor;
        }

        public Dictionary<string, int> Simple_Assembler(string[] instructions)
        {
            var instructionArray = PopulateInstructions(instructions).ToArray();

            var registers = new Dictionary<string, int>();

            instructionProcessor.ProcessInstruction(instructionArray, registers);

            return registers;
        }

        private IEnumerable<Instruction> PopulateInstructions(string[] strInstructions)
        {
            foreach (var strInstruction in strInstructions)
            {
                var splittedInstruction = strInstruction.Split(' ');

                var instruction = new Instruction();
                instruction.Command = splittedInstruction[0];
                instruction.RegisterName = splittedInstruction[1];
                instruction.Parameter = splittedInstruction.Length == 3 ? splittedInstruction[2] : "";
                yield return instruction;
            }
        }
    }
}