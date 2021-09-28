using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Aeternum
{
    public class StarSystemGraphics 
    {
        GameObject starSystemGraph; 
    }
    public class StarSystem 
    {
        public string Name; 
        private int starType; // 0 - main secuence yellow, positive = older , less rich negative = younger, less habitable
        private const int MaxPlanets = 6; // Later read from config file? Positins of planets [0] - null [1] - planet [2] - null ... etc.
        public Planet[] Planets;
        public Vector3 Position;
        
        public StarSystem()
        {
            Planets = new Planet[MaxPlanets];
        }
        public Planet GetPlanet(int planetIndex) 
        {
            return Planets[planetIndex];
        }
        public void Generate() 
        {
            GeneratePlanets();
        }
        public void GeneratePlanets() {
            // Generate 0 to Max planets, weighting planet class based on
            // StarType + distance from the Sun

            // The StarType might also influence the likelihood of number
            // of planets
        } 

    }
}