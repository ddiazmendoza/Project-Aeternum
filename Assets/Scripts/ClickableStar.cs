using System.Collections;
using TMPro;
using UnityEngine;

namespace Aeternum
{
    public class ClickableStar : MonoBehaviour 
    {
        private void Start()
        {
            GetComponentInChildren<TextMeshProUGUI>().text = StarSystem.Name;
            
        }

        public StarSystem StarSystem;

        public void OnClick()
        {
            Debug.Log("ClickableStar::OnClick -- " + StarSystem.Name);
            ViewManager.Instance.SystemView.StarSystem = StarSystem;
            ViewManager.Instance.ShowView( ViewManager.Instance.SystemView );
        }
        
    }
}
    