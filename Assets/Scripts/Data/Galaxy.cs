using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeternum
{
    // public enum StarNames { Vega, Alpha, Beta, Gamma }
    public enum PlanetType {LavaWorld, IceWorld, Contintental, GasGigant, Gaian, Oceanic, Asteroid, Radiated, Toxic, Desert}
    public enum PlanetTraits {Industrial, Natives, GoldDeposit, ArtifactWorld}
    public enum PlanetSize {Tiny, Small, Normal, Large, Huge, COUNT}
    public enum PlanetRichness {VeryPoor, Poor, Abundant, Rich, VeryRich}
    public static class GalaxyConfig
    {
        // This gets filled out by some kind of "New Game" screen
        // and is used by the Generate function to tune the game parameters
        public static int NumPlayers = 8;
        public static int NumStars = 100;

        // Total width/height of the range of star positions in Unity world units
        public  const int GalaxyWidth = 100;
        public  const int GalaxyHeight = 100;
        // Consider reading the defaults from a config file
    }
    public class Galaxy 
    {
        private List<StarSystem> StarSystems;
        public Galaxy()
        {
            StarSystems = new List<StarSystem>();
        }
        public StarSystem GetStarSystem(int StarSystemId)
        {
            return StarSystems[StarSystemId];
        }
        public int GetNumStarSystems()
        {
            return StarSystems.Count;
        }
        public void Generate(  )
        {
            // First pass, just make some random stars for us.

            int galaxyWidth = GalaxyConfig.GalaxyWidth;
            int galaxyHeight = GalaxyConfig.GalaxyHeight;

            for (int i = 0; i < GalaxyConfig.NumStars; i++)
            {
                StarSystem ss = new StarSystem();
                ss.Position = new Vector3(
                        Random.Range(-galaxyWidth, galaxyWidth),
                        Random.Range(-galaxyHeight / 2, galaxyHeight / 2),
                        1
                    );
                ss.Generate( /* Do we pass exactly what type of start system we want? */ );
                // Player starting stars are special
                // Do we want to vary star types based on distance from galactic center?

                ss.Name = "Star " + i.ToString();

                StarSystems.Add(ss);
            }

            Debug.Log("Num Stars Generated: " + StarSystems.Count);
        }

        public void Load( /* Some kind of file handle? */ )
        {
            
        }

        public void Save( /* Some kind of file handle? */ )
        {

        }
    }
}