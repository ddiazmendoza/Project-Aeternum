using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Aeternum
{
    
    public class Player : MonoBehaviour 
    {
        public string Name { get; set; }
        
        public string CivName { get; set; }
        
        public int CivLevel {get; set;}
        public Economy Economics {get; set;}

        
        public Player()
        {
            LoadDefaultData();

        }

        internal void LoadDefaultData()
        {
            Name = "defaultUser";
            CivName = "defaultCivilization";
            CivLevel = 1; 
            
        }
    }

    
}