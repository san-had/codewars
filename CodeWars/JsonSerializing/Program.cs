using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonSerializing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var validationResults = GetValidationResults();

            var jsonString = Serialize(validationResults);

            var validationEndResults = Deserialize(jsonString);

            DisplayResult(validationEndResults);
        }

        private static void DisplayResult(IList<ValidationResult> validationResults)
        {
            foreach (var validationResult in validationResults)
            {
                System.Console.WriteLine($"{ validationResult.Id.ToString()}\t{validationResult.Name}");
            }
        }

        private static string Serialize(IList<ValidationResult> validationResults)
        {
            var jsonString = JsonConvert.SerializeObject(validationResults);

            return jsonString;
        }

        private static IList<ValidationResult> Deserialize(string jsonString)
        {
            var validationResults = JsonConvert.DeserializeObject<List<ValidationResult>>(jsonString);

            return validationResults;
        }

        private static IList<ValidationResult> GetValidationResults()
        {
            List<ValidationResult> validationResults = new List<ValidationResult>()
            {
                new ValidationResult { Id = 1, Name = "Hello"},
                new ValidationResult { Id = 2, Name = "Péter"},
                new ValidationResult { Id = 3, Name = "Bubu"},
                new ValidationResult { Id = 4, Name = "Babu"}
            };

            return validationResults;
        }
    }
}