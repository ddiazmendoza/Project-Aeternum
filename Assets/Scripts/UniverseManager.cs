using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aeternum 
{
    public class UniverseManager : MonoBehaviour
    {
        [SerializeField]
        public int Turn;

        [SerializeField]
        public bool gameHasStarted = false; 
        public Text text; 
        void Start()
        {
           StartGame();
            // Receive user input? GetUserInput() {} Used for open menus with shortcuts? 
        }

        // Update is called once per frame
        void Update()
        {
           text.text = Turn.ToString();
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