using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Aeternum
{
    public class StarSystemGraphics 
    {
        // int?  string?  sprite? texture?  model
        // do we maintain animation data?
        GameObject starSystemGraph; 
    }
    public class StarSystem 
    {
        public string Name; 

        const int MIN_STAR_TYPE = 0;    // Not pleased with this
        const int MAX_STAR_TYPE =  2;
        public int StarType {get; private set;}     // 0 - main secuence yellow, positive = older , less rich negative = younger, less habitable

        public Vector3 Position;
        public StarSystemGraphics StarSystemGraphics;

        private const int MaxPlanets = 6; // Later read from config file? Positins of planets [0] - null [1] - planet [2] - null ... etc.
        private Planet[] planets;
        
        public StarSystem()
        {
            planets = new Planet[MaxPlanets];
        }
        public void Generate(int starType = 0 ) // Galactic age/richness info? Or maybe we get told what kind of star to generate?  Especially for player starting planets? 
        {
            this.StarType = starType;
            GeneratePlanets();
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
        public Planet GetPlanet(int planetIndex) 
        {
            return planets[planetIndex];
        } // I know it's the same... 
        public Planet GetPlanetAtIndex(int i) 
        {
            return planets[i];
        }
        public int GetNumPlanets() 
        {
            int c = 0;
            for (var i = 0; i < GetMaxPlanets(); i++)
            {
                if (planets[i] != null)
                {
                    c++;
                }
                
            }
            return c;
        }
        public int GetMaxPlanets() 
        {
            return Config.GetInt("STAR_MAX_PLANETS");
        }
        public int GetStarTypeIndex()
        {
            // Weird hacky function to convert from -2...+2 range to a 0...4 range

            return StarType - MIN_STAR_TYPE;
        }
        public string GeneratePlanetName(int pos) 
        {
            // TODO: Make awesome
            return Name + " " + (pos + 1).ToString();
        }
        private PlanetType GeneratePlanetType(int pos) 
        {
            // Tweak this based on star type and galaxy settings 
            float goldilocksRange = 0.5f;

            float distance = (float)pos / (float)GetMaxPlanets();
            float distanceSquared = distance *distance;

            float gasGiantWeight = Mathf.Lerp(0f, 1f, distanceSquared);
            float goldilocksWeight = Mathf.Lerp(1f, 0f, 2f * Mathf.Abs(goldilocksRange - distance));
            float asteroidWeight = 1.0f;

            // Cool suns should have goldilocks closer to the sun
            // Hot suns should have it further

            float allWeights = gasGiantWeight + goldilocksWeight + asteroidWeight;
            float r = UnityEngine.Random.Range(0, allWeights);

            if (r < gasGiantWeight) 
            {
                // TODO
                return PlanetType.GasGigant;
            }
            r -= gasGiantWeight;
            if (r < goldilocksWeight) 
            {
                // TODO 
                return PlanetType.Contintental;
            }
            r -= goldilocksWeight;
            // If we get here, it's because we rolled in the asteroid weight
            return PlanetType.Asteroid;
        }
        public void Load( /* Some kind of file handle? */ )
        {

        }
        public void Save( /* Some kind of file handle? */ )
        {

        }

    }
}