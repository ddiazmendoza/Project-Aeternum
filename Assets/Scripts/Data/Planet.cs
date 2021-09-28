using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Aeternum
{
    public enum PlanetType {Lava, Ice, Contintental, GasGigant, GaiaWorld, IslesWorld, OceanWorld}
    public enum PlanetTraits {Industrial, Natives, GoldDeposit, ArtifactWorld}
    public class PlanetGraphic 
    {

    }
    public class Planet
    {
        public PlanetGraphic PlanetGraphic;
        public string Name; 
        readonly int PlanetIndex; 
        public PlanetType Type {get; set;}
        public Colony Colony {get; set;}
        public bool hasColony { set {
            if (this.Colony != null) 
            {   hasColony = true;   }}}
        
        public double PlanetIncome {get; set;}
        public double PlanetProduction {get; set;}
        public List<PlanetTraits> PlanetTraits; 

        public Planet()
        {

        }
        // Start is called before the first frame update
        void Start()
        {
            if (this.Colony != null) // We have a colony in here 
            {

            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void Generate(int n) 
        {
            for (int i = 0; i < n; i++) 
            {

            }
        }
        public struct Territory 
        {
            
        }
    }
}