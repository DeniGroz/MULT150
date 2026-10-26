using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.L))
        {
            disableLight(this.gameObject);
        }*/
        if(Input.GetKeyDown(KeyCode.L))
        {
            toggleLight(this.gameObject);
        }
    }

    /*void disableLight(GameObject light)
    {
        light.GetComponent<Light>().enabled = false;
    }*/

    void toggleLight(GameObject light)
    {
        bool lightOn = light.GetComponent<Light>().enabled;
        if(lightOn)
        {
            light.GetComponent<Light>().enabled = false;
        }
        else
        {
            light.GetComponent<Light>().enabled = true;
        }
    }
}

