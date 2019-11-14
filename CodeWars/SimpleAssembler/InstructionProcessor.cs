using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpleAssembler
{
    public class InstructionProcessor
    {
        public void ProcessInstruction(Instruction[] instructions, Dictionary<string, int> registers)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                AddRegistersFromInstruction(registers, instructions[i]);
                switch (instructions[i].Command)
                {
                    case "mov":
                        Mov(instructions[i], registers);
                        break;

                    case "inc":
                        registers[instructions[i].RegisterName] += 1;
                        break;

                    case "dec":
                        registers[instructions[i].RegisterName] -= 1;
                        break;

                    case "jnz":
                        i = i + Jnz(instructions[i], registers);
                        break;

                    default:
                        break;
                }
            }
        }

        private void Mov(Instruction instruction, Dictionary<string, int> registers)
        {
            if (IsParameterRegister(instruction.Parameter))
            {
                registers[instruction.RegisterName] = registers[instruction.Parameter];
            }
            else
            {
                registers[instruction.RegisterName] = int.Parse(instruction.Parameter);
            }
        }

        private int Jnz(Instruction instruction, Dictionary<string, int> registers)
        {
            if (IsParameterRegister(instruction.RegisterName))
            {
                if (registers[instruction.RegisterName] == 0)
                {
                    return 0;
                }
                else
                {
                    return Int32.Parse(instruction.Parameter) - 1;
                }
            }
            else
            {
                return int.Parse(instruction.RegisterName) - 1;
            }
        }

        private void AddRegistersFromInstruction(Dictionary<string, int> registers, Instruction instruction)
        {
            if (IsParameterRegister(instruction.RegisterName) && !registers.ContainsKey(instruction.RegisterName))
            {
                registers.Add(instruction.RegisterName, 0);
            }

            if (!string.IsNullOrEmpty(instruction.Parameter))
            {
                if (IsParameterRegister(instruction.Parameter) && !registers.ContainsKey(instruction.Parameter))
                {
                    registers.Add(instruction.Parameter, 0);
                }
            }
        }

        private bool IsParameterRegister(string parameter)
        {
            bool isRegister = false;

            if (parameter != null)
            {
                Regex regexp = new Regex(@"^[a-z]$");

                isRegister = regexp.IsMatch(parameter.ToLower());
            }
            return isRegister;
        }
    }
}