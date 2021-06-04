using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamacSkripta : MonoBehaviour
{
    public GameObject platno;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Row_Boat")
                {
                    if (platno.activeSelf) platno.SetActive(false);
                    else platno.SetActive(true);
                }
            }
        }
    }
}
