using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YinYangSkripta : MonoBehaviour
{
    public GameObject dnevno1, dnevno2, dnevno3, dnevno4, dnevno5, dnevno6, dnevno7;
 
    public GameObject nocno1, nocno2, nocno3, nocno4, nocno5, nocno6, nocno7, nocno8;

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
                if (hit.collider.gameObject.name == "YinYang")
                {
                    if (dnevno1.activeSelf) dnevno1.SetActive(false);
                    else dnevno1.SetActive(true);

                    if (dnevno2.activeSelf) dnevno2.SetActive(false);
                    else dnevno2.SetActive(true);

                    if (dnevno3.activeSelf) dnevno3.SetActive(false);
                    else dnevno3.SetActive(true);

                    if (dnevno4.activeSelf) dnevno4.SetActive(false);
                    else dnevno4.SetActive(true);

                    if (dnevno5.activeSelf) dnevno5.SetActive(false);
                    else dnevno5.SetActive(true);

                    if (dnevno6.activeSelf) dnevno6.SetActive(false);
                    else dnevno6.SetActive(true);

                    if (dnevno7.activeSelf) dnevno7.SetActive(false);
                    else dnevno7.SetActive(true);

                    if (nocno1.activeSelf) nocno1.SetActive(false);
                    else nocno1.SetActive(true);

                    if (nocno2.activeSelf) nocno2.SetActive(false);
                    else nocno2.SetActive(true);

                    if (nocno3.activeSelf) nocno3.SetActive(false);
                    else nocno3.SetActive(true);

                    if (nocno4.activeSelf) nocno4.SetActive(false);
                    else nocno4.SetActive(true);

                    if (nocno5.activeSelf) nocno5.SetActive(false);
                    else nocno5.SetActive(true);

                    if (nocno6.activeSelf) nocno6.SetActive(false);
                    else nocno6.SetActive(true);

                    if (nocno7.activeSelf) nocno7.SetActive(false);
                    else nocno7.SetActive(true);

                    if (nocno8.activeSelf) nocno8.SetActive(false);
                    else nocno8.SetActive(true);
                }
            }
                
        }
        
    }
}
