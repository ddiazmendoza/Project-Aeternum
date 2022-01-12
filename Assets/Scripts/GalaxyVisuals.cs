using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aeternum
{
    public class GalaxyVisuals : MonoBehaviour 
    {
        public LayerMask ClickableStarsLayerMask;

        // Update is called once per frame
        void Update () 
        {
            GetInput();
        }
        public GameObject[] StarPrefabs;    // Index of array is a star type. The prefabs are 
                                            // responsible for having appearance variety.
        private Galaxy galaxy;
        private void GetInput() 
        {
            if (Input.GetMouseButtonUp(0))
            {
                // Mouse was clicked -- is it on a star?
                // TODO:  Ignore clicks if over a UI element
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                
                bool didHit = Physics.Raycast(ray, out hitInfo, 100f, ClickableStarsLayerMask);

                if (didHit)
                {
                    ClickableStar cs = hitInfo.collider.GetComponentInParent<ClickableStar>();
                    cs.OnClick();
                    //Debug.DrawRay(ray.origin, ray.direction * 10, Color.magenta);
                }
            }
        }
        public void InitiateVisuals( Galaxy galaxy )
        {
            this.galaxy = galaxy;

            for (int i = 0; i < galaxy.GetNumStarSystems(); i++)
            {
                StarSystem ss = galaxy.GetStarSystem(i);

                GameObject go = Instantiate(
                    StarPrefabs[0],
                    ss.Position,       // Are we gonna want to mult by a scalar? maybe not actually
                    Quaternion.identity,
                    this.transform
                    );

                go.GetComponent<ClickableStar>().StarSystem = ss;


            }
        }
    }
}

