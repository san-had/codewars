using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RoboScript
{
    public class Syntax
    {
        public static string Highlight(string codes)
        {
            string highlighted = string.Empty;

            const string template = "<span style=\"color: {0}\">{1}</span>";
            var colorDictionary = new Dictionary<char, string>
            {
                { 'F',"pink" },
                {'L', "red"},
                {'R', "green" }
            };

            for (int index = 0; index < codes.Length; index++)
            {
                char code = codes[index];
                string collected = string.Empty;
                switch (code)
                {
                    case 'F':
                    case 'L':
                    case 'R':
                        collected = code.ToString();
                        while (index + 1 < codes.Length && code == codes[index + 1])
                        {
                            index++;
                            collected = string.Concat(collected, codes[index]);
                        }

                        highlighted = string.Concat(highlighted, string.Format(template, colorDictionary[code], collected));
                        break;

                    case '(':
                    case ')':
                        highlighted = string.Concat(highlighted, code.ToString());
                        break;

                    default:
                        var regex = new Regex(@"^[0-9]");
                        if (regex.IsMatch(code.ToString()))
                        {
                            collected = code.ToString();
                            while (index + 1 < codes.Length && regex.IsMatch(codes[index + 1].ToString()))
                            {
                                index++;
                                collected = string.Concat(collected, codes[index]);
                            }

                            highlighted = string.Concat(highlighted, string.Format(template, "orange", collected));
                        }
                        else
                        {
                            throw new InvalidOperationException($"Invalid code: {code}");
                        }
                        break;
                }
            }
            return highlighted;
        }
    }
}