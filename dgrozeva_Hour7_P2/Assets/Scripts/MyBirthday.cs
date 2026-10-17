using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int birthday = 29;
        int i = 1;
        while (i <= 31)
        {
            if (i != birthday)
            {
                Debug.Log(i);
            }
            else
            {
                Debug.Log("Its my birthday!");
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
