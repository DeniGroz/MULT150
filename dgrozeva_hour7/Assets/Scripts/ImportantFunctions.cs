using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    public int runSpeed;
    bool slowing = false;
    void Start()
    { 
        
        Debug.Log("start runspeed: " +runSpeed);
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("current runspeed: " +runSpeed);
        if (runSpeed < 15 && !slowing)
        {
            runSpeed++;
            Debug.Log("running faster. Speed: " + runSpeed);
        }
        else
        {
            slowing = true;
            Debug.Log("slowing down. Speed: " + runSpeed);
            runSpeed--;
            if (runSpeed == 0)
            {
                slowing = false;
            }
        }
        //I played around a bit
    }
}
