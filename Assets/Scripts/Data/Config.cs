using System;
using UnityEngine;

namespace Aeternum 
{
    public static class Config 
    {
        public static int GetInt(string parameter) 
        {
            switch (parameter)
            {
                case "PLANET_MAX_POPULATION_Tiny":
                    return 4;
                case "PLANET_MAX_POPULATION_Small":
                    return 6;
                case "PLANET_MAX_POPULATION_Medium":
                    return 10;
                case "PLANET_MAX_POPULATION_Large":
                    return 12;
                case "PLANET_MAX_POPULATION_Huge":
                    return 16;
                case "STAR_MAX_PLANETS":
                    return 6;
                case "STAR_ORBIT_DISTANCE":
                    return 1;
                default:
                    Debug.LogError("GetInt: No option for " + parameter);
                    return 0;
            }
        }
        public static string GetName(string starName, int pos)
        {
            // Random name generator
            return null;
        }
        public static float GetFloat(string parameter)
        {
            switch (parameter)
            {
                case "STAR_ORBIT_DISTANCE":
                    return 1.0f;
                default:
                    Debug.LogError("GetFloat: No option for " + parameter);
                    return 0;
            }
        }
    }
}