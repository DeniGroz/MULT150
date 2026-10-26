using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string keyPressed = GetKeyPressed();
        if(keyPressed != null)
        {
            Debug.Log(keyPressed);
        }

    }

    string GetKeyPressed()
    {
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            return "W";
        }
            
        if(Input.GetKeyDown(KeyCode.A))
        {
            return "A";
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            return "S";
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            return "D";
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            return "M";
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            return "O";
        }
        return null;
    }


}
