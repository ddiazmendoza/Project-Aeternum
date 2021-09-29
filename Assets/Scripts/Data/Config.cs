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
                case "STAR_MAX_PLANETS":
                    return 6;
                    break;
                default:
                throw new System.ArgumentNullException();
                    break;
            }
        }
        public static string GetName(string starName, int pos)
        {
            // Random name generator
            return null;
        }
    }
}