using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Aeternum
{
    public class PlanetGraphic 
    {

    }
    public class Planet
    {
        public PlanetGraphic PlanetGraphic;
        public string Name; 
        readonly int PlanetIndex; 
        public PlanetSize PlanetSize;
        public PlanetType Type {get; set;}
        public Colony Colony {get; set;}
        public bool hasColony { set {
            if (this.Colony != null) 
            {   hasColony = true;   }}}
        
        public double PlanetIncome {get; set;}
        public double PlanetProduction {get; set;}

        // Planet traits might become a class that can apply their own logic?
        public List<PlanetTraits> PlanetTraits; 


    }
}