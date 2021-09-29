using System;
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
        private Planet[] planets;
        public Vector3 Position;
        
        public StarSystem()
        {
            planets = new Planet[MaxPlanets];
        }
        public Planet GetPlanet(int planetIndex) 
        {
            return planets[planetIndex];
        }
        public void Generate() // When we generate SS each of them generates planets
        {
            
        }
        public void GeneratePlanets() {
            // Generate 0 to Max planets, weighting planet class based on
            // StarType + distance from the Sun

            // The StarType might also influence the likelihood of number
            // of planets
            float planetChance = 0.50f;

            for (int i = 0; i < GetMaxPlanets(); i++)
            {
                if (UnityEngine.Random.Range(0f, 1f) <= planetChance) // 50% of possibility
                {
                    // Make a planet!
                    Planet planet = new Planet();
                    planets[i] = planet;
                    planet.Name = GeneratePlanetName(i);

                    int size_max = (int)PlanetSize.COUNT;

                    planet.PlanetSize = (PlanetSize)Enum.GetValues(typeof(PlanetSize)).GetValue(UnityEngine.Random.Range(0, size_max));
                }
            }
        } 
        public int GetMaxPlanets() 
        {
            return Config.GetInt("STAR_MAX_PLANETS");
        }
        public string GeneratePlanetName(int pos) 
        {
            // TODO: Make awesome
            return Name + " " + (pos + 1).ToString();
        }
        public void Load( /* Some kind of file handle? */ )
        {

        }
        public void Save( /* Some kind of file handle? */ )
        {

        }

    }
}