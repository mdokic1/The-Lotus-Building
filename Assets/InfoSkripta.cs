using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSkripta : MonoBehaviour
{
    public GameObject info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        info.SetActive(!info.activeSelf);
    }
}
