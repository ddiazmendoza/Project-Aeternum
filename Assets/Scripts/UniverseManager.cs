using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aeternum 
{
    public class UniverseManager : MonoBehaviour
    {
        // This script is responsible for holding the main Galaxy data object,
        // triggering file save/loads or triggering the generation of a new galaxy.

        // Maybe also gets callbacks from end turn button?
        [SerializeField]
        public int Turn;

        [SerializeField]
        public bool gameHasStarted = false; 
        public Text turnText; 
        private Galaxy galaxy;
        void Start()
        {
           StartGame();
            // Receive user input? GetUserInput() {} Used for open menus with shortcuts? 
        }

        // Update is called once per frame
        void Update()
        {
           turnText.text = Turn.ToString();
        }
        public void Generate() 
        {
            Debug.Log("UniverseManager::Generate -- Generating a new Galaxy");
            galaxy = new Galaxy();
            galaxy.Generate();

            // tell our visual system to spawn the graphics
            
        } 
        public void StartGame() 
        {
            gameHasStarted = true;
            Debug.Log("game started");
            Turn = 1;
        }
        public void SolveNextTurn() 
        {
            Turn++;
        }
    }
}