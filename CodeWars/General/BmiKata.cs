using System;

namespace General
{
    public class BmiKata
    {
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);

            if (bmi <= 18.5)
                return "Underweight";

            if (bmi <= 25.0)
                return "Normal";

            if (bmi <= 30.0)
                return "Overwight";

            if (bmi > 30)
                return "Obese";

            return "Undefined";
        }

        public static string Bmi2(double weight, double height)
        {
            double bmi = Math.Round(weight / (height * height), 1);

            string bmiVal = bmi <= 18.5 ? "Underweight"
                : bmi <= 25.0 ? "Normal"
                : bmi < 30.0 ? "Overwight"
                : bmi > 30 ? "Obese" : "Undefined";

            return bmiVal;
        }
    }
}