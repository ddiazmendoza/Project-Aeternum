using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Aeternum;

public class GalaxyVisuals : MonoBehaviour {
    public LayerMask ClickableStarsLayerMask;

    // Update is called once per frame
    void Update () 
    {
        if ( Input.GetMouseButtonUp(0) )
        {
            Debug.Log("mouse clicked");
            // Mouse was clicked -- is it on a star?

            // TODO:  Ignore clicks if over a UI element

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, ClickableStarsLayerMask))
            {
                Debug.Log("we hit a star...");
                // We hit something, and that something can ONLY be a clickable star
                ClickableStar cs = hitInfo.collider.GetComponentInParent<ClickableStar>();

                Debug.Log("Clicked star: " + cs.name);

                cs.OnClick();
            }
        }
		
        

	}

    public GameObject[] StarPrefabs;    // Index of array is a star type. The prefabs are 
                                        // responsible for having appearance variety.

    private Galaxy galaxy;

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