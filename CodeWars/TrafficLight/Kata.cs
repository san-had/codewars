using System;
using System.Collections.ObjectModel;

namespace TrafficLight
{
    public class Kata
    {
        public static string UpdateLight(string current)
        {
            var trafficLights = new Collection<string> { "green", "yellow", "red" };

            var index = trafficLights.IndexOf(current);

            if (index == -1)
            {
                throw new NotImplementedException($"Invalid light: {current}");
            }

            var newIndex = (index + 1) % 3;

            return trafficLights[newIndex];
        }
    }
}