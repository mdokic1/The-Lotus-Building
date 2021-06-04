using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmajSkripta : MonoBehaviour
{
    public GameObject pozadina;
    public GameObject tekst;

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

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.name == "dragon")
                {
                    if (pozadina.activeSelf) pozadina.SetActive(false);
                    else pozadina.SetActive(true);

                    if (tekst.activeSelf) tekst.SetActive(false);
                    else tekst.SetActive(true);
                }
            }
        }
        
    }
}
