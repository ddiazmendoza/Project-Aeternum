using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeternum
{
    public class Galaxy 
    {
        public List<StarSystem> StarSystems = new List<StarSystem>();
        public int MaxStars = 10;

        public Galaxy()
        {
            Generate(MaxStars);
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        } 
        void Generate(int n) // n of stars to generate
        {
            for (int i = 0; i < n; i++) 
            {
                var ss = new StarSystem();
                StarSystems.Add(ss);
            }
        }
    }
}